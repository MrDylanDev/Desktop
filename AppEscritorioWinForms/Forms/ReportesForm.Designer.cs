namespace app_escritorio.Forms
{
    partial class ReportesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            root = new app_escritorio.UI.RPanel();
            lblFootnote = new app_escritorio.UI.RLabel();
            spacer4 = new Panel();
            histCard = new app_escritorio.UI.RPanel();
            gridHist = new app_escritorio.UI.RDataGridView();
            colHFecha = new DataGridViewTextBoxColumn();
            colHMesa = new DataGridViewTextBoxColumn();
            colHDetalle = new DataGridViewTextBoxColumn();
            colHTotal = new DataGridViewTextBoxColumn();
            colHMetodo = new DataGridViewTextBoxColumn();
            colHCajero = new DataGridViewTextBoxColumn();
            colHEstado = new DataGridViewTextBoxColumn();
            colHVer = new DataGridViewButtonColumn();
            histFilters = new app_escritorio.UI.RPanel();
            cmbEstado = new app_escritorio.UI.RComboBox();
            cmbMetodo = new app_escritorio.UI.RComboBox();
            txtHistSearch = new app_escritorio.UI.RTextBox();
            histHead = new app_escritorio.UI.RPanel();
            lblRango = new app_escritorio.UI.RLabel();
            lblHistTitle = new app_escritorio.UI.RLabel();
            spacer3 = new Panel();
            mesaCard = new app_escritorio.UI.RPanel();
            gridMesa = new app_escritorio.UI.RDataGridView();
            colMesa = new DataGridViewTextBoxColumn();
            colMesaTickets = new DataGridViewTextBoxColumn();
            colMesaTotal = new DataGridViewTextBoxColumn();
            colMesaMesero = new DataGridViewTextBoxColumn();
            lblMesaTitle = new app_escritorio.UI.RLabel();
            spacer2 = new Panel();
            rowCharts = new TableLayoutPanel();
            chartCard = new app_escritorio.UI.RPanel();
            chart = new app_escritorio.UI.RBarChart();
            lblChartNote = new app_escritorio.UI.RLabel();
            lblChartTitle = new app_escritorio.UI.RLabel();
            topCard = new app_escritorio.UI.RPanel();
            gridTop = new app_escritorio.UI.RDataGridView();
            colTopRank = new DataGridViewTextBoxColumn();
            colTopPlato = new DataGridViewTextBoxColumn();
            colTopCant = new DataGridViewTextBoxColumn();
            colTopTotal = new DataGridViewTextBoxColumn();
            lblTopTitle = new app_escritorio.UI.RLabel();
            spacer1 = new Panel();
            kpis = new TableLayoutPanel();
            kpiTotal = new app_escritorio.UI.RPanel();
            lblTotalSub = new app_escritorio.UI.RLabel();
            lblTotal = new app_escritorio.UI.RLabel();
            lblTotalCaption = new app_escritorio.UI.RLabel();
            kpiTicket = new app_escritorio.UI.RPanel();
            lblTicketSub = new app_escritorio.UI.RLabel();
            lblTicket = new app_escritorio.UI.RLabel();
            lblTicketCaption = new app_escritorio.UI.RLabel();
            kpiTax = new app_escritorio.UI.RPanel();
            lblTaxSub = new app_escritorio.UI.RLabel();
            lblTax = new app_escritorio.UI.RLabel();
            lblTaxCaption = new app_escritorio.UI.RLabel();
            kpiMetodo = new app_escritorio.UI.RPanel();
            lblMetodoSub = new app_escritorio.UI.RLabel();
            lblMetodo = new app_escritorio.UI.RLabel();
            lblMetodoCaption = new app_escritorio.UI.RLabel();
            spacer0 = new Panel();
            header = new app_escritorio.UI.RPanel();
            btnRefresh = new app_escritorio.UI.RButton();
            cmbOrigen = new app_escritorio.UI.RComboBox();
            cmbPeriodo = new app_escritorio.UI.RComboBox();
            badgeDemo = new app_escritorio.UI.RBadge();
            badgeAdmin = new app_escritorio.UI.RBadge();
            lblTitle = new app_escritorio.UI.RLabel();
            topBar = new app_escritorio.Shell.ShellTopBar();
            sidebar = new app_escritorio.Shell.ShellSidebar();
            root.SuspendLayout();
            histCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridHist).BeginInit();
            histFilters.SuspendLayout();
            histHead.SuspendLayout();
            mesaCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMesa).BeginInit();
            rowCharts.SuspendLayout();
            chartCard.SuspendLayout();
            topCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTop).BeginInit();
            kpis.SuspendLayout();
            kpiTotal.SuspendLayout();
            kpiTicket.SuspendLayout();
            kpiTax.SuspendLayout();
            kpiMetodo.SuspendLayout();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // root
            // 
            root.AutoScroll = true;
            root.Controls.Add(lblFootnote);
            root.Controls.Add(spacer4);
            root.Controls.Add(histCard);
            root.Controls.Add(spacer3);
            root.Controls.Add(mesaCard);
            root.Controls.Add(spacer2);
            root.Controls.Add(rowCharts);
            root.Controls.Add(spacer1);
            root.Controls.Add(kpis);
            root.Controls.Add(spacer0);
            root.Controls.Add(header);
            root.Dock = DockStyle.Fill;
            root.Location = new Point(272, 64);
            root.Name = "root";
            root.Padding = new Padding(24);
            root.Size = new Size(1098, 685);
            root.Surface = UI.SurfaceLevel.Surface;
            root.TabIndex = 0;
            // 
            // lblFootnote
            // 
            lblFootnote.Dock = DockStyle.Top;
            lblFootnote.Location = new Point(24, 1272);
            lblFootnote.Name = "lblFootnote";
            lblFootnote.Padding = new Padding(0, 12, 0, 0);
            lblFootnote.Size = new Size(1033, 56);
            lblFootnote.TabIndex = 5;
            lblFootnote.Text = resources.GetString("lblFootnote.Text");
            lblFootnote.TextStyle = UI.TextStyle.Caption;
            // 
            // spacer4
            // 
            spacer4.Dock = DockStyle.Top;
            spacer4.Location = new Point(24, 1256);
            spacer4.Name = "spacer4";
            spacer4.Size = new Size(1033, 16);
            spacer4.TabIndex = 0;
            // 
            // histCard
            // 
            histCard.Controls.Add(gridHist);
            histCard.Controls.Add(histFilters);
            histCard.Controls.Add(histHead);
            histCard.CornerRadius = 14;
            histCard.Dock = DockStyle.Top;
            histCard.Location = new Point(24, 816);
            histCard.Name = "histCard";
            histCard.Padding = new Padding(20);
            histCard.Size = new Size(1033, 440);
            histCard.TabIndex = 4;
            // 
            // gridHist
            // 
            gridHist.AllowUserToAddRows = false;
            gridHist.AllowUserToDeleteRows = false;
            gridHist.AllowUserToResizeRows = false;
            gridHist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridHist.BackgroundColor = Color.FromArgb(12, 15, 16);
            gridHist.BorderStyle = BorderStyle.None;
            gridHist.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridHist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(12, 15, 16);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(225, 191, 181);
            dataGridViewCellStyle1.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(12, 15, 16);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(225, 191, 181);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridHist.ColumnHeadersHeight = 36;
            gridHist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridHist.Columns.AddRange(new DataGridViewColumn[] { colHFecha, colHMesa, colHDetalle, colHTotal, colHMetodo, colHCajero, colHEstado, colHVer });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(12, 15, 16);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(225, 226, 228);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(40, 42, 44);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(225, 226, 228);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridHist.DefaultCellStyle = dataGridViewCellStyle2;
            gridHist.Dock = DockStyle.Fill;
            gridHist.EnableHeadersVisualStyles = false;
            gridHist.GridColor = Color.FromArgb(40, 42, 44);
            gridHist.Location = new Point(20, 112);
            gridHist.MultiSelect = false;
            gridHist.Name = "gridHist";
            gridHist.ReadOnly = true;
            gridHist.RowHeadersVisible = false;
            gridHist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridHist.Size = new Size(993, 308);
            gridHist.TabIndex = 2;
            gridHist.CellClick += GridHist_CellClick;
            // 
            // colHFecha
            // 
            colHFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHFecha.HeaderText = "Fecha";
            colHFecha.Name = "colHFecha";
            colHFecha.ReadOnly = true;
            colHFecha.Width = 96;
            // 
            // colHMesa
            // 
            colHMesa.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHMesa.HeaderText = "Mesa";
            colHMesa.Name = "colHMesa";
            colHMesa.ReadOnly = true;
            colHMesa.Width = 90;
            // 
            // colHDetalle
            // 
            colHDetalle.FillWeight = 300F;
            colHDetalle.HeaderText = "Qué se vendió";
            colHDetalle.Name = "colHDetalle";
            colHDetalle.ReadOnly = true;
            // 
            // colHTotal
            // 
            colHTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHTotal.HeaderText = "Total";
            colHTotal.Name = "colHTotal";
            colHTotal.ReadOnly = true;
            colHTotal.Width = 96;
            // 
            // colHMetodo
            // 
            colHMetodo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHMetodo.HeaderText = "Método";
            colHMetodo.Name = "colHMetodo";
            colHMetodo.ReadOnly = true;
            colHMetodo.Width = 86;
            // 
            // colHCajero
            // 
            colHCajero.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHCajero.HeaderText = "Cajero";
            colHCajero.Name = "colHCajero";
            colHCajero.ReadOnly = true;
            colHCajero.Width = 86;
            // 
            // colHEstado
            // 
            colHEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHEstado.HeaderText = "Estado";
            colHEstado.Name = "colHEstado";
            colHEstado.ReadOnly = true;
            colHEstado.Width = 96;
            // 
            // colHVer
            // 
            colHVer.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colHVer.HeaderText = "";
            colHVer.Name = "colHVer";
            colHVer.ReadOnly = true;
            colHVer.Text = "Ver";
            colHVer.UseColumnTextForButtonValue = true;
            colHVer.Width = 64;
            // 
            // histFilters
            // 
            histFilters.Controls.Add(cmbEstado);
            histFilters.Controls.Add(cmbMetodo);
            histFilters.Controls.Add(txtHistSearch);
            histFilters.Dock = DockStyle.Top;
            histFilters.Location = new Point(20, 60);
            histFilters.Name = "histFilters";
            histFilters.Size = new Size(993, 52);
            histFilters.Surface = UI.SurfaceLevel.Transparent;
            histFilters.TabIndex = 1;
            // 
            // cmbEstado
            // 
            cmbEstado.Items.AddRange(new object[] { "Todos", "Cobrado", "Anulado" });
            cmbEstado.Location = new Point(478, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(150, 32);
            cmbEstado.TabIndex = 2;
            cmbEstado.SelectedIndexChanged += Hist_Changed;
            // 
            // cmbMetodo
            // 
            cmbMetodo.Items.AddRange(new object[] { "Todos", "Efectivo", "Tarjeta" });
            cmbMetodo.Location = new Point(316, 4);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(150, 32);
            cmbMetodo.TabIndex = 1;
            cmbMetodo.SelectedIndexChanged += Hist_Changed;
            // 
            // txtHistSearch
            // 
            txtHistSearch.Location = new Point(0, 0);
            txtHistSearch.Name = "txtHistSearch";
            txtHistSearch.Padding = new Padding(10, 8, 10, 8);
            txtHistSearch.PlaceholderText = "Buscar mesa, producto, cajero...";
            txtHistSearch.Size = new Size(300, 40);
            txtHistSearch.TabIndex = 0;
            txtHistSearch.TextChanged += Hist_Changed;
            // 
            // histHead
            // 
            histHead.Controls.Add(lblRango);
            histHead.Controls.Add(lblHistTitle);
            histHead.Dock = DockStyle.Top;
            histHead.Location = new Point(20, 20);
            histHead.Name = "histHead";
            histHead.Size = new Size(993, 40);
            histHead.Surface = UI.SurfaceLevel.Transparent;
            histHead.TabIndex = 0;
            // 
            // lblRango
            // 
            lblRango.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRango.Location = new Point(613, 4);
            lblRango.Name = "lblRango";
            lblRango.Size = new Size(380, 28);
            lblRango.TabIndex = 1;
            lblRango.Text = "Hoy: $0 · 0 ventas";
            lblRango.TextAlign = ContentAlignment.MiddleRight;
            lblRango.TextStyle = UI.TextStyle.AccentBold;
            // 
            // lblHistTitle
            // 
            lblHistTitle.Location = new Point(0, 0);
            lblHistTitle.Name = "lblHistTitle";
            lblHistTitle.Size = new Size(620, 36);
            lblHistTitle.TabIndex = 0;
            lblHistTitle.Text = "Historial de cobros — qué se vendió (trazabilidad POS)";
            lblHistTitle.TextStyle = UI.TextStyle.Heading;
            // 
            // spacer3
            // 
            spacer3.Dock = DockStyle.Top;
            spacer3.Location = new Point(24, 800);
            spacer3.Name = "spacer3";
            spacer3.Size = new Size(1033, 16);
            spacer3.TabIndex = 0;
            // 
            // mesaCard
            // 
            mesaCard.Controls.Add(gridMesa);
            mesaCard.Controls.Add(lblMesaTitle);
            mesaCard.CornerRadius = 14;
            mesaCard.Dock = DockStyle.Top;
            mesaCard.Location = new Point(24, 550);
            mesaCard.Name = "mesaCard";
            mesaCard.Padding = new Padding(20);
            mesaCard.Size = new Size(1033, 250);
            mesaCard.TabIndex = 3;
            // 
            // gridMesa
            // 
            gridMesa.AllowUserToAddRows = false;
            gridMesa.AllowUserToDeleteRows = false;
            gridMesa.AllowUserToResizeRows = false;
            gridMesa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMesa.BackgroundColor = Color.FromArgb(12, 15, 16);
            gridMesa.BorderStyle = BorderStyle.None;
            gridMesa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridMesa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(12, 15, 16);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(225, 191, 181);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(12, 15, 16);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(225, 191, 181);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridMesa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridMesa.ColumnHeadersHeight = 36;
            gridMesa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridMesa.Columns.AddRange(new DataGridViewColumn[] { colMesa, colMesaTickets, colMesaTotal, colMesaMesero });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(12, 15, 16);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(225, 226, 228);
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(40, 42, 44);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(225, 226, 228);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            gridMesa.DefaultCellStyle = dataGridViewCellStyle4;
            gridMesa.Dock = DockStyle.Fill;
            gridMesa.EnableHeadersVisualStyles = false;
            gridMesa.GridColor = Color.FromArgb(40, 42, 44);
            gridMesa.Location = new Point(20, 56);
            gridMesa.MultiSelect = false;
            gridMesa.Name = "gridMesa";
            gridMesa.ReadOnly = true;
            gridMesa.RowHeadersVisible = false;
            gridMesa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridMesa.Size = new Size(993, 174);
            gridMesa.TabIndex = 1;
            // 
            // colMesa
            // 
            colMesa.FillWeight = 150F;
            colMesa.HeaderText = "Mesa";
            colMesa.Name = "colMesa";
            colMesa.ReadOnly = true;
            // 
            // colMesaTickets
            // 
            colMesaTickets.HeaderText = "Tickets";
            colMesaTickets.Name = "colMesaTickets";
            colMesaTickets.ReadOnly = true;
            // 
            // colMesaTotal
            // 
            colMesaTotal.FillWeight = 150F;
            colMesaTotal.HeaderText = "Total";
            colMesaTotal.Name = "colMesaTotal";
            colMesaTotal.ReadOnly = true;
            // 
            // colMesaMesero
            // 
            colMesaMesero.FillWeight = 150F;
            colMesaMesero.HeaderText = "Mesero";
            colMesaMesero.Name = "colMesaMesero";
            colMesaMesero.ReadOnly = true;
            // 
            // lblMesaTitle
            // 
            lblMesaTitle.Dock = DockStyle.Top;
            lblMesaTitle.Location = new Point(20, 20);
            lblMesaTitle.Name = "lblMesaTitle";
            lblMesaTitle.Size = new Size(993, 36);
            lblMesaTitle.TabIndex = 0;
            lblMesaTitle.Text = "Ventas por mesa";
            lblMesaTitle.TextStyle = UI.TextStyle.Heading;
            // 
            // spacer2
            // 
            spacer2.Dock = DockStyle.Top;
            spacer2.Location = new Point(24, 534);
            spacer2.Name = "spacer2";
            spacer2.Size = new Size(1033, 16);
            spacer2.TabIndex = 0;
            // 
            // rowCharts
            // 
            rowCharts.ColumnCount = 2;
            rowCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            rowCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            rowCharts.Controls.Add(chartCard, 0, 0);
            rowCharts.Controls.Add(topCard, 1, 0);
            rowCharts.Dock = DockStyle.Top;
            rowCharts.Location = new Point(24, 234);
            rowCharts.Name = "rowCharts";
            rowCharts.RowCount = 1;
            rowCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rowCharts.Size = new Size(1033, 300);
            rowCharts.TabIndex = 2;
            // 
            // chartCard
            // 
            chartCard.Controls.Add(chart);
            chartCard.Controls.Add(lblChartNote);
            chartCard.Controls.Add(lblChartTitle);
            chartCard.CornerRadius = 14;
            chartCard.Dock = DockStyle.Fill;
            chartCard.Location = new Point(0, 0);
            chartCard.Margin = new Padding(0, 0, 12, 0);
            chartCard.Name = "chartCard";
            chartCard.Padding = new Padding(20);
            chartCard.Size = new Size(607, 300);
            chartCard.TabIndex = 0;
            // 
            // chart
            // 
            chart.Dock = DockStyle.Fill;
            chart.Location = new Point(20, 56);
            chart.Name = "chart";
            chart.Size = new Size(567, 202);
            chart.TabIndex = 1;
            // 
            // lblChartNote
            // 
            lblChartNote.Dock = DockStyle.Bottom;
            lblChartNote.Location = new Point(20, 258);
            lblChartNote.Name = "lblChartNote";
            lblChartNote.Size = new Size(567, 22);
            lblChartNote.TabIndex = 2;
            lblChartNote.Text = "* Barras mock escala relativa al máximo del período";
            lblChartNote.TextAlign = ContentAlignment.BottomLeft;
            lblChartNote.TextStyle = UI.TextStyle.Caption;
            // 
            // lblChartTitle
            // 
            lblChartTitle.Dock = DockStyle.Top;
            lblChartTitle.Location = new Point(20, 20);
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Size = new Size(567, 36);
            lblChartTitle.TabIndex = 0;
            lblChartTitle.Text = "Ventas últimos 7 días";
            lblChartTitle.TextStyle = UI.TextStyle.Heading;
            // 
            // topCard
            // 
            topCard.Controls.Add(gridTop);
            topCard.Controls.Add(lblTopTitle);
            topCard.CornerRadius = 14;
            topCard.Dock = DockStyle.Fill;
            topCard.Location = new Point(619, 0);
            topCard.Margin = new Padding(0);
            topCard.Name = "topCard";
            topCard.Padding = new Padding(20);
            topCard.Size = new Size(414, 300);
            topCard.TabIndex = 1;
            // 
            // gridTop
            // 
            gridTop.AllowUserToAddRows = false;
            gridTop.AllowUserToDeleteRows = false;
            gridTop.AllowUserToResizeRows = false;
            gridTop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTop.BackgroundColor = Color.FromArgb(12, 15, 16);
            gridTop.BorderStyle = BorderStyle.None;
            gridTop.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridTop.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(12, 15, 16);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(225, 191, 181);
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(12, 15, 16);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(225, 191, 181);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridTop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridTop.ColumnHeadersHeight = 36;
            gridTop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridTop.Columns.AddRange(new DataGridViewColumn[] { colTopRank, colTopPlato, colTopCant, colTopTotal });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(12, 15, 16);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(225, 226, 228);
            dataGridViewCellStyle6.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(40, 42, 44);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(225, 226, 228);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            gridTop.DefaultCellStyle = dataGridViewCellStyle6;
            gridTop.Dock = DockStyle.Fill;
            gridTop.EnableHeadersVisualStyles = false;
            gridTop.GridColor = Color.FromArgb(40, 42, 44);
            gridTop.Location = new Point(20, 56);
            gridTop.MultiSelect = false;
            gridTop.Name = "gridTop";
            gridTop.ReadOnly = true;
            gridTop.RowHeadersVisible = false;
            gridTop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTop.Size = new Size(374, 224);
            gridTop.TabIndex = 1;
            // 
            // colTopRank
            // 
            colTopRank.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colTopRank.HeaderText = "#";
            colTopRank.Name = "colTopRank";
            colTopRank.ReadOnly = true;
            colTopRank.Width = 36;
            // 
            // colTopPlato
            // 
            colTopPlato.FillWeight = 200F;
            colTopPlato.HeaderText = "Plato";
            colTopPlato.Name = "colTopPlato";
            colTopPlato.ReadOnly = true;
            // 
            // colTopCant
            // 
            colTopCant.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colTopCant.HeaderText = "Cant.";
            colTopCant.Name = "colTopCant";
            colTopCant.ReadOnly = true;
            colTopCant.Width = 56;
            // 
            // colTopTotal
            // 
            colTopTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colTopTotal.HeaderText = "Total";
            colTopTotal.Name = "colTopTotal";
            colTopTotal.ReadOnly = true;
            colTopTotal.Width = 96;
            // 
            // lblTopTitle
            // 
            lblTopTitle.Dock = DockStyle.Top;
            lblTopTitle.Location = new Point(20, 20);
            lblTopTitle.Name = "lblTopTitle";
            lblTopTitle.Size = new Size(374, 36);
            lblTopTitle.TabIndex = 0;
            lblTopTitle.Text = "Top platos";
            lblTopTitle.TextStyle = UI.TextStyle.Heading;
            // 
            // spacer1
            // 
            spacer1.Dock = DockStyle.Top;
            spacer1.Location = new Point(24, 218);
            spacer1.Name = "spacer1";
            spacer1.Size = new Size(1033, 16);
            spacer1.TabIndex = 0;
            // 
            // kpis
            // 
            kpis.ColumnCount = 4;
            kpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            kpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            kpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            kpis.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            kpis.Controls.Add(kpiTotal, 0, 0);
            kpis.Controls.Add(kpiTicket, 1, 0);
            kpis.Controls.Add(kpiTax, 2, 0);
            kpis.Controls.Add(kpiMetodo, 3, 0);
            kpis.Dock = DockStyle.Top;
            kpis.Location = new Point(24, 100);
            kpis.Name = "kpis";
            kpis.RowCount = 1;
            kpis.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            kpis.Size = new Size(1033, 118);
            kpis.TabIndex = 1;
            // 
            // kpiTotal
            // 
            kpiTotal.Controls.Add(lblTotalSub);
            kpiTotal.Controls.Add(lblTotal);
            kpiTotal.Controls.Add(lblTotalCaption);
            kpiTotal.CornerRadius = 14;
            kpiTotal.Dock = DockStyle.Fill;
            kpiTotal.Location = new Point(0, 0);
            kpiTotal.Margin = new Padding(0, 0, 12, 0);
            kpiTotal.Name = "kpiTotal";
            kpiTotal.Size = new Size(246, 118);
            kpiTotal.TabIndex = 0;
            // 
            // lblTotalSub
            // 
            lblTotalSub.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalSub.Location = new Point(18, 84);
            lblTotalSub.Name = "lblTotalSub";
            lblTotalSub.Size = new Size(212, 18);
            lblTotalSub.TabIndex = 2;
            lblTotalSub.Text = "0 tickets";
            lblTotalSub.TextStyle = UI.TextStyle.Caption;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTotal.Location = new Point(18, 40);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(212, 40);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "$ 0";
            lblTotal.TextStyle = UI.TextStyle.Title;
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTotalCaption.Location = new Point(18, 16);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(212, 20);
            lblTotalCaption.TabIndex = 0;
            lblTotalCaption.Text = "Total ventas";
            lblTotalCaption.TextStyle = UI.TextStyle.Muted;
            // 
            // kpiTicket
            // 
            kpiTicket.Controls.Add(lblTicketSub);
            kpiTicket.Controls.Add(lblTicket);
            kpiTicket.Controls.Add(lblTicketCaption);
            kpiTicket.CornerRadius = 14;
            kpiTicket.Dock = DockStyle.Fill;
            kpiTicket.Location = new Point(258, 0);
            kpiTicket.Margin = new Padding(0, 0, 12, 0);
            kpiTicket.Name = "kpiTicket";
            kpiTicket.Size = new Size(246, 118);
            kpiTicket.TabIndex = 1;
            // 
            // lblTicketSub
            // 
            lblTicketSub.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTicketSub.Location = new Point(18, 84);
            lblTicketSub.Name = "lblTicketSub";
            lblTicketSub.Size = new Size(212, 18);
            lblTicketSub.TabIndex = 2;
            lblTicketSub.Text = "por cuenta";
            lblTicketSub.TextStyle = UI.TextStyle.Caption;
            // 
            // lblTicket
            // 
            lblTicket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTicket.Location = new Point(18, 40);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(212, 40);
            lblTicket.TabIndex = 1;
            lblTicket.Text = "$ 0";
            lblTicket.TextStyle = UI.TextStyle.Title;
            // 
            // lblTicketCaption
            // 
            lblTicketCaption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTicketCaption.Location = new Point(18, 16);
            lblTicketCaption.Name = "lblTicketCaption";
            lblTicketCaption.Size = new Size(212, 20);
            lblTicketCaption.TabIndex = 0;
            lblTicketCaption.Text = "Ticket promedio";
            lblTicketCaption.TextStyle = UI.TextStyle.Muted;
            // 
            // kpiTax
            // 
            kpiTax.Controls.Add(lblTaxSub);
            kpiTax.Controls.Add(lblTax);
            kpiTax.Controls.Add(lblTaxCaption);
            kpiTax.CornerRadius = 14;
            kpiTax.Dock = DockStyle.Fill;
            kpiTax.Location = new Point(516, 0);
            kpiTax.Margin = new Padding(0, 0, 12, 0);
            kpiTax.Name = "kpiTax";
            kpiTax.Size = new Size(246, 118);
            kpiTax.TabIndex = 2;
            // 
            // lblTaxSub
            // 
            lblTaxSub.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTaxSub.Location = new Point(18, 84);
            lblTaxSub.Name = "lblTaxSub";
            lblTaxSub.Size = new Size(212, 18);
            lblTaxSub.TabIndex = 2;
            lblTaxSub.Text = "INC 8% / IVA 19% unificado";
            lblTaxSub.TextStyle = UI.TextStyle.Caption;
            // 
            // lblTax
            // 
            lblTax.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTax.ColorOverride = Color.FromArgb(255, 185, 95);
            lblTax.Location = new Point(18, 40);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(212, 40);
            lblTax.TabIndex = 1;
            lblTax.Text = "$ 0";
            lblTax.TextStyle = UI.TextStyle.Title;
            // 
            // lblTaxCaption
            // 
            lblTaxCaption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTaxCaption.Location = new Point(18, 16);
            lblTaxCaption.Name = "lblTaxCaption";
            lblTaxCaption.Size = new Size(212, 20);
            lblTaxCaption.TabIndex = 0;
            lblTaxCaption.Text = "Impuesto recaudado";
            lblTaxCaption.TextStyle = UI.TextStyle.Muted;
            // 
            // kpiMetodo
            // 
            kpiMetodo.Controls.Add(lblMetodoSub);
            kpiMetodo.Controls.Add(lblMetodo);
            kpiMetodo.Controls.Add(lblMetodoCaption);
            kpiMetodo.CornerRadius = 14;
            kpiMetodo.Dock = DockStyle.Fill;
            kpiMetodo.Location = new Point(774, 0);
            kpiMetodo.Margin = new Padding(0);
            kpiMetodo.Name = "kpiMetodo";
            kpiMetodo.Size = new Size(259, 118);
            kpiMetodo.TabIndex = 3;
            // 
            // lblMetodoSub
            // 
            lblMetodoSub.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMetodoSub.Location = new Point(18, 84);
            lblMetodoSub.Name = "lblMetodoSub";
            lblMetodoSub.Size = new Size(225, 18);
            lblMetodoSub.TabIndex = 2;
            lblMetodoSub.Text = "salón + delivery (mock)";
            lblMetodoSub.TextStyle = UI.TextStyle.Caption;
            // 
            // lblMetodo
            // 
            lblMetodo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMetodo.Location = new Point(18, 40);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(225, 40);
            lblMetodo.TabIndex = 1;
            lblMetodo.Text = "$ 0 / $ 0";
            lblMetodo.TextStyle = UI.TextStyle.Title;
            // 
            // lblMetodoCaption
            // 
            lblMetodoCaption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMetodoCaption.Location = new Point(18, 16);
            lblMetodoCaption.Name = "lblMetodoCaption";
            lblMetodoCaption.Size = new Size(225, 20);
            lblMetodoCaption.TabIndex = 0;
            lblMetodoCaption.Text = "Efectivo / Tarjeta";
            lblMetodoCaption.TextStyle = UI.TextStyle.Muted;
            // 
            // spacer0
            // 
            spacer0.Dock = DockStyle.Top;
            spacer0.Location = new Point(24, 84);
            spacer0.Name = "spacer0";
            spacer0.Size = new Size(1033, 16);
            spacer0.TabIndex = 0;
            // 
            // header
            // 
            header.Controls.Add(btnRefresh);
            header.Controls.Add(cmbOrigen);
            header.Controls.Add(cmbPeriodo);
            header.Controls.Add(badgeDemo);
            header.Controls.Add(badgeAdmin);
            header.Controls.Add(lblTitle);
            header.Dock = DockStyle.Top;
            header.Location = new Point(24, 24);
            header.Name = "header";
            header.Size = new Size(1033, 60);
            header.Surface = UI.SurfaceLevel.Transparent;
            header.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Font = new Font("Segoe UI", 9.75F);
            btnRefresh.Location = new Point(925, 10);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(108, 38);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "↻ Actualizar";
            btnRefresh.Variant = UI.ButtonVariant.Secondary;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // cmbOrigen
            // 
            cmbOrigen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbOrigen.Items.AddRange(new object[] { "Todo (salón + delivery)", "Solo salón", "Solo delivery" });
            cmbOrigen.Location = new Point(723, 13);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(190, 32);
            cmbOrigen.TabIndex = 4;
            cmbOrigen.SelectedIndexChanged += Filter_Changed;
            // 
            // cmbPeriodo
            // 
            cmbPeriodo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPeriodo.Items.AddRange(new object[] { "Hoy", "Últimos 7 días", "Últimos 30 días", "Este mes" });
            cmbPeriodo.Location = new Point(541, 13);
            cmbPeriodo.Name = "cmbPeriodo";
            cmbPeriodo.Size = new Size(170, 32);
            cmbPeriodo.TabIndex = 3;
            cmbPeriodo.SelectedIndexChanged += Filter_Changed;
            // 
            // badgeDemo
            // 
            badgeDemo.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            badgeDemo.Kind = UI.BadgeKind.Accent;
            badgeDemo.Location = new Point(284, 18);
            badgeDemo.Name = "badgeDemo";
            badgeDemo.Size = new Size(112, 24);
            badgeDemo.TabIndex = 2;
            badgeDemo.Text = "DEMO frontend";
            // 
            // badgeAdmin
            // 
            badgeAdmin.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold);
            badgeAdmin.Kind = UI.BadgeKind.Primary;
            badgeAdmin.Location = new Point(180, 18);
            badgeAdmin.Name = "badgeAdmin";
            badgeAdmin.Size = new Size(94, 24);
            badgeAdmin.TabIndex = 1;
            badgeAdmin.Text = "Solo Admin";
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(0, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(176, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reportes";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.TextStyle = UI.TextStyle.Hero;
            // 
            // topBar
            // 
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(272, 0);
            topBar.Name = "topBar";
            topBar.RoleText = "Administrador";
            topBar.RouteText = "Reportes · Solo Admin";
            topBar.Size = new Size(1098, 64);
            topBar.TabIndex = 1;
            // 
            // sidebar
            // 
            sidebar.ActiveRoute = "reportes";
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(272, 749);
            sidebar.TabIndex = 2;
            // 
            // ReportesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 20, 21);
            ClientSize = new Size(1370, 749);
            Controls.Add(root);
            Controls.Add(topBar);
            Controls.Add(sidebar);
            MinimumSize = new Size(1100, 700);
            Name = "ReportesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RestoOS - Modular Core";
            root.ResumeLayout(false);
            histCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridHist).EndInit();
            histFilters.ResumeLayout(false);
            histHead.ResumeLayout(false);
            mesaCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridMesa).EndInit();
            rowCharts.ResumeLayout(false);
            chartCard.ResumeLayout(false);
            topCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridTop).EndInit();
            kpis.ResumeLayout(false);
            kpiTotal.ResumeLayout(false);
            kpiTicket.ResumeLayout(false);
            kpiTax.ResumeLayout(false);
            kpiMetodo.ResumeLayout(false);
            header.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private app_escritorio.UI.RLabel lblFootnote;
        private System.Windows.Forms.Panel spacer4;
        private app_escritorio.UI.RPanel histCard;
        private app_escritorio.UI.RDataGridView gridHist;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHMetodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHCajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHEstado;
        private System.Windows.Forms.DataGridViewButtonColumn colHVer;
        private app_escritorio.UI.RPanel histFilters;
        private app_escritorio.UI.RComboBox cmbEstado;
        private app_escritorio.UI.RComboBox cmbMetodo;
        private app_escritorio.UI.RTextBox txtHistSearch;
        private app_escritorio.UI.RPanel histHead;
        private app_escritorio.UI.RLabel lblRango;
        private app_escritorio.UI.RLabel lblHistTitle;
        private System.Windows.Forms.Panel spacer3;
        private app_escritorio.UI.RPanel mesaCard;
        private app_escritorio.UI.RDataGridView gridMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMesaTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMesaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMesaMesero;
        private app_escritorio.UI.RLabel lblMesaTitle;
        private System.Windows.Forms.Panel spacer2;
        private System.Windows.Forms.TableLayoutPanel rowCharts;
        private app_escritorio.UI.RPanel chartCard;
        private app_escritorio.UI.RBarChart chart;
        private app_escritorio.UI.RLabel lblChartNote;
        private app_escritorio.UI.RLabel lblChartTitle;
        private app_escritorio.UI.RPanel topCard;
        private app_escritorio.UI.RDataGridView gridTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopPlato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopTotal;
        private app_escritorio.UI.RLabel lblTopTitle;
        private System.Windows.Forms.Panel spacer1;
        private System.Windows.Forms.TableLayoutPanel kpis;
        private app_escritorio.UI.RPanel kpiTotal;
        private app_escritorio.UI.RLabel lblTotalSub;
        private app_escritorio.UI.RLabel lblTotal;
        private app_escritorio.UI.RLabel lblTotalCaption;
        private app_escritorio.UI.RPanel kpiTicket;
        private app_escritorio.UI.RLabel lblTicketSub;
        private app_escritorio.UI.RLabel lblTicket;
        private app_escritorio.UI.RLabel lblTicketCaption;
        private app_escritorio.UI.RPanel kpiTax;
        private app_escritorio.UI.RLabel lblTaxSub;
        private app_escritorio.UI.RLabel lblTax;
        private app_escritorio.UI.RLabel lblTaxCaption;
        private app_escritorio.UI.RPanel kpiMetodo;
        private app_escritorio.UI.RLabel lblMetodoSub;
        private app_escritorio.UI.RLabel lblMetodo;
        private app_escritorio.UI.RLabel lblMetodoCaption;
        private System.Windows.Forms.Panel spacer0;
        private app_escritorio.UI.RPanel header;
        private app_escritorio.UI.RButton btnRefresh;
        private app_escritorio.UI.RComboBox cmbOrigen;
        private app_escritorio.UI.RComboBox cmbPeriodo;
        private app_escritorio.UI.RBadge badgeDemo;
        private app_escritorio.UI.RBadge badgeAdmin;
        private app_escritorio.UI.RLabel lblTitle;
        private app_escritorio.Shell.ShellTopBar topBar;
        private app_escritorio.Shell.ShellSidebar sidebar;
    }
}
