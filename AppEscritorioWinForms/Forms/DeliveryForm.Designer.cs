namespace app_escritorio.Forms
{
    partial class DeliveryForm
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
            this.btnNew = new app_escritorio.UI.RButton();
            this.btnSync = new app_escritorio.UI.RButton();
            this.lblDemo = new app_escritorio.UI.RLabel();
            this.pnlAggregator = new app_escritorio.UI.RPanel();
            this.lblAggregator = new app_escritorio.UI.RLabel();
            this.lblAggregatorDot = new app_escritorio.UI.RLabel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.filters = new app_escritorio.UI.RPanel();
            this.cmbEstado = new app_escritorio.UI.RComboBox();
            this.cmbPlataforma = new app_escritorio.UI.RComboBox();
            this.txtSearch = new app_escritorio.UI.RTextBox();
            this.gridCard = new app_escritorio.UI.RPanel();
            this.grid = new app_escritorio.UI.RDataGridView();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colAvanzar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblFootnote = new app_escritorio.UI.RLabel();
            this.topBar = new app_escritorio.Shell.ShellTopBar();
            this.sidebar = new app_escritorio.Shell.ShellSidebar();
            this.root.SuspendLayout();
            this.layout.SuspendLayout();
            this.header.SuspendLayout();
            this.pnlAggregator.SuspendLayout();
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
            this.header.Controls.Add(this.btnNew);
            this.header.Controls.Add(this.btnSync);
            this.header.Controls.Add(this.lblDemo);
            this.header.Controls.Add(this.pnlAggregator);
            this.header.Controls.Add(this.lblTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1052, 60);
            this.header.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.header.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnNew.Location = new System.Drawing.Point(916, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(136, 38);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "+ Nuevo pedido";
            this.btnNew.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnSync
            // 
            this.btnSync.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnSync.Location = new System.Drawing.Point(724, 10);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(180, 38);
            this.btnSync.TabIndex = 3;
            this.btnSync.Text = "↻  Sincronizar menú";
            this.btnSync.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnSync.Click += new System.EventHandler(this.BtnSync_Click);
            // 
            // lblDemo
            // 
            this.lblDemo.Location = new System.Drawing.Point(446, 12);
            this.lblDemo.Name = "lblDemo";
            this.lblDemo.Size = new System.Drawing.Size(120, 32);
            this.lblDemo.TabIndex = 2;
            this.lblDemo.Text = "DEMO frontend";
            this.lblDemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDemo.TextStyle = app_escritorio.UI.TextStyle.Overline;
            // 
            // pnlAggregator
            // 
            this.pnlAggregator.Controls.Add(this.lblAggregator);
            this.pnlAggregator.Controls.Add(this.lblAggregatorDot);
            this.pnlAggregator.CornerRadius = 8;
            this.pnlAggregator.Location = new System.Drawing.Point(176, 12);
            this.pnlAggregator.Name = "pnlAggregator";
            this.pnlAggregator.Size = new System.Drawing.Size(256, 32);
            this.pnlAggregator.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.pnlAggregator.TabIndex = 1;
            // 
            // lblAggregator
            // 
            this.lblAggregator.Location = new System.Drawing.Point(26, 0);
            this.lblAggregator.Name = "lblAggregator";
            this.lblAggregator.Size = new System.Drawing.Size(220, 32);
            this.lblAggregator.TabIndex = 1;
            this.lblAggregator.Text = "Agregador conectado (DEMO)";
            this.lblAggregator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAggregator.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblAggregatorDot
            // 
            this.lblAggregatorDot.Location = new System.Drawing.Point(8, 0);
            this.lblAggregatorDot.Name = "lblAggregatorDot";
            this.lblAggregatorDot.Size = new System.Drawing.Size(18, 32);
            this.lblAggregatorDot.TabIndex = 0;
            this.lblAggregatorDot.Text = "●";
            this.lblAggregatorDot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAggregatorDot.TextStyle = app_escritorio.UI.TextStyle.Positive;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Delivery";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Hero;
            // 
            // filters
            // 
            this.filters.Controls.Add(this.cmbEstado);
            this.filters.Controls.Add(this.cmbPlataforma);
            this.filters.Controls.Add(this.txtSearch);
            this.filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filters.Location = new System.Drawing.Point(0, 60);
            this.filters.Margin = new System.Windows.Forms.Padding(0);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(1052, 56);
            this.filters.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.filters.TabIndex = 1;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Items.AddRange(new object[] {
            "Todos",
            "Nuevo",
            "En preparación",
            "Listo para rider",
            "Entregado"});
            this.cmbEstado.Location = new System.Drawing.Point(502, 12);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(190, 32);
            this.cmbEstado.TabIndex = 2;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // cmbPlataforma
            // 
            this.cmbPlataforma.Items.AddRange(new object[] {
            "Todas",
            "Rappi",
            "Uber Eats",
            "DiDi Food"});
            this.cmbPlataforma.Location = new System.Drawing.Point(316, 12);
            this.cmbPlataforma.Name = "cmbPlataforma";
            this.cmbPlataforma.Size = new System.Drawing.Size(170, 32);
            this.cmbPlataforma.TabIndex = 1;
            this.cmbPlataforma.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Buscar pedido, cliente...";
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
            this.colHora,
            this.colPlataforma,
            this.colId,
            this.colCliente,
            this.colDetalle,
            this.colTotal,
            this.colEstado,
            this.colEditar,
            this.colDelete,
            this.colAvanzar});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(8, 8);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1036, 500);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // colHora
            // 
            this.colHora.FillWeight = 55F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            // 
            // colPlataforma
            // 
            this.colPlataforma.FillWeight = 95F;
            this.colPlataforma.HeaderText = "Plataforma";
            this.colPlataforma.Name = "colPlataforma";
            this.colPlataforma.Tag = "chip";
            // 
            // colId
            // 
            this.colId.FillWeight = 75F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            // 
            // colCliente
            // 
            this.colCliente.FillWeight = 110F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colDetalle
            // 
            this.colDetalle.FillWeight = 230F;
            this.colDetalle.HeaderText = "Detalle";
            this.colDetalle.Name = "colDetalle";
            // 
            // colTotal
            // 
            this.colTotal.FillWeight = 80F;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // colEstado
            // 
            this.colEstado.FillWeight = 115F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Tag = "chip";
            // 
            // colEditar
            // 
            this.colEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEditar.HeaderText = "";
            this.colEditar.Name = "colEditar";
            this.colEditar.Tag = "";
            this.colEditar.Text = "Editar";
            this.colEditar.UseColumnTextForButtonValue = true;
            this.colEditar.Width = 76;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.Tag = "danger";
            this.colDelete.Text = "×";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 46;
            // 
            // colAvanzar
            // 
            this.colAvanzar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAvanzar.HeaderText = "";
            this.colAvanzar.Name = "colAvanzar";
            this.colAvanzar.Tag = "primary";
            this.colAvanzar.Width = 124;
            // 
            // lblFootnote
            // 
            this.lblFootnote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFootnote.Location = new System.Drawing.Point(0, 0);
            this.lblFootnote.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblFootnote.Name = "lblFootnote";
            this.lblFootnote.Size = new System.Drawing.Size(1052, 40);
            this.lblFootnote.TabIndex = 3;
            this.lblFootnote.Text = "* Integración vía agregador/middleware simulada: Rappi/Uber Eats/DiDi Food llegan a la misma cola que salón. Sincronizar empuja precio/disponibilidad de Menú a plataformas.";
            this.lblFootnote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFootnote.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(272, 0);
            this.topBar.Name = "topBar";
            this.topBar.RoleText = "Administrador";
            this.topBar.RouteText = "Delivery · DEMO";
            this.topBar.Size = new System.Drawing.Size(1100, 64);
            this.topBar.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.ActiveRoute = "delivery";
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(272, 844);
            this.sidebar.TabIndex = 2;
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1372, 844);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "DeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestoOS - Modular Core";
            this.Controls.Add(this.root);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sidebar);
            this.gridCard.ResumeLayout(false);
            this.filters.ResumeLayout(false);
            this.pnlAggregator.ResumeLayout(false);
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
        private app_escritorio.UI.RButton btnNew;
        private app_escritorio.UI.RButton btnSync;
        private app_escritorio.UI.RLabel lblDemo;
        private app_escritorio.UI.RPanel pnlAggregator;
        private app_escritorio.UI.RLabel lblAggregator;
        private app_escritorio.UI.RLabel lblAggregatorDot;
        private app_escritorio.UI.RLabel lblTitle;
        private app_escritorio.UI.RPanel filters;
        private app_escritorio.UI.RComboBox cmbEstado;
        private app_escritorio.UI.RComboBox cmbPlataforma;
        private app_escritorio.UI.RTextBox txtSearch;
        private app_escritorio.UI.RPanel gridCard;
        private app_escritorio.UI.RDataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.DataGridViewButtonColumn colAvanzar;
        private app_escritorio.UI.RLabel lblFootnote;
        private app_escritorio.Shell.ShellTopBar topBar;
        private app_escritorio.Shell.ShellSidebar sidebar;
    }
}
