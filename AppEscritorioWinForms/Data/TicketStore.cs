using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using app_escritorio.Forms;

namespace app_escritorio.Data
{
    /// <summary>
    /// Tickets abiertos por mesa. Lo comparten el POS y Mesas.
    /// Persiste en %LocalAppData%\RestoOS\tickets.dat (formato mesa|producto|categoria|precio|cantidad|notas).
    /// Cierra la crítica P-01: antes todo vivía solo en RAM y se perdía al cerrar.
    /// </summary>
    public static class TicketStore
    {
        public const string NoTable = "Mesa no seleccionada";
        private const string GeneralKey = "__GENERAL__";
        private static readonly Dictionary<string, BindingList<OrderLine>> _tickets = new Dictionary<string, BindingList<OrderLine>>();
        private static bool _loaded;
        private static bool _saving;

        private static string StorePath => Path.Combine(LocalSettings.AppDataDir, "tickets.dat");

        /// <summary>Se dispara cuando cambia cualquier ticket (para refrescar Mesas).</summary>
        public static event Action TicketChanged;

        public static BindingList<OrderLine> GetTicketFor(string mesa)
        {
            EnsureLoaded();
            string key = Normalize(mesa);
            if (!_tickets.TryGetValue(key, out var list))
            {
                list = new BindingList<OrderLine>();
                list.ListChanged += (s, e) => Save();
                _tickets[key] = list;
            }
            return list;
        }

        public static decimal GetSubtotalFor(string mesa)
        {
            EnsureLoaded();
            return GetTicketFor(mesa).Sum(l => l.LineTotal);
        }

        public static void NotifyChanged()
        {
            Save();
            try { TicketChanged?.Invoke(); } catch { }
        }

        /// <summary>Mueve el ticket al renombrar una mesa (cierra P-03). Fusiona si el destino ya tiene líneas.</summary>
        public static void Rename(string oldName, string newName)
        {
            EnsureLoaded();
            string oldKey = Normalize(oldName);
            string newKey = Normalize(newName);
            if (oldKey == newKey) return;
            if (!_tickets.TryGetValue(oldKey, out var old)) return;
            if (_tickets.TryGetValue(newKey, out var existing))
            {
                foreach (var l in old)
                {
                    var match = existing.FirstOrDefault(x => x.Name == l.Name && (x.Notes ?? "") == (l.Notes ?? "") && x.Product.Price == l.Product.Price);
                    if (match == null) existing.Add(l);
                    else match.Quantity += l.Quantity;
                }
            }
            else
            {
                _tickets[newKey] = old;
            }
            _tickets.Remove(oldKey);
            Save();
        }

        /// <summary>Borra el ticket de una mesa eliminada.</summary>
        public static void RemoveTicket(string mesa)
        {
            EnsureLoaded();
            if (_tickets.Remove(Normalize(mesa))) Save();
        }

        private static string Normalize(string mesa) =>
            string.IsNullOrWhiteSpace(mesa) || mesa == NoTable ? GeneralKey : mesa.Trim();

        private static void EnsureLoaded()
        {
            if (_loaded) return;
            _loaded = true;
            Load();
        }

        private static void Load()
        {
            try
            {
                if (!File.Exists(StorePath)) return;
                foreach (var line in File.ReadAllLines(StorePath, Encoding.UTF8))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var p = Split(line);
                    if (p.Length < 6) continue;
                    string key = Normalize(Unescape(p[0]));
                    string name = Unescape(p[1]);
                    string category = Unescape(p[2]);
                    if (string.IsNullOrWhiteSpace(name)) continue;
                    if (!decimal.TryParse(p[3], NumberStyles.Any, CultureInfo.InvariantCulture, out var price)) continue;
                    if (!int.TryParse(p[4], out int qty) || qty <= 0) continue;
                    string notes = Unescape(p[5]);
                    if (!_tickets.TryGetValue(key, out var list))
                    {
                        list = new BindingList<OrderLine>();
                        list.ListChanged += (s, e) => Save();
                        _tickets[key] = list;
                    }
                    var product = new Product(name, category, price);
                    var orderLine = new OrderLine(product) { Quantity = qty, Notes = notes ?? string.Empty };
                    list.Add(orderLine);
                }
            }
            catch { }
        }

        private static void Save()
        {
            if (!_loaded || _saving) return;
            try
            {
                _saving = true;
                Directory.CreateDirectory(LocalSettings.AppDataDir);
                var sb = new StringBuilder();
                foreach (var kv in _tickets)
                {
                    foreach (var l in kv.Value)
                    {
                        if (l == null || l.Product == null) continue;
                        sb.Append(Escape(kv.Key)).Append('|')
                          .Append(Escape(l.Product.Name ?? string.Empty)).Append('|')
                          .Append(Escape(l.Product.Category ?? string.Empty)).Append('|')
                          .Append(l.Product.Price.ToString(CultureInfo.InvariantCulture)).Append('|')
                          .Append(l.Quantity).Append('|')
                          .Append(Escape(l.Notes ?? string.Empty))
                          .AppendLine();
                    }
                }
                string tmp = StorePath + ".tmp";
                File.WriteAllText(tmp, sb.ToString(), Encoding.UTF8);
                if (File.Exists(StorePath)) File.Replace(tmp, StorePath, null);
                else File.Move(tmp, StorePath);
            }
            catch { }
            finally { _saving = false; }
        }

        private static string Escape(string s) =>
            (s ?? string.Empty).Replace("\\", "\\\\").Replace("|", "\\p").Replace("\r", "").Replace("\n", "\\n");

        private static string Unescape(string s)
        {
            if (s == null) return string.Empty;
            return s.Replace("\\n", "\n").Replace("\\p", "|").Replace("\\\\", "\\");
        }

        private static string[] Split(string line)
        {
            var parts = new List<string>();
            var cur = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '\\' && i + 1 < line.Length && (line[i + 1] == 'p' || line[i + 1] == 'n' || line[i + 1] == '\\'))
                {
                    cur.Append(line[i]).Append(line[i + 1]);
                    i++;
                }
                else if (line[i] == '|')
                {
                    parts.Add(cur.ToString());
                    cur.Clear();
                }
                else cur.Append(line[i]);
            }
            parts.Add(cur.ToString());
            return parts.ToArray();
        }
    }
}
