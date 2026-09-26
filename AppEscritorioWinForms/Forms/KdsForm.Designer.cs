namespace app_escritorio.Forms
{
    partial class KdsForm
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
            this.components = new System.ComponentModel.Container();
            this.root = new app_escritorio.UI.RPanel();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.header = new app_escritorio.UI.RPanel();
            this.pnlClock = new app_escritorio.UI.RPanel();
            this.lblClock = new app_escritorio.UI.RLabel();
            this.lblDemo = new app_escritorio.UI.RLabel();
            this.cmbStation = new app_escritorio.UI.RComboBox();
            this.pnlPending = new app_escritorio.UI.RPanel();
            this.lblPending = new app_escritorio.UI.RLabel();
            this.lblPendingDot = new app_escritorio.UI.RLabel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.columns = new System.Windows.Forms.TableLayoutPanel();
            this.colNuevo = new app_escritorio.UI.RPanel();
            this.listNuevo = new app_escritorio.UI.RFlowPanel();
            this.sampleNuevo = new app_escritorio.Views.Kds.KdsOrderCard();
            this.headNuevo = new app_escritorio.UI.RPanel();
            this.badgeNuevo = new app_escritorio.UI.RBadge();
            this.lblNuevo = new app_escritorio.UI.RLabel();
            this.dotNuevo = new app_escritorio.UI.RLabel();
            this.colPrep = new app_escritorio.UI.RPanel();
            this.listPrep = new app_escritorio.UI.RFlowPanel();
            this.samplePrep = new app_escritorio.Views.Kds.KdsOrderCard();
            this.headPrep = new app_escritorio.UI.RPanel();
            this.badgePrep = new app_escritorio.UI.RBadge();
            this.lblPrep = new app_escritorio.UI.RLabel();
            this.dotPrep = new app_escritorio.UI.RLabel();
            this.colListo = new app_escritorio.UI.RPanel();
            this.listListo = new app_escritorio.UI.RFlowPanel();
            this.sampleListo = new app_escritorio.Views.Kds.KdsOrderCard();
            this.headListo = new app_escritorio.UI.RPanel();
            this.badgeListo = new app_escritorio.UI.RBadge();
            this.lblListo = new app_escritorio.UI.RLabel();
            this.dotListo = new app_escritorio.UI.RLabel();
            this.topBar = new app_escritorio.Shell.ShellTopBar();
            this.sidebar = new app_escritorio.Shell.ShellSidebar();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.layout.SuspendLayout();
            this.header.SuspendLayout();
            this.pnlClock.SuspendLayout();
            this.pnlPending.SuspendLayout();
            this.columns.SuspendLayout();
            this.colNuevo.SuspendLayout();
            this.listNuevo.SuspendLayout();
            this.headNuevo.SuspendLayout();
            this.colPrep.SuspendLayout();
            this.listPrep.SuspendLayout();
            this.headPrep.SuspendLayout();
            this.colListo.SuspendLayout();
            this.listListo.SuspendLayout();
            this.headListo.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.layout);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(272, 64);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(16);
            this.root.Size = new System.Drawing.Size(1100, 780);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // layout
            // 
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            this.layout.Controls.Add(this.header, 0, 0);
            this.layout.Controls.Add(this.columns, 0, 1);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(16, 16);
            this.layout.Name = "layout";
            this.layout.RowCount = 2;
            this.layout.Size = new System.Drawing.Size(1068, 748);
            this.layout.TabIndex = 0;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            // 
            // header
            // 
            this.header.Controls.Add(this.pnlClock);
            this.header.Controls.Add(this.lblDemo);
            this.header.Controls.Add(this.cmbStation);
            this.header.Controls.Add(this.pnlPending);
            this.header.Controls.Add(this.lblTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1068, 56);
            this.header.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.header.TabIndex = 0;
            // 
            // pnlClock
            // 
            this.pnlClock.Controls.Add(this.lblClock);
            this.pnlClock.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.pnlClock.CornerRadius = 8;
            this.pnlClock.Location = new System.Drawing.Point(852, 12);
            this.pnlClock.Name = "pnlClock";
            this.pnlClock.Size = new System.Drawing.Size(96, 32);
            this.pnlClock.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.pnlClock.TabIndex = 4;
            // 
            // lblClock
            // 
            this.lblClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClock.Location = new System.Drawing.Point(0, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(96, 32);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClock.TextStyle = app_escritorio.UI.TextStyle.Mono;
            // 
            // lblDemo
            // 
            this.lblDemo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblDemo.Location = new System.Drawing.Point(960, 12);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(108, 32);
            this.lblDemo.TabIndex = 3;
            this.lblDemo.Text = "DEMO frontend";
            this.lblDemo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDemo.TextStyle = app_escritorio.UI.TextStyle.Overline;
            // 
            // cmbStation
            // 
            this.cmbStation.Items.AddRange(new object[] {
            "Todas las estaciones",
            "Parrilla",
            "Fría",
            "Barra"});
            this.cmbStation.Location = new System.Drawing.Point(372, 12);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(180, 32);
            this.cmbStation.TabIndex = 2;
            this.cmbStation.SelectedIndexChanged += new System.EventHandler(this.CmbStation_SelectedIndexChanged);
            // 
            // pnlPending
            // 
            this.pnlPending.Controls.Add(this.lblPending);
            this.pnlPending.Controls.Add(this.lblPendingDot);
            this.pnlPending.CornerRadius = 8;
            this.pnlPending.Location = new System.Drawing.Point(204, 12);
            this.pnlPending.Name = "pnlPending";
            this.pnlPending.Size = new System.Drawing.Size(150, 32);
            this.pnlPending.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.pnlPending.TabIndex = 1;
            // 
            // lblPending
            // 
            this.lblPending.Location = new System.Drawing.Point(26, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(108, 32);
            this.lblPending.TabIndex = 1;
            this.lblPending.Text = "0 pendientes";
            this.lblPending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPending.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblPendingDot
            // 
            this.lblPendingDot.Location = new System.Drawing.Point(8, 0);
            this.lblPendingDot.Name = "lblPendingDot";
            this.lblPendingDot.Size = new System.Drawing.Size(18, 32);
            this.lblPendingDot.TabIndex = 0;
            this.lblPendingDot.Text = "●";
            this.lblPendingDot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPendingDot.TextStyle = app_escritorio.UI.TextStyle.Positive;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cocina KDS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Hero;
            // 
            // columns
            // 
            this.columns.ColumnCount = 3;
            this.columns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.columns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.columns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.columns.Controls.Add(this.colNuevo, 0, 0);
            this.columns.Controls.Add(this.colPrep, 1, 0);
            this.columns.Controls.Add(this.colListo, 2, 0);
            this.columns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.columns.Location = new System.Drawing.Point(0, 60);
            this.columns.Margin = new System.Windows.Forms.Padding(0);
            this.columns.Name = "columns";
            this.columns.RowCount = 1;
            this.columns.Size = new System.Drawing.Size(1068, 688);
            this.columns.TabIndex = 1;
            this.columns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            // 
            // colNuevo
            // 
            this.colNuevo.Controls.Add(this.listNuevo);
            this.colNuevo.Controls.Add(this.headNuevo);
            this.colNuevo.CornerRadius = 14;
            this.colNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colNuevo.Location = new System.Drawing.Point(0, 0);
            this.colNuevo.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.colNuevo.Name = "colNuevo";
            this.colNuevo.Padding = new System.Windows.Forms.Padding(12);
            this.colNuevo.Size = new System.Drawing.Size(344, 700);
            this.colNuevo.Surface = app_escritorio.UI.SurfaceLevel.Lowest;
            this.colNuevo.TabIndex = 0;
            // 
            // listNuevo
            // 
            this.listNuevo.Controls.Add(this.sampleNuevo);
            this.listNuevo.AutoScroll = true;
            this.listNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listNuevo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listNuevo.Location = new System.Drawing.Point(12, 48);
            this.listNuevo.Name = "listNuevo";
            this.listNuevo.Size = new System.Drawing.Size(320, 640);
            this.listNuevo.Surface = app_escritorio.UI.SurfaceLevel.Lowest;
            this.listNuevo.TabIndex = 1;
            this.listNuevo.WrapContents = false;
            this.listNuevo.Resize += new System.EventHandler(this.List_Resize);
            // 
            // sampleNuevo
            // 
            this.sampleNuevo.Location = new System.Drawing.Point(0, 0);
            this.sampleNuevo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.sampleNuevo.Mesa = "Mesa 2";
            this.sampleNuevo.Name = "sampleNuevo";
            this.sampleNuevo.Size = new System.Drawing.Size(300, 178);
            this.sampleNuevo.Stage = app_escritorio.Models.KdsStatus.Nuevo;
            this.sampleNuevo.TabIndex = 0;
            // 
            // headNuevo
            // 
            this.headNuevo.Controls.Add(this.badgeNuevo);
            this.headNuevo.Controls.Add(this.lblNuevo);
            this.headNuevo.Controls.Add(this.dotNuevo);
            this.headNuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.headNuevo.Location = new System.Drawing.Point(12, 12);
            this.headNuevo.Name = "headNuevo";
            this.headNuevo.Size = new System.Drawing.Size(320, 36);
            this.headNuevo.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.headNuevo.TabIndex = 0;
            // 
            // badgeNuevo
            // 
            this.badgeNuevo.CornerRadius = 10;
            this.badgeNuevo.Kind = app_escritorio.UI.BadgeKind.Neutral;
            this.badgeNuevo.Location = new System.Drawing.Point(70, 6);
            this.badgeNuevo.Name = "badgeNuevo";
            this.badgeNuevo.Size = new System.Drawing.Size(28, 22);
            this.badgeNuevo.TabIndex = 2;
            this.badgeNuevo.Text = "0";
            // 
            // lblNuevo
            // 
            this.lblNuevo.Location = new System.Drawing.Point(20, 0);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(46, 34);
            this.lblNuevo.TabIndex = 1;
            this.lblNuevo.Text = "Nuevo";
            this.lblNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNuevo.TextStyle = app_escritorio.UI.TextStyle.BodyBold;
            // 
            // dotNuevo
            // 
            this.dotNuevo.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(95)))));
            this.dotNuevo.Location = new System.Drawing.Point(0, 0);
            this.dotNuevo.Name = "dotNuevo";
            this.dotNuevo.Size = new System.Drawing.Size(18, 34);
            this.dotNuevo.TabIndex = 0;
            this.dotNuevo.Text = "●";
            this.dotNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dotNuevo.TextStyle = app_escritorio.UI.TextStyle.Body;
            // 
            // colPrep
            // 
            this.colPrep.Controls.Add(this.listPrep);
            this.colPrep.Controls.Add(this.headPrep);
            this.colPrep.CornerRadius = 14;
            this.colPrep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colPrep.Location = new System.Drawing.Point(0, 0);
            this.colPrep.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.colPrep.Name = "colPrep";
            this.colPrep.Padding = new System.Windows.Forms.Padding(12);
            this.colPrep.Size = new System.Drawing.Size(344, 700);
            this.colPrep.Surface = app_escritorio.UI.SurfaceLevel.Lowest;
            this.colPrep.TabIndex = 1;
            // 
            // listPrep
            // 
            this.listPrep.Controls.Add(this.samplePrep);
            this.listPrep.AutoScroll = true;
            this.listPrep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPrep.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listPrep.Location = new System.Drawing.Point(12, 48);
            this.listPrep.Name = "listPrep";
            this.listPrep.Size = new System.Drawing.Size(320, 640);
            this.listPrep.Surface = app_escritorio.UI.SurfaceLevel.Lowest;
            this.listPrep.TabIndex = 1;
            this.listPrep.WrapContents = false;
            this.listPrep.Resize += new System.EventHandler(this.List_Resize);
            // 
            // samplePrep
            // 
            this.samplePrep.Location = new System.Drawing.Point(0, 0);
            this.samplePrep.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.samplePrep.Mesa = "Mesa 3";
            this.samplePrep.Name = "samplePrep";
            this.samplePrep.Size = new System.Drawing.Size(300, 178);
            this.samplePrep.Stage = app_escritorio.Models.KdsStatus.Preparacion;
            this.samplePrep.TabIndex = 0;
            // 
            // headPrep
            // 
            this.headPrep.Controls.Add(this.badgePrep);
            this.headPrep.Controls.Add(this.lblPrep);
            this.headPrep.Controls.Add(this.dotPrep);
            this.headPrep.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPrep.Location = new System.Drawing.Point(12, 12);
            this.headPrep.Name = "headPrep";
            this.headPrep.Size = new System.Drawing.Size(320, 36);
            this.headPrep.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.headPrep.TabIndex = 0;
            // 
            // badgePrep
            // 
            this.badgePrep.CornerRadius = 10;
            this.badgePrep.Kind = app_escritorio.UI.BadgeKind.Neutral;
            this.badgePrep.Location = new System.Drawing.Point(128, 6);
            this.badgePrep.Name = "badgePrep";
            this.badgePrep.Size = new System.Drawing.Size(28, 22);
            this.badgePrep.TabIndex = 2;
            this.badgePrep.Text = "0";
            // 
            // lblPrep
            // 
            this.lblPrep.Location = new System.Drawing.Point(20, 0);
            this.lblPrep.Name = "lblPrep";
            this.lblPrep.Size = new System.Drawing.Size(104, 34);
            this.lblPrep.TabIndex = 1;
            this.lblPrep.Text = "En preparación";
            this.lblPrep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrep.TextStyle = app_escritorio.UI.TextStyle.BodyBold;
            // 
            // dotPrep
            // 
            this.dotPrep.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.dotPrep.Location = new System.Drawing.Point(0, 0);
            this.dotPrep.Name = "dotPrep";
            this.dotPrep.Size = new System.Drawing.Size(18, 34);
            this.dotPrep.TabIndex = 0;
            this.dotPrep.Text = "●";
            this.dotPrep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dotPrep.TextStyle = app_escritorio.UI.TextStyle.Body;
            // 
            // colListo
            // 
            this.colListo.Controls.Add(this.listListo);
            this.colListo.Controls.Add(this.headListo);
            this.colListo.CornerRadius = 14;
            this.colListo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colListo.Location = new System.Drawing.Point(0, 0);
            this.colListo.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.colListo.Name = "colListo";
            this.colListo.Padding = new System.Windows.Forms.Padding(12);
            this.colListo.Size = new System.Drawing.Size(344, 700);
            this.colListo.Surface = app_escritorio.UI.SurfaceLevel.Lowest;
            this.colListo.TabIndex = 2;
            // 
            // listListo
            // 
            this.listListo.Controls.Add(this.sampleListo);
            this.listListo.AutoScroll = true;
            this.listListo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listListo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listListo.Location = new System.Drawing.Point(12, 48);
            this.listListo.Name = "listListo";
            this.listListo.Size = new System.Drawing.Size(320, 640);
            this.listListo.Surface = app_escritorio.UI.SurfaceLevel.Lowest;
            this.listListo.TabIndex = 1;
            this.listListo.WrapContents = false;
            this.listListo.Resize += new System.EventHandler(this.List_Resize);
            // 
            // sampleListo
            // 
            this.sampleListo.Location = new System.Drawing.Point(0, 0);
            this.sampleListo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.sampleListo.Mesa = "Mesa 5";
            this.sampleListo.Name = "sampleListo";
            this.sampleListo.Size = new System.Drawing.Size(300, 178);
            this.sampleListo.Stage = app_escritorio.Models.KdsStatus.Listo;
            this.sampleListo.TabIndex = 0;
            // 
            // headListo
            // 
            this.headListo.Controls.Add(this.badgeListo);
            this.headListo.Controls.Add(this.lblListo);
            this.headListo.Controls.Add(this.dotListo);
            this.headListo.Dock = System.Windows.Forms.DockStyle.Top;
            this.headListo.Location = new System.Drawing.Point(12, 12);
            this.headListo.Name = "headListo";
            this.headListo.Size = new System.Drawing.Size(320, 36);
            this.headListo.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.headListo.TabIndex = 0;
            // 
            // badgeListo
            // 
            this.badgeListo.CornerRadius = 10;
            this.badgeListo.Kind = app_escritorio.UI.BadgeKind.Neutral;
            this.badgeListo.Location = new System.Drawing.Point(62, 6);
            this.badgeListo.Name = "badgeListo";
            this.badgeListo.Size = new System.Drawing.Size(28, 22);
            this.badgeListo.TabIndex = 2;
            this.badgeListo.Text = "0";
            // 
            // lblListo
            // 
            this.lblListo.Location = new System.Drawing.Point(20, 0);
            this.lblListo.Name = "lblListo";
            this.lblListo.Size = new System.Drawing.Size(38, 34);
            this.lblListo.TabIndex = 1;
            this.lblListo.Text = "Listo";
            this.lblListo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListo.TextStyle = app_escritorio.UI.TextStyle.BodyBold;
            // 
            // dotListo
            // 
            this.dotListo.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(222)))), ((int)(((byte)(163)))));
            this.dotListo.Location = new System.Drawing.Point(0, 0);
            this.dotListo.Name = "dotListo";
            this.dotListo.Size = new System.Drawing.Size(18, 34);
            this.dotListo.TabIndex = 0;
            this.dotListo.Text = "●";
            this.dotListo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dotListo.TextStyle = app_escritorio.UI.TextStyle.Body;
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(272, 0);
            this.topBar.Name = "topBar";
            this.topBar.RoleText = "Administrador";
            this.topBar.RouteText = "Cocina KDS · DEMO";
            this.topBar.Size = new System.Drawing.Size(1100, 64);
            this.topBar.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.ActiveRoute = "kds";
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(272, 844);
            this.sidebar.TabIndex = 2;
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // KdsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1372, 844);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "KdsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestoOS - Modular Core";
            this.Controls.Add(this.root);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sidebar);
            this.headListo.ResumeLayout(false);
            this.listListo.ResumeLayout(false);
            this.colListo.ResumeLayout(false);
            this.headPrep.ResumeLayout(false);
            this.listPrep.ResumeLayout(false);
            this.colPrep.ResumeLayout(false);
            this.headNuevo.ResumeLayout(false);
            this.listNuevo.ResumeLayout(false);
            this.colNuevo.ResumeLayout(false);
            this.columns.ResumeLayout(false);
            this.columns.PerformLayout();
            this.pnlPending.ResumeLayout(false);
            this.pnlClock.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.root.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private System.Windows.Forms.TableLayoutPanel layout;
        private app_escritorio.UI.RPanel header;
        private app_escritorio.UI.RPanel pnlClock;
        private app_escritorio.UI.RLabel lblClock;
        private app_escritorio.UI.RLabel lblDemo;
        private app_escritorio.UI.RComboBox cmbStation;
        private app_escritorio.UI.RPanel pnlPending;
        private app_escritorio.UI.RLabel lblPending;
        private app_escritorio.UI.RLabel lblPendingDot;
        private app_escritorio.UI.RLabel lblTitle;
        private System.Windows.Forms.TableLayoutPanel columns;
        private app_escritorio.UI.RPanel colNuevo;
        private app_escritorio.UI.RFlowPanel listNuevo;
        private app_escritorio.Views.Kds.KdsOrderCard sampleNuevo;
        private app_escritorio.UI.RPanel headNuevo;
        private app_escritorio.UI.RBadge badgeNuevo;
        private app_escritorio.UI.RLabel lblNuevo;
        private app_escritorio.UI.RLabel dotNuevo;
        private app_escritorio.UI.RPanel colPrep;
        private app_escritorio.UI.RFlowPanel listPrep;
        private app_escritorio.Views.Kds.KdsOrderCard samplePrep;
        private app_escritorio.UI.RPanel headPrep;
        private app_escritorio.UI.RBadge badgePrep;
        private app_escritorio.UI.RLabel lblPrep;
        private app_escritorio.UI.RLabel dotPrep;
        private app_escritorio.UI.RPanel colListo;
        private app_escritorio.UI.RFlowPanel listListo;
        private app_escritorio.Views.Kds.KdsOrderCard sampleListo;
        private app_escritorio.UI.RPanel headListo;
        private app_escritorio.UI.RBadge badgeListo;
        private app_escritorio.UI.RLabel lblListo;
        private app_escritorio.UI.RLabel dotListo;
        private app_escritorio.Shell.ShellTopBar topBar;
        private app_escritorio.Shell.ShellSidebar sidebar;
        private System.Windows.Forms.Timer clockTimer;
    }
}
