using System;
using System.IO;
using System.Xml;

namespace app_escritorio.Data
{
    /// <summary>Lectura de los archivos que guarda Configuración en %LocalAppData%\RestoOS.</summary>
    public static class LocalSettings
    {
        public static string AppDataDir => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestoOS");
        private static string TaxPath => Path.Combine(AppDataDir, "tax.dat");
        private static string SettingsPath => Path.Combine(AppDataDir, "settings.xml");

        /// <summary>Impuesto por defecto en % (0, 8, 19 ó 27). 8 si no hay nada guardado.</summary>
        public static int LoadTaxPercent()
        {
            try
            {
                if (File.Exists(TaxPath) && int.TryParse(File.ReadAllText(TaxPath).Trim(), out int p) && (p == 0 || p == 8 || p == 19 || p == 27))
                    return p;
            }
            catch { }
            return 8;
        }

        /// <summary>Nombre del restaurante guardado en Configuración (o null).</summary>
        public static string LoadRestaurantName()
        {
            try
            {
                if (!File.Exists(SettingsPath)) return null;
                var xml = new XmlDocument();
                xml.Load(SettingsPath);
                var name = xml.DocumentElement?.SelectSingleNode("RestaurantName")?.InnerText;
                return string.IsNullOrWhiteSpace(name) ? null : name.Trim();
            }
            catch { return null; }
        }

        /// <summary>Dirección del restaurante (se muestra bajo el nombre en el sidebar).</summary>
        public static string LoadAddress()
        {
            try
            {
                if (!File.Exists(SettingsPath)) return null;
                var xml = new XmlDocument();
                xml.Load(SettingsPath);
                var a = xml.DocumentElement?.SelectSingleNode("Address")?.InnerText;
                return string.IsNullOrWhiteSpace(a) ? null : a.Trim();
            }
            catch { return null; }
        }

        public static bool IsModuleEnabled(string key)
        {
            var store = Forms.ModulesForm.Store;
            return store.ContainsKey(key) && store[key];
        }
    }
}
