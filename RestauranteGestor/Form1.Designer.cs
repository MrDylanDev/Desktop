namespace RestauranteGestor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        internal System.Windows.Forms.Panel sidebarPanel;
        internal System.Windows.Forms.Panel panelTop;
        internal System.Windows.Forms.Panel panelMain;
        internal System.Windows.Forms.Label lblHeaderTitle;
        internal System.Windows.Forms.Label lblHeaderSubtitle;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#0c0f10");
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Width = 272;
            this.sidebarPanel.Padding = new System.Windows.Forms.Padding(12);
            this.sidebarPanel.AutoScroll = true;

            // Logo
            var logoPanel = new System.Windows.Forms.Panel();
            logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            logoPanel.Height = 56;
            logoPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#0c0f10");
            var lblLogo = new System.Windows.Forms.Label();
            lblLogo.Text = "◉  RestoOS\n     Modular Core";
            lblLogo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffb59d");
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            logoPanel.Controls.Add(lblLogo);

            // Badge offline
            var badgePanel = new System.Windows.Forms.Panel();
            badgePanel.Dock = System.Windows.Forms.DockStyle.Top;
            badgePanel.Height = 48;
            badgePanel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            var badge = new System.Windows.Forms.Label();
            badge.Text = "● Operando Local    100% Offline Ready";
            badge.ForeColor = System.Drawing.Color.White;
            badge.BackColor = System.Drawing.ColorTranslator.FromHtml("#00a572");
            badge.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            badge.Dock = System.Windows.Forms.DockStyle.Fill;
            badge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            badgePanel.Controls.Add(badge);
            // rounded effect via padding

            // Sucursal
            var sucPanel = new System.Windows.Forms.Panel();
            sucPanel.Dock = System.Windows.Forms.DockStyle.Top;
            sucPanel.Height = 64;
            sucPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#1d2022");
            sucPanel.Padding = new System.Windows.Forms.Padding(10);
            var lblSuc = new System.Windows.Forms.Label();
            lblSuc.Text = "SUCURSAL ACTIVA\nLa Brasserie Urbana\nSucursal Centro";
            lblSuc.ForeColor = System.Drawing.ColorTranslator.FromHtml("#e1e2e4");
            lblSuc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblSuc.Dock = System.Windows.Forms.DockStyle.Fill;
            sucPanel.Controls.Add(lblSuc);

            // Footer LAN - add first so Dock.Bottom reserves space
            var footer = new System.Windows.Forms.Label();
            footer.Text = "▦ Servidor Local LAN      192.168.1.100";
            footer.ForeColor = System.Drawing.ColorTranslator.FromHtml("#4edea3");
            footer.BackColor = System.Drawing.ColorTranslator.FromHtml("#191c1e");
            footer.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            footer.Height = 28;
            footer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sidebarPanel.Controls.Add(footer);

            // Nav host - fills remaining, buttons dock top inside it
            var navHost = new System.Windows.Forms.Panel();
            navHost.Dock = System.Windows.Forms.DockStyle.Fill;
            navHost.BackColor = System.Drawing.ColorTranslator.FromHtml("#0c0f10");
            navHost.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            navHost.AutoScroll = true;
            this.sidebarPanel.Controls.Add(navHost);

            // Add dock-top panels in correct order (first added = top)
            this.sidebarPanel.Controls.Add(sucPanel);
            this.sidebarPanel.Controls.Add(badgePanel);
            this.sidebarPanel.Controls.Add(logoPanel);
            // correct order is logo top, then badge, then suc: already added logo last -> top, so no BringToFront

            // Configuración gear - separable footer above LAN
            var configPanel = new System.Windows.Forms.Panel();
            configPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            configPanel.Height = 52;
            configPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#0c0f10");
            configPanel.Padding = new System.Windows.Forms.Padding(8);
            var btnConfig = new System.Windows.Forms.Button();
            btnConfig.Name = "btnConfig";
            btnConfig.Text = "⚙  Configuración  >  Módulos";
            btnConfig.Tag = "config-modulos";
            btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnConfig.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffb59d");
            btnConfig.BackColor = System.Drawing.ColorTranslator.FromHtml("#1d2022");
            btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            configPanel.Controls.Add(btnConfig);
            this.sidebarPanel.Controls.Add(configPanel);

            // Nav buttons inside navHost docked top
            string[] nav = new string[] {
                "☷  Selector de Módulos",
                "◩  Dashboard",
                "▭  Punto de Venta POS          F1",
                "▦  Mesas y Salón               F2",
                "♨  Cocina KDS                 F3",
                "▤  Inventario",
                "◰  Reservas",
                "▭  Menú Digital",
                "▣  Reportes y Métricas"
            };
            string[] tags = new string[] {
                "selector",
                "dashboard",
                "pos",
                "mesas",
                "kds",
                "inventario",
                "reservas",
                "menu",
                "reportes"
            };
            // add in reverse so first appears top when Dock.Top
            for (int i = nav.Length - 1; i >= 0; i--)
            {
                var btn = new System.Windows.Forms.Button();
                btn.Text = nav[i];
                btn.Tag = tags[i];
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI", 9F, i==0? System.Drawing.FontStyle.Bold: System.Drawing.FontStyle.Regular);
                btn.ForeColor = System.Drawing.ColorTranslator.FromHtml(i==0? "#ffb59d": "#e1e2e4");
                btn.BackColor = System.Drawing.ColorTranslator.FromHtml(i==0? "#282a2c": "#0c0f10");
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.Height = 40;
                btn.Dock = System.Windows.Forms.DockStyle.Top;
                btn.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
                navHost.Controls.Add(btn);
            }

            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#191c1e");
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 64;
            this.panelTop.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);

            var topInner = new System.Windows.Forms.Panel();
            topInner.Dock = System.Windows.Forms.DockStyle.Fill;
            topInner.BackColor = System.Drawing.ColorTranslator.FromHtml("#191c1e");

            this.lblClock = new System.Windows.Forms.Label();
            this.lblClock.Text = "14:42:08";
            this.lblClock.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblClock.ForeColor = System.Drawing.ColorTranslator.FromHtml("#e1e2e4");
            this.lblClock.BackColor = System.Drawing.ColorTranslator.FromHtml("#282a2c");
            this.lblClock.AutoSize = false;
            this.lblClock.Size = new System.Drawing.Size(110, 32);
            this.lblClock.Location = new System.Drawing.Point(0, 8);
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            var btnPanico = new System.Windows.Forms.Button();
            btnPanico.Text = "⚡ Pánico / Ayuda rápida";
            btnPanico.BackColor = System.Drawing.ColorTranslator.FromHtml("#93000a");
            btnPanico.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffdad6");
            btnPanico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPanico.FlatAppearance.BorderSize = 0;
            btnPanico.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            btnPanico.Size = new System.Drawing.Size(170, 32);
            btnPanico.Location = new System.Drawing.Point(820, 8);
            btnPanico.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            var btnTactil = new System.Windows.Forms.Button();
            btnTactil.Text = "☝ Modo Táctil";
            btnTactil.BackColor = System.Drawing.ColorTranslator.FromHtml("#282a2c");
            btnTactil.ForeColor = System.Drawing.ColorTranslator.FromHtml("#e1e2e4");
            btnTactil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTactil.FlatAppearance.BorderSize = 0;
            btnTactil.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            btnTactil.Size = new System.Drawing.Size(120, 32);
            btnTactil.Location = new System.Drawing.Point(1000, 8);
            btnTactil.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            var btnFull = new System.Windows.Forms.Button();
            btnFull.Text = "⛶";
            btnFull.BackColor = System.Drawing.ColorTranslator.FromHtml("#282a2c");
            btnFull.ForeColor = System.Drawing.ColorTranslator.FromHtml("#e1e2e4");
            btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFull.FlatAppearance.BorderSize = 0;
            btnFull.Size = new System.Drawing.Size(36, 32);
            btnFull.Location = new System.Drawing.Point(1130, 8);
            btnFull.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            var btnConfigTop = new System.Windows.Forms.Button();
            btnConfigTop.Name = "btnConfigTop";
            btnConfigTop.Text = "⚙";
            btnConfigTop.Tag = "config-modulos";
            btnConfigTop.BackColor = System.Drawing.ColorTranslator.FromHtml("#1d2022");
            btnConfigTop.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffb59d");
            btnConfigTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfigTop.FlatAppearance.BorderSize = 0;
            btnConfigTop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            btnConfigTop.Size = new System.Drawing.Size(36, 32);
            btnConfigTop.Location = new System.Drawing.Point(1090, 8);
            btnConfigTop.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnConfigTop.Cursor = System.Windows.Forms.Cursors.Hand;

            var avatar = new System.Windows.Forms.Label();
            avatar.Text = "●";
            avatar.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb59d");
            avatar.ForeColor = System.Drawing.ColorTranslator.FromHtml("#5d1800");
            avatar.Font = new System.Drawing.Font("Segoe UI", 12F);
            avatar.Size = new System.Drawing.Size(32, 32);
            avatar.Location = new System.Drawing.Point(1178, 8);
            avatar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            avatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            topInner.Controls.Add(this.lblClock);
            topInner.Controls.Add(btnPanico);
            topInner.Controls.Add(btnTactil);
            topInner.Controls.Add(btnConfigTop);
            topInner.Controls.Add(btnFull);
            topInner.Controls.Add(avatar);
            this.panelTop.Controls.Add(topInner);

            // hidden header labels for Form1.cs
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle.Visible = false;
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle.Visible = false;

            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.ColorTranslator.FromHtml("#111415");
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Padding = new System.Windows.Forms.Padding(0);

            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.sidebarPanel);
            this.Text = "RestoOS - Modular Core";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }
    }
}
