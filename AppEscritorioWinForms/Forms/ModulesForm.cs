using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    public partial class ModulesForm : Form
    {
        public string Role { get; set; }
        private static string StorePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestoOS", "modules.dat");
        private static Dictionary<string, bool> _store;
        private bool _initializing = true;

        public static event Action<string, bool> ModuleStateChanged;
        public static Dictionary<string, bool> Store
        {
            get
            {
                if (_store != null) return _store;
                _store = new Dictionary<string, bool>
                {
                    ["salon"] = true, ["menu"] = true, ["kds"] = false, ["inventario"] = true, ["reservas"] = true, ["reportes"] = true, ["delivery"] = true
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

        public static void SaveStore()
        {
            try
            {
                var dir = Path.GetDirectoryName(StorePath);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                var lines = new List<string>();
                foreach (var kv in Store) lines.Add(kv.Key + "=" + (kv.Value ? "1" : "0"));
                File.WriteAllLines(StorePath, lines);
            }
            catch { }
        }

                public ModulesForm()
        {
            InitializeComponent();
            LoadModules();
            topBar1.RoleText = NavigationManager.CurrentRole ?? "Administrador";
            topBar1.CambiarPerfilClicked += (s, e) => { Application.Restart(); };
            sidebarControl1.SetActivePage("Módulos");
        }

        private void LoadModules()
        {
            _initializing = true;
            flowLayout.Controls.Clear();

            Color orange = Color.FromArgb(243, 146, 0);
            Color green = Color.FromArgb(0, 200, 150);

            // 1. POS
            flowLayout.Controls.Add(CreateModuleCard("pos", "⊡", "Punto de Venta Esencial (POS)", "Cobro, pedido, efectivo y tarjeta como método de registro.", orange, true, true, "Núcleo del sistema · Activo"));
            // 2. Salón
            flowLayout.Controls.Add(CreateModuleCard("salon", "⊞", "Gestión de Salón y Mesas", "Plano visual, estados de mesa y apertura de pedidos.", orange, false, Store["salon"], ""));
            // 3. Menú
            flowLayout.Controls.Add(CreateModuleCard("menu", "≡", "Menú y productos", "Catálogo de categorías, platos, precios y disponibilidad.", green, false, Store["menu"], ""));
            // 4. KDS
            flowLayout.Controls.Add(CreateModuleCard("kds", "⋯", "Cocina KDS", "Kanban de pedidos: Nuevo → En preparación → Listo (solo frontend).", orange, false, Store["kds"], ""));
            // 5. Inventario
            flowLayout.Controls.Add(CreateModuleCard("inventario", "☰", "Inventario", "Registro de insumos, descuento automático y alertas stock bajo (solo frontend).", green, false, Store["inventario"], ""));
            // 6. Reservas
            flowLayout.Controls.Add(CreateModuleCard("reservas", "⊟", "Reservas", "Vista calendario/agenda y asignación de mesa (solo frontend).", orange, false, Store["reservas"], ""));
            // 7. Reportes
            flowLayout.Controls.Add(CreateModuleCard("reportes", "⊡", "Reportes + Trazabilidad", "Ventas por período e historial de cobros (qué se vendió) — solo Admin (solo frontend).", orange, false, Store["reportes"], ""));
            // 8. Delivery
            flowLayout.Controls.Add(CreateModuleCard("delivery", "◎", "Delivery", "Pedidos Rappi/Uber/DiDi vía agregador y sincronización de menú (solo frontend).", orange, false, Store["delivery"], ""));

            // Módulos futuros
            flowFuturos.Controls.Clear();
            flowFuturos.Controls.Add(CreateFutureCard("DIAN - Próximamente"));

            _initializing = false;

            // Adjust positions after cards render
            flowLayout.PerformLayout();
            lblFuturos.Top = flowLayout.Bottom + 40;
            flowFuturos.Top = lblFuturos.Bottom + 10;
        }

        private Control CreateModuleCard(string key, string icon, string title, string desc, Color iconColor, bool isCore, bool isChecked, string coreText)
        {
            var card = new RoundedPanel
            {
                Width = 480,
                Height = 200,
                BackColor = Color.FromArgb(30, 30, 35),
                CornerRadius = 12,
                Margin = new Padding(0, 0, 20, 20)
            };

            var iconLabel = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 24, FontStyle.Regular),
                ForeColor = iconColor,
                Location = new Point(20, 15),
                AutoSize = true
            };

            var titleLabel = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(65, 25),
                AutoSize = true
            };

            var descLabel = new Label
            {
                Text = desc,
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.DarkGray,
                Location = new Point(25, 75),
                Width = 430,
                Height = 45
            };

            card.Controls.Add(iconLabel);
            card.Controls.Add(titleLabel);
            card.Controls.Add(descLabel);

            if (isCore)
            {
                var coreLabel = new Label
                {
                    Text = coreText,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = iconColor,
                    Location = new Point(25, 145),
                    AutoSize = true
                };
                card.Controls.Add(coreLabel);
            }
            else
            {
                var checkboxColor = isChecked ? Color.FromArgb(0, 200, 150) : Color.FromArgb(140, 140, 140);
                
                var chk = new CheckBox
                {
                    Text = "Módulo activado",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(25, 135),
                    Checked = isChecked,
                    AutoSize = true
                };

                var statusLabel = new Label
                {
                    Text = isChecked ? "Módulo activo" : "Módulo desactivado",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = checkboxColor,
                    Location = new Point(45, 165), // offset below checkbox
                    AutoSize = true
                };

                chk.CheckedChanged += (s, e) =>
                {
                    if (_initializing) return;
                    Store[key] = chk.Checked;
                    SaveStore(); 
                    ModuleStateChanged?.Invoke(key, chk.Checked);
                    
                    var newColor = chk.Checked ? Color.FromArgb(0, 200, 150) : Color.FromArgb(140, 140, 140);
                    statusLabel.ForeColor = newColor;
                    statusLabel.Text = chk.Checked ? "Módulo activo" : "Módulo desactivado";
                };

                card.Controls.Add(chk);
                card.Controls.Add(statusLabel);
            }

            return card;
        }

        private Control CreateFutureCard(string title)
        {
            var card = new RoundedPanel
            {
                Width = 340,
                Height = 60,
                BackColor = Color.FromArgb(30, 30, 35),
                CornerRadius = 12,
                Margin = new Padding(0, 0, 12, 12)
            };

            var lbl = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.Gray,
                Location = new Point(20, 15),
                AutoSize = true
            };
            card.Controls.Add(lbl);
            return card;
        }
    }

    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 12;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = new GraphicsPath())
            {
                int r = CornerRadius * 2;
                path.AddArc(0, 0, r, r, 180, 90);
                path.AddArc(Width - r, 0, r, r, 270, 90);
                path.AddArc(Width - r, Height - r, r, r, 0, 90);
                path.AddArc(0, Height - r, r, r, 90, 90);
                path.CloseAllFigures();
                this.Region = new Region(path);
            }
        }
    }
}
