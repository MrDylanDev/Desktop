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
            components = new System.ComponentModel.Container();
            root = new app_escritorio.UI.RPanel();
            layout = new TableLayoutPanel();
            header = new app_escritorio.UI.RPanel();
            pnlClock = new app_escritorio.UI.RPanel();
            lblClock = new app_escritorio.UI.RLabel();
            lblDemo = new app_escritorio.UI.RLabel();
            cmbStation = new app_escritorio.UI.RComboBox();
            pnlPending = new app_escritorio.UI.RPanel();
            lblPending = new app_escritorio.UI.RLabel();
            lblPendingDot = new app_escritorio.UI.RLabel();
            lblTitle = new app_escritorio.UI.RLabel();
            columns = new TableLayoutPanel();
            colNuevo = new app_escritorio.UI.RPanel();
            listNuevo = new app_escritorio.UI.RFlowPanel();
            sampleNuevo = new app_escritorio.Views.Kds.KdsOrderCard();
            headNuevo = new app_escritorio.UI.RPanel();
            badgeNuevo = new app_escritorio.UI.RBadge();
            lblNuevo = new app_escritorio.UI.RLabel();
            dotNuevo = new app_escritorio.UI.RLabel();
            colPrep = new app_escritorio.UI.RPanel();
            listPrep = new app_escritorio.UI.RFlowPanel();
            samplePrep = new app_escritorio.Views.Kds.KdsOrderCard();
            headPrep = new app_escritorio.UI.RPanel();
            badgePrep = new app_escritorio.UI.RBadge();
            lblPrep = new app_escritorio.UI.RLabel();
            dotPrep = new app_escritorio.UI.RLabel();
            colListo = new app_escritorio.UI.RPanel();
            listListo = new app_escritorio.UI.RFlowPanel();
            sampleListo = new app_escritorio.Views.Kds.KdsOrderCard();
            headListo = new app_escritorio.UI.RPanel();
            badgeListo = new app_escritorio.UI.RBadge();
            lblListo = new app_escritorio.UI.RLabel();
            dotListo = new app_escritorio.UI.RLabel();
            topBar = new app_escritorio.Shell.ShellTopBar();
            sidebar = new app_escritorio.Shell.ShellSidebar();
            clockTimer = new System.Windows.Forms.Timer(components);
            root.SuspendLayout();
            layout.SuspendLayout();
            header.SuspendLayout();
            pnlClock.SuspendLayout();
            pnlPending.SuspendLayout();
            columns.SuspendLayout();
            colNuevo.SuspendLayout();
            listNuevo.SuspendLayout();
            headNuevo.SuspendLayout();
            colPrep.SuspendLayout();
            listPrep.SuspendLayout();
            headPrep.SuspendLayout();
            colListo.SuspendLayout();
            listListo.SuspendLayout();
            headListo.SuspendLayout();
            SuspendLayout();
            // 
            // root
            // 
            root.Controls.Add(layout);
            root.Dock = DockStyle.Fill;
            root.Location = new Point(272, 64);
            root.Name = "root";
            root.Padding = new Padding(16);
            root.Size = new Size(1098, 685);
            root.Surface = UI.SurfaceLevel.Surface;
            root.TabIndex = 0;
            // 
            // layout
            // 
            layout.ColumnCount = 1;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.Controls.Add(header, 0, 0);
            layout.Controls.Add(columns, 0, 1);
            layout.Dock = DockStyle.Fill;
            layout.Location = new Point(16, 16);
            layout.Name = "layout";
            layout.RowCount = 2;
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.Size = new Size(1066, 653);
            layout.TabIndex = 0;
            // 
            // header
            // 
            header.Controls.Add(pnlClock);
            header.Controls.Add(lblDemo);
            header.Controls.Add(cmbStation);
            header.Controls.Add(pnlPending);
            header.Controls.Add(lblTitle);
            header.Dock = DockStyle.Fill;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(0, 0, 0, 4);
            header.Name = "header";
            header.Size = new Size(1066, 56);
            header.Surface = UI.SurfaceLevel.Transparent;
            header.TabIndex = 0;
            // 
            // pnlClock
            // 
            pnlClock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlClock.Controls.Add(lblClock);
            pnlClock.CornerRadius = 8;
            pnlClock.Location = new Point(850, 12);
            pnlClock.Name = "pnlClock";
            pnlClock.Size = new Size(96, 32);
            pnlClock.TabIndex = 4;
            // 
            // lblClock
            // 
            lblClock.Dock = DockStyle.Fill;
            lblClock.Location = new Point(0, 0);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(96, 32);
            lblClock.TabIndex = 0;
            lblClock.Text = "00:00:00";
            lblClock.TextAlign = ContentAlignment.MiddleCenter;
            lblClock.TextStyle = UI.TextStyle.Mono;
            // 
            // lblDemo
            // 
            lblDemo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDemo.Location = new Point(958, 12);
            lblDemo.Name = "lblDemo";
            lblDemo.Size = new Size(108, 32);
            lblDemo.TabIndex = 3;
            lblDemo.Text = "DEMO frontend";
            lblDemo.TextAlign = ContentAlignment.MiddleRight;
            lblDemo.TextStyle = UI.TextStyle.Overline;
            // 
            // cmbStation
            // 
            cmbStation.Items.AddRange(new object[] { "Todas las estaciones", "Parrilla", "Fría", "Barra" });
            cmbStation.Location = new Point(372, 12);
            cmbStation.Name = "cmbStation";
            cmbStation.Size = new Size(180, 32);
            cmbStation.TabIndex = 2;
            cmbStation.SelectedIndexChanged += CmbStation_SelectedIndexChanged;
            // 
            // pnlPending
            // 
            pnlPending.Controls.Add(lblPending);
            pnlPending.Controls.Add(lblPendingDot);
            pnlPending.CornerRadius = 8;
            pnlPending.Location = new Point(204, 12);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(150, 32);
            pnlPending.TabIndex = 1;
            // 
            // lblPending
            // 
            lblPending.Location = new Point(26, 0);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(108, 32);
            lblPending.TabIndex = 1;
            lblPending.Text = "0 pendientes";
            lblPending.TextAlign = ContentAlignment.MiddleLeft;
            lblPending.TextStyle = UI.TextStyle.Caption;
            // 
            // lblPendingDot
            // 
            lblPendingDot.Location = new Point(8, 0);
            lblPendingDot.Name = "lblPendingDot";
            lblPendingDot.Size = new Size(18, 32);
            lblPendingDot.TabIndex = 0;
            lblPendingDot.Text = "●";
            lblPendingDot.TextAlign = ContentAlignment.MiddleLeft;
            lblPendingDot.TextStyle = UI.TextStyle.Positive;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(0, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cocina KDS";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.TextStyle = UI.TextStyle.Hero;
            // 
            // columns
            // 
            columns.ColumnCount = 3;
            columns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            columns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            columns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            columns.Controls.Add(colNuevo, 0, 0);
            columns.Controls.Add(colPrep, 1, 0);
            columns.Controls.Add(colListo, 2, 0);
            columns.Dock = DockStyle.Fill;
            columns.Location = new Point(0, 60);
            columns.Margin = new Padding(0);
            columns.Name = "columns";
            columns.RowCount = 1;
            columns.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            columns.Size = new Size(1066, 593);
            columns.TabIndex = 1;
            // 
            // colNuevo
            // 
            colNuevo.Controls.Add(listNuevo);
            colNuevo.Controls.Add(headNuevo);
            colNuevo.CornerRadius = 14;
            colNuevo.Dock = DockStyle.Fill;
            colNuevo.Location = new Point(0, 0);
            colNuevo.Margin = new Padding(0, 0, 6, 0);
            colNuevo.Name = "colNuevo";
            colNuevo.Padding = new Padding(12);
            colNuevo.Size = new Size(349, 593);
            colNuevo.Surface = UI.SurfaceLevel.Lowest;
            colNuevo.TabIndex = 0;
            // 
            // listNuevo
            // 
            listNuevo.AutoScroll = true;
            listNuevo.Controls.Add(sampleNuevo);
            listNuevo.Dock = DockStyle.Fill;
            listNuevo.FlowDirection = FlowDirection.TopDown;
            listNuevo.Location = new Point(12, 48);
            listNuevo.Name = "listNuevo";
            listNuevo.Size = new Size(325, 533);
            listNuevo.Surface = UI.SurfaceLevel.Lowest;
            listNuevo.TabIndex = 1;
            listNuevo.WrapContents = false;
            listNuevo.Resize += List_Resize;
            // 
            // sampleNuevo
            // 
            sampleNuevo.BorderColor = Color.FromArgb(255, 185, 95);
            sampleNuevo.BorderWidth = 1;
            sampleNuevo.CornerRadius = 12;
            sampleNuevo.HoverSurface = UI.SurfaceLevel.Container;
            sampleNuevo.Location = new Point(0, 0);
            sampleNuevo.Margin = new Padding(0, 0, 0, 10);
            sampleNuevo.Mesa = "Mesa 2";
            sampleNuevo.Name = "sampleNuevo";
            sampleNuevo.Size = new Size(300, 122);
            sampleNuevo.Surface = UI.SurfaceLevel.Container;
            sampleNuevo.TabIndex = 0;
            // 
            // headNuevo
            // 
            headNuevo.Controls.Add(badgeNuevo);
            headNuevo.Controls.Add(lblNuevo);
            headNuevo.Controls.Add(dotNuevo);
            headNuevo.Dock = DockStyle.Top;
            headNuevo.Location = new Point(12, 12);
            headNuevo.Name = "headNuevo";
            headNuevo.Size = new Size(325, 36);
            headNuevo.Surface = UI.SurfaceLevel.Transparent;
            headNuevo.TabIndex = 0;
            // 
            // badgeNuevo
            // 
            badgeNuevo.CornerRadius = 10;
            badgeNuevo.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            badgeNuevo.Location = new Point(70, 6);
            badgeNuevo.Name = "badgeNuevo";
            badgeNuevo.Size = new Size(28, 22);
            badgeNuevo.TabIndex = 2;
            badgeNuevo.Text = "0";
            // 
            // lblNuevo
            // 
            lblNuevo.Location = new Point(20, 0);
            lblNuevo.Name = "lblNuevo";
            lblNuevo.Size = new Size(46, 34);
            lblNuevo.TabIndex = 1;
            lblNuevo.Text = "Nuevo";
            lblNuevo.TextAlign = ContentAlignment.MiddleLeft;
            lblNuevo.TextStyle = UI.TextStyle.BodyBold;
            // 
            // dotNuevo
            // 
            dotNuevo.ColorOverride = Color.FromArgb(255, 185, 95);
            dotNuevo.Location = new Point(0, 0);
            dotNuevo.Name = "dotNuevo";
            dotNuevo.Size = new Size(18, 34);
            dotNuevo.TabIndex = 0;
            dotNuevo.Text = "●";
            dotNuevo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // colPrep
            // 
            colPrep.Controls.Add(listPrep);
            colPrep.Controls.Add(headPrep);
            colPrep.CornerRadius = 14;
            colPrep.Dock = DockStyle.Fill;
            colPrep.Location = new Point(358, 0);
            colPrep.Margin = new Padding(3, 0, 3, 0);
            colPrep.Name = "colPrep";
            colPrep.Padding = new Padding(12);
            colPrep.Size = new Size(349, 593);
            colPrep.Surface = UI.SurfaceLevel.Lowest;
            colPrep.TabIndex = 1;
            // 
            // listPrep
            // 
            listPrep.AutoScroll = true;
            listPrep.Controls.Add(samplePrep);
            listPrep.Dock = DockStyle.Fill;
            listPrep.FlowDirection = FlowDirection.TopDown;
            listPrep.Location = new Point(12, 48);
            listPrep.Name = "listPrep";
            listPrep.Size = new Size(325, 533);
            listPrep.Surface = UI.SurfaceLevel.Lowest;
            listPrep.TabIndex = 1;
            listPrep.WrapContents = false;
            listPrep.Resize += List_Resize;
            // 
            // samplePrep
            // 
            samplePrep.BorderColor = Color.FromArgb(255, 181, 157);
            samplePrep.BorderWidth = 1;
            samplePrep.CornerRadius = 12;
            samplePrep.HoverSurface = UI.SurfaceLevel.Container;
            samplePrep.Location = new Point(0, 0);
            samplePrep.Margin = new Padding(0, 0, 0, 10);
            samplePrep.Mesa = "Mesa 3";
            samplePrep.Name = "samplePrep";
            samplePrep.Size = new Size(300, 122);
            samplePrep.Stage = Models.KdsStatus.Preparacion;
            samplePrep.Surface = UI.SurfaceLevel.Container;
            samplePrep.TabIndex = 0;
            // 
            // headPrep
            // 
            headPrep.Controls.Add(badgePrep);
            headPrep.Controls.Add(lblPrep);
            headPrep.Controls.Add(dotPrep);
            headPrep.Dock = DockStyle.Top;
            headPrep.Location = new Point(12, 12);
            headPrep.Name = "headPrep";
            headPrep.Size = new Size(325, 36);
            headPrep.Surface = UI.SurfaceLevel.Transparent;
            headPrep.TabIndex = 0;
            // 
            // badgePrep
            // 
            badgePrep.CornerRadius = 10;
            badgePrep.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            badgePrep.Location = new Point(128, 6);
            badgePrep.Name = "badgePrep";
            badgePrep.Size = new Size(28, 22);
            badgePrep.TabIndex = 2;
            badgePrep.Text = "0";
            // 
            // lblPrep
            // 
            lblPrep.Location = new Point(20, 0);
            lblPrep.Name = "lblPrep";
            lblPrep.Size = new Size(104, 34);
            lblPrep.TabIndex = 1;
            lblPrep.Text = "En preparación";
            lblPrep.TextAlign = ContentAlignment.MiddleLeft;
            lblPrep.TextStyle = UI.TextStyle.BodyBold;
            // 
            // dotPrep
            // 
            dotPrep.ColorOverride = Color.FromArgb(255, 181, 157);
            dotPrep.Location = new Point(0, 0);
            dotPrep.Name = "dotPrep";
            dotPrep.Size = new Size(18, 34);
            dotPrep.TabIndex = 0;
            dotPrep.Text = "●";
            dotPrep.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // colListo
            // 
            colListo.Controls.Add(listListo);
            colListo.Controls.Add(headListo);
            colListo.CornerRadius = 14;
            colListo.Dock = DockStyle.Fill;
            colListo.Location = new Point(716, 0);
            colListo.Margin = new Padding(6, 0, 0, 0);
            colListo.Name = "colListo";
            colListo.Padding = new Padding(12);
            colListo.Size = new Size(350, 593);
            colListo.Surface = UI.SurfaceLevel.Lowest;
            colListo.TabIndex = 2;
            // 
            // listListo
            // 
            listListo.AutoScroll = true;
            listListo.Controls.Add(sampleListo);
            listListo.Dock = DockStyle.Fill;
            listListo.FlowDirection = FlowDirection.TopDown;
            listListo.Location = new Point(12, 48);
            listListo.Name = "listListo";
            listListo.Size = new Size(326, 533);
            listListo.Surface = UI.SurfaceLevel.Lowest;
            listListo.TabIndex = 1;
            listListo.WrapContents = false;
            listListo.Resize += List_Resize;
            // 
            // sampleListo
            // 
            sampleListo.BorderColor = Color.FromArgb(78, 222, 163);
            sampleListo.BorderWidth = 1;
            sampleListo.CornerRadius = 12;
            sampleListo.HoverSurface = UI.SurfaceLevel.Container;
            sampleListo.Location = new Point(0, 0);
            sampleListo.Margin = new Padding(0, 0, 0, 10);
            sampleListo.Mesa = "Mesa 5";
            sampleListo.Name = "sampleListo";
            sampleListo.Size = new Size(300, 122);
            sampleListo.Stage = Models.KdsStatus.Listo;
            sampleListo.Surface = UI.SurfaceLevel.Container;
            sampleListo.TabIndex = 0;
            // 
            // headListo
            // 
            headListo.Controls.Add(badgeListo);
            headListo.Controls.Add(lblListo);
            headListo.Controls.Add(dotListo);
            headListo.Dock = DockStyle.Top;
            headListo.Location = new Point(12, 12);
            headListo.Name = "headListo";
            headListo.Size = new Size(326, 36);
            headListo.Surface = UI.SurfaceLevel.Transparent;
            headListo.TabIndex = 0;
            // 
            // badgeListo
            // 
            badgeListo.CornerRadius = 10;
            badgeListo.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            badgeListo.Location = new Point(62, 6);
            badgeListo.Name = "badgeListo";
            badgeListo.Size = new Size(28, 22);
            badgeListo.TabIndex = 2;
            badgeListo.Text = "0";
            // 
            // lblListo
            // 
            lblListo.Location = new Point(20, 0);
            lblListo.Name = "lblListo";
            lblListo.Size = new Size(38, 34);
            lblListo.TabIndex = 1;
            lblListo.Text = "Listo";
            lblListo.TextAlign = ContentAlignment.MiddleLeft;
            lblListo.TextStyle = UI.TextStyle.BodyBold;
            // 
            // dotListo
            // 
            dotListo.ColorOverride = Color.FromArgb(78, 222, 163);
            dotListo.Location = new Point(0, 0);
            dotListo.Name = "dotListo";
            dotListo.Size = new Size(18, 34);
            dotListo.TabIndex = 0;
            dotListo.Text = "●";
            dotListo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // topBar
            // 
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(272, 0);
            topBar.Name = "topBar";
            topBar.RoleText = "Administrador";
            topBar.RouteText = "Cocina KDS · DEMO";
            topBar.Size = new Size(1098, 64);
            topBar.TabIndex = 1;
            topBar.Load += topBar_Load;
            // 
            // sidebar
            // 
            sidebar.ActiveRoute = "kds";
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(272, 749);
            sidebar.TabIndex = 2;
            // 
            // clockTimer
            // 
            clockTimer.Interval = 1000;
            clockTimer.Tick += ClockTimer_Tick;
            // 
            // KdsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 20, 21);
            ClientSize = new Size(1370, 749);
            Controls.Add(root);
            Controls.Add(topBar);
            Controls.Add(sidebar);
            MinimumSize = new Size(1100, 700);
            Name = "KdsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RestoOS - Modular Core";
            root.ResumeLayout(false);
            layout.ResumeLayout(false);
            header.ResumeLayout(false);
            pnlClock.ResumeLayout(false);
            pnlPending.ResumeLayout(false);
            columns.ResumeLayout(false);
            colNuevo.ResumeLayout(false);
            listNuevo.ResumeLayout(false);
            headNuevo.ResumeLayout(false);
            colPrep.ResumeLayout(false);
            listPrep.ResumeLayout(false);
            headPrep.ResumeLayout(false);
            colListo.ResumeLayout(false);
            listListo.ResumeLayout(false);
            headListo.ResumeLayout(false);
            ResumeLayout(false);
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
