namespace app_escritorio.Forms
{
    partial class ReservasForm
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
            this.pnlDate = new app_escritorio.UI.RPanel();
            this.lblFecha = new app_escritorio.UI.RLabel();
            this.lblDateIcon = new app_escritorio.UI.RLabel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.content = new System.Windows.Forms.TableLayoutPanel();
            this.calCard = new app_escritorio.UI.RPanel();
            this.calendar = new app_escritorio.UI.RCalendar();
            this.lblCalTitle = new app_escritorio.UI.RLabel();
            this.listCard = new app_escritorio.UI.RPanel();
            this.grid = new app_escritorio.UI.RDataGridView();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.filters = new app_escritorio.UI.RPanel();
            this.cmbEstado = new app_escritorio.UI.RComboBox();
            this.txtSearch = new app_escritorio.UI.RTextBox();
            this.lblFootnote = new app_escritorio.UI.RLabel();
            this.topBar = new app_escritorio.Shell.ShellTopBar();
            this.sidebar = new app_escritorio.Shell.ShellSidebar();
            this.root.SuspendLayout();
            this.layout.SuspendLayout();
            this.header.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.content.SuspendLayout();
            this.calCard.SuspendLayout();
            this.listCard.SuspendLayout();
            this.filters.SuspendLayout();
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
            this.layout.Controls.Add(this.content, 0, 1);
            this.layout.Controls.Add(this.lblFootnote, 0, 2);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(24, 24);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.Size = new System.Drawing.Size(1052, 732);
            this.layout.TabIndex = 0;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0F));
            // 
            // header
            // 
            this.header.Controls.Add(this.btnAdd);
            this.header.Controls.Add(this.lblDemo);
            this.header.Controls.Add(this.pnlDate);
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
            this.btnAdd.Location = new System.Drawing.Point(892, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+ Nueva reserva";
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
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.lblFecha);
            this.pnlDate.Controls.Add(this.lblDateIcon);
            this.pnlDate.CornerRadius = 8;
            this.pnlDate.Location = new System.Drawing.Point(184, 12);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(220, 32);
            this.pnlDate.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.pnlDate.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(28, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(180, 32);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Hoy";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFecha.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblDateIcon
            // 
            this.lblDateIcon.Location = new System.Drawing.Point(8, 0);
            this.lblDateIcon.Name = "lblDateIcon";
            this.lblDateIcon.Size = new System.Drawing.Size(20, 32);
            this.lblDateIcon.TabIndex = 0;
            this.lblDateIcon.Text = "◰";
            this.lblDateIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateIcon.TextStyle = app_escritorio.UI.TextStyle.AccentSmall;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reservas";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Hero;
            // 
            // content
            // 
            this.content.ColumnCount = 2;
            this.content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360.0F));
            this.content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            this.content.Controls.Add(this.calCard, 0, 0);
            this.content.Controls.Add(this.listCard, 1, 0);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 60);
            this.content.Margin = new System.Windows.Forms.Padding(0);
            this.content.Name = "content";
            this.content.RowCount = 1;
            this.content.Size = new System.Drawing.Size(1052, 624);
            this.content.TabIndex = 1;
            this.content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            // 
            // calCard
            // 
            this.calCard.Controls.Add(this.calendar);
            this.calCard.Controls.Add(this.lblCalTitle);
            this.calCard.CornerRadius = 14;
            this.calCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calCard.Location = new System.Drawing.Point(0, 0);
            this.calCard.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.calCard.Name = "calCard";
            this.calCard.Padding = new System.Windows.Forms.Padding(20);
            this.calCard.Size = new System.Drawing.Size(348, 624);
            this.calCard.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.calCard.TabIndex = 0;
            // 
            // calendar
            // 
            this.calendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendar.Location = new System.Drawing.Point(20, 56);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(308, 300);
            this.calendar.TabIndex = 1;
            this.calendar.DateChanged += new System.EventHandler(this.Calendar_DateChanged);
            // 
            // lblCalTitle
            // 
            this.lblCalTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCalTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCalTitle.Name = "lblCalTitle";
            this.lblCalTitle.Size = new System.Drawing.Size(308, 36);
            this.lblCalTitle.TabIndex = 0;
            this.lblCalTitle.Text = "Calendario";
            this.lblCalTitle.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // listCard
            // 
            this.listCard.Controls.Add(this.grid);
            this.listCard.Controls.Add(this.filters);
            this.listCard.CornerRadius = 14;
            this.listCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCard.Location = new System.Drawing.Point(360, 0);
            this.listCard.Margin = new System.Windows.Forms.Padding(0);
            this.listCard.Name = "listCard";
            this.listCard.Padding = new System.Windows.Forms.Padding(20);
            this.listCard.Size = new System.Drawing.Size(692, 624);
            this.listCard.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.listCard.TabIndex = 1;
            // 
            // grid
            // 
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHora,
            this.colCliente,
            this.colPersonas,
            this.colMesa,
            this.colEstado,
            this.colTel,
            this.colEditar,
            this.colDelete});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(20, 72);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(652, 532);
            this.grid.TabIndex = 1;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // colHora
            // 
            this.colHora.FillWeight = 60F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            // 
            // colCliente
            // 
            this.colCliente.FillWeight = 170F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colPersonas
            // 
            this.colPersonas.FillWeight = 50F;
            this.colPersonas.HeaderText = "Pers.";
            this.colPersonas.Name = "colPersonas";
            // 
            // colMesa
            // 
            this.colMesa.FillWeight = 90F;
            this.colMesa.HeaderText = "Mesa";
            this.colMesa.Name = "colMesa";
            // 
            // colEstado
            // 
            this.colEstado.FillWeight = 100F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Tag = "chip";
            // 
            // colTel
            // 
            this.colTel.FillWeight = 110F;
            this.colTel.HeaderText = "Tel.";
            this.colTel.Name = "colTel";
            // 
            // colEditar
            // 
            this.colEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEditar.HeaderText = "";
            this.colEditar.Name = "colEditar";
            this.colEditar.Tag = "";
            this.colEditar.Text = "Editar";
            this.colEditar.UseColumnTextForButtonValue = true;
            this.colEditar.Width = 80;
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
            // filters
            // 
            this.filters.Controls.Add(this.cmbEstado);
            this.filters.Controls.Add(this.txtSearch);
            this.filters.Dock = System.Windows.Forms.DockStyle.Top;
            this.filters.Location = new System.Drawing.Point(20, 20);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(652, 52);
            this.filters.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.filters.TabIndex = 0;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Items.AddRange(new object[] {
            "Todos",
            "Confirmada",
            "En curso",
            "Cancelada"});
            this.cmbEstado.Location = new System.Drawing.Point(316, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(170, 32);
            this.cmbEstado.TabIndex = 1;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Buscar cliente o mesa...";
            this.txtSearch.Size = new System.Drawing.Size(300, 40);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblFootnote
            // 
            this.lblFootnote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFootnote.Location = new System.Drawing.Point(0, 0);
            this.lblFootnote.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblFootnote.Name = "lblFootnote";
            this.lblFootnote.Size = new System.Drawing.Size(1052, 40);
            this.lblFootnote.TabIndex = 2;
            this.lblFootnote.Text = "* Vista calendario/agenda con asignación de mesa simulada. La persistencia y asignación real a salón quedan para Fase 2 con SQLite.";
            this.lblFootnote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFootnote.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(272, 0);
            this.topBar.Name = "topBar";
            this.topBar.RoleText = "Administrador";
            this.topBar.RouteText = "Reservas · DEMO";
            this.topBar.Size = new System.Drawing.Size(1100, 64);
            this.topBar.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.ActiveRoute = "reservas";
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(272, 844);
            this.sidebar.TabIndex = 2;
            // 
            // ReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1372, 844);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "ReservasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestoOS - Modular Core";
            this.Controls.Add(this.root);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sidebar);
            this.filters.ResumeLayout(false);
            this.listCard.ResumeLayout(false);
            this.calCard.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.pnlDate.ResumeLayout(false);
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
        private app_escritorio.UI.RPanel pnlDate;
        private app_escritorio.UI.RLabel lblFecha;
        private app_escritorio.UI.RLabel lblDateIcon;
        private app_escritorio.UI.RLabel lblTitle;
        private System.Windows.Forms.TableLayoutPanel content;
        private app_escritorio.UI.RPanel calCard;
        private app_escritorio.UI.RCalendar calendar;
        private app_escritorio.UI.RLabel lblCalTitle;
        private app_escritorio.UI.RPanel listCard;
        private app_escritorio.UI.RDataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTel;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private app_escritorio.UI.RPanel filters;
        private app_escritorio.UI.RComboBox cmbEstado;
        private app_escritorio.UI.RTextBox txtSearch;
        private app_escritorio.UI.RLabel lblFootnote;
        private app_escritorio.Shell.ShellTopBar topBar;
        private app_escritorio.Shell.ShellSidebar sidebar;
    }
}
