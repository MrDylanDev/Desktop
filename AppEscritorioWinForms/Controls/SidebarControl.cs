using System;
using System.Drawing;
using System.Windows.Forms;
using app_escritorio.Forms;

namespace app_escritorio.Controls
{
    public partial class SidebarControl : UserControl
    {
        private Panel pnlButtons;

        public SidebarControl()
        {
            InitializeComponent();
            BuildUI();
        }

        private void BuildUI()
        {
            this.BackColor = Color.FromArgb(20, 20, 25);
            this.Size = new Size(250, 720);

            // 1. Logo area
            Panel pnlLogo = new Panel { Dock = DockStyle.Top, Height = 70 };
            
            Label lblDot = new Label
            {
                Text = "●",
                ForeColor = Color.FromArgb(243, 146, 0),
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                Location = new Point(14, 16),
                AutoSize = true
            };
            Label lblTitle = new Label
            {
                Text = "RestoOS",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                Location = new Point(44, 16),
                AutoSize = true
            };
            Label lblSubtitle = new Label
            {
                Text = "Modular Core",
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                Location = new Point(46, 44),
                AutoSize = true
            };

            pnlLogo.Controls.Add(lblDot);
            pnlLogo.Controls.Add(lblTitle);
            pnlLogo.Controls.Add(lblSubtitle);

            // 2. Operando local button
            Panel pnlLocal = new Panel { Dock = DockStyle.Top, Height = 60 };
            Panel pnlLocalBtn = new Panel
            {
                BackColor = Color.FromArgb(0, 180, 100),
                Location = new Point(16, 10),
                Size = new Size(218, 36),
                Cursor = Cursors.Hand
            };
            Label lblOperando = new Label
            {
                Text = "● Operando local",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            pnlLocalBtn.Controls.Add(lblOperando);
            pnlLocal.Controls.Add(pnlLocalBtn);

            // 3. Sucursal Activa
            Panel pnlSucursal = new Panel { Dock = DockStyle.Top, Height = 90 };
            Label lblSucHeader = new Label
            {
                Text = "SUCURSAL ACTIVA",
                ForeColor = Color.FromArgb(243, 146, 0),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(16, 5),
                AutoSize = true
            };
            Panel pnlSucBox = new Panel
            {
                BackColor = Color.FromArgb(30, 30, 35),
                Location = new Point(16, 25),
                Size = new Size(218, 54)
            };
            Label lblLaBrasserie = new Label
            {
                Text = "La Brasserie Urbana",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12F),
                Location = new Point(10, 5),
                AutoSize = true
            };
            Label lblSucCentro = new Label
            {
                Text = "Sucursal Centro",
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 11F),
                Location = new Point(10, 27),
                AutoSize = true
            };
            pnlSucBox.Controls.Add(lblLaBrasserie);
            pnlSucBox.Controls.Add(lblSucCentro);
            pnlSucursal.Controls.Add(lblSucHeader);
            pnlSucursal.Controls.Add(pnlSucBox);

            // 4. Section Header
            Panel pnlHeader = new Panel { Dock = DockStyle.Top, Height = 40 };
            Label lblSectionHeader = new Label
            {
                ForeColor = Color.FromArgb(243, 146, 0),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Location = new Point(16, 15),
                AutoSize = true
            };
            pnlHeader.Controls.Add(lblSectionHeader);

            // 5. Buttons Container
            pnlButtons = new Panel { Dock = DockStyle.Top, Height = 350 };

            btnModulos = CreateNavButton("⊞  Selector de Módulos");
            btnReportes = CreateNavButton("◻  Reportes + Trazabilidad");
            btnConfiguracion = CreateNavButton("   Configuración del restaurante");

            btnPos = CreateNavButton("   Punto de Venta POS  F1");
            btnMesas = CreateNavButton("   Mesas y Salón  F2");
            btnKds = CreateNavButton("◻  Cocina KDS  F3");
            btnInventario = CreateNavButton("   Inventario");
            btnReservas = CreateNavButton("   Reservas");
            btnDelivery = CreateNavButton("   Delivery");
            btnMenu = CreateNavButton("   Menú Digital");

            // Attach original logic
            btnPos.Click += (s, ev) => Forms.NavigationManager.NavigateTo(Forms.NavigationManager.PosView);
            btnMesas.Click += (s, ev) => Forms.NavigationManager.NavigateTo(Forms.NavigationManager.MesasView);
            btnKds.Click += (s, ev) => Forms.NavigationManager.NavigateTo(Forms.NavigationManager.KdsView);
            btnInventario.Click += (s, ev) => Forms.NavigationManager.NavigateTo(Forms.NavigationManager.InventarioView);
            btnReservas.Click += (s, ev) => Forms.NavigationManager.NavigateTo(Forms.NavigationManager.ReservasView);
            btnDelivery.Click += (s, ev) => Forms.NavigationManager.NavigateTo(Forms.NavigationManager.DeliveryView);
            btnReportes.Click += (s, ev) => Forms.NavigationManager.NavigateTo(Forms.NavigationManager.ReportesView);
            btnModulos.Click += (s, ev) => Forms.NavigationManager.NavigateTo(Forms.NavigationManager.ModulesView);
            btnConfiguracion.Click += (s, ev) => Forms.NavigationManager.NavigateTo(Forms.NavigationManager.SettingsView);
            btnMenu.Click += (s, ev) => Forms.NavigationManager.NavigateTo(Forms.NavigationManager.MenuView);

            // 6. Bottom area
            Panel pnlBottom = new Panel { Dock = DockStyle.Bottom, Height = 80 };
            Button btnConfigLink = new Button
            {
                Text = "⚙ Configuración > Módulos",
                ForeColor = Color.Gray,
                Font = new Font("Segoe UI", 10F),
                FlatStyle = FlatStyle.Flat,
                Dock = DockStyle.Top,
                Height = 40,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(14, 0, 0, 0),
                Cursor = Cursors.Hand
            };
            btnConfigLink.FlatAppearance.BorderSize = 0;
            btnConfigLink.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnConfigLink.FlatAppearance.MouseDownBackColor = Color.Transparent;
            
            Label lblDatosLocales = new Label
            {
                Text = "🟢 Datos locales",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F),
                Location = new Point(16, 45),
                AutoSize = true
            };
            pnlBottom.Controls.Add(lblDatosLocales);
            pnlBottom.Controls.Add(btnConfigLink);

            this.Controls.Add(pnlButtons);
            this.Controls.Add(pnlHeader);
            this.Controls.Add(pnlSucursal);
            this.Controls.Add(pnlLocal);
            this.Controls.Add(pnlLogo);
            this.Controls.Add(pnlBottom);

            pnlButtons.BringToFront();
            pnlHeader.BringToFront();
            pnlSucursal.BringToFront();
            pnlLocal.BringToFront();
            pnlLogo.BringToFront();

            bool isAdmin = Forms.NavigationManager.CurrentRole == "Admin";
            lblSectionHeader.Text = isAdmin ? "--- ADMINISTRACIÓN ---" : "--- OPERACIÓN ---";

            if (isAdmin)
            {
                pnlButtons.Controls.Add(btnConfiguracion); btnConfiguracion.BringToFront();
                pnlButtons.Controls.Add(btnReportes); btnReportes.BringToFront();
                pnlButtons.Controls.Add(btnModulos); btnModulos.BringToFront();
            }
            else
            {
                pnlButtons.Controls.Add(btnMenu); btnMenu.BringToFront();
                pnlButtons.Controls.Add(btnDelivery); btnDelivery.BringToFront();
                pnlButtons.Controls.Add(btnReservas); btnReservas.BringToFront();
                pnlButtons.Controls.Add(btnInventario); btnInventario.BringToFront();
                pnlButtons.Controls.Add(btnKds); btnKds.BringToFront();
                pnlButtons.Controls.Add(btnMesas); btnMesas.BringToFront();
                pnlButtons.Controls.Add(btnPos); btnPos.BringToFront();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.DesignMode) return;

            if (Forms.NavigationManager.CurrentRole != "Admin")
            {
                btnMesas.Enabled = Forms.ModulesForm.Store.ContainsKey("salon") && Forms.ModulesForm.Store["salon"];
                btnMenu.Enabled = Forms.ModulesForm.Store.ContainsKey("menu") && Forms.ModulesForm.Store["menu"];
                btnKds.Enabled = Forms.ModulesForm.Store.ContainsKey("kds") && Forms.ModulesForm.Store["kds"];
                btnInventario.Enabled = Forms.ModulesForm.Store.ContainsKey("inventario") && Forms.ModulesForm.Store["inventario"];
                btnReservas.Enabled = Forms.ModulesForm.Store.ContainsKey("reservas") && Forms.ModulesForm.Store["reservas"];
                btnDelivery.Enabled = Forms.ModulesForm.Store.ContainsKey("delivery") && Forms.ModulesForm.Store["delivery"];
                
                Forms.ModulesForm.ModuleStateChanged += (module, enabled) =>
                {
                    if (module == "salon") btnMesas.Enabled = enabled;
                    else if (module == "menu") btnMenu.Enabled = enabled;
                    else if (module == "kds") btnKds.Enabled = enabled;
                    else if (module == "inventario") btnInventario.Enabled = enabled;
                    else if (module == "reservas") btnReservas.Enabled = enabled;
                    else if (module == "delivery") btnDelivery.Enabled = enabled;
                };
            }
        }

        private Button CreateNavButton(string text)
        {
            Button btn = new Button
            {
                Text = text,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 12F),
                Height = 44,
                Dock = DockStyle.Top,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(14, 0, 0, 0),
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 50);
            return btn;
        }

        public void SetActivePage(string page)
        {
            foreach (Control c in pnlButtons.Controls)
            {
                if (c is Button b)
                {
                    b.BackColor = Color.Transparent;
                    if (!string.IsNullOrEmpty(page) && b.Text.Contains(page))
                    {
                        b.BackColor = Color.FromArgb(45, 45, 55); // active button
                    }
                }
            }
        }
    }
}