using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using app_escritorio.Data;
using app_escritorio.UI;

namespace app_escritorio.Forms
{
    /// <summary>
    /// Configuración (migración de ConfiguracionView.xaml de WPF). Solo Admin.
    /// Guarda settings.xml y tax.dat en %LocalAppData%\RestoOS y crea respaldos con fecha y hora.
    /// </summary>
    public partial class SettingsForm : Form
    {
        /// <summary>Se guardaron nombre/dirección (el Shell actualiza la sucursal del sidebar).</summary>
        public event EventHandler RestaurantSaved;

        private static readonly int[] TaxValues = { 0, 8, 19, 27 };
        private static string AppDataDir => LocalSettings.AppDataDir;
        private static string ExeDataDir => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
        private static string SettingsPath => Path.Combine(AppDataDir, "settings.xml");
        private static string TaxPath => Path.Combine(AppDataDir, "tax.dat");
        private static string BackupRoot => Path.Combine(AppDataDir, "backups");

        public SettingsForm()
        {
            InitializeComponent();
            if (UiHelpers.IsDesignTime) return;
            LoadData();
        }

        private static List<string> DataFiles() => new List<string>
        {
            Path.Combine(ExeDataDir, "menu.xml"),
            Path.Combine(ExeDataDir, "orders.xml"),
            SettingsPath,
            Path.Combine(AppDataDir, "mesas.dat"),
            Path.Combine(AppDataDir, "modules.dat"),
            TaxPath
        };

        public void LoadData()
        {
            txtName.Text = "Mi restaurante";
            txtCurrency.Text = "$";
            try
            {
                if (File.Exists(SettingsPath))
                {
                    var xml = new XmlDocument();
                    xml.Load(SettingsPath);
                    var s = xml.DocumentElement;
                    if (s != null)
                    {
                        txtName.Text = s.SelectSingleNode("RestaurantName")?.InnerText ?? "Mi restaurante";
                        txtAddress.Text = s.SelectSingleNode("Address")?.InnerText ?? "";
                        txtPhone.Text = s.SelectSingleNode("Phone")?.InnerText ?? "";
                        txtCurrency.Text = s.SelectSingleNode("CurrencySymbol")?.InnerText ?? "$";
                        txtLogo.Text = s.SelectSingleNode("LogoPath")?.InnerText ?? "";
                    }
                }
            }
            catch { }

            int tax = Array.IndexOf(TaxValues, LocalSettings.LoadTaxPercent());
            cmbTax.SelectedIndex = tax >= 0 ? tax : 1;

            try
            {
                string[] dirs = Directory.Exists(BackupRoot) ? Directory.GetDirectories(BackupRoot) : new string[0];
                if (dirs.Length == 0) lblBackupInfo.Text = "Sin respaldos aún.";
                else
                {
                    Array.Sort(dirs);
                    string last = dirs[dirs.Length - 1];
                    lblBackupInfo.Text = dirs.Length + " respaldo(s). Último: " + Path.GetFileName(last) + " (" + Directory.GetFiles(last).Length + " archivos).";
                }
            }
            catch { lblBackupInfo.Text = "No se pudo leer la carpeta de respaldos."; }

            var sb = new StringBuilder();
            foreach (string f in DataFiles())
                sb.AppendLine(File.Exists(f)
                    ? Path.GetFileName(f) + " — " + (new FileInfo(f).Length / 1024) + " KB — " + f
                    : Path.GetFileName(f) + " — no existe aún");
            lblDataInfo.Text = sb.ToString().Trim();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog { Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp|Todos|*.*" })
                if (dlg.ShowDialog(TopLevelControl ?? this) == DialogResult.OK) txtLogo.Text = dlg.FileName;
        }

        private void BtnSaveRestaurant_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (name.Length == 0)
            {
                MessageBox.Show("El nombre del restaurante es requerido.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            try
            {
                Directory.CreateDirectory(AppDataDir);
                var xml = new XmlDocument();
                var root = xml.CreateElement("RestaurantSettings");
                xml.AppendChild(root);
                void Add(string tag, string value) { var n = xml.CreateElement(tag); n.InnerText = value; root.AppendChild(n); }
                Add("RestaurantName", name);
                Add("Address", txtAddress.Text.Trim());
                Add("Phone", txtPhone.Text.Trim());
                Add("CurrencySymbol", txtCurrency.Text.Trim());
                Add("LogoPath", txtLogo.Text.Trim());
                xml.Save(SettingsPath);
                RestaurantSaved?.Invoke(this, EventArgs.Empty);
                LoadData();
                MessageBox.Show("Datos guardados.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSaveTax_Click(object sender, EventArgs e)
        {
            int value = TaxValues[Math.Max(0, cmbTax.SelectedIndex)];
            try
            {
                Directory.CreateDirectory(AppDataDir);
                File.WriteAllText(TaxPath, value.ToString());
                LoadData();
                MessageBox.Show("Impuesto por defecto: " + cmbTax.SelectedItem + ".", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string dest = Path.Combine(BackupRoot, "respaldo_" + DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                Directory.CreateDirectory(dest);
                int copied = 0;
                foreach (string src in DataFiles())
                    if (File.Exists(src)) { File.Copy(src, Path.Combine(dest, Path.GetFileName(src)), true); copied++; }
                LoadData();
                MessageBox.Show("Respaldo creado con " + copied + " archivos en:\n" + dest, "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear el respaldo: " + ex.Message, "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(BackupRoot);
                Process.Start("explorer.exe", BackupRoot);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la carpeta: " + ex.Message, "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefreshData_Click(object sender, EventArgs e) => LoadData();
    }
}
