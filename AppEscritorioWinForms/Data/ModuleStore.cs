using System;
using System.Collections.Generic;
using System.IO;

namespace app_escritorio.Data
{
    /// <summary>
    /// Módulos activados/desactivados (%LocalAppData%\RestoOS\modules.dat, formato clave=1/0).
    /// Lo usan la pantalla Módulos, el sidebar y el POS.
    /// </summary>
    public static class ModuleStore
    {
        /// <summary>Claves de los módulos opcionales (el POS siempre está activo).</summary>
        public static readonly string[] Keys = { "salon", "menu", "kds", "inventario", "reservas", "delivery", "reportes" };

        private static string StorePath => Path.Combine(LocalSettings.AppDataDir, "modules.dat");
        private static Dictionary<string, bool> _store;

        /// <summary>Se dispara al activar/desactivar un módulo (clave, activo).</summary>
        public static event Action<string, bool> ModuleStateChanged;

        public static Dictionary<string, bool> Store
        {
            get
            {
                if (_store != null) return _store;
                _store = new Dictionary<string, bool>
                {
                    ["salon"] = true, ["menu"] = true, ["kds"] = false, ["inventario"] = true,
                    ["reservas"] = true, ["reportes"] = true, ["delivery"] = true
                };
                try
                {
                    if (File.Exists(StorePath))
                        foreach (var line in File.ReadAllLines(StorePath))
                        {
                            var p = line.Split('=');
                            if (p.Length == 2) _store[p[0].Trim().ToLowerInvariant()] = p[1].Trim() == "1";
                        }
                }
                catch { }
                return _store;
            }
        }

        public static bool IsEnabled(string key) => key == "pos" || (Store.TryGetValue(key, out bool on) && on);

        public static void SetEnabled(string key, bool enabled)
        {
            if (IsEnabled(key) == enabled && Store.ContainsKey(key)) return;
            Store[key] = enabled;
            Save();
            ModuleStateChanged?.Invoke(key, enabled);
        }

        private static void Save()
        {
            try
            {
                Directory.CreateDirectory(LocalSettings.AppDataDir);
                var lines = new List<string>();
                foreach (var kv in Store) lines.Add(kv.Key + "=" + (kv.Value ? "1" : "0"));
                File.WriteAllLines(StorePath, lines);
            }
            catch { }
        }
    }
}
