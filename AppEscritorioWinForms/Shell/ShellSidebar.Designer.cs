namespace app_escritorio.Shell
{
    partial class ShellSidebar
    {
        /// <summary>Variable del diseñador requerida.</summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this.root = new app_escritorio.UI.RPanel();
            this.flowMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBrand = new app_escritorio.UI.RLabel();
            this.lblSubtitle = new app_escritorio.UI.RLabel();
            this.badgeLocal = new app_escritorio.UI.RBadge();
            this.cardSucursal = new app_escritorio.UI.RPanel();
            this.lblSucHeader = new app_escritorio.UI.RLabel();
            this.lblSucName = new app_escritorio.UI.RLabel();
            this.lblSucSub = new app_escritorio.UI.RLabel();
            this.flowOperacion = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOperacion = new app_escritorio.UI.RLabel();
            this.flowAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.sepAdmin = new app_escritorio.UI.RPanel();
            this.lblAdmin = new app_escritorio.UI.RLabel();
            this.flowBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDatos = new app_escritorio.UI.RLabel();
            this.btnPos = new app_escritorio.UI.RButton();
            this.btnMesas = new app_escritorio.UI.RButton();
            this.btnKds = new app_escritorio.UI.RButton();
            this.btnInventario = new app_escritorio.UI.RButton();
            this.btnReservas = new app_escritorio.UI.RButton();
            this.btnDelivery = new app_escritorio.UI.RButton();
            this.btnMenu = new app_escritorio.UI.RButton();
            this.btnModulos = new app_escritorio.UI.RButton();
            this.btnReportes = new app_escritorio.UI.RButton();
            this.btnConfiguracion = new app_escritorio.UI.RButton();
            this.btnConfigModulos = new app_escritorio.UI.RButton();
            this.root.SuspendLayout();
            this.flowMain.SuspendLayout();
            this.cardSucursal.SuspendLayout();
            this.flowOperacion.SuspendLayout();
            this.flowAdmin.SuspendLayout();
            this.flowBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.flowMain);
            this.root.Controls.Add(this.flowBottom);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(12);
            this.root.Size = new System.Drawing.Size(272, 760);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Lowest;
            this.root.TabIndex = 0;
            // 
            // flowMain
            // 
            this.flowMain.Controls.Add(this.lblBrand);
            this.flowMain.Controls.Add(this.lblSubtitle);
            this.flowMain.Controls.Add(this.badgeLocal);
            this.flowMain.Controls.Add(this.cardSucursal);
            this.flowMain.Controls.Add(this.flowOperacion);
            this.flowMain.Controls.Add(this.flowAdmin);
            this.flowMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMain.Location = new System.Drawing.Point(12, 12);
            this.flowMain.Name = "flowMain";
            this.flowMain.Size = new System.Drawing.Size(248, 692);
            this.flowMain.TabIndex = 0;
            this.flowMain.WrapContents = false;
            // 
            // lblBrand
            // 
            this.lblBrand.Location = new System.Drawing.Point(3, 0);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(8, 6, 8, 2);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(242, 30);
            this.lblBrand.Text = "◉  RestoOS";
            this.lblBrand.TextStyle = app_escritorio.UI.TextStyle.Brand;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Location = new System.Drawing.Point(3, 44);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 10);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(242, 22);
            this.lblSubtitle.Text = "Modular Core";
            this.lblSubtitle.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // badgeLocal
            // 
            this.badgeLocal.Kind = app_escritorio.UI.BadgeKind.Success;
            this.badgeLocal.Location = new System.Drawing.Point(0, 78);
            this.badgeLocal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.badgeLocal.Name = "badgeLocal";
            this.badgeLocal.Size = new System.Drawing.Size(248, 32);
            this.badgeLocal.TabIndex = 2;
            this.badgeLocal.Text = "●  Operando local";
            // 
            // cardSucursal
            // 
            this.cardSucursal.Controls.Add(this.lblSucSub);
            this.cardSucursal.Controls.Add(this.lblSucName);
            this.cardSucursal.Controls.Add(this.lblSucHeader);
            this.cardSucursal.CornerRadius = 10;
            this.cardSucursal.Location = new System.Drawing.Point(0, 122);
            this.cardSucursal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.cardSucursal.Name = "cardSucursal";
            this.cardSucursal.Size = new System.Drawing.Size(248, 80);
            this.cardSucursal.TabIndex = 3;
            // 
            // lblSucHeader
            // 
            this.lblSucHeader.Location = new System.Drawing.Point(12, 10);
            this.lblSucHeader.Name = "lblSucHeader";
            this.lblSucHeader.Size = new System.Drawing.Size(224, 18);
            this.lblSucHeader.Text = "SUCURSAL ACTIVA";
            this.lblSucHeader.TextStyle = app_escritorio.UI.TextStyle.Overline;
            // 
            // lblSucName
            // 
            this.lblSucName.Location = new System.Drawing.Point(12, 30);
            this.lblSucName.Name = "lblSucName";
            this.lblSucName.Size = new System.Drawing.Size(224, 20);
            this.lblSucName.Text = "La Brasserie Urbana";
            this.lblSucName.TextStyle = app_escritorio.UI.TextStyle.Body;
            // 
            // lblSucSub
            // 
            this.lblSucSub.Location = new System.Drawing.Point(12, 52);
            this.lblSucSub.Name = "lblSucSub";
            this.lblSucSub.Size = new System.Drawing.Size(224, 18);
            this.lblSucSub.Text = "Sucursal Centro";
            this.lblSucSub.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // flowOperacion
            // 
            this.flowOperacion.AutoSize = true;
            this.flowOperacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowOperacion.Controls.Add(this.lblOperacion);
            this.flowOperacion.Controls.Add(this.btnPos);
            this.flowOperacion.Controls.Add(this.btnMesas);
            this.flowOperacion.Controls.Add(this.btnKds);
            this.flowOperacion.Controls.Add(this.btnInventario);
            this.flowOperacion.Controls.Add(this.btnReservas);
            this.flowOperacion.Controls.Add(this.btnDelivery);
            this.flowOperacion.Controls.Add(this.btnMenu);
            this.flowOperacion.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowOperacion.Location = new System.Drawing.Point(0, 216);
            this.flowOperacion.Margin = new System.Windows.Forms.Padding(0);
            this.flowOperacion.Name = "flowOperacion";
            this.flowOperacion.Size = new System.Drawing.Size(248, 332);
            this.flowOperacion.TabIndex = 4;
            this.flowOperacion.WrapContents = false;
            // 
            // lblOperacion
            // 
            this.lblOperacion.Location = new System.Drawing.Point(8, 8);
            this.lblOperacion.Margin = new System.Windows.Forms.Padding(8, 8, 8, 6);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(232, 18);
            this.lblOperacion.Text = "OPERACIÓN";
            this.lblOperacion.TextStyle = app_escritorio.UI.TextStyle.Overline;
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(0, 32);
            this.btnPos.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnPos.Name = "btnPos";
            this.btnPos.Padding = new System.Windows.Forms.Padding(14, 0, 8, 0);
            this.btnPos.Size = new System.Drawing.Size(248, 36);
            this.btnPos.TabIndex = 1;
            this.btnPos.Tag = "pos";
            this.btnPos.Text = "▭  Punto de Venta POS   F1";
            this.btnPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPos.Variant = app_escritorio.UI.ButtonVariant.Nav;
            this.btnPos.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.Location = new System.Drawing.Point(0, 76);
            this.btnMesas.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Padding = new System.Windows.Forms.Padding(14, 0, 8, 0);
            this.btnMesas.Size = new System.Drawing.Size(248, 36);
            this.btnMesas.TabIndex = 2;
            this.btnMesas.Tag = "mesas";
            this.btnMesas.Text = "▦  Mesas y Salón   F2";
            this.btnMesas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesas.Variant = app_escritorio.UI.ButtonVariant.Nav;
            this.btnMesas.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnKds
            // 
            this.btnKds.Location = new System.Drawing.Point(0, 120);
            this.btnKds.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnKds.Name = "btnKds";
            this.btnKds.Padding = new System.Windows.Forms.Padding(14, 0, 8, 0);
            this.btnKds.Size = new System.Drawing.Size(248, 36);
            this.btnKds.TabIndex = 3;
            this.btnKds.Tag = "kds";
            this.btnKds.Text = "♨  Cocina KDS   F3";
            this.btnKds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKds.Variant = app_escritorio.UI.ButtonVariant.Nav;
            this.btnKds.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(0, 164);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(14, 0, 8, 0);
            this.btnInventario.Size = new System.Drawing.Size(248, 36);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Tag = "inventario";
            this.btnInventario.Text = "▤  Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Variant = app_escritorio.UI.ButtonVariant.Nav;
            this.btnInventario.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.Location = new System.Drawing.Point(0, 208);
            this.btnReservas.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Padding = new System.Windows.Forms.Padding(14, 0, 8, 0);
            this.btnReservas.Size = new System.Drawing.Size(248, 36);
            this.btnReservas.TabIndex = 5;
            this.btnReservas.Tag = "reservas";
            this.btnReservas.Text = "◰  Reservas";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.Variant = app_escritorio.UI.ButtonVariant.Nav;
            this.btnReservas.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Location = new System.Drawing.Point(0, 252);
            this.btnDelivery.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Padding = new System.Windows.Forms.Padding(14, 0, 8, 0);
            this.btnDelivery.Size = new System.Drawing.Size(248, 36);
            this.btnDelivery.TabIndex = 6;
            this.btnDelivery.Tag = "delivery";
            this.btnDelivery.Text = "◎  Delivery";
            this.btnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelivery.Variant = app_escritorio.UI.ButtonVariant.Nav;
            this.btnDelivery.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(0, 296);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(14, 0, 8, 0);
            this.btnMenu.Size = new System.Drawing.Size(248, 36);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Tag = "menu";
            this.btnMenu.Text = "▭  Menú Digital";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Variant = app_escritorio.UI.ButtonVariant.Nav;
            this.btnMenu.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // flowAdmin
            // 
            this.flowAdmin.AutoSize = true;
            this.flowAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowAdmin.Controls.Add(this.sepAdmin);
            this.flowAdmin.Controls.Add(this.lblAdmin);
            this.flowAdmin.Controls.Add(this.btnModulos);
            this.flowAdmin.Controls.Add(this.btnReportes);
            this.flowAdmin.Controls.Add(this.btnConfiguracion);
            this.flowAdmin.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowAdmin.Location = new System.Drawing.Point(0, 548);
            this.flowAdmin.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowAdmin.Name = "flowAdmin";
            this.flowAdmin.Size = new System.Drawing.Size(248, 172);
            this.flowAdmin.TabIndex = 5;
            this.flowAdmin.WrapContents = false;
            // 
            // sepAdmin
            // 
            this.sepAdmin.Location = new System.Drawing.Point(8, 0);
            this.sepAdmin.Margin = new System.Windows.Forms.Padding(8, 0, 8, 10);
            this.sepAdmin.Name = "sepAdmin";
            this.sepAdmin.Size = new System.Drawing.Size(232, 1);
            this.sepAdmin.Surface = app_escritorio.UI.SurfaceLevel.Highest;
            this.sepAdmin.TabIndex = 0;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Location = new System.Drawing.Point(8, 11);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(8, 0, 8, 6);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(232, 18);
            this.lblAdmin.Text = "ADMINISTRACIÓN";
            this.lblAdmin.TextStyle = app_escritorio.UI.TextStyle.Overline;
            // 
            // btnModulos
            // 
            this.btnModulos.Location = new System.Drawing.Point(0, 35);
            this.btnModulos.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnModulos.Name = "btnModulos";
            this.btnModulos.Padding = new System.Windows.Forms.Padding(14, 0, 8, 0);
            this.btnModulos.Size = new System.Drawing.Size(248, 36);
            this.btnModulos.TabIndex = 1;
            this.btnModulos.Tag = "modulos";
            this.btnModulos.Text = "☷  Selector de Módulos";
            this.btnModulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModulos.Variant = app_escritorio.UI.ButtonVariant.Nav;
            this.btnModulos.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(0, 79);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(14, 0, 8, 0);
            this.btnReportes.Size = new System.Drawing.Size(248, 36);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Tag = "reportes";
            this.btnReportes.Text = "▣  Reportes + Trazabilidad";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Variant = app_escritorio.UI.ButtonVariant.Nav;
            this.btnReportes.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 123);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(14, 0, 8, 0);
            this.btnConfiguracion.Size = new System.Drawing.Size(248, 36);
            this.btnConfiguracion.TabIndex = 3;
            this.btnConfiguracion.Tag = "configuracion";
            this.btnConfiguracion.Text = "⚙  Configuración del restaurante";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Variant = app_escritorio.UI.ButtonVariant.Nav;
            this.btnConfiguracion.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // flowBottom
            // 
            this.flowBottom.Controls.Add(this.btnConfigModulos);
            this.flowBottom.Controls.Add(this.lblDatos);
            this.flowBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowBottom.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowBottom.Location = new System.Drawing.Point(12, 704);
            this.flowBottom.Name = "flowBottom";
            this.flowBottom.Size = new System.Drawing.Size(248, 36);
            this.flowBottom.TabIndex = 1;
            this.flowBottom.WrapContents = false;
            // 
            // btnConfigModulos
            // 
            this.btnConfigModulos.Location = new System.Drawing.Point(0, 2);
            this.btnConfigModulos.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnConfigModulos.Name = "btnConfigModulos";
            this.btnConfigModulos.Padding = new System.Windows.Forms.Padding(14, 0, 8, 0);
            this.btnConfigModulos.Size = new System.Drawing.Size(248, 36);
            this.btnConfigModulos.TabIndex = 0;
            this.btnConfigModulos.Tag = "modulos";
            this.btnConfigModulos.Text = "⚙  Configuración  ›  Módulos";
            this.btnConfigModulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigModulos.Variant = app_escritorio.UI.ButtonVariant.Nav;
            this.btnConfigModulos.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.Location = new System.Drawing.Point(14, 58);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(14, 10, 8, 4);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(226, 18);
            this.lblDatos.Text = "▦  Datos locales";
            this.lblDatos.TextStyle = app_escritorio.UI.TextStyle.Positive;
            // 
            // ShellSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.root);
            this.Name = "ShellSidebar";
            this.Size = new System.Drawing.Size(272, 760);
            this.flowBottom.ResumeLayout(false);
            this.flowAdmin.ResumeLayout(false);
            this.flowAdmin.PerformLayout();
            this.flowOperacion.ResumeLayout(false);
            this.flowOperacion.PerformLayout();
            this.cardSucursal.ResumeLayout(false);
            this.flowMain.ResumeLayout(false);
            this.flowMain.PerformLayout();
            this.root.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private System.Windows.Forms.FlowLayoutPanel flowMain;
        private app_escritorio.UI.RLabel lblBrand;
        private app_escritorio.UI.RLabel lblSubtitle;
        private app_escritorio.UI.RBadge badgeLocal;
        private app_escritorio.UI.RPanel cardSucursal;
        private app_escritorio.UI.RLabel lblSucHeader;
        private app_escritorio.UI.RLabel lblSucName;
        private app_escritorio.UI.RLabel lblSucSub;
        private System.Windows.Forms.FlowLayoutPanel flowOperacion;
        private app_escritorio.UI.RLabel lblOperacion;
        private System.Windows.Forms.FlowLayoutPanel flowAdmin;
        private app_escritorio.UI.RPanel sepAdmin;
        private app_escritorio.UI.RLabel lblAdmin;
        private System.Windows.Forms.FlowLayoutPanel flowBottom;
        private app_escritorio.UI.RLabel lblDatos;
        private app_escritorio.UI.RButton btnPos;
        private app_escritorio.UI.RButton btnMesas;
        private app_escritorio.UI.RButton btnKds;
        private app_escritorio.UI.RButton btnInventario;
        private app_escritorio.UI.RButton btnReservas;
        private app_escritorio.UI.RButton btnDelivery;
        private app_escritorio.UI.RButton btnMenu;
        private app_escritorio.UI.RButton btnModulos;
        private app_escritorio.UI.RButton btnReportes;
        private app_escritorio.UI.RButton btnConfiguracion;
        private app_escritorio.UI.RButton btnConfigModulos;
    }
}
