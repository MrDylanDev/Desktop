using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace RestauranteGestor.Native.Views
{
    public partial class ModulesView : UserControl
    {
        private static string StorePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestoOS", "modules.dat");
        private static Dictionary<string, bool> _store;

        private static Dictionary<string, bool> Store
        {
            get
            {
                if (_store != null) return _store;
                _store = new Dictionary<string, bool>
                {
                    ["salon"] = true, ["menu"] = true, ["kds"] = false, ["inventario"] = false, ["reservas"] = false, ["reportes"] = false, ["delivery"] = false
                };
                try
                {
                    if (File.Exists(StorePath))
                    {
                        foreach (var line in File.ReadAllLines(StorePath))
                        {
                            var p = line.Split('=');
                            if (p.Length == 2) _store[p[0].Trim().ToLower()] = p[1].Trim() == "1";
                        }
                    }
                }
                catch { }
                return _store;
            }
        }

        private static void SaveStore()
        {
            try
            {
                var dir = Path.GetDirectoryName(StorePath);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                var lines = new System.Collections.Generic.List<string>();
                foreach (var kv in Store) lines.Add(kv.Key + "=" + (kv.Value ? "1" : "0"));
                File.WriteAllLines(StorePath, lines);
            }
            catch { }
        }

        private bool _initializing = true;
        public bool SalonEnabled => Store["salon"];
        public bool MenuEnabled => Store["menu"];
        public bool KdsEnabled => Store["kds"];
        public bool InventarioEnabled => Store["inventario"];
        public bool ReservasEnabled => Store["reservas"];
        public bool ReportesEnabled => Store["reportes"];
        public bool DeliveryEnabled => Store["delivery"];
        public event Action<string, bool> ModuleStateChanged;

        public ModulesView()
        {
            InitializeComponent();
            _initializing = true;
            SalonToggle.IsChecked = Store["salon"];
            MenuToggle.IsChecked = Store["menu"];
            KdsToggle.IsChecked = Store["kds"];
            InventarioToggle.IsChecked = Store["inventario"];
            ReservasToggle.IsChecked = Store["reservas"];
            ReportesToggle.IsChecked = Store["reportes"];
            DeliveryToggle.IsChecked = Store["delivery"];
            UpdateStatus(SalonToggle, SalonStatus, Store["salon"]);
            UpdateStatus(MenuToggle, MenuStatus, Store["menu"]);
            UpdateStatus(KdsToggle, KdsStatus, Store["kds"]);
            UpdateStatus(InventarioToggle, InventarioStatus, Store["inventario"]);
            UpdateStatus(ReservasToggle, ReservasStatus, Store["reservas"]);
            UpdateStatus(ReportesToggle, ReportesStatus, Store["reportes"]);
            UpdateStatus(DeliveryToggle, DeliveryStatus, Store["delivery"]);
            _initializing = false;
        }

        private void UpdateStatus(CheckBox toggle, System.Windows.Controls.TextBlock status, bool enabled)
        {
            if (status == null) return;
            status.Text = enabled ? "Módulo activo" : "Módulo desactivado";
            status.Foreground = enabled ? (System.Windows.Media.Brush)FindResource("Tertiary") : (System.Windows.Media.Brush)FindResource("OnSurfaceVariant");
            if (toggle != null) toggle.Foreground = status.Foreground;
        }

        private void ModuleToggle_Changed(object sender, RoutedEventArgs e)
        {
            if (_initializing) return;
            bool enabled = (sender as CheckBox)?.IsChecked == true;
            if (ReferenceEquals(sender, SalonToggle))
            {
                Store["salon"] = enabled;
                UpdateStatus(SalonToggle, SalonStatus, enabled);
                SaveStore(); ModuleStateChanged?.Invoke("salon", enabled);
            }
            else if (ReferenceEquals(sender, MenuToggle))
            {
                Store["menu"] = enabled;
                UpdateStatus(MenuToggle, MenuStatus, enabled);
                SaveStore(); ModuleStateChanged?.Invoke("menu", enabled);
            }
            else if (ReferenceEquals(sender, KdsToggle))
            {
                Store["kds"] = enabled;
                UpdateStatus(KdsToggle, KdsStatus, enabled);
                SaveStore(); ModuleStateChanged?.Invoke("kds", enabled);
            }
            else if (ReferenceEquals(sender, InventarioToggle))
            {
                Store["inventario"] = enabled;
                UpdateStatus(InventarioToggle, InventarioStatus, enabled);
                SaveStore(); ModuleStateChanged?.Invoke("inventario", enabled);
            }
            else if (ReferenceEquals(sender, ReservasToggle))
            {
                Store["reservas"] = enabled;
                UpdateStatus(ReservasToggle, ReservasStatus, enabled);
                SaveStore(); ModuleStateChanged?.Invoke("reservas", enabled);
            }
            else if (ReferenceEquals(sender, ReportesToggle))
            {
                Store["reportes"] = enabled;
                UpdateStatus(ReportesToggle, ReportesStatus, enabled);
                SaveStore(); ModuleStateChanged?.Invoke("reportes", enabled);
            }
            else if (ReferenceEquals(sender, DeliveryToggle))
            {
                Store["delivery"] = enabled;
                UpdateStatus(DeliveryToggle, DeliveryStatus, enabled);
                SaveStore(); ModuleStateChanged?.Invoke("delivery", enabled);
            }
        }
    }
}
