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
            this.root = new app_escritorio.UI.RPanel();
            this.lblFootnote = new app_escritorio.UI.RLabel();
            this.spacer4 = new System.Windows.Forms.Panel();
            this.histCard = new app_escritorio.UI.RPanel();
            this.gridHist = new app_escritorio.UI.RDataGridView();
            this.colHFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHMetodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHCajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.histFilters = new app_escritorio.UI.RPanel();
            this.cmbEstado = new app_escritorio.UI.RComboBox();
            this.cmbMetodo = new app_escritorio.UI.RComboBox();
            this.txtHistSearch = new app_escritorio.UI.RTextBox();
            this.histHead = new app_escritorio.UI.RPanel();
            this.lblRango = new app_escritorio.UI.RLabel();
            this.lblHistTitle = new app_escritorio.UI.RLabel();
            this.spacer3 = new System.Windows.Forms.Panel();
            this.mesaCard = new app_escritorio.UI.RPanel();
            this.gridMesa = new app_escritorio.UI.RDataGridView();
            this.colMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMesaTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMesaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMesaMesero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMesaTitle = new app_escritorio.UI.RLabel();
            this.spacer2 = new System.Windows.Forms.Panel();
            this.rowCharts = new System.Windows.Forms.TableLayoutPanel();
            this.chartCard = new app_escritorio.UI.RPanel();
            this.chart = new app_escritorio.UI.RBarChart();
            this.lblChartNote = new app_escritorio.UI.RLabel();
            this.lblChartTitle = new app_escritorio.UI.RLabel();
            this.topCard = new app_escritorio.UI.RPanel();
            this.gridTop = new app_escritorio.UI.RDataGridView();
            this.colTopRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTopPlato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTopCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTopTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTopTitle = new app_escritorio.UI.RLabel();
            this.spacer1 = new System.Windows.Forms.Panel();
            this.kpis = new System.Windows.Forms.TableLayoutPanel();
            this.kpiTotal = new app_escritorio.UI.RPanel();
            this.lblTotalSub = new app_escritorio.UI.RLabel();
            this.lblTotal = new app_escritorio.UI.RLabel();
            this.lblTotalCaption = new app_escritorio.UI.RLabel();
            this.kpiTicket = new app_escritorio.UI.RPanel();
            this.lblTicketSub = new app_escritorio.UI.RLabel();
            this.lblTicket = new app_escritorio.UI.RLabel();
            this.lblTicketCaption = new app_escritorio.UI.RLabel();
            this.kpiTax = new app_escritorio.UI.RPanel();
            this.lblTaxSub = new app_escritorio.UI.RLabel();
            this.lblTax = new app_escritorio.UI.RLabel();
            this.lblTaxCaption = new app_escritorio.UI.RLabel();
            this.kpiMetodo = new app_escritorio.UI.RPanel();
            this.lblMetodoSub = new app_escritorio.UI.RLabel();
            this.lblMetodo = new app_escritorio.UI.RLabel();
            this.lblMetodoCaption = new app_escritorio.UI.RLabel();
            this.spacer0 = new System.Windows.Forms.Panel();
            this.header = new app_escritorio.UI.RPanel();
            this.btnRefresh = new app_escritorio.UI.RButton();
            this.cmbOrigen = new app_escritorio.UI.RComboBox();
            this.cmbPeriodo = new app_escritorio.UI.RComboBox();
            this.badgeDemo = new app_escritorio.UI.RBadge();
            this.badgeAdmin = new app_escritorio.UI.RBadge();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.topBar = new app_escritorio.Shell.ShellTopBar();
            this.sidebar = new app_escritorio.Shell.ShellSidebar();
            this.root.SuspendLayout();
            this.histCard.SuspendLayout();
            this.histFilters.SuspendLayout();
            this.histHead.SuspendLayout();
            this.mesaCard.SuspendLayout();
            this.rowCharts.SuspendLayout();
            this.chartCard.SuspendLayout();
            this.topCard.SuspendLayout();
            this.kpis.SuspendLayout();
            this.kpiTotal.SuspendLayout();
            this.kpiTicket.SuspendLayout();
            this.kpiTax.SuspendLayout();
            this.kpiMetodo.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTop)).BeginInit();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.lblFootnote);
            this.root.Controls.Add(this.spacer4);
            this.root.Controls.Add(this.histCard);
            this.root.Controls.Add(this.spacer3);
            this.root.Controls.Add(this.mesaCard);
            this.root.Controls.Add(this.spacer2);
            this.root.Controls.Add(this.rowCharts);
            this.root.Controls.Add(this.spacer1);
            this.root.Controls.Add(this.kpis);
            this.root.Controls.Add(this.spacer0);
            this.root.Controls.Add(this.header);
            this.root.AutoScroll = true;
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(272, 64);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(24);
            this.root.Size = new System.Drawing.Size(1100, 780);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // lblFootnote
            // 
            this.lblFootnote.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFootnote.Location = new System.Drawing.Point(0, 0);
            this.lblFootnote.Name = "lblFootnote";
            this.lblFootnote.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.lblFootnote.Size = new System.Drawing.Size(1052, 56);
            this.lblFootnote.TabIndex = 5;
            this.lblFootnote.Text = "* Reportes unifica salón + delivery (simulado). Historial trazable (qué se vendió por mesa/método/cajero) integrado en el mismo panel Solo Admin. Exportar CSV y arqueo por turno quedan para Fase 2 con SQLite.";
            this.lblFootnote.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // spacer4
            // 
            this.spacer4.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer4.Name = "spacer4";
            this.spacer4.Size = new System.Drawing.Size(1052, 16);
            this.spacer4.TabIndex = 0;
            // 
            // histCard
            // 
            this.histCard.Controls.Add(this.gridHist);
            this.histCard.Controls.Add(this.histFilters);
            this.histCard.Controls.Add(this.histHead);
            this.histCard.CornerRadius = 14;
            this.histCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.histCard.Name = "histCard";
            this.histCard.Padding = new System.Windows.Forms.Padding(20);
            this.histCard.Size = new System.Drawing.Size(1052, 440);
            this.histCard.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.histCard.TabIndex = 4;
            // 
            // gridHist
            // 
            this.gridHist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHFecha,
            this.colHMesa,
            this.colHDetalle,
            this.colHTotal,
            this.colHMetodo,
            this.colHCajero,
            this.colHEstado,
            this.colHVer});
            this.gridHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHist.Location = new System.Drawing.Point(20, 112);
            this.gridHist.Name = "gridHist";
            this.gridHist.Size = new System.Drawing.Size(1012, 308);
            this.gridHist.TabIndex = 2;
            this.gridHist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridHist_CellClick);
            // 
            // colHFecha
            // 
            this.colHFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHFecha.HeaderText = "Fecha";
            this.colHFecha.Name = "colHFecha";
            this.colHFecha.Width = 96;
            // 
            // colHMesa
            // 
            this.colHMesa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHMesa.HeaderText = "Mesa";
            this.colHMesa.Name = "colHMesa";
            this.colHMesa.Width = 90;
            // 
            // colHDetalle
            // 
            this.colHDetalle.FillWeight = 300F;
            this.colHDetalle.HeaderText = "Qué se vendió";
            this.colHDetalle.Name = "colHDetalle";
            // 
            // colHTotal
            // 
            this.colHTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHTotal.HeaderText = "Total";
            this.colHTotal.Name = "colHTotal";
            this.colHTotal.Width = 96;
            // 
            // colHMetodo
            // 
            this.colHMetodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHMetodo.HeaderText = "Método";
            this.colHMetodo.Name = "colHMetodo";
            this.colHMetodo.Width = 86;
            // 
            // colHCajero
            // 
            this.colHCajero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHCajero.HeaderText = "Cajero";
            this.colHCajero.Name = "colHCajero";
            this.colHCajero.Width = 86;
            // 
            // colHEstado
            // 
            this.colHEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHEstado.HeaderText = "Estado";
            this.colHEstado.Name = "colHEstado";
            this.colHEstado.Tag = "chip";
            this.colHEstado.Width = 96;
            // 
            // colHVer
            // 
            this.colHVer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHVer.HeaderText = "";
            this.colHVer.Name = "colHVer";
            this.colHVer.Tag = "";
            this.colHVer.Text = "Ver";
            this.colHVer.UseColumnTextForButtonValue = true;
            this.colHVer.Width = 64;
            // 
            // histFilters
            // 
            this.histFilters.Controls.Add(this.cmbEstado);
            this.histFilters.Controls.Add(this.cmbMetodo);
            this.histFilters.Controls.Add(this.txtHistSearch);
            this.histFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.histFilters.Location = new System.Drawing.Point(20, 60);
            this.histFilters.Name = "histFilters";
            this.histFilters.Size = new System.Drawing.Size(1012, 52);
            this.histFilters.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.histFilters.TabIndex = 1;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Items.AddRange(new object[] {
            "Todos",
            "Cobrado",
            "Anulado"});
            this.cmbEstado.Location = new System.Drawing.Point(478, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(150, 32);
            this.cmbEstado.TabIndex = 2;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.Hist_Changed);
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.Items.AddRange(new object[] {
            "Todos",
            "Efectivo",
            "Tarjeta"});
            this.cmbMetodo.Location = new System.Drawing.Point(316, 4);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(150, 32);
            this.cmbMetodo.TabIndex = 1;
            this.cmbMetodo.SelectedIndexChanged += new System.EventHandler(this.Hist_Changed);
            // 
            // txtHistSearch
            // 
            this.txtHistSearch.Location = new System.Drawing.Point(0, 0);
            this.txtHistSearch.Name = "txtHistSearch";
            this.txtHistSearch.PlaceholderText = "Buscar mesa, producto, cajero...";
            this.txtHistSearch.Size = new System.Drawing.Size(300, 40);
            this.txtHistSearch.TabIndex = 0;
            this.txtHistSearch.TextChanged += new System.EventHandler(this.Hist_Changed);
            // 
            // histHead
            // 
            this.histHead.Controls.Add(this.lblRango);
            this.histHead.Controls.Add(this.lblHistTitle);
            this.histHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.histHead.Location = new System.Drawing.Point(20, 20);
            this.histHead.Name = "histHead";
            this.histHead.Size = new System.Drawing.Size(1012, 40);
            this.histHead.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.histHead.TabIndex = 0;
            // 
            // lblRango
            // 
            this.lblRango.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblRango.Location = new System.Drawing.Point(632, 4);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(380, 28);
            this.lblRango.TabIndex = 1;
            this.lblRango.Text = "Hoy: $0 · 0 ventas";
            this.lblRango.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRango.TextStyle = app_escritorio.UI.TextStyle.AccentBold;
            // 
            // lblHistTitle
            // 
            this.lblHistTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHistTitle.Name = "lblHistTitle";
            this.lblHistTitle.Size = new System.Drawing.Size(620, 36);
            this.lblHistTitle.TabIndex = 0;
            this.lblHistTitle.Text = "Historial de cobros — qué se vendió (trazabilidad POS)";
            this.lblHistTitle.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // spacer3
            // 
            this.spacer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer3.Name = "spacer3";
            this.spacer3.Size = new System.Drawing.Size(1052, 16);
            this.spacer3.TabIndex = 0;
            // 
            // mesaCard
            // 
            this.mesaCard.Controls.Add(this.gridMesa);
            this.mesaCard.Controls.Add(this.lblMesaTitle);
            this.mesaCard.CornerRadius = 14;
            this.mesaCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.mesaCard.Name = "mesaCard";
            this.mesaCard.Padding = new System.Windows.Forms.Padding(20);
            this.mesaCard.Size = new System.Drawing.Size(1052, 250);
            this.mesaCard.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.mesaCard.TabIndex = 3;
            // 
            // gridMesa
            // 
            this.gridMesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMesa,
            this.colMesaTickets,
            this.colMesaTotal,
            this.colMesaMesero});
            this.gridMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMesa.Location = new System.Drawing.Point(20, 56);
            this.gridMesa.Name = "gridMesa";
            this.gridMesa.Size = new System.Drawing.Size(1012, 174);
            this.gridMesa.TabIndex = 1;
            // 
            // colMesa
            // 
            this.colMesa.FillWeight = 150F;
            this.colMesa.HeaderText = "Mesa";
            this.colMesa.Name = "colMesa";
            // 
            // colMesaTickets
            // 
            this.colMesaTickets.FillWeight = 100F;
            this.colMesaTickets.HeaderText = "Tickets";
            this.colMesaTickets.Name = "colMesaTickets";
            // 
            // colMesaTotal
            // 
            this.colMesaTotal.FillWeight = 150F;
            this.colMesaTotal.HeaderText = "Total";
            this.colMesaTotal.Name = "colMesaTotal";
            // 
            // colMesaMesero
            // 
            this.colMesaMesero.FillWeight = 150F;
            this.colMesaMesero.HeaderText = "Mesero";
            this.colMesaMesero.Name = "colMesaMesero";
            // 
            // lblMesaTitle
            // 
            this.lblMesaTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMesaTitle.Location = new System.Drawing.Point(0, 0);
            this.lblMesaTitle.Name = "lblMesaTitle";
            this.lblMesaTitle.Size = new System.Drawing.Size(1012, 36);
            this.lblMesaTitle.TabIndex = 0;
            this.lblMesaTitle.Text = "Ventas por mesa";
            this.lblMesaTitle.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // spacer2
            // 
            this.spacer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer2.Name = "spacer2";
            this.spacer2.Size = new System.Drawing.Size(1052, 16);
            this.spacer2.TabIndex = 0;
            // 
            // rowCharts
            // 
            this.rowCharts.ColumnCount = 2;
            this.rowCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0F));
            this.rowCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0F));
            this.rowCharts.Controls.Add(this.chartCard, 0, 0);
            this.rowCharts.Controls.Add(this.topCard, 1, 0);
            this.rowCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.rowCharts.Name = "rowCharts";
            this.rowCharts.RowCount = 1;
            this.rowCharts.Size = new System.Drawing.Size(1052, 300);
            this.rowCharts.TabIndex = 2;
            this.rowCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            // 
            // chartCard
            // 
            this.chartCard.Controls.Add(this.chart);
            this.chartCard.Controls.Add(this.lblChartNote);
            this.chartCard.Controls.Add(this.lblChartTitle);
            this.chartCard.CornerRadius = 14;
            this.chartCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCard.Location = new System.Drawing.Point(0, 0);
            this.chartCard.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.chartCard.Name = "chartCard";
            this.chartCard.Padding = new System.Windows.Forms.Padding(20);
            this.chartCard.Size = new System.Drawing.Size(628, 300);
            this.chartCard.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.chartCard.TabIndex = 0;
            // 
            // chart
            // 
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(20, 56);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(588, 204);
            this.chart.TabIndex = 1;
            // 
            // lblChartNote
            // 
            this.lblChartNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblChartNote.Location = new System.Drawing.Point(0, 0);
            this.lblChartNote.Name = "lblChartNote";
            this.lblChartNote.Size = new System.Drawing.Size(588, 22);
            this.lblChartNote.TabIndex = 2;
            this.lblChartNote.Text = "* Barras mock escala relativa al máximo del período";
            this.lblChartNote.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblChartNote.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChartTitle.Location = new System.Drawing.Point(0, 0);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(588, 36);
            this.lblChartTitle.TabIndex = 0;
            this.lblChartTitle.Text = "Ventas últimos 7 días";
            this.lblChartTitle.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // topCard
            // 
            this.topCard.Controls.Add(this.gridTop);
            this.topCard.Controls.Add(this.lblTopTitle);
            this.topCard.CornerRadius = 14;
            this.topCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topCard.Location = new System.Drawing.Point(640, 0);
            this.topCard.Margin = new System.Windows.Forms.Padding(0);
            this.topCard.Name = "topCard";
            this.topCard.Padding = new System.Windows.Forms.Padding(20);
            this.topCard.Size = new System.Drawing.Size(412, 300);
            this.topCard.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.topCard.TabIndex = 1;
            // 
            // gridTop
            // 
            this.gridTop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTopRank,
            this.colTopPlato,
            this.colTopCant,
            this.colTopTotal});
            this.gridTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTop.Location = new System.Drawing.Point(20, 56);
            this.gridTop.Name = "gridTop";
            this.gridTop.Size = new System.Drawing.Size(372, 224);
            this.gridTop.TabIndex = 1;
            // 
            // colTopRank
            // 
            this.colTopRank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTopRank.HeaderText = "#";
            this.colTopRank.Name = "colTopRank";
            this.colTopRank.Width = 36;
            // 
            // colTopPlato
            // 
            this.colTopPlato.FillWeight = 200F;
            this.colTopPlato.HeaderText = "Plato";
            this.colTopPlato.Name = "colTopPlato";
            // 
            // colTopCant
            // 
            this.colTopCant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTopCant.HeaderText = "Cant.";
            this.colTopCant.Name = "colTopCant";
            this.colTopCant.Width = 56;
            // 
            // colTopTotal
            // 
            this.colTopTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTopTotal.HeaderText = "Total";
            this.colTopTotal.Name = "colTopTotal";
            this.colTopTotal.Width = 96;
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTopTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(372, 36);
            this.lblTopTitle.TabIndex = 0;
            this.lblTopTitle.Text = "Top platos";
            this.lblTopTitle.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // spacer1
            // 
            this.spacer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(1052, 16);
            this.spacer1.TabIndex = 0;
            // 
            // kpis
            // 
            this.kpis.ColumnCount = 4;
            this.kpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F));
            this.kpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F));
            this.kpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F));
            this.kpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F));
            this.kpis.Controls.Add(this.kpiTotal, 0, 0);
            this.kpis.Controls.Add(this.kpiTicket, 1, 0);
            this.kpis.Controls.Add(this.kpiTax, 2, 0);
            this.kpis.Controls.Add(this.kpiMetodo, 3, 0);
            this.kpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpis.Name = "kpis";
            this.kpis.RowCount = 1;
            this.kpis.Size = new System.Drawing.Size(1052, 118);
            this.kpis.TabIndex = 1;
            this.kpis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            // 
            // kpiTotal
            // 
            this.kpiTotal.Controls.Add(this.lblTotalSub);
            this.kpiTotal.Controls.Add(this.lblTotal);
            this.kpiTotal.Controls.Add(this.lblTotalCaption);
            this.kpiTotal.CornerRadius = 14;
            this.kpiTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpiTotal.Location = new System.Drawing.Point(0, 0);
            this.kpiTotal.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.kpiTotal.Name = "kpiTotal";
            this.kpiTotal.Size = new System.Drawing.Size(254, 118);
            this.kpiTotal.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.kpiTotal.TabIndex = 0;
            // 
            // lblTotalSub
            // 
            this.lblTotalSub.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblTotalSub.Location = new System.Drawing.Point(18, 84);
            this.lblTotalSub.Name = "lblTotalSub";
            this.lblTotalSub.Size = new System.Drawing.Size(220, 18);
            this.lblTotalSub.TabIndex = 2;
            this.lblTotalSub.Text = "0 tickets";
            this.lblTotalSub.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblTotal.Location = new System.Drawing.Point(18, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(220, 40);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "$ 0";
            this.lblTotal.TextStyle = app_escritorio.UI.TextStyle.Title;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblTotalCaption.Location = new System.Drawing.Point(18, 16);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(220, 20);
            this.lblTotalCaption.TabIndex = 0;
            this.lblTotalCaption.Text = "Total ventas";
            this.lblTotalCaption.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // kpiTicket
            // 
            this.kpiTicket.Controls.Add(this.lblTicketSub);
            this.kpiTicket.Controls.Add(this.lblTicket);
            this.kpiTicket.Controls.Add(this.lblTicketCaption);
            this.kpiTicket.CornerRadius = 14;
            this.kpiTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpiTicket.Location = new System.Drawing.Point(0, 0);
            this.kpiTicket.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.kpiTicket.Name = "kpiTicket";
            this.kpiTicket.Size = new System.Drawing.Size(254, 118);
            this.kpiTicket.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.kpiTicket.TabIndex = 1;
            // 
            // lblTicketSub
            // 
            this.lblTicketSub.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblTicketSub.Location = new System.Drawing.Point(18, 84);
            this.lblTicketSub.Name = "lblTicketSub";
            this.lblTicketSub.Size = new System.Drawing.Size(220, 18);
            this.lblTicketSub.TabIndex = 2;
            this.lblTicketSub.Text = "por cuenta";
            this.lblTicketSub.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblTicket
            // 
            this.lblTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblTicket.Location = new System.Drawing.Point(18, 40);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(220, 40);
            this.lblTicket.TabIndex = 1;
            this.lblTicket.Text = "$ 0";
            this.lblTicket.TextStyle = app_escritorio.UI.TextStyle.Title;
            // 
            // lblTicketCaption
            // 
            this.lblTicketCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblTicketCaption.Location = new System.Drawing.Point(18, 16);
            this.lblTicketCaption.Name = "lblTicketCaption";
            this.lblTicketCaption.Size = new System.Drawing.Size(220, 20);
            this.lblTicketCaption.TabIndex = 0;
            this.lblTicketCaption.Text = "Ticket promedio";
            this.lblTicketCaption.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // kpiTax
            // 
            this.kpiTax.Controls.Add(this.lblTaxSub);
            this.kpiTax.Controls.Add(this.lblTax);
            this.kpiTax.Controls.Add(this.lblTaxCaption);
            this.kpiTax.CornerRadius = 14;
            this.kpiTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpiTax.Location = new System.Drawing.Point(0, 0);
            this.kpiTax.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.kpiTax.Name = "kpiTax";
            this.kpiTax.Size = new System.Drawing.Size(254, 118);
            this.kpiTax.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.kpiTax.TabIndex = 2;
            // 
            // lblTaxSub
            // 
            this.lblTaxSub.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblTaxSub.Location = new System.Drawing.Point(18, 84);
            this.lblTaxSub.Name = "lblTaxSub";
            this.lblTaxSub.Size = new System.Drawing.Size(220, 18);
            this.lblTaxSub.TabIndex = 2;
            this.lblTaxSub.Text = "INC 8% / IVA 19% unificado";
            this.lblTaxSub.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblTax
            // 
            this.lblTax.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblTax.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(95)))));
            this.lblTax.Location = new System.Drawing.Point(18, 40);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(220, 40);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "$ 0";
            this.lblTax.TextStyle = app_escritorio.UI.TextStyle.Title;
            // 
            // lblTaxCaption
            // 
            this.lblTaxCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblTaxCaption.Location = new System.Drawing.Point(18, 16);
            this.lblTaxCaption.Name = "lblTaxCaption";
            this.lblTaxCaption.Size = new System.Drawing.Size(220, 20);
            this.lblTaxCaption.TabIndex = 0;
            this.lblTaxCaption.Text = "Impuesto recaudado";
            this.lblTaxCaption.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // kpiMetodo
            // 
            this.kpiMetodo.Controls.Add(this.lblMetodoSub);
            this.kpiMetodo.Controls.Add(this.lblMetodo);
            this.kpiMetodo.Controls.Add(this.lblMetodoCaption);
            this.kpiMetodo.CornerRadius = 14;
            this.kpiMetodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpiMetodo.Location = new System.Drawing.Point(0, 0);
            this.kpiMetodo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.kpiMetodo.Name = "kpiMetodo";
            this.kpiMetodo.Size = new System.Drawing.Size(254, 118);
            this.kpiMetodo.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.kpiMetodo.TabIndex = 3;
            // 
            // lblMetodoSub
            // 
            this.lblMetodoSub.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblMetodoSub.Location = new System.Drawing.Point(18, 84);
            this.lblMetodoSub.Name = "lblMetodoSub";
            this.lblMetodoSub.Size = new System.Drawing.Size(220, 18);
            this.lblMetodoSub.TabIndex = 2;
            this.lblMetodoSub.Text = "salón + delivery (mock)";
            this.lblMetodoSub.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblMetodo
            // 
            this.lblMetodo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblMetodo.Location = new System.Drawing.Point(18, 40);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(220, 40);
            this.lblMetodo.TabIndex = 1;
            this.lblMetodo.Text = "$ 0 / $ 0";
            this.lblMetodo.TextStyle = app_escritorio.UI.TextStyle.Title;
            // 
            // lblMetodoCaption
            // 
            this.lblMetodoCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblMetodoCaption.Location = new System.Drawing.Point(18, 16);
            this.lblMetodoCaption.Name = "lblMetodoCaption";
            this.lblMetodoCaption.Size = new System.Drawing.Size(220, 20);
            this.lblMetodoCaption.TabIndex = 0;
            this.lblMetodoCaption.Text = "Efectivo / Tarjeta";
            this.lblMetodoCaption.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // spacer0
            // 
            this.spacer0.Dock = System.Windows.Forms.DockStyle.Top;
            this.spacer0.Name = "spacer0";
            this.spacer0.Size = new System.Drawing.Size(1052, 16);
            this.spacer0.TabIndex = 0;
            // 
            // header
            // 
            this.header.Controls.Add(this.btnRefresh);
            this.header.Controls.Add(this.cmbOrigen);
            this.header.Controls.Add(this.cmbPeriodo);
            this.header.Controls.Add(this.badgeDemo);
            this.header.Controls.Add(this.badgeAdmin);
            this.header.Controls.Add(this.lblTitle);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(24, 24);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1052, 60);
            this.header.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.header.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnRefresh.Location = new System.Drawing.Point(944, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 38);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "↻ Actualizar";
            this.btnRefresh.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.Items.AddRange(new object[] {
            "Todo (salón + delivery)",
            "Solo salón",
            "Solo delivery"});
            this.cmbOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.cmbOrigen.Location = new System.Drawing.Point(742, 13);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(190, 32);
            this.cmbOrigen.TabIndex = 4;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Items.AddRange(new object[] {
            "Hoy",
            "Últimos 7 días",
            "Últimos 30 días",
            "Este mes"});
            this.cmbPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.cmbPeriodo.Location = new System.Drawing.Point(560, 13);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(170, 32);
            this.cmbPeriodo.TabIndex = 3;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // badgeDemo
            // 
            this.badgeDemo.Kind = app_escritorio.UI.BadgeKind.Accent;
            this.badgeDemo.Location = new System.Drawing.Point(284, 18);
            this.badgeDemo.Name = "badgeDemo";
            this.badgeDemo.Size = new System.Drawing.Size(112, 24);
            this.badgeDemo.TabIndex = 2;
            this.badgeDemo.Text = "DEMO frontend";
            // 
            // badgeAdmin
            // 
            this.badgeAdmin.Kind = app_escritorio.UI.BadgeKind.Primary;
            this.badgeAdmin.Location = new System.Drawing.Point(180, 18);
            this.badgeAdmin.Name = "badgeAdmin";
            this.badgeAdmin.Size = new System.Drawing.Size(94, 24);
            this.badgeAdmin.TabIndex = 1;
            this.badgeAdmin.Text = "Solo Admin";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reportes";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Hero;
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(272, 0);
            this.topBar.Name = "topBar";
            this.topBar.RoleText = "Administrador";
            this.topBar.RouteText = "Reportes · Solo Admin";
            this.topBar.Size = new System.Drawing.Size(1100, 64);
            this.topBar.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.ActiveRoute = "reportes";
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(272, 844);
            this.sidebar.TabIndex = 2;
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1372, 844);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "ReportesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestoOS - Modular Core";
            this.Controls.Add(this.root);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sidebar);
            this.header.ResumeLayout(false);
            this.kpiMetodo.ResumeLayout(false);
            this.kpiTax.ResumeLayout(false);
            this.kpiTicket.ResumeLayout(false);
            this.kpiTotal.ResumeLayout(false);
            this.kpis.ResumeLayout(false);
            this.kpis.PerformLayout();
            this.topCard.ResumeLayout(false);
            this.chartCard.ResumeLayout(false);
            this.rowCharts.ResumeLayout(false);
            this.rowCharts.PerformLayout();
            this.mesaCard.ResumeLayout(false);
            this.histHead.ResumeLayout(false);
            this.histFilters.ResumeLayout(false);
            this.histCard.ResumeLayout(false);
            this.root.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTop)).EndInit();
            this.ResumeLayout(false);
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
