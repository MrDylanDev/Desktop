namespace app_escritorio.Forms
{
    partial class PosForm
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
            this.topBar = new app_escritorio.Shell.ShellTopBar();
            this.sidebar = new app_escritorio.Shell.ShellSidebar();
            this.leftLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new app_escritorio.UI.RTextBox();
            this.cmbCategory = new app_escritorio.UI.RComboBox();
            this.flowProducts = new app_escritorio.UI.RFlowPanel();
            this.cardShortcuts = new app_escritorio.UI.RPanel();
            this.lblShortcuts = new app_escritorio.UI.RLabel();
            this.splitter = new System.Windows.Forms.Splitter();
            this.ticketPanel = new app_escritorio.UI.RPanel();
            this.ticketLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.lblMesa = new app_escritorio.UI.RLabel();
            this.pnlTipo = new System.Windows.Forms.Panel();
            this.lblTipo = new app_escritorio.UI.RLabel();
            this.cmbTipo = new app_escritorio.UI.RComboBox();
            this.lblDestinoTitle = new app_escritorio.UI.RLabel();
            this.lblDestino = new app_escritorio.UI.RLabel();
            this.pnlDomicilio = new System.Windows.Forms.Panel();
            this.lblDomHeader = new app_escritorio.UI.RLabel();
            this.txtCliente = new app_escritorio.UI.RTextBox();
            this.txtTelefono = new app_escritorio.UI.RTextBox();
            this.txtDireccion = new app_escritorio.UI.RTextBox();
            this.badgeDelivery = new app_escritorio.UI.RBadge();
            this.flowTicket = new app_escritorio.UI.RFlowPanel();
            this.lblEmpty = new app_escritorio.UI.RLabel();
            this.totalsPanel = new System.Windows.Forms.Panel();
            this.lblTaxTitle = new app_escritorio.UI.RLabel();
            this.cmbTax = new app_escritorio.UI.RComboBox();
            this.lblSubtotalTitle = new app_escritorio.UI.RLabel();
            this.lblSubtotal = new app_escritorio.UI.RLabel();
            this.lblTaxLabel = new app_escritorio.UI.RLabel();
            this.lblTax = new app_escritorio.UI.RLabel();
            this.lblTotalTitle = new app_escritorio.UI.RLabel();
            this.lblTotal = new app_escritorio.UI.RLabel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.btnCobrar = new app_escritorio.UI.RButton();
            this.btnVaciar = new app_escritorio.UI.RButton();
            this.root.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.cardShortcuts.SuspendLayout();
            this.ticketPanel.SuspendLayout();
            this.ticketLayout.SuspendLayout();
            this.headerFlow.SuspendLayout();
            this.pnlTipo.SuspendLayout();
            this.pnlDomicilio.SuspendLayout();
            this.flowTicket.SuspendLayout();
            this.totalsPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.leftLayout);
            this.root.Controls.Add(this.splitter);
            this.root.Controls.Add(this.ticketPanel);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(272, 64);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(16);
            this.root.Size = new System.Drawing.Size(1100, 780);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // leftLayout
            // 
            this.leftLayout.ColumnCount = 1;
            this.leftLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftLayout.Controls.Add(this.txtSearch, 0, 0);
            this.leftLayout.Controls.Add(this.cmbCategory, 0, 1);
            this.leftLayout.Controls.Add(this.flowProducts, 0, 2);
            this.leftLayout.Controls.Add(this.cardShortcuts, 0, 3);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLayout.Location = new System.Drawing.Point(16, 16);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.RowCount = 4;
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.leftLayout.Size = new System.Drawing.Size(660, 748);
            this.leftLayout.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Buscar plato o producto...";
            this.txtSearch.Size = new System.Drawing.Size(660, 42);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.cmbCategory.Items.AddRange(new object[] {
            "Todos",
            "Pizzas y pastas",
            "Carnes y parrilla",
            "Hamburguesas",
            "Bebidas",
            "Postres y café"});
            this.cmbCategory.Location = new System.Drawing.Point(0, 54);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(660, 32);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.CmbCategory_SelectedIndexChanged);
            // 
            // flowProducts
            // 
            this.flowProducts.AutoScroll = true;
            this.flowProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowProducts.Location = new System.Drawing.Point(0, 100);
            this.flowProducts.Margin = new System.Windows.Forms.Padding(0);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Size = new System.Drawing.Size(660, 590);
            this.flowProducts.TabIndex = 2;
            // 
            // cardShortcuts
            // 
            this.cardShortcuts.Controls.Add(this.lblShortcuts);
            this.cardShortcuts.CornerRadius = 10;
            this.cardShortcuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardShortcuts.Location = new System.Drawing.Point(0, 702);
            this.cardShortcuts.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.cardShortcuts.Name = "cardShortcuts";
            this.cardShortcuts.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.cardShortcuts.Size = new System.Drawing.Size(660, 46);
            this.cardShortcuts.TabIndex = 3;
            // 
            // lblShortcuts
            // 
            this.lblShortcuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShortcuts.Location = new System.Drawing.Point(12, 0);
            this.lblShortcuts.Name = "lblShortcuts";
            this.lblShortcuts.Size = new System.Drawing.Size(636, 46);
            this.lblShortcuts.TabIndex = 0;
            this.lblShortcuts.Text = "Atajos: F1 POS · F2 Mesas · F3 Cocina · ESC Cerrar cobro";
            this.lblShortcuts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShortcuts.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(676, 16);
            this.splitter.MinExtra = 320;
            this.splitter.MinSize = 320;
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(8, 748);
            this.splitter.TabIndex = 1;
            this.splitter.TabStop = false;
            // 
            // ticketPanel
            // 
            this.ticketPanel.Controls.Add(this.ticketLayout);
            this.ticketPanel.CornerRadius = 14;
            this.ticketPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ticketPanel.Location = new System.Drawing.Point(684, 16);
            this.ticketPanel.MaximumSize = new System.Drawing.Size(520, 0);
            this.ticketPanel.MinimumSize = new System.Drawing.Size(340, 0);
            this.ticketPanel.Name = "ticketPanel";
            this.ticketPanel.Padding = new System.Windows.Forms.Padding(16);
            this.ticketPanel.Size = new System.Drawing.Size(400, 748);
            this.ticketPanel.Surface = app_escritorio.UI.SurfaceLevel.Lowest;
            this.ticketPanel.TabIndex = 2;
            // 
            // ticketLayout
            // 
            this.ticketLayout.ColumnCount = 1;
            this.ticketLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ticketLayout.Controls.Add(this.headerFlow, 0, 0);
            this.ticketLayout.Controls.Add(this.flowTicket, 0, 1);
            this.ticketLayout.Controls.Add(this.totalsPanel, 0, 2);
            this.ticketLayout.Controls.Add(this.buttonsPanel, 0, 3);
            this.ticketLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketLayout.Location = new System.Drawing.Point(16, 16);
            this.ticketLayout.Name = "ticketLayout";
            this.ticketLayout.RowCount = 4;
            this.ticketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.ticketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ticketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ticketLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.ticketLayout.Size = new System.Drawing.Size(368, 716);
            this.ticketLayout.TabIndex = 0;
            // 
            // headerFlow
            // 
            this.headerFlow.AutoSize = true;
            this.headerFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headerFlow.Controls.Add(this.lblTitle);
            this.headerFlow.Controls.Add(this.lblMesa);
            this.headerFlow.Controls.Add(this.pnlTipo);
            this.headerFlow.Controls.Add(this.pnlDomicilio);
            this.headerFlow.Controls.Add(this.badgeDelivery);
            this.headerFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.headerFlow.Location = new System.Drawing.Point(0, 0);
            this.headerFlow.Margin = new System.Windows.Forms.Padding(0);
            this.headerFlow.Name = "headerFlow";
            this.headerFlow.Size = new System.Drawing.Size(368, 250);
            this.headerFlow.TabIndex = 0;
            this.headerFlow.WrapContents = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pedido actual";
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Title;
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(0, 30);
            this.lblMesa.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.TabIndex = 1;
            this.lblMesa.Text = "Mesa no seleccionada";
            this.lblMesa.TextStyle = app_escritorio.UI.TextStyle.Accent;
            // 
            // pnlTipo
            // 
            this.pnlTipo.Controls.Add(this.lblDestino);
            this.pnlTipo.Controls.Add(this.lblDestinoTitle);
            this.pnlTipo.Controls.Add(this.cmbTipo);
            this.pnlTipo.Controls.Add(this.lblTipo);
            this.pnlTipo.Location = new System.Drawing.Point(0, 60);
            this.pnlTipo.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pnlTipo.Name = "pnlTipo";
            this.pnlTipo.Size = new System.Drawing.Size(368, 58);
            this.pnlTipo.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(0, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(178, 16);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Location = new System.Drawing.Point(0, 20);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(178, 32);
            this.cmbTipo.TabIndex = 1;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.CmbTipo_SelectedIndexChanged);
            // 
            // lblDestinoTitle
            // 
            this.lblDestinoTitle.Location = new System.Drawing.Point(190, 0);
            this.lblDestinoTitle.Name = "lblDestinoTitle";
            this.lblDestinoTitle.Size = new System.Drawing.Size(178, 16);
            this.lblDestinoTitle.TabIndex = 2;
            this.lblDestinoTitle.Text = "Mesa / Destino";
            this.lblDestinoTitle.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoEllipsis = true;
            this.lblDestino.Location = new System.Drawing.Point(190, 20);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(178, 32);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "—";
            this.lblDestino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDestino.TextStyle = app_escritorio.UI.TextStyle.BodyBold;
            // 
            // pnlDomicilio
            // 
            this.pnlDomicilio.Controls.Add(this.txtDireccion);
            this.pnlDomicilio.Controls.Add(this.txtTelefono);
            this.pnlDomicilio.Controls.Add(this.txtCliente);
            this.pnlDomicilio.Controls.Add(this.lblDomHeader);
            this.pnlDomicilio.Location = new System.Drawing.Point(0, 126);
            this.pnlDomicilio.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlDomicilio.Name = "pnlDomicilio";
            this.pnlDomicilio.Size = new System.Drawing.Size(368, 102);
            this.pnlDomicilio.TabIndex = 3;
            // 
            // lblDomHeader
            // 
            this.lblDomHeader.Location = new System.Drawing.Point(0, 0);
            this.lblDomHeader.Name = "lblDomHeader";
            this.lblDomHeader.Size = new System.Drawing.Size(368, 16);
            this.lblDomHeader.TabIndex = 0;
            this.lblDomHeader.Text = "Datos domicilio propio (solo si Delivery activo)";
            this.lblDomHeader.TextStyle = app_escritorio.UI.TextStyle.Overline;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(0, 22);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PlaceholderText = "Cliente";
            this.txtCliente.Size = new System.Drawing.Size(181, 34);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextChanged += new System.EventHandler(this.TxtDomicilio_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(187, 22);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Teléfono";
            this.txtTelefono.Size = new System.Drawing.Size(181, 34);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(0, 62);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Dirección domicilio...";
            this.txtDireccion.Size = new System.Drawing.Size(368, 34);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.TextChanged += new System.EventHandler(this.TxtDomicilio_TextChanged);
            // 
            // badgeDelivery
            // 
            this.badgeDelivery.Kind = app_escritorio.UI.BadgeKind.Accent;
            this.badgeDelivery.Location = new System.Drawing.Point(0, 234);
            this.badgeDelivery.Margin = new System.Windows.Forms.Padding(0, 6, 0, 8);
            this.badgeDelivery.Name = "badgeDelivery";
            this.badgeDelivery.Size = new System.Drawing.Size(368, 24);
            this.badgeDelivery.TabIndex = 4;
            this.badgeDelivery.Text = "◎ Delivery activo — domicilio opcional";
            // 
            // flowTicket
            // 
            this.flowTicket.AutoScroll = true;
            this.flowTicket.Controls.Add(this.lblEmpty);
            this.flowTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTicket.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTicket.Location = new System.Drawing.Point(0, 262);
            this.flowTicket.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowTicket.Name = "flowTicket";
            this.flowTicket.Size = new System.Drawing.Size(368, 200);
            this.flowTicket.Surface = app_escritorio.UI.SurfaceLevel.Lowest;
            this.flowTicket.TabIndex = 1;
            this.flowTicket.WrapContents = false;
            this.flowTicket.Resize += new System.EventHandler(this.FlowTicket_Resize);
            // 
            // lblEmpty
            // 
            this.lblEmpty.Location = new System.Drawing.Point(0, 0);
            this.lblEmpty.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(360, 40);
            this.lblEmpty.TabIndex = 0;
            this.lblEmpty.Text = "Toca un producto para agregarlo al pedido.";
            this.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmpty.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // totalsPanel
            // 
            this.totalsPanel.Controls.Add(this.lblTotal);
            this.totalsPanel.Controls.Add(this.lblTotalTitle);
            this.totalsPanel.Controls.Add(this.lblTax);
            this.totalsPanel.Controls.Add(this.lblTaxLabel);
            this.totalsPanel.Controls.Add(this.lblSubtotal);
            this.totalsPanel.Controls.Add(this.lblSubtotalTitle);
            this.totalsPanel.Controls.Add(this.cmbTax);
            this.totalsPanel.Controls.Add(this.lblTaxTitle);
            this.totalsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalsPanel.Location = new System.Drawing.Point(0, 462);
            this.totalsPanel.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.totalsPanel.Name = "totalsPanel";
            this.totalsPanel.Size = new System.Drawing.Size(368, 138);
            this.totalsPanel.TabIndex = 2;
            // 
            // lblTaxTitle
            // 
            this.lblTaxTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTaxTitle.Name = "lblTaxTitle";
            this.lblTaxTitle.Size = new System.Drawing.Size(200, 16);
            this.lblTaxTitle.TabIndex = 0;
            this.lblTaxTitle.Text = "Impuesto configurable";
            this.lblTaxTitle.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // cmbTax
            // 
            this.cmbTax.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.cmbTax.Items.AddRange(new object[] {
            "Exento — 0%",
            "INC — 8%",
            "IVA — 19%"});
            this.cmbTax.Location = new System.Drawing.Point(0, 20);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(368, 32);
            this.cmbTax.TabIndex = 1;
            this.cmbTax.SelectedIndexChanged += new System.EventHandler(this.CmbTax_SelectedIndexChanged);
            // 
            // lblSubtotalTitle
            // 
            this.lblSubtotalTitle.Location = new System.Drawing.Point(0, 64);
            this.lblSubtotalTitle.Name = "lblSubtotalTitle";
            this.lblSubtotalTitle.Size = new System.Drawing.Size(150, 20);
            this.lblSubtotalTitle.TabIndex = 2;
            this.lblSubtotalTitle.Text = "Subtotal";
            this.lblSubtotalTitle.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblSubtotal.Location = new System.Drawing.Point(168, 64);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(200, 20);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.Text = "$ 0";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSubtotal.TextStyle = app_escritorio.UI.TextStyle.Body;
            // 
            // lblTaxLabel
            // 
            this.lblTaxLabel.Location = new System.Drawing.Point(0, 88);
            this.lblTaxLabel.Name = "lblTaxLabel";
            this.lblTaxLabel.Size = new System.Drawing.Size(150, 20);
            this.lblTaxLabel.TabIndex = 4;
            this.lblTaxLabel.Text = "Impuesto (8%)";
            this.lblTaxLabel.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblTax
            // 
            this.lblTax.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblTax.Location = new System.Drawing.Point(168, 88);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(200, 20);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "$ 0";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTax.TextStyle = app_escritorio.UI.TextStyle.Body;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.Location = new System.Drawing.Point(0, 112);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(150, 26);
            this.lblTotalTitle.TabIndex = 6;
            this.lblTotalTitle.Text = "Total";
            this.lblTotalTitle.TextStyle = app_escritorio.UI.TextStyle.Total;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblTotal.Location = new System.Drawing.Point(148, 112);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(220, 26);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "$ 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.TextStyle = app_escritorio.UI.TextStyle.Total;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.btnVaciar);
            this.buttonsPanel.Controls.Add(this.btnCobrar);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 612);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(368, 104);
            this.buttonsPanel.TabIndex = 3;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.btnCobrar.Location = new System.Drawing.Point(0, 4);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(368, 54);
            this.btnCobrar.TabIndex = 0;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnCobrar.Click += new System.EventHandler(this.BtnCobrar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.btnVaciar.Location = new System.Drawing.Point(0, 66);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(368, 38);
            this.btnVaciar.TabIndex = 1;
            this.btnVaciar.Text = "Vaciar pedido";
            this.btnVaciar.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnVaciar.Click += new System.EventHandler(this.BtnVaciar_Click);
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(272, 0);
            this.topBar.Name = "topBar";
            this.topBar.RoleText = "Administrador";
            this.topBar.RouteText = "POS";
            this.topBar.Size = new System.Drawing.Size(1100, 64);
            this.topBar.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.ActiveRoute = "pos";
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(272, 844);
            this.sidebar.TabIndex = 2;
            // 
            // PosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1372, 844);
            this.Controls.Add(this.root);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sidebar);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "PosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestoOS - Modular Core";
            this.buttonsPanel.ResumeLayout(false);
            this.totalsPanel.ResumeLayout(false);
            this.flowTicket.ResumeLayout(false);
            this.flowTicket.PerformLayout();
            this.pnlDomicilio.ResumeLayout(false);
            this.pnlTipo.ResumeLayout(false);
            this.headerFlow.ResumeLayout(false);
            this.headerFlow.PerformLayout();
            this.ticketLayout.ResumeLayout(false);
            this.ticketLayout.PerformLayout();
            this.ticketPanel.ResumeLayout(false);
            this.cardShortcuts.ResumeLayout(false);
            this.leftLayout.ResumeLayout(false);
            this.leftLayout.PerformLayout();
            this.root.ResumeLayout(false);
            this.root.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private app_escritorio.Shell.ShellTopBar topBar;
        private app_escritorio.Shell.ShellSidebar sidebar;
        private System.Windows.Forms.TableLayoutPanel leftLayout;
        private app_escritorio.UI.RTextBox txtSearch;
        private app_escritorio.UI.RComboBox cmbCategory;
        private app_escritorio.UI.RFlowPanel flowProducts;
        private app_escritorio.UI.RPanel cardShortcuts;
        private app_escritorio.UI.RLabel lblShortcuts;
        private System.Windows.Forms.Splitter splitter;
        private app_escritorio.UI.RPanel ticketPanel;
        private System.Windows.Forms.TableLayoutPanel ticketLayout;
        private System.Windows.Forms.FlowLayoutPanel headerFlow;
        private app_escritorio.UI.RLabel lblTitle;
        private app_escritorio.UI.RLabel lblMesa;
        private System.Windows.Forms.Panel pnlTipo;
        private app_escritorio.UI.RLabel lblTipo;
        private app_escritorio.UI.RComboBox cmbTipo;
        private app_escritorio.UI.RLabel lblDestinoTitle;
        private app_escritorio.UI.RLabel lblDestino;
        private System.Windows.Forms.Panel pnlDomicilio;
        private app_escritorio.UI.RLabel lblDomHeader;
        private app_escritorio.UI.RTextBox txtCliente;
        private app_escritorio.UI.RTextBox txtTelefono;
        private app_escritorio.UI.RTextBox txtDireccion;
        private app_escritorio.UI.RBadge badgeDelivery;
        private app_escritorio.UI.RFlowPanel flowTicket;
        private app_escritorio.UI.RLabel lblEmpty;
        private System.Windows.Forms.Panel totalsPanel;
        private app_escritorio.UI.RLabel lblTaxTitle;
        private app_escritorio.UI.RComboBox cmbTax;
        private app_escritorio.UI.RLabel lblSubtotalTitle;
        private app_escritorio.UI.RLabel lblSubtotal;
        private app_escritorio.UI.RLabel lblTaxLabel;
        private app_escritorio.UI.RLabel lblTax;
        private app_escritorio.UI.RLabel lblTotalTitle;
        private app_escritorio.UI.RLabel lblTotal;
        private System.Windows.Forms.Panel buttonsPanel;
        private app_escritorio.UI.RButton btnCobrar;
        private app_escritorio.UI.RButton btnVaciar;
    }
}
