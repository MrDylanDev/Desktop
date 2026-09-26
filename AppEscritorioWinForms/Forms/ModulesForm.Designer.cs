namespace app_escritorio.Forms
{
    partial class ModulesForm
    {
        /// <summary>Variable del diseñador requerida.</summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.root = new app_escritorio.UI.RPanel();
            this.flowFuturos = new app_escritorio.UI.RFlowPanel();
            this.pnlDian = new app_escritorio.UI.RPanel();
            this.lblDian = new app_escritorio.UI.RLabel();
            this.lblFuturos = new app_escritorio.UI.RLabel();
            this.flowCards = new app_escritorio.UI.RFlowPanel();
            this.cardPos = new app_escritorio.Views.Modulos.ModuleCard();
            this.cardSalon = new app_escritorio.Views.Modulos.ModuleCard();
            this.cardMenu = new app_escritorio.Views.Modulos.ModuleCard();
            this.cardKds = new app_escritorio.Views.Modulos.ModuleCard();
            this.cardInventario = new app_escritorio.Views.Modulos.ModuleCard();
            this.cardReservas = new app_escritorio.Views.Modulos.ModuleCard();
            this.cardReportes = new app_escritorio.Views.Modulos.ModuleCard();
            this.cardDelivery = new app_escritorio.Views.Modulos.ModuleCard();
            this.lblSubtitle = new app_escritorio.UI.RLabel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.lblOverline = new app_escritorio.UI.RLabel();
            this.topBar = new app_escritorio.Shell.ShellTopBar();
            this.sidebar = new app_escritorio.Shell.ShellSidebar();
            this.root.SuspendLayout();
            this.flowFuturos.SuspendLayout();
            this.pnlDian.SuspendLayout();
            this.flowCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.flowFuturos);
            this.root.Controls.Add(this.lblFuturos);
            this.root.Controls.Add(this.flowCards);
            this.root.Controls.Add(this.lblSubtitle);
            this.root.Controls.Add(this.lblTitle);
            this.root.Controls.Add(this.lblOverline);
            this.root.AutoScroll = true;
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(272, 64);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(28);
            this.root.Size = new System.Drawing.Size(1100, 780);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // flowFuturos
            // 
            this.flowFuturos.Controls.Add(this.pnlDian);
            this.flowFuturos.AutoSize = true;
            this.flowFuturos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowFuturos.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowFuturos.Location = new System.Drawing.Point(28, 684);
            this.flowFuturos.Name = "flowFuturos";
            this.flowFuturos.Size = new System.Drawing.Size(1044, 76);
            this.flowFuturos.TabIndex = 5;
            // 
            // pnlDian
            // 
            this.pnlDian.Controls.Add(this.lblDian);
            this.pnlDian.CornerRadius = 14;
            this.pnlDian.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.pnlDian.Name = "pnlDian";
            this.pnlDian.Size = new System.Drawing.Size(340, 64);
            this.pnlDian.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.pnlDian.TabIndex = 0;
            // 
            // lblDian
            // 
            this.lblDian.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(138)))), ((int)(((byte)(137)))));
            this.lblDian.Location = new System.Drawing.Point(20, 0);
            this.lblDian.Name = "lblDian";
            this.lblDian.Size = new System.Drawing.Size(300, 64);
            this.lblDian.TabIndex = 0;
            this.lblDian.Text = "DIAN · Próximamente";
            this.lblDian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDian.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // lblFuturos
            // 
            this.lblFuturos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFuturos.Location = new System.Drawing.Point(0, 0);
            this.lblFuturos.Name = "lblFuturos";
            this.lblFuturos.Padding = new System.Windows.Forms.Padding(0, 18, 0, 10);
            this.lblFuturos.Size = new System.Drawing.Size(1044, 44);
            this.lblFuturos.TabIndex = 4;
            this.lblFuturos.Text = "Módulos futuros";
            this.lblFuturos.TextStyle = app_escritorio.UI.TextStyle.Overline;
            // 
            // flowCards
            // 
            this.flowCards.Controls.Add(this.cardPos);
            this.flowCards.Controls.Add(this.cardSalon);
            this.flowCards.Controls.Add(this.cardMenu);
            this.flowCards.Controls.Add(this.cardKds);
            this.flowCards.Controls.Add(this.cardInventario);
            this.flowCards.Controls.Add(this.cardReservas);
            this.flowCards.Controls.Add(this.cardReportes);
            this.flowCards.Controls.Add(this.cardDelivery);
            this.flowCards.AutoSize = true;
            this.flowCards.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowCards.Location = new System.Drawing.Point(28, 128);
            this.flowCards.Name = "flowCards";
            this.flowCards.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.flowCards.Size = new System.Drawing.Size(1044, 512);
            this.flowCards.TabIndex = 3;
            // 
            // cardPos
            // 
            this.cardPos.Description = "Cobro, pedido, efectivo y tarjeta como método de registro.";
            this.cardPos.Glyph = "▣";
            this.cardPos.GlyphColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.cardPos.IsCore = true;
            this.cardPos.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.cardPos.ModuleKey = "pos";
            this.cardPos.Name = "cardPos";
            this.cardPos.Size = new System.Drawing.Size(360, 232);
            this.cardPos.TabIndex = 0;
            this.cardPos.Title = "Punto de Venta Esencial (POS)";
            // 
            // cardSalon
            // 
            this.cardSalon.Description = "Plano visual, estados de mesa y apertura de pedidos.";
            this.cardSalon.Glyph = "▦";
            this.cardSalon.GlyphColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(95)))));
            this.cardSalon.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.cardSalon.ModuleKey = "salon";
            this.cardSalon.Name = "cardSalon";
            this.cardSalon.Size = new System.Drawing.Size(360, 232);
            this.cardSalon.TabIndex = 1;
            this.cardSalon.Title = "Gestión de Salón y Mesas";
            this.cardSalon.ModuleToggled += new System.EventHandler(this.Card_ModuleToggled);
            // 
            // cardMenu
            // 
            this.cardMenu.Description = "Catálogo de categorías, platos, precios y disponibilidad.";
            this.cardMenu.Glyph = "▤";
            this.cardMenu.GlyphColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.cardMenu.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.cardMenu.ModuleKey = "menu";
            this.cardMenu.Name = "cardMenu";
            this.cardMenu.Size = new System.Drawing.Size(360, 232);
            this.cardMenu.TabIndex = 2;
            this.cardMenu.Title = "Menú y productos";
            this.cardMenu.ModuleToggled += new System.EventHandler(this.Card_ModuleToggled);
            // 
            // cardKds
            // 
            this.cardKds.Description = "Kanban de pedidos: Nuevo → En preparación → Listo (solo frontend).";
            this.cardKds.Glyph = "♨";
            this.cardKds.GlyphColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(95)))));
            this.cardKds.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.cardKds.ModuleEnabled = false;
            this.cardKds.ModuleKey = "kds";
            this.cardKds.Name = "cardKds";
            this.cardKds.Size = new System.Drawing.Size(360, 232);
            this.cardKds.TabIndex = 3;
            this.cardKds.Title = "Cocina KDS";
            this.cardKds.ModuleToggled += new System.EventHandler(this.Card_ModuleToggled);
            // 
            // cardInventario
            // 
            this.cardInventario.Description = "Registro de insumos, descuento automático y alertas stock bajo (solo frontend).";
            this.cardInventario.Glyph = "▤";
            this.cardInventario.GlyphColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.cardInventario.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.cardInventario.ModuleKey = "inventario";
            this.cardInventario.Name = "cardInventario";
            this.cardInventario.Size = new System.Drawing.Size(360, 232);
            this.cardInventario.TabIndex = 4;
            this.cardInventario.Title = "Inventario";
            this.cardInventario.ModuleToggled += new System.EventHandler(this.Card_ModuleToggled);
            // 
            // cardReservas
            // 
            this.cardReservas.Description = "Vista calendario/agenda y asignación de mesa (solo frontend).";
            this.cardReservas.Glyph = "◰";
            this.cardReservas.GlyphColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(95)))));
            this.cardReservas.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.cardReservas.ModuleKey = "reservas";
            this.cardReservas.Name = "cardReservas";
            this.cardReservas.Size = new System.Drawing.Size(360, 232);
            this.cardReservas.TabIndex = 5;
            this.cardReservas.Title = "Reservas";
            this.cardReservas.ModuleToggled += new System.EventHandler(this.Card_ModuleToggled);
            // 
            // cardReportes
            // 
            this.cardReportes.Description = "Ventas por período e historial de cobros (qué se vendió) — solo Admin (solo frontend).";
            this.cardReportes.Glyph = "▣";
            this.cardReportes.GlyphColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.cardReportes.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.cardReportes.ModuleKey = "reportes";
            this.cardReportes.Name = "cardReportes";
            this.cardReportes.Size = new System.Drawing.Size(360, 232);
            this.cardReportes.TabIndex = 6;
            this.cardReportes.Title = "Reportes + Trazabilidad";
            this.cardReportes.ModuleToggled += new System.EventHandler(this.Card_ModuleToggled);
            // 
            // cardDelivery
            // 
            this.cardDelivery.Description = "Pedidos Rappi/Uber/DiDi vía agregador y sincronización de menú (solo frontend).";
            this.cardDelivery.Glyph = "◎";
            this.cardDelivery.GlyphColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(95)))));
            this.cardDelivery.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.cardDelivery.ModuleKey = "delivery";
            this.cardDelivery.Name = "cardDelivery";
            this.cardDelivery.Size = new System.Drawing.Size(360, 232);
            this.cardDelivery.TabIndex = 7;
            this.cardDelivery.Title = "Delivery";
            this.cardDelivery.ModuleToggled += new System.EventHandler(this.Card_ModuleToggled);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(1044, 22);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Activa solo lo que tu restaurante necesita hoy. Los módulos no disponibles se muestran como próximos pasos.";
            this.lblSubtitle.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblTitle.Size = new System.Drawing.Size(1044, 64);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Escalabilidad";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Hero;
            // 
            // lblOverline
            // 
            this.lblOverline.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOverline.Location = new System.Drawing.Point(0, 0);
            this.lblOverline.Name = "lblOverline";
            this.lblOverline.Size = new System.Drawing.Size(1044, 20);
            this.lblOverline.TabIndex = 0;
            this.lblOverline.Text = "Módulos";
            this.lblOverline.TextStyle = app_escritorio.UI.TextStyle.Overline;
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(272, 0);
            this.topBar.Name = "topBar";
            this.topBar.RoleText = "Administrador";
            this.topBar.RouteText = "Módulos";
            this.topBar.Size = new System.Drawing.Size(1100, 64);
            this.topBar.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.ActiveRoute = "modulos";
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(272, 844);
            this.sidebar.TabIndex = 2;
            // 
            // ModulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1372, 844);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "ModulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestoOS - Modular Core";
            this.Controls.Add(this.root);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sidebar);
            this.flowCards.ResumeLayout(false);
            this.pnlDian.ResumeLayout(false);
            this.flowFuturos.ResumeLayout(false);
            this.root.ResumeLayout(false);
            this.root.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private app_escritorio.UI.RFlowPanel flowFuturos;
        private app_escritorio.UI.RPanel pnlDian;
        private app_escritorio.UI.RLabel lblDian;
        private app_escritorio.UI.RLabel lblFuturos;
        private app_escritorio.UI.RFlowPanel flowCards;
        private app_escritorio.Views.Modulos.ModuleCard cardPos;
        private app_escritorio.Views.Modulos.ModuleCard cardSalon;
        private app_escritorio.Views.Modulos.ModuleCard cardMenu;
        private app_escritorio.Views.Modulos.ModuleCard cardKds;
        private app_escritorio.Views.Modulos.ModuleCard cardInventario;
        private app_escritorio.Views.Modulos.ModuleCard cardReservas;
        private app_escritorio.Views.Modulos.ModuleCard cardReportes;
        private app_escritorio.Views.Modulos.ModuleCard cardDelivery;
        private app_escritorio.UI.RLabel lblSubtitle;
        private app_escritorio.UI.RLabel lblTitle;
        private app_escritorio.UI.RLabel lblOverline;
        private app_escritorio.Shell.ShellTopBar topBar;
        private app_escritorio.Shell.ShellSidebar sidebar;
    }
}
