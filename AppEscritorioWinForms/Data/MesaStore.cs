using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using app_escritorio.Utils;

namespace app_escritorio.Data
{
    /// <summary>Mesa del salón (mismo formato de mesas.dat que la versión WPF).</summary>
    public class MesaInfo
    {
        public MesaInfo(string name, string sector, string capacity, string status, string mockTotal, bool canOpen)
        {
            Name = name; Sector = sector; Capacity = capacity; Status = status; MockTotal = mockTotal; CanOpen = canOpen;
        }

        public string Name { get; set; }
        public string Sector { get; set; }
        public string Capacity { get; set; }
        public string Status { get; set; }
        public string MockTotal { get; set; }
        public bool CanOpen { get; set; }

        /// <summary>"Mesa 5" → "5"; "Barra 1" → "1".</summary>
        public string Number
        {
            get
            {
                var parts = (Name ?? string.Empty).Split(' ');
                return parts.Length > 1 ? parts[parts.Length - 1] : Name;
            }
        }

        public decimal RealTotal => TicketStore.GetSubtotalFor(Name);

        /// <summary>Total real del ticket del POS; si no hay, el total de demostración.</summary>
        public string Total
        {
            get
            {
                var real = RealTotal;
                return real > 0 ? real.ToString("C0", CultureInfo.GetCultureInfo("es-CO")) : (MockTotal ?? "$0");
            }
        }

        public Color StatusColor
        {
            get
            {
                switch (Status)
                {
                    case "Libre": return Theme.Tertiary;
                    case "Ocupada": return Theme.Secondary;
                    case "Cuenta pedida": return Theme.Primary;
                    case "Por limpiar": return Theme.Error;
                    default: return Theme.OnSurfaceVariant;
                }
            }
        }
    }

    /// <summary>Lee y guarda las mesas en %LocalAppData%\RestoOS\mesas.dat.</summary>
    public static class MesaStore
    {
        public static readonly string[] Sectors = { "Principal", "Terraza", "Barra", "VIP" };
        public static readonly string[] Statuses = { "Libre", "Ocupada", "Cuenta pedida", "Reservada", "Por limpiar" };

        private static string StorePath => Path.Combine(LocalSettings.AppDataDir, "mesas.dat");

        public static List<MesaInfo> Load()
        {
            var list = new List<MesaInfo>();
            try
            {
                if (File.Exists(StorePath))
                {
                    foreach (var line in File.ReadAllLines(StorePath))
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        var p = line.Split('|');
                        if (p.Length < 6) continue;
                        list.Add(new MesaInfo(p[0], p[1], p[2], p[3], p[4], p[5] == "1"));
                    }
                    if (list.Count > 0) return list;
                }
            }
            catch { }

            list.Add(new MesaInfo("Mesa 1", "Principal", "2 personas", "Libre", "$0", true));
            list.Add(new MesaInfo("Mesa 2", "Principal", "4 personas", "Ocupada", "$42.500", true));
            list.Add(new MesaInfo("Mesa 3", "Principal", "4 personas", "Ocupada", "$64.200", true));
            list.Add(new MesaInfo("Mesa 4", "Principal", "6 personas", "Libre", "$0", true));
            list.Add(new MesaInfo("Mesa 5", "Principal", "2 personas", "Cuenta pedida", "$87.900", true));
            list.Add(new MesaInfo("Mesa 6", "Principal", "4 personas", "Por limpiar", "$51.000", true));
            list.Add(new MesaInfo("Mesa 7", "Terraza", "4 personas", "Reservada", "$0", false));
            list.Add(new MesaInfo("Mesa 8", "Terraza", "4 personas", "Libre", "$0", true));
            list.Add(new MesaInfo("Barra 1", "Barra", "2 personas", "Ocupada", "$18.500", true));
            list.Add(new MesaInfo("VIP 1", "VIP", "8 personas", "Reservada", "$0", false));
            Save(list);
            return list;
        }

        public static void Save(IEnumerable<MesaInfo> mesas)
        {
            try
            {
                Directory.CreateDirectory(LocalSettings.AppDataDir);
                File.WriteAllLines(StorePath, mesas.Select(t => string.Join("|",
                    t.Name, t.Sector, t.Capacity, t.Status, t.MockTotal ?? "$0", t.CanOpen ? "1" : "0")));
            }
            catch { }
        }
    }
}
