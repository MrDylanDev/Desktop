using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using app_escritorio.Data;
using app_escritorio.Models;

namespace RestauranteGestor.Native.Views
{
    /// <summary>
    /// Apartado Configuración (Solo Admin): datos del restaurante (settings.xml
    /// compartido con AppEscritorioWinForms), impuesto por defecto del POS y
    /// respaldos de un clic.
    /// </summary>
    public partial class ConfiguracionView : UserControl
    {
        private static string ExeDataDir => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
        private static string SettingsPath => Path.Combine(ExeDataDir, "settings.xml");
        private static string AppDataDir => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestoOS");
        private static string TaxPath => Path.Combine(AppDataDir, "tax.dat");
        private static string BackupRoot => Path.Combine(AppDataDir, "backups");

        public ConfiguracionView()
        {
            InitializeComponent();
            TaxBox.Items.Add("Exento — 0%");
            TaxBox.Items.Add("INC — 8%");
            TaxBox.Items.Add("IVA — 19%");
            RefreshData();
        }

        public void RefreshData()
        {
            LoadRestaurant();
            LoadTax();
            RefreshBackupInfo();
            RefreshDataInfo();
        }

        // ---------- Impuesto (compartido con PosView) ----------

        public static int LoadTaxPercent()
        {
            try
            {
                if (File.Exists(TaxPath))
                {
                    int p;
                    if (int.TryParse(File.ReadAllText(TaxPath).Trim(), out p) && (p == 0 || p == 8 || p == 19)) return p;
                }
            }
            catch { }
            return 8;
        }

        public static void SaveTaxPercent(int percent)
        {
            try
            {
                if (!Directory.Exists(AppDataDir)) Directory.CreateDirectory(AppDataDir);
                File.WriteAllText(TaxPath, percent.ToString());
            }
            catch { }
        }

        private void LoadTax()
        {
            int p = LoadTaxPercent();
            TaxBox.SelectionChanged -= TaxBox_SelectionChanged;
            TaxBox.SelectedIndex = p == 0 ? 0 : (p == 19 ? 2 : 1);
            TaxBox.SelectionChanged += TaxBox_SelectionChanged;
        }

        private void TaxBox_SelectionChanged(object sender, SelectionChangedEventArgs e) { }

        private void SaveTax_Click(object sender, RoutedEventArgs e)
        {
            int p = TaxBox.SelectedIndex == 0 ? 0 : (TaxBox.SelectedIndex == 2 ? 19 : 8);
            SaveTaxPercent(p);
            MessageBox.Show("Impuesto por defecto: " + TaxBox.SelectedItem + ".", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // ---------- Restaurante (settings.xml de David) ----------

        private void LoadRestaurant()
        {
            if (NameBox == null) return;
            RestaurantSettings s = SettingsStore.Load(SettingsPath);
            NameBox.Text = s.RestaurantName ?? "";
            AddressBox.Text = s.Address ?? "";
            PhoneBox.Text = s.Phone ?? "";
            CurrencyBox.Text = string.IsNullOrEmpty(s.CurrencySymbol) ? "$" : s.CurrencySymbol;
            LogoBox.Text = s.LogoPath ?? "";
        }

        private void BrowseLogo_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog { Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp|Todos|*.*", Title = "Logo del restaurante" };
            if (dlg.ShowDialog() == true) LogoBox.Text = dlg.FileName;
        }

        private void SaveRestaurant_Click(object sender, RoutedEventArgs e)
        {
            string name = (NameBox.Text ?? "").Trim();
            if (name.Length == 0)
            {
                MessageBox.Show("El nombre del restaurante es requerido.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information);
                NameBox.Focus();
                return;
            }
            SettingsStore.Save(SettingsPath, new RestaurantSettings
            {
                RestaurantName = name,
                Address = (AddressBox.Text ?? "").Trim(),
                Phone = (PhoneBox.Text ?? "").Trim(),
                CurrencySymbol = (CurrencyBox.Text ?? "").Trim(),
                LogoPath = (LogoBox.Text ?? "").Trim()
            });
            MessageBox.Show("Datos guardados.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // ---------- Respaldo ----------

        private static List<string> DataFiles()
        {
            return new List<string>
            {
                Path.Combine(ExeDataDir, "menu.xml"),
                Path.Combine(ExeDataDir, "orders.xml"),
                Path.Combine(ExeDataDir, "settings.xml"),
                Path.Combine(AppDataDir, "mesas.dat"),
                Path.Combine(AppDataDir, "modules.dat"),
                Path.Combine(AppDataDir, "tax.dat")
            };
        }

        private void RefreshBackupInfo()
        {
            if (BackupInfo == null) return;
            try
            {
                if (!Directory.Exists(BackupRoot)) { BackupInfo.Text = "Sin respaldos aún."; return; }
                var dirs = Directory.GetDirectories(BackupRoot);
                if (dirs.Length == 0) { BackupInfo.Text = "Sin respaldos aún."; return; }
                Array.Sort(dirs);
                string last = dirs[dirs.Length - 1];
                int files = Directory.GetFiles(last).Length;
                BackupInfo.Text = dirs.Length + " respaldo(s). Último: " + Path.GetFileName(last) + " (" + files + " archivos).";
            }
            catch { BackupInfo.Text = "No se pudo leer la carpeta de respaldos."; }
        }

        private void Backup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string dest = Path.Combine(BackupRoot, "respaldo_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                Directory.CreateDirectory(dest);
                int copied = 0;
                foreach (string src in DataFiles())
                {
                    if (File.Exists(src)) { File.Copy(src, Path.Combine(dest, Path.GetFileName(src)), true); copied++; }
                }
                RefreshBackupInfo();
                MessageBox.Show("Respaldo creado con " + copied + " archivos en:\n" + dest, "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear el respaldo: " + ex.Message, "RestoOS", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OpenBackupFolder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!Directory.Exists(BackupRoot)) Directory.CreateDirectory(BackupRoot);
                Process.Start(BackupRoot);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la carpeta: " + ex.Message, "RestoOS", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // ---------- Datos ----------

        private void RefreshDataInfo()
        {
            if (DataInfo == null) return;
            var sb = new StringBuilder();
            foreach (string f in DataFiles())
            {
                string name = Path.GetFileName(f);
                if (File.Exists(f))
                {
                    long len = new FileInfo(f).Length;
                    sb.AppendLine(name + " — " + (len / 1024) + " KB — " + f);
                }
                else
                {
                    sb.AppendLine(name + " — no existe aún");
                }
            }
            DataInfo.Text = sb.ToString().Trim();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e) => RefreshData();
    }
}
