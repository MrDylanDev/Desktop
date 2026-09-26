namespace app_escritorio.Forms
{
    partial class SettingsForm
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
            this.column = new app_escritorio.UI.RPanel();
            this.cardData = new app_escritorio.UI.RPanel();
            this.lblcardDataTitle = new app_escritorio.UI.RLabel();
            this.btnRefreshData = new app_escritorio.UI.RButton();
            this.lblDataInfo = new app_escritorio.UI.RLabel();
            this.lblDataSub = new app_escritorio.UI.RLabel();
            this.spacer3 = new System.Windows.Forms.Panel();
            this.cardBackup = new app_escritorio.UI.RPanel();
            this.lblcardBackupTitle = new app_escritorio.UI.RLabel();
            this.btnOpenFolder = new app_escritorio.UI.RButton();
            this.btnBackup = new app_escritorio.UI.RButton();
            this.lblBackupInfo = new app_escritorio.UI.RLabel();
            this.lblBackupSub = new app_escritorio.UI.RLabel();
            this.spacer2 = new System.Windows.Forms.Panel();
            this.cardTax = new app_escritorio.UI.RPanel();
            this.lblcardTaxTitle = new app_escritorio.UI.RLabel();
            this.btnSaveTax = new app_escritorio.UI.RButton();
            this.cmbTax = new app_escritorio.UI.RComboBox();
            this.lblTaxSub = new app_escritorio.UI.RLabel();
            this.spacer1 = new System.Windows.Forms.Panel();
            this.cardRestaurant = new app_escritorio.UI.RPanel();
            this.lblcardRestaurantTitle = new app_escritorio.UI.RLabel();
            this.btnSaveRestaurant = new app_escritorio.UI.RButton();
            this.btnBrowse = new app_escritorio.UI.RButton();
            this.txtLogo = new app_escritorio.UI.RTextBox();
            this.lblLogo = new app_escritorio.UI.RLabel();
            this.txtCurrency = new app_escritorio.UI.RTextBox();
            this.lblCurrency = new app_escritorio.UI.RLabel();
            this.txtPhone = new app_escritorio.UI.RTextBox();
            this.lblPhone = new app_escritorio.UI.RLabel();
            this.txtAddress = new app_escritorio.UI.RTextBox();
            this.lblAddress = new app_escritorio.UI.RLabel();
            this.txtName = new app_escritorio.UI.RTextBox();
            this.lblName = new app_escritorio.UI.RLabel();
            this.lblSubtitle = new app_escritorio.UI.RLabel();
            this.header = new app_escritorio.UI.RPanel();
            this.badgeAdmin = new app_escritorio.UI.RBadge();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.topBar = new app_escritorio.Shell.ShellTopBar();
            this.sidebar = new app_escritorio.Shell.ShellSidebar();
            this.root.SuspendLayout();
            this.column.SuspendLayout();
            this.cardData.SuspendLayout();
            this.cardBackup.SuspendLayout();
            this.cardTax.SuspendLayout();
            this.cardRestaurant.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.column);
            this.root.AutoScroll = true;
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(272, 64);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(28);
            this.root.Size = new System.Drawing.Size(1100, 780);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // column
            // 
            this.column.Controls.Add(this.cardData);
            this.column.Controls.Add(this.spacer3);
            this.column.Controls.Add(this.cardBackup);
            this.column.Controls.Add(this.spacer2);
            this.column.Controls.Add(this.cardTax);
            this.column.Controls.Add(this.spacer1);
            this.column.Controls.Add(this.cardRestaurant);
            this.column.Controls.Add(this.lblSubtitle);
            this.column.Controls.Add(this.header);
            this.column.Location = new System.Drawing.Point(28, 28);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(860, 1186);
            this.column.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.column.TabIndex = 0;
            // 
            // cardData
            // 
            this.cardData.Controls.Add(this.lblcardDataTitle);
            this.cardData.Controls.Add(this.btnRefreshData);
            this.cardData.Controls.Add(this.lblDataInfo);
            this.cardData.Controls.Add(this.lblDataSub);
            this.cardData.CornerRadius = 14;
            this.cardData.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardData.Name = "cardData";
            this.cardData.Size = new System.Drawing.Size(860, 262);
            this.cardData.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.cardData.TabIndex = 9;
            // 
            // lblcardDataTitle
            // 
            this.lblcardDataTitle.Location = new System.Drawing.Point(24, 18);
            this.lblcardDataTitle.Name = "lblcardDataTitle";
            this.lblcardDataTitle.Size = new System.Drawing.Size(600, 30);
            this.lblcardDataTitle.TabIndex = 50;
            this.lblcardDataTitle.Text = "Datos";
            this.lblcardDataTitle.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.Location = new System.Drawing.Point(24, 202);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(130, 40);
            this.btnRefreshData.TabIndex = 2;
            this.btnRefreshData.Text = "Actualizar";
            this.btnRefreshData.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnRefreshData.Click += new System.EventHandler(this.BtnRefreshData_Click);
            // 
            // lblDataInfo
            // 
            this.lblDataInfo.Location = new System.Drawing.Point(24, 80);
            this.lblDataInfo.Name = "lblDataInfo";
            this.lblDataInfo.Size = new System.Drawing.Size(812, 112);
            this.lblDataInfo.TabIndex = 1;
            this.lblDataInfo.Text = "menu.xml — 20 KB — C:\\...\\data\\menu.xml\r\nsettings.xml — no existe aún";
            this.lblDataInfo.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblDataSub
            // 
            this.lblDataSub.Location = new System.Drawing.Point(24, 52);
            this.lblDataSub.Name = "lblDataSub";
            this.lblDataSub.Size = new System.Drawing.Size(812, 20);
            this.lblDataSub.TabIndex = 0;
            this.lblDataSub.Text = "Ubicación y tamaño de cada archivo. Útil para soporte.";
            this.lblDataSub.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // spacer3
            // 
            this.spacer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer3.Name = "spacer3";
            this.spacer3.Size = new System.Drawing.Size(860, 16);
            this.spacer3.TabIndex = 0;
            // 
            // cardBackup
            // 
            this.cardBackup.Controls.Add(this.lblcardBackupTitle);
            this.cardBackup.Controls.Add(this.btnOpenFolder);
            this.cardBackup.Controls.Add(this.btnBackup);
            this.cardBackup.Controls.Add(this.lblBackupInfo);
            this.cardBackup.Controls.Add(this.lblBackupSub);
            this.cardBackup.CornerRadius = 14;
            this.cardBackup.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardBackup.Name = "cardBackup";
            this.cardBackup.Size = new System.Drawing.Size(860, 176);
            this.cardBackup.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.cardBackup.TabIndex = 7;
            // 
            // lblcardBackupTitle
            // 
            this.lblcardBackupTitle.Location = new System.Drawing.Point(24, 18);
            this.lblcardBackupTitle.Name = "lblcardBackupTitle";
            this.lblcardBackupTitle.Size = new System.Drawing.Size(600, 30);
            this.lblcardBackupTitle.TabIndex = 50;
            this.lblcardBackupTitle.Text = "Respaldo";
            this.lblcardBackupTitle.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(236, 112);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(140, 40);
            this.btnOpenFolder.TabIndex = 3;
            this.btnOpenFolder.Text = "Abrir carpeta";
            this.btnOpenFolder.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnOpenFolder.Click += new System.EventHandler(this.BtnOpenFolder_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(24, 112);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(200, 40);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Crear respaldo ahora";
            this.btnBackup.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // lblBackupInfo
            // 
            this.lblBackupInfo.Location = new System.Drawing.Point(24, 78);
            this.lblBackupInfo.Name = "lblBackupInfo";
            this.lblBackupInfo.Size = new System.Drawing.Size(812, 22);
            this.lblBackupInfo.TabIndex = 1;
            this.lblBackupInfo.Text = "Sin respaldos aún.";
            this.lblBackupInfo.TextStyle = app_escritorio.UI.TextStyle.Body;
            // 
            // lblBackupSub
            // 
            this.lblBackupSub.Location = new System.Drawing.Point(24, 52);
            this.lblBackupSub.Name = "lblBackupSub";
            this.lblBackupSub.Size = new System.Drawing.Size(812, 20);
            this.lblBackupSub.TabIndex = 0;
            this.lblBackupSub.Text = "Copia carta, pedidos, ajustes, mesas, módulos e impuesto con fecha y hora.";
            this.lblBackupSub.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // spacer2
            // 
            this.spacer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer2.Name = "spacer2";
            this.spacer2.Size = new System.Drawing.Size(860, 16);
            this.spacer2.TabIndex = 0;
            // 
            // cardTax
            // 
            this.cardTax.Controls.Add(this.lblcardTaxTitle);
            this.cardTax.Controls.Add(this.btnSaveTax);
            this.cardTax.Controls.Add(this.cmbTax);
            this.cardTax.Controls.Add(this.lblTaxSub);
            this.cardTax.CornerRadius = 14;
            this.cardTax.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardTax.Name = "cardTax";
            this.cardTax.Size = new System.Drawing.Size(860, 192);
            this.cardTax.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.cardTax.TabIndex = 5;
            // 
            // lblcardTaxTitle
            // 
            this.lblcardTaxTitle.Location = new System.Drawing.Point(24, 18);
            this.lblcardTaxTitle.Name = "lblcardTaxTitle";
            this.lblcardTaxTitle.Size = new System.Drawing.Size(600, 30);
            this.lblcardTaxTitle.TabIndex = 50;
            this.lblcardTaxTitle.Text = "Impuesto por defecto";
            this.lblcardTaxTitle.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // btnSaveTax
            // 
            this.btnSaveTax.Location = new System.Drawing.Point(24, 128);
            this.btnSaveTax.Name = "btnSaveTax";
            this.btnSaveTax.Size = new System.Drawing.Size(812, 44);
            this.btnSaveTax.TabIndex = 2;
            this.btnSaveTax.Text = "Guardar impuesto";
            this.btnSaveTax.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnSaveTax.Click += new System.EventHandler(this.BtnSaveTax_Click);
            // 
            // cmbTax
            // 
            this.cmbTax.Items.AddRange(new object[] {
            "Exento — 0%",
            "INC — 8%",
            "IVA — 19%",
            "INC+IVA — 27% unificado"});
            this.cmbTax.Location = new System.Drawing.Point(24, 82);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(812, 32);
            this.cmbTax.TabIndex = 1;
            // 
            // lblTaxSub
            // 
            this.lblTaxSub.Location = new System.Drawing.Point(24, 52);
            this.lblTaxSub.Name = "lblTaxSub";
            this.lblTaxSub.Size = new System.Drawing.Size(812, 20);
            this.lblTaxSub.TabIndex = 0;
            this.lblTaxSub.Text = "El POS lo usa al abrir; se puede cambiar por venta.";
            this.lblTaxSub.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // spacer1
            // 
            this.spacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(860, 16);
            this.spacer1.TabIndex = 0;
            // 
            // cardRestaurant
            // 
            this.cardRestaurant.Controls.Add(this.lblcardRestaurantTitle);
            this.cardRestaurant.Controls.Add(this.btnSaveRestaurant);
            this.cardRestaurant.Controls.Add(this.btnBrowse);
            this.cardRestaurant.Controls.Add(this.txtLogo);
            this.cardRestaurant.Controls.Add(this.lblLogo);
            this.cardRestaurant.Controls.Add(this.txtCurrency);
            this.cardRestaurant.Controls.Add(this.lblCurrency);
            this.cardRestaurant.Controls.Add(this.txtPhone);
            this.cardRestaurant.Controls.Add(this.lblPhone);
            this.cardRestaurant.Controls.Add(this.txtAddress);
            this.cardRestaurant.Controls.Add(this.lblAddress);
            this.cardRestaurant.Controls.Add(this.txtName);
            this.cardRestaurant.Controls.Add(this.lblName);
            this.cardRestaurant.CornerRadius = 14;
            this.cardRestaurant.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardRestaurant.Name = "cardRestaurant";
            this.cardRestaurant.Size = new System.Drawing.Size(860, 420);
            this.cardRestaurant.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.cardRestaurant.TabIndex = 3;
            // 
            // lblcardRestaurantTitle
            // 
            this.lblcardRestaurantTitle.Location = new System.Drawing.Point(24, 18);
            this.lblcardRestaurantTitle.Name = "lblcardRestaurantTitle";
            this.lblcardRestaurantTitle.Size = new System.Drawing.Size(600, 30);
            this.lblcardRestaurantTitle.TabIndex = 50;
            this.lblcardRestaurantTitle.Text = "Restaurante";
            this.lblcardRestaurantTitle.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // btnSaveRestaurant
            // 
            this.btnSaveRestaurant.Location = new System.Drawing.Point(24, 354);
            this.btnSaveRestaurant.Name = "btnSaveRestaurant";
            this.btnSaveRestaurant.Size = new System.Drawing.Size(812, 44);
            this.btnSaveRestaurant.TabIndex = 6;
            this.btnSaveRestaurant.Text = "Guardar datos";
            this.btnSaveRestaurant.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnSaveRestaurant.Click += new System.EventHandler(this.BtnSaveRestaurant_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(728, 300);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(108, 40);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Examinar";
            this.btnBrowse.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(24, 300);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.PlaceholderText = "C:\\ruta\\logo.png";
            this.txtLogo.Size = new System.Drawing.Size(692, 40);
            this.txtLogo.TabIndex = 4;
            // 
            // lblLogo
            // 
            this.lblLogo.Location = new System.Drawing.Point(24, 278);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(692, 20);
            this.lblLogo.TabIndex = 64;
            this.lblLogo.Text = "Logo (ruta de imagen)";
            this.lblLogo.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(436, 228);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.PlaceholderText = "$";
            this.txtCurrency.Size = new System.Drawing.Size(400, 40);
            this.txtCurrency.TabIndex = 3;
            // 
            // lblCurrency
            // 
            this.lblCurrency.Location = new System.Drawing.Point(436, 206);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(400, 20);
            this.lblCurrency.TabIndex = 63;
            this.lblCurrency.Text = "Moneda";
            this.lblCurrency.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(24, 228);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "300 000 0000";
            this.txtPhone.Size = new System.Drawing.Size(400, 40);
            this.txtPhone.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(24, 206);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(400, 20);
            this.lblPhone.TabIndex = 62;
            this.lblPhone.Text = "Teléfono";
            this.lblPhone.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(24, 156);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "Calle 00 # 00-00";
            this.txtAddress.Size = new System.Drawing.Size(812, 40);
            this.txtAddress.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(24, 134);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(812, 20);
            this.lblAddress.TabIndex = 61;
            this.lblAddress.Text = "Dirección";
            this.lblAddress.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 84);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Mi restaurante";
            this.txtName.Size = new System.Drawing.Size(812, 40);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(24, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(812, 20);
            this.lblName.TabIndex = 60;
            this.lblName.Text = "Nombre *";
            this.lblName.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtitle.Location = new System.Drawing.Point(0, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(860, 40);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Datos del negocio, impuesto por defecto y respaldos. Solo el Administrador.";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSubtitle.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // header
            // 
            this.header.Controls.Add(this.badgeAdmin);
            this.header.Controls.Add(this.lblTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(860, 48);
            this.header.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.header.TabIndex = 0;
            // 
            // badgeAdmin
            // 
            this.badgeAdmin.Kind = app_escritorio.UI.BadgeKind.Primary;
            this.badgeAdmin.Location = new System.Drawing.Point(266, 14);
            this.badgeAdmin.Name = "badgeAdmin";
            this.badgeAdmin.Size = new System.Drawing.Size(94, 24);
            this.badgeAdmin.TabIndex = 1;
            this.badgeAdmin.Text = "Solo Admin";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Configuración";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Hero;
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(272, 0);
            this.topBar.Name = "topBar";
            this.topBar.RoleText = "Administrador";
            this.topBar.RouteText = "Configuración · Solo Admin";
            this.topBar.Size = new System.Drawing.Size(1100, 64);
            this.topBar.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.ActiveRoute = "configuracion";
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(272, 844);
            this.sidebar.TabIndex = 2;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1372, 844);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestoOS - Modular Core";
            this.Controls.Add(this.root);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sidebar);
            this.header.ResumeLayout(false);
            this.cardRestaurant.ResumeLayout(false);
            this.cardTax.ResumeLayout(false);
            this.cardBackup.ResumeLayout(false);
            this.cardData.ResumeLayout(false);
            this.column.ResumeLayout(false);
            this.root.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private app_escritorio.UI.RPanel column;
        private app_escritorio.UI.RPanel cardData;
        private app_escritorio.UI.RLabel lblcardDataTitle;
        private app_escritorio.UI.RButton btnRefreshData;
        private app_escritorio.UI.RLabel lblDataInfo;
        private app_escritorio.UI.RLabel lblDataSub;
        private System.Windows.Forms.Panel spacer3;
        private app_escritorio.UI.RPanel cardBackup;
        private app_escritorio.UI.RLabel lblcardBackupTitle;
        private app_escritorio.UI.RButton btnOpenFolder;
        private app_escritorio.UI.RButton btnBackup;
        private app_escritorio.UI.RLabel lblBackupInfo;
        private app_escritorio.UI.RLabel lblBackupSub;
        private System.Windows.Forms.Panel spacer2;
        private app_escritorio.UI.RPanel cardTax;
        private app_escritorio.UI.RLabel lblcardTaxTitle;
        private app_escritorio.UI.RButton btnSaveTax;
        private app_escritorio.UI.RComboBox cmbTax;
        private app_escritorio.UI.RLabel lblTaxSub;
        private System.Windows.Forms.Panel spacer1;
        private app_escritorio.UI.RPanel cardRestaurant;
        private app_escritorio.UI.RLabel lblcardRestaurantTitle;
        private app_escritorio.UI.RButton btnSaveRestaurant;
        private app_escritorio.UI.RButton btnBrowse;
        private app_escritorio.UI.RTextBox txtLogo;
        private app_escritorio.UI.RLabel lblLogo;
        private app_escritorio.UI.RTextBox txtCurrency;
        private app_escritorio.UI.RLabel lblCurrency;
        private app_escritorio.UI.RTextBox txtPhone;
        private app_escritorio.UI.RLabel lblPhone;
        private app_escritorio.UI.RTextBox txtAddress;
        private app_escritorio.UI.RLabel lblAddress;
        private app_escritorio.UI.RTextBox txtName;
        private app_escritorio.UI.RLabel lblName;
        private app_escritorio.UI.RLabel lblSubtitle;
        private app_escritorio.UI.RPanel header;
        private app_escritorio.UI.RBadge badgeAdmin;
        private app_escritorio.UI.RLabel lblTitle;
        private app_escritorio.Shell.ShellTopBar topBar;
        private app_escritorio.Shell.ShellSidebar sidebar;
    }
}
