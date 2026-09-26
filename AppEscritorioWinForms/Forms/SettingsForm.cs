using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using app_escritorio.Data;
using app_escritorio.Models;
using System.Xml;

namespace app_escritorio.Forms
{
    public partial class SettingsForm : Form
    {
        public string Role { get; set; }

        private FlowLayoutPanel flowLayout;
        
        private TextBox nameBox, addressBox, phoneBox, currencyBox, logoBox;
        private ComboBox taxBox;
        private Label backupInfo, dataInfo;

        private static string ExeDataDir => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
        private static string AppDataDir => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestoOS");
        private static string SettingsPath => Path.Combine(AppDataDir, "settings.xml");
        private static string TaxPath => Path.Combine(AppDataDir, "tax.dat");
        private static string BackupRoot => Path.Combine(AppDataDir, "backups");

        public SettingsForm()
        {
            InitializeComponent();
            BuildUI();
            LoadData();
        }

        private void BuildUI()
        {
            flowLayout = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Padding = new Padding(40)
            };
            contentPanel.Controls.Add(flowLayout);

            // Header Panel
            var headerPanel = new Panel { Width = 1000, Height = 100, Margin = new Padding(0, 0, 0, 20) };
            
            var lblTitle = new Label
            {
                Text = "Configuración",
                Font = new Font("Segoe UI", 26, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(0, 0)
            };
            headerPanel.Controls.Add(lblTitle);

            var lblBadge = new Label
            {
                Text = "Solo Admin",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(243, 146, 0),
                AutoSize = true,
                Location = new Point(250, 15) // Adjust based on title width
            };
            headerPanel.Controls.Add(lblBadge);

            var lblSubtitle = new Label
            {
                Text = "Datos del negocio, impuesto por defecto y respaldos. Solo el Administrador.",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(160, 160, 160),
                AutoSize = true,
                Location = new Point(0, 50)
            };
            headerPanel.Controls.Add(lblSubtitle);

            flowLayout.Controls.Add(headerPanel);

            // CARD 1: Restaurante
            var card1 = CreateCard("Restaurante", 450);
            
            AddLabel(card1, "Nombre *", 24, 60);
            nameBox = AddTextBox(card1, 24, 80, 952);
            nameBox.Text = "Mi restaurante";

            AddLabel(card1, "Dirección", 24, 130);
            addressBox = AddTextBox(card1, 24, 150, 952);

            AddLabel(card1, "Teléfono", 24, 200);
            phoneBox = AddTextBox(card1, 24, 220, 460);

            AddLabel(card1, "Moneda", 516, 200);
            currencyBox = AddTextBox(card1, 516, 220, 460);
            currencyBox.Text = "€";

            var lblLogo = AddLabel(card1, "Logo (ruta de imagen)", 24, 270);
            lblLogo.ForeColor = Color.FromArgb(243, 146, 0);
            logoBox = AddTextBox(card1, 24, 290, 840);

            var btnBrowse = AddButton(card1, "Examinar", 876, 290, 100, 36, Color.FromArgb(50, 50, 55), Color.White);
            btnBrowse.Click += (s, e) =>
            {
                using (var dlg = new OpenFileDialog { Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp|Todos|*.*" })
                {
                    if (dlg.ShowDialog() == DialogResult.OK) logoBox.Text = dlg.FileName;
                }
            };

            var btnSaveRest = AddButton(card1, "Guardar datos", 24, 360, 952, 44, Color.FromArgb(250, 180, 160), Color.FromArgb(50, 20, 0));
            btnSaveRest.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnSaveRest.Click += SaveRestaurant_Click;

            flowLayout.Controls.Add(card1);

            // CARD 2: Impuesto por defecto
            var card2 = CreateCard("Impuesto por defecto", 220);
            AddSubtitle(card2, "El POS lo usa al abrir; se puede cambiar por venta.", 24, 50);

            taxBox = new ComboBox
            {
                Location = new Point(24, 85),
                Width = 952,
                Height = 44,
                Font = new Font("Segoe UI", 14),
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = Color.FromArgb(42, 42, 48),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            taxBox.Items.AddRange(new object[] { "Exento — 0%", "INC — 8%", "IVA — 19%", "INC+IVA — 27% unificado" });
            taxBox.SelectedIndex = 1; // INC - 8% by default
            card2.Controls.Add(taxBox);

            var btnSaveTax = AddButton(card2, "Guardar impuesto", 24, 145, 952, 44, Color.FromArgb(250, 180, 160), Color.FromArgb(50, 20, 0));
            btnSaveTax.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnSaveTax.Click += SaveTax_Click;

            flowLayout.Controls.Add(card2);

            // CARD 3: Respaldo
            var card3 = CreateCard("Respaldo", 200);
            AddSubtitle(card3, "Copia carta, pedidos, ajustes, mesas, módulos e impuesto con fecha y hora.", 24, 50);

            backupInfo = new Label
            {
                Text = "Sin respaldos aún.",
                Location = new Point(24, 85),
                AutoSize = true,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(243, 146, 0)
            };
            card3.Controls.Add(backupInfo);

            var btnBackup = AddButton(card3, "Crear respaldo ahora", 24, 130, 200, 36, Color.FromArgb(250, 180, 160), Color.FromArgb(50, 20, 0));
            btnBackup.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnBackup.Click += Backup_Click;

            var btnOpenBackup = AddButton(card3, "Abrir carpeta", 240, 130, 120, 36, Color.FromArgb(50, 50, 55), Color.White);
            btnOpenBackup.Click += OpenBackupFolder_Click;

            flowLayout.Controls.Add(card3);

            // CARD 4: Datos
            var card4 = CreateCard("Datos", 260);
            AddSubtitle(card4, "Ubicación y tamaño de cada archivo. Útil para soporte.", 24, 50);

            dataInfo = new Label
            {
                Location = new Point(24, 85),
                Size = new Size(952, 110),
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(160, 160, 160)
            };
            card4.Controls.Add(dataInfo);

            var btnRefresh = AddButton(card4, "Actualizar", 24, 200, 120, 36, Color.FromArgb(50, 50, 55), Color.White);
            btnRefresh.Click += (s, e) => LoadData();

            flowLayout.Controls.Add(card4);
        }

        private RoundedPanel CreateCard(string title, int height)
        {
            var p = new RoundedPanel
            {
                Width = 1000,
                Height = height,
                BackColor = Color.FromArgb(30, 30, 35),
                CornerRadius = 12,
                Margin = new Padding(0, 0, 0, 20)
            };
            var l = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(24, 15),
                AutoSize = true
            };
            p.Controls.Add(l);
            return p;
        }

        private Label AddLabel(Control parent, string text, int x, int y)
        {
            var l = new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(160, 160, 160),
                Location = new Point(x, y),
                AutoSize = true
            };
            parent.Controls.Add(l);
            return l;
        }

        private void AddSubtitle(Control parent, string text, int x, int y)
        {
            parent.Controls.Add(new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(160, 160, 160),
                Location = new Point(x, y),
                AutoSize = true
            });
        }

        private TextBox AddTextBox(Control parent, int x, int y, int w)
        {
            var t = new TextBox
            {
                Location = new Point(x, y),
                Width = w,
                Height = 36,
                Font = new Font("Segoe UI", 14),
                BackColor = Color.FromArgb(42, 42, 48),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            t.AutoSize = false;
            t.Height = 36;
            parent.Controls.Add(t);
            return t;
        }

        private Button AddButton(Control parent, string text, int x, int y, int w, int h, Color backColor, Color foreColor)
        {
            var b = new Button
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(w, h),
                BackColor = backColor,
                ForeColor = foreColor,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10)
            };
            b.FlatAppearance.BorderSize = 0;
            parent.Controls.Add(b);
            return b;
        }

        private void LoadData()
        {
            // Restaurante
            try
            {
                if (File.Exists(SettingsPath))
                {
                    var xml = new XmlDocument();
                    xml.Load(SettingsPath);
                    var s = xml.DocumentElement;
                    if (s != null)
                    {
                        nameBox.Text = s.SelectSingleNode("RestaurantName")?.InnerText ?? "Mi restaurante";
                        addressBox.Text = s.SelectSingleNode("Address")?.InnerText ?? "";
                        phoneBox.Text = s.SelectSingleNode("Phone")?.InnerText ?? "";
                        currencyBox.Text = s.SelectSingleNode("CurrencySymbol")?.InnerText ?? "€";
                        logoBox.Text = s.SelectSingleNode("LogoPath")?.InnerText ?? "";
                    }
                }
            }
            catch { }

            // Impuesto
            try
            {
                if (File.Exists(TaxPath))
                {
                    string text = File.ReadAllText(TaxPath).Trim();
                    if (text == "0") taxBox.SelectedIndex = 0;
                    else if (text == "8") taxBox.SelectedIndex = 1;
                    else if (text == "19") taxBox.SelectedIndex = 2;
                    else if (text == "27") taxBox.SelectedIndex = 3;
                }
            }
            catch { }

            // Respaldo
            try
            {
                if (!Directory.Exists(BackupRoot) || Directory.GetDirectories(BackupRoot).Length == 0)
                {
                    backupInfo.Text = "Sin respaldos aún.";
                }
                else
                {
                    var dirs = Directory.GetDirectories(BackupRoot);
                    Array.Sort(dirs);
                    string last = dirs[dirs.Length - 1];
                    int files = Directory.GetFiles(last).Length;
                    backupInfo.Text = dirs.Length + " respaldo(s). Último: " + Path.GetFileName(last) + " (" + files + " archivos).";
                }
            }
            catch { backupInfo.Text = "No se pudo leer la carpeta de respaldos."; }

            // Datos
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
            dataInfo.Text = sb.ToString().Trim();
        }

        private List<string> DataFiles()
        {
            return new List<string>
            {
                Path.Combine(ExeDataDir, "menu.xml"),
                Path.Combine(ExeDataDir, "orders.xml"),
                Path.Combine(AppDataDir, "settings.xml"),
                Path.Combine(AppDataDir, "mesas.dat"),
                Path.Combine(AppDataDir, "modules.dat"),
                Path.Combine(AppDataDir, "tax.dat")
            };
        }

        private void SaveRestaurant_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("El nombre del restaurante es requerido.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nameBox.Focus();
                return;
            }
            
            try
            {
                if (!Directory.Exists(AppDataDir)) Directory.CreateDirectory(AppDataDir);
                var xml = new XmlDocument();
                var root = xml.CreateElement("RestaurantSettings");
                xml.AppendChild(root);

                var n = xml.CreateElement("RestaurantName"); n.InnerText = name; root.AppendChild(n);
                var a = xml.CreateElement("Address"); a.InnerText = addressBox.Text.Trim(); root.AppendChild(a);
                var p = xml.CreateElement("Phone"); p.InnerText = phoneBox.Text.Trim(); root.AppendChild(p);
                var c = xml.CreateElement("CurrencySymbol"); c.InnerText = currencyBox.Text.Trim(); root.AppendChild(c);
                var l = xml.CreateElement("LogoPath"); l.InnerText = logoBox.Text.Trim(); root.AppendChild(l);

                xml.Save(SettingsPath);
                MessageBox.Show("Datos guardados.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveTax_Click(object sender, EventArgs e)
        {
            string val = "8";
            if (taxBox.SelectedIndex == 0) val = "0";
            else if (taxBox.SelectedIndex == 1) val = "8";
            else if (taxBox.SelectedIndex == 2) val = "19";
            else if (taxBox.SelectedIndex == 3) val = "27";

            try
            {
                if (!Directory.Exists(AppDataDir)) Directory.CreateDirectory(AppDataDir);
                File.WriteAllText(TaxPath, val);
                MessageBox.Show("Impuesto por defecto: " + taxBox.SelectedItem + ".", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void Backup_Click(object sender, EventArgs e)
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
                LoadData();
                MessageBox.Show("Respaldo creado con " + copied + " archivos en:\n" + dest, "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear el respaldo: " + ex.Message, "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenBackupFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(BackupRoot)) Directory.CreateDirectory(BackupRoot);
                Process.Start("explorer.exe", BackupRoot);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la carpeta: " + ex.Message, "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
