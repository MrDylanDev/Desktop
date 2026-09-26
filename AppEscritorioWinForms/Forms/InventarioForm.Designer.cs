namespace app_escritorio.Forms
{
    partial class InventarioForm
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
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.header = new app_escritorio.UI.RPanel();
            this.btnAdd = new app_escritorio.UI.RButton();
            this.lblDemo = new app_escritorio.UI.RLabel();
            this.pnlAlert = new app_escritorio.UI.RPanel();
            this.lblAlerts = new app_escritorio.UI.RLabel();
            this.lblAlertDot = new app_escritorio.UI.RLabel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.filters = new app_escritorio.UI.RPanel();
            this.swLowOnly = new app_escritorio.UI.RSwitch();
            this.cmbCategory = new app_escritorio.UI.RComboBox();
            this.txtSearch = new app_escritorio.UI.RTextBox();
            this.gridCard = new app_escritorio.UI.RPanel();
            this.grid = new app_escritorio.UI.RDataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAjustar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblFootnote = new app_escritorio.UI.RLabel();
            this.topBar = new app_escritorio.Shell.ShellTopBar();
            this.sidebar = new app_escritorio.Shell.ShellSidebar();
            this.root.SuspendLayout();
            this.layout.SuspendLayout();
            this.header.SuspendLayout();
            this.pnlAlert.SuspendLayout();
            this.filters.SuspendLayout();
            this.gridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.layout);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(272, 64);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(24);
            this.root.Size = new System.Drawing.Size(1100, 780);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // layout
            // 
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            this.layout.Controls.Add(this.header, 0, 0);
            this.layout.Controls.Add(this.filters, 0, 1);
            this.layout.Controls.Add(this.gridCard, 0, 2);
            this.layout.Controls.Add(this.lblFootnote, 0, 3);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(24, 24);
            this.layout.Name = "layout";
            this.layout.RowCount = 4;
            this.layout.Size = new System.Drawing.Size(1052, 732);
            this.layout.TabIndex = 0;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0F));
            // 
            // header
            // 
            this.header.Controls.Add(this.btnAdd);
            this.header.Controls.Add(this.lblDemo);
            this.header.Controls.Add(this.pnlAlert);
            this.header.Controls.Add(this.lblTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1052, 60);
            this.header.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.header.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnAdd.Location = new System.Drawing.Point(904, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+ Nuevo insumo";
            this.btnAdd.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblDemo
            // 
            this.lblDemo.Location = new System.Drawing.Point(420, 12);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(120, 32);
            this.lblDemo.TabIndex = 2;
            this.lblDemo.Text = "DEMO frontend";
            this.lblDemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDemo.TextStyle = app_escritorio.UI.TextStyle.Overline;
            // 
            // pnlAlert
            // 
            this.pnlAlert.Controls.Add(this.lblAlerts);
            this.pnlAlert.Controls.Add(this.lblAlertDot);
            this.pnlAlert.CornerRadius = 8;
            this.pnlAlert.Location = new System.Drawing.Point(196, 12);
            this.pnlAlert.Name = "pnlAlert";
            this.pnlAlert.Size = new System.Drawing.Size(206, 32);
            this.pnlAlert.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.pnlAlert.TabIndex = 1;
            // 
            // lblAlerts
            // 
            this.lblAlerts.Location = new System.Drawing.Point(26, 0);
            this.lblAlerts.Name = "lblAlerts";
            this.lblAlerts.Size = new System.Drawing.Size(170, 32);
            this.lblAlerts.TabIndex = 1;
            this.lblAlerts.Text = "3 alertas stock bajo";
            this.lblAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlerts.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblAlertDot
            // 
            this.lblAlertDot.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.lblAlertDot.Location = new System.Drawing.Point(8, 0);
            this.lblAlertDot.Name = "lblAlertDot";
            this.lblAlertDot.Size = new System.Drawing.Size(18, 32);
            this.lblAlertDot.TabIndex = 0;
            this.lblAlertDot.Text = "●";
            this.lblAlertDot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlertDot.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inventario";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Hero;
            // 
            // filters
            // 
            this.filters.Controls.Add(this.swLowOnly);
            this.filters.Controls.Add(this.cmbCategory);
            this.filters.Controls.Add(this.txtSearch);
            this.filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filters.Location = new System.Drawing.Point(0, 60);
            this.filters.Margin = new System.Windows.Forms.Padding(0);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(1052, 56);
            this.filters.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.filters.TabIndex = 1;
            // 
            // swLowOnly
            // 
            this.swLowOnly.Location = new System.Drawing.Point(512, 12);
            this.swLowOnly.Name = "swLowOnly";
            this.swLowOnly.Size = new System.Drawing.Size(200, 32);
            this.swLowOnly.TabIndex = 2;
            this.swLowOnly.Text = "Solo stock bajo";
            this.swLowOnly.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Items.AddRange(new object[] {
            "Todas",
            "Carnes",
            "Verduras",
            "Lácteos",
            "Bebidas",
            "Secos"});
            this.cmbCategory.Location = new System.Drawing.Point(316, 12);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 32);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Buscar insumo...";
            this.txtSearch.Size = new System.Drawing.Size(300, 40);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // gridCard
            // 
            this.gridCard.Controls.Add(this.grid);
            this.gridCard.CornerRadius = 14;
            this.gridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCard.Location = new System.Drawing.Point(0, 116);
            this.gridCard.Margin = new System.Windows.Forms.Padding(0);
            this.gridCard.Name = "gridCard";
            this.gridCard.Padding = new System.Windows.Forms.Padding(8);
            this.gridCard.Size = new System.Drawing.Size(1052, 516);
            this.gridCard.Surface = app_escritorio.UI.SurfaceLevel.Lowest;
            this.gridCard.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCategory,
            this.colStock,
            this.colMin,
            this.colEstado,
            this.colCost,
            this.colAjustar,
            this.colDelete});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(8, 8);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1036, 500);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // colName
            // 
            this.colName.FillWeight = 180F;
            this.colName.HeaderText = "Insumo";
            this.colName.Name = "colName";
            // 
            // colCategory
            // 
            this.colCategory.FillWeight = 100F;
            this.colCategory.HeaderText = "Categoría";
            this.colCategory.Name = "colCategory";
            // 
            // colStock
            // 
            this.colStock.FillWeight = 90F;
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            // 
            // colMin
            // 
            this.colMin.FillWeight = 90F;
            this.colMin.HeaderText = "Mínimo";
            this.colMin.Name = "colMin";
            // 
            // colEstado
            // 
            this.colEstado.FillWeight = 80F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Tag = "chip";
            // 
            // colCost
            // 
            this.colCost.FillWeight = 90F;
            this.colCost.HeaderText = "Costo";
            this.colCost.Name = "colCost";
            // 
            // colAjustar
            // 
            this.colAjustar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAjustar.HeaderText = "";
            this.colAjustar.Name = "colAjustar";
            this.colAjustar.Tag = "";
            this.colAjustar.Text = "Ajustar";
            this.colAjustar.UseColumnTextForButtonValue = true;
            this.colAjustar.Width = 90;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.Tag = "danger";
            this.colDelete.Text = "×";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 50;
            // 
            // lblFootnote
            // 
            this.lblFootnote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFootnote.Location = new System.Drawing.Point(0, 0);
            this.lblFootnote.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblFootnote.Name = "lblFootnote";
            this.lblFootnote.Size = new System.Drawing.Size(1052, 40);
            this.lblFootnote.TabIndex = 3;
            this.lblFootnote.Text = "* Descuento automático por venta y alertas de stock bajo son simulados en esta demo. La lógica real (descuento al cobrar en POS) queda para Fase 2 con SQLite.";
            this.lblFootnote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFootnote.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(272, 0);
            this.topBar.Name = "topBar";
            this.topBar.RoleText = "Administrador";
            this.topBar.RouteText = "Inventario · DEMO";
            this.topBar.Size = new System.Drawing.Size(1100, 64);
            this.topBar.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.ActiveRoute = "inventario";
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(272, 844);
            this.sidebar.TabIndex = 2;
            // 
            // InventarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1372, 844);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "InventarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestoOS - Modular Core";
            this.Controls.Add(this.root);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sidebar);
            this.gridCard.ResumeLayout(false);
            this.filters.ResumeLayout(false);
            this.pnlAlert.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.root.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private System.Windows.Forms.TableLayoutPanel layout;
        private app_escritorio.UI.RPanel header;
        private app_escritorio.UI.RButton btnAdd;
        private app_escritorio.UI.RLabel lblDemo;
        private app_escritorio.UI.RPanel pnlAlert;
        private app_escritorio.UI.RLabel lblAlerts;
        private app_escritorio.UI.RLabel lblAlertDot;
        private app_escritorio.UI.RLabel lblTitle;
        private app_escritorio.UI.RPanel filters;
        private app_escritorio.UI.RSwitch swLowOnly;
        private app_escritorio.UI.RComboBox cmbCategory;
        private app_escritorio.UI.RTextBox txtSearch;
        private app_escritorio.UI.RPanel gridCard;
        private app_escritorio.UI.RDataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewButtonColumn colAjustar;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private app_escritorio.UI.RLabel lblFootnote;
        private app_escritorio.Shell.ShellTopBar topBar;
        private app_escritorio.Shell.ShellSidebar sidebar;
    }
}
