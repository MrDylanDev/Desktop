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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            root = new app_escritorio.UI.RPanel();
            layout = new TableLayoutPanel();
            header = new app_escritorio.UI.RPanel();
            btnNew = new app_escritorio.UI.RButton();
            btnSync = new app_escritorio.UI.RButton();
            lblDemo = new app_escritorio.UI.RLabel();
            pnlAggregator = new app_escritorio.UI.RPanel();
            lblAggregator = new app_escritorio.UI.RLabel();
            lblAggregatorDot = new app_escritorio.UI.RLabel();
            lblTitle = new app_escritorio.UI.RLabel();
            filters = new app_escritorio.UI.RPanel();
            cmbEstado = new app_escritorio.UI.RComboBox();
            cmbPlataforma = new app_escritorio.UI.RComboBox();
            txtSearch = new app_escritorio.UI.RTextBox();
            gridCard = new app_escritorio.UI.RPanel();
            grid = new app_escritorio.UI.RDataGridView();
            colHora = new DataGridViewTextBoxColumn();
            colPlataforma = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colDetalle = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colEditar = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            colAvanzar = new DataGridViewButtonColumn();
            lblFootnote = new app_escritorio.UI.RLabel();
            topBar = new app_escritorio.Shell.ShellTopBar();
            sidebar = new app_escritorio.Shell.ShellSidebar();
            root.SuspendLayout();
            layout.SuspendLayout();
            header.SuspendLayout();
            pnlAggregator.SuspendLayout();
            filters.SuspendLayout();
            gridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // root
            // 
            root.Controls.Add(layout);
            root.Dock = DockStyle.Fill;
            root.Location = new Point(272, 64);
            root.Name = "root";
            root.Padding = new Padding(24);
            root.Size = new Size(1098, 685);
            root.Surface = UI.SurfaceLevel.Surface;
            root.TabIndex = 0;
            // 
            // layout
            // 
            layout.ColumnCount = 1;
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layout.Controls.Add(header, 0, 0);
            layout.Controls.Add(filters, 0, 1);
            layout.Controls.Add(gridCard, 0, 2);
            layout.Controls.Add(lblFootnote, 0, 3);
            layout.Dock = DockStyle.Fill;
            layout.Location = new Point(24, 24);
            layout.Name = "layout";
            layout.RowCount = 4;
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            layout.Size = new Size(1050, 637);
            layout.TabIndex = 0;
            // 
            // header
            // 
            header.Controls.Add(btnNew);
            header.Controls.Add(btnSync);
            header.Controls.Add(lblDemo);
            header.Controls.Add(pnlAggregator);
            header.Controls.Add(lblTitle);
            header.Dock = DockStyle.Fill;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(0);
            header.Name = "header";
            header.Size = new Size(1050, 60);
            header.Surface = UI.SurfaceLevel.Transparent;
            header.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNew.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnNew.Location = new Point(914, 10);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(136, 38);
            btnNew.TabIndex = 4;
            btnNew.Text = "+ Nuevo pedido";
            btnNew.Click += BtnNew_Click;
            // 
            // btnSync
            // 
            btnSync.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSync.Font = new Font("Segoe UI", 9.75F);
            btnSync.Location = new Point(722, 10);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(180, 38);
            btnSync.TabIndex = 3;
            btnSync.Text = "↻  Sincronizar menú";
            btnSync.Variant = UI.ButtonVariant.Secondary;
            btnSync.Click += BtnSync_Click;
            // 
            // lblDemo
            // 
            lblDemo.Location = new Point(446, 12);
            lblDemo.Name = "lblDemo";
            lblDemo.Size = new Size(120, 32);
            lblDemo.TabIndex = 2;
            lblDemo.Text = "DEMO frontend";
            lblDemo.TextAlign = ContentAlignment.MiddleLeft;
            lblDemo.TextStyle = UI.TextStyle.Overline;
            // 
            // pnlAggregator
            // 
            pnlAggregator.Controls.Add(lblAggregator);
            pnlAggregator.Controls.Add(lblAggregatorDot);
            pnlAggregator.CornerRadius = 8;
            pnlAggregator.Location = new Point(176, 12);
            pnlAggregator.Name = "pnlAggregator";
            pnlAggregator.Size = new Size(256, 32);
            pnlAggregator.TabIndex = 1;
            // 
            // lblAggregator
            // 
            lblAggregator.Location = new Point(26, 0);
            lblAggregator.Name = "lblAggregator";
            lblAggregator.Size = new Size(220, 32);
            lblAggregator.TabIndex = 1;
            lblAggregator.Text = "Agregador conectado (DEMO)";
            lblAggregator.TextAlign = ContentAlignment.MiddleLeft;
            lblAggregator.TextStyle = UI.TextStyle.Caption;
            // 
            // lblAggregatorDot
            // 
            lblAggregatorDot.Location = new Point(8, 0);
            lblAggregatorDot.Name = "lblAggregatorDot";
            lblAggregatorDot.Size = new Size(18, 32);
            lblAggregatorDot.TabIndex = 0;
            lblAggregatorDot.Text = "●";
            lblAggregatorDot.TextAlign = ContentAlignment.MiddleLeft;
            lblAggregatorDot.TextStyle = UI.TextStyle.Positive;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(0, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Delivery";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.TextStyle = UI.TextStyle.Hero;
            // 
            // filters
            // 
            filters.Controls.Add(cmbEstado);
            filters.Controls.Add(cmbPlataforma);
            filters.Controls.Add(txtSearch);
            filters.Dock = DockStyle.Fill;
            filters.Location = new Point(0, 60);
            filters.Margin = new Padding(0);
            filters.Name = "filters";
            filters.Size = new Size(1050, 56);
            filters.Surface = UI.SurfaceLevel.Transparent;
            filters.TabIndex = 1;
            // 
            // cmbEstado
            // 
            cmbEstado.Items.AddRange(new object[] { "Todos", "Nuevo", "En preparación", "Listo para rider", "Entregado" });
            cmbEstado.Location = new Point(502, 12);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(190, 32);
            cmbEstado.TabIndex = 2;
            cmbEstado.SelectedIndexChanged += Filter_Changed;
            // 
            // cmbPlataforma
            // 
            cmbPlataforma.Items.AddRange(new object[] { "Todas", "Rappi", "Uber Eats", "DiDi Food" });
            cmbPlataforma.Location = new Point(316, 12);
            cmbPlataforma.Name = "cmbPlataforma";
            cmbPlataforma.Size = new Size(170, 32);
            cmbPlataforma.TabIndex = 1;
            cmbPlataforma.SelectedIndexChanged += Filter_Changed;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(0, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(10, 8, 10, 8);
            txtSearch.PlaceholderText = "Buscar pedido, cliente...";
            txtSearch.Size = new Size(300, 40);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += Filter_Changed;
            // 
            // gridCard
            // 
            gridCard.Controls.Add(grid);
            gridCard.CornerRadius = 14;
            gridCard.Dock = DockStyle.Fill;
            gridCard.Location = new Point(0, 116);
            gridCard.Margin = new Padding(0);
            gridCard.Name = "gridCard";
            gridCard.Padding = new Padding(8);
            gridCard.Size = new Size(1050, 473);
            gridCard.Surface = UI.SurfaceLevel.Lowest;
            gridCard.TabIndex = 2;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = Color.FromArgb(12, 15, 16);
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(12, 15, 16);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(225, 191, 181);
            dataGridViewCellStyle1.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(12, 15, 16);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(225, 191, 181);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grid.ColumnHeadersHeight = 36;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.Columns.AddRange(new DataGridViewColumn[] { colHora, colPlataforma, colId, colCliente, colDetalle, colTotal, colEstado, colEditar, colDelete, colAvanzar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(12, 15, 16);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(225, 226, 228);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(40, 42, 44);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(225, 226, 228);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grid.DefaultCellStyle = dataGridViewCellStyle2;
            grid.Dock = DockStyle.Fill;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = Color.FromArgb(40, 42, 44);
            grid.Location = new Point(8, 8);
            grid.MultiSelect = false;
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(1034, 457);
            grid.TabIndex = 0;
            grid.CellClick += Grid_CellClick;
            // 
            // colHora
            // 
            colHora.FillWeight = 55F;
            colHora.HeaderText = "Hora";
            colHora.Name = "colHora";
            colHora.ReadOnly = true;
            // 
            // colPlataforma
            // 
            colPlataforma.FillWeight = 95F;
            colPlataforma.HeaderText = "Plataforma";
            colPlataforma.Name = "colPlataforma";
            colPlataforma.ReadOnly = true;
            // 
            // colId
            // 
            colId.FillWeight = 75F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colCliente
            // 
            colCliente.FillWeight = 110F;
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colDetalle
            // 
            colDetalle.FillWeight = 230F;
            colDetalle.HeaderText = "Detalle";
            colDetalle.Name = "colDetalle";
            colDetalle.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.FillWeight = 80F;
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.FillWeight = 115F;
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // colEditar
            // 
            colEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colEditar.HeaderText = "";
            colEditar.Name = "colEditar";
            colEditar.ReadOnly = true;
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            colEditar.Width = 76;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDelete.HeaderText = "";
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "×";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 46;
            // 
            // colAvanzar
            // 
            colAvanzar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colAvanzar.HeaderText = "";
            colAvanzar.Name = "colAvanzar";
            colAvanzar.ReadOnly = true;
            colAvanzar.Width = 124;
            // 
            // lblFootnote
            // 
            lblFootnote.Dock = DockStyle.Fill;
            lblFootnote.Location = new Point(0, 597);
            lblFootnote.Margin = new Padding(0, 8, 0, 0);
            lblFootnote.Name = "lblFootnote";
            lblFootnote.Size = new Size(1050, 40);
            lblFootnote.TabIndex = 3;
            lblFootnote.Text = "* Integración vía agregador/middleware simulada: Rappi/Uber Eats/DiDi Food llegan a la misma cola que salón. Sincronizar empuja precio/disponibilidad de Menú a plataformas.";
            lblFootnote.TextAlign = ContentAlignment.MiddleLeft;
            lblFootnote.TextStyle = UI.TextStyle.Caption;
            // 
            // topBar
            // 
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(272, 0);
            topBar.Name = "topBar";
            topBar.RoleText = "Administrador";
            topBar.RouteText = "Delivery · DEMO";
            topBar.Size = new Size(1098, 64);
            topBar.TabIndex = 1;
            // 
            // sidebar
            // 
            sidebar.ActiveRoute = "delivery";
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(272, 749);
            sidebar.TabIndex = 2;
            sidebar.Load += sidebar_Load;
            // 
            // DeliveryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 20, 21);
            ClientSize = new Size(1370, 749);
            Controls.Add(root);
            Controls.Add(topBar);
            Controls.Add(sidebar);
            MinimumSize = new Size(1100, 700);
            Name = "DeliveryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RestoOS - Modular Core";
            root.ResumeLayout(false);
            layout.ResumeLayout(false);
            header.ResumeLayout(false);
            pnlAggregator.ResumeLayout(false);
            filters.ResumeLayout(false);
            gridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
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
