namespace app_escritorio.Forms
{
    partial class MenuForm
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
            this.statsBar = new app_escritorio.UI.RPanel();
            this.btnNuevo = new app_escritorio.UI.RButton();
            this.txtSearch = new app_escritorio.UI.RTextBox();
            this.chipChef = new app_escritorio.UI.RChip();
            this.chipAgotados = new app_escritorio.UI.RChip();
            this.chipDisponibles = new app_escritorio.UI.RChip();
            this.catBar = new app_escritorio.UI.RPanel();
            this.btnHistorial = new app_escritorio.UI.RButton();
            this.btnCategorias = new app_escritorio.UI.RButton();
            this.flowCategorias = new app_escritorio.UI.RFlowPanel();
            this.chipCatSample2 = new app_escritorio.UI.RChip();
            this.chipCatSample1 = new app_escritorio.UI.RChip();
            this.chipCatTodas = new app_escritorio.UI.RChip();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.flowDishes = new app_escritorio.UI.RFlowPanel();
            this.sampleCard2 = new app_escritorio.Views.Carta.DishCard();
            this.sampleCard1 = new app_escritorio.Views.Carta.DishCard();
            this.editorPanel = new app_escritorio.UI.RPanel();
            this.editorBottom = new System.Windows.Forms.Panel();
            this.lblEstado = new app_escritorio.UI.RLabel();
            this.btnEliminar = new app_escritorio.UI.RButton();
            this.btnDuplicar = new app_escritorio.UI.RButton();
            this.btnPublicar = new app_escritorio.UI.RButton();
            this.invCard = new app_escritorio.UI.RPanel();
            this.btnVincular = new app_escritorio.UI.RButton();
            this.flowInsumos = new app_escritorio.UI.RFlowPanel();
            this.sampleInsumo2 = new app_escritorio.Views.Carta.InsumoLinkRow();
            this.sampleInsumo1 = new app_escritorio.Views.Carta.InsumoLinkRow();
            this.lblInvHint = new app_escritorio.UI.RLabel();
            this.lblInvCount = new app_escritorio.UI.RLabel();
            this.lblInvTitle = new app_escritorio.UI.RLabel();
            this.lblStockHint = new app_escritorio.UI.RLabel();
            this.txtStock = new app_escritorio.UI.RTextBox();
            this.lblStock = new app_escritorio.UI.RLabel();
            this.tglLacteos = new app_escritorio.UI.RButton();
            this.tglGluten = new app_escritorio.UI.RButton();
            this.tglMasVendido = new app_escritorio.UI.RButton();
            this.tglSinLactosa = new app_escritorio.UI.RButton();
            this.tglChef = new app_escritorio.UI.RButton();
            this.tglPicante = new app_escritorio.UI.RButton();
            this.tglVegetariano = new app_escritorio.UI.RButton();
            this.tglSinTacc = new app_escritorio.UI.RButton();
            this.lblEtiquetas = new app_escritorio.UI.RLabel();
            this.txtDescripcion = new app_escritorio.UI.RTextBox();
            this.lblDescripcion = new app_escritorio.UI.RLabel();
            this.cardDelivery = new app_escritorio.UI.RPanel();
            this.chipCalcDelivery = new app_escritorio.UI.RChip();
            this.txtPrecioDelivery = new app_escritorio.UI.RTextBox();
            this.lblDeliveryCap = new app_escritorio.UI.RLabel();
            this.cardSalon = new app_escritorio.UI.RPanel();
            this.lblSalonHint = new app_escritorio.UI.RLabel();
            this.txtPrecioSalon = new app_escritorio.UI.RTextBox();
            this.lblSalonCap = new app_escritorio.UI.RLabel();
            this.swDisponible = new app_escritorio.UI.RSwitch();
            this.btnFoto = new app_escritorio.UI.RButton();
            this.imgPreview = new app_escritorio.Views.Carta.DishImage();
            this.cmbCategoria = new app_escritorio.UI.RComboBox();
            this.lblCategoria = new app_escritorio.UI.RLabel();
            this.txtNombre = new app_escritorio.UI.RTextBox();
            this.lblNombre = new app_escritorio.UI.RLabel();
            this.lblEditSub = new app_escritorio.UI.RLabel();
            this.lblEditTitle = new app_escritorio.UI.RLabel();
            this.lblEditIcon = new app_escritorio.UI.RLabel();
            this.topBar = new app_escritorio.Shell.ShellTopBar();
            this.sidebar = new app_escritorio.Shell.ShellSidebar();
            this.root.SuspendLayout();
            this.layout.SuspendLayout();
            this.statsBar.SuspendLayout();
            this.catBar.SuspendLayout();
            this.flowCategorias.SuspendLayout();
            this.mainTable.SuspendLayout();
            this.flowDishes.SuspendLayout();
            this.editorPanel.SuspendLayout();
            this.invCard.SuspendLayout();
            this.flowInsumos.SuspendLayout();
            this.cardDelivery.SuspendLayout();
            this.cardSalon.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.layout);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(272, 64);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(20);
            this.root.Size = new System.Drawing.Size(1100, 780);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // layout
            // 
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            this.layout.Controls.Add(this.statsBar, 0, 0);
            this.layout.Controls.Add(this.catBar, 0, 1);
            this.layout.Controls.Add(this.mainTable, 0, 2);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(20, 20);
            this.layout.Name = "layout";
            this.layout.RowCount = 3;
            this.layout.Size = new System.Drawing.Size(1060, 740);
            this.layout.TabIndex = 0;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            // 
            // statsBar
            // 
            this.statsBar.Controls.Add(this.btnNuevo);
            this.statsBar.Controls.Add(this.txtSearch);
            this.statsBar.Controls.Add(this.chipChef);
            this.statsBar.Controls.Add(this.chipAgotados);
            this.statsBar.Controls.Add(this.chipDisponibles);
            this.statsBar.CornerRadius = 14;
            this.statsBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsBar.Location = new System.Drawing.Point(0, 0);
            this.statsBar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.statsBar.Name = "statsBar";
            this.statsBar.Size = new System.Drawing.Size(1060, 58);
            this.statsBar.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.statsBar.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnNuevo.Location = new System.Drawing.Point(926, 11);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(124, 36);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "+ Nuevo plato";
            this.btnNuevo.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.txtSearch.Location = new System.Drawing.Point(612, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Buscar plato, ingrediente o alérgeno";
            this.txtSearch.Size = new System.Drawing.Size(304, 40);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // chipChef
            // 
            this.chipChef.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(95)))));
            this.chipChef.ChipStyle = app_escritorio.UI.ChipStyle.Plain;
            this.chipChef.Clickable = true;
            this.chipChef.Glyph = "☆";
            this.chipChef.Location = new System.Drawing.Point(338, 15);
            this.chipChef.Name = "chipChef";
            this.chipChef.Size = new System.Drawing.Size(200, 28);
            this.chipChef.TabIndex = 2;
            this.chipChef.Text = "3 Sugerencias del Chef";
            this.chipChef.Click += new System.EventHandler(this.StatChip_Click);
            // 
            // chipAgotados
            // 
            this.chipAgotados.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(171)))));
            this.chipAgotados.ChipStyle = app_escritorio.UI.ChipStyle.Plain;
            this.chipAgotados.Clickable = true;
            this.chipAgotados.Glyph = "⊗";
            this.chipAgotados.Location = new System.Drawing.Point(176, 15);
            this.chipAgotados.Name = "chipAgotados";
            this.chipAgotados.Size = new System.Drawing.Size(150, 28);
            this.chipAgotados.TabIndex = 1;
            this.chipAgotados.Text = "2 Agotados hoy";
            this.chipAgotados.Click += new System.EventHandler(this.StatChip_Click);
            // 
            // chipDisponibles
            // 
            this.chipDisponibles.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(222)))), ((int)(((byte)(163)))));
            this.chipDisponibles.ChipStyle = app_escritorio.UI.ChipStyle.Plain;
            this.chipDisponibles.Clickable = true;
            this.chipDisponibles.Glyph = "✓";
            this.chipDisponibles.Location = new System.Drawing.Point(14, 15);
            this.chipDisponibles.Name = "chipDisponibles";
            this.chipDisponibles.Size = new System.Drawing.Size(150, 28);
            this.chipDisponibles.TabIndex = 0;
            this.chipDisponibles.Text = "12 Disponibles";
            this.chipDisponibles.Click += new System.EventHandler(this.StatChip_Click);
            // 
            // catBar
            // 
            this.catBar.Controls.Add(this.btnHistorial);
            this.catBar.Controls.Add(this.btnCategorias);
            this.catBar.Controls.Add(this.flowCategorias);
            this.catBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catBar.Location = new System.Drawing.Point(0, 68);
            this.catBar.Margin = new System.Windows.Forms.Padding(0);
            this.catBar.Name = "catBar";
            this.catBar.Size = new System.Drawing.Size(1060, 48);
            this.catBar.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.catBar.TabIndex = 1;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnHistorial.Compact = true;
            this.btnHistorial.Location = new System.Drawing.Point(934, 4);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(126, 36);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.Text = "🕘  Historial";
            this.btnHistorial.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnHistorial.Click += new System.EventHandler(this.BtnHistorial_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnCategorias.Compact = true;
            this.btnCategorias.Location = new System.Drawing.Point(800, 4);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(126, 36);
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.Text = "☰  Categorías";
            this.btnCategorias.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            // 
            // flowCategorias
            // 
            this.flowCategorias.Controls.Add(this.chipCatSample2);
            this.flowCategorias.Controls.Add(this.chipCatSample1);
            this.flowCategorias.Controls.Add(this.chipCatTodas);
            this.flowCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.flowCategorias.Location = new System.Drawing.Point(0, 6);
            this.flowCategorias.Name = "flowCategorias";
            this.flowCategorias.Size = new System.Drawing.Size(790, 38);
            this.flowCategorias.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.flowCategorias.TabIndex = 0;
            this.flowCategorias.WrapContents = false;
            // 
            // chipCatSample2
            // 
            this.chipCatSample2.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.chipCatSample2.ChipStyle = app_escritorio.UI.ChipStyle.Soft;
            this.chipCatSample2.Clickable = true;
            this.chipCatSample2.Name = "chipCatSample2";
            this.chipCatSample2.Size = new System.Drawing.Size(100, 32);
            this.chipCatSample2.TabIndex = 2;
            this.chipCatSample2.Text = "Parrilla · 3";
            // 
            // chipCatSample1
            // 
            this.chipCatSample1.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.chipCatSample1.ChipStyle = app_escritorio.UI.ChipStyle.Soft;
            this.chipCatSample1.Clickable = true;
            this.chipCatSample1.Name = "chipCatSample1";
            this.chipCatSample1.Size = new System.Drawing.Size(100, 32);
            this.chipCatSample1.TabIndex = 1;
            this.chipCatSample1.Text = "Entradas · 2";
            // 
            // chipCatTodas
            // 
            this.chipCatTodas.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(157)))));
            this.chipCatTodas.ChipStyle = app_escritorio.UI.ChipStyle.Soft;
            this.chipCatTodas.Clickable = true;
            this.chipCatTodas.Name = "chipCatTodas";
            this.chipCatTodas.Selected = true;
            this.chipCatTodas.Size = new System.Drawing.Size(100, 32);
            this.chipCatTodas.TabIndex = 0;
            this.chipCatTodas.Text = "Todas · 12";
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 2;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 384.0F));
            this.mainTable.Controls.Add(this.flowDishes, 0, 0);
            this.mainTable.Controls.Add(this.editorPanel, 1, 0);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 116);
            this.mainTable.Margin = new System.Windows.Forms.Padding(0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 1;
            this.mainTable.Size = new System.Drawing.Size(1060, 624);
            this.mainTable.TabIndex = 2;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            // 
            // flowDishes
            // 
            this.flowDishes.Controls.Add(this.sampleCard2);
            this.flowDishes.Controls.Add(this.sampleCard1);
            this.flowDishes.AllowDrop = true;
            this.flowDishes.AutoScroll = true;
            this.flowDishes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDishes.Location = new System.Drawing.Point(0, 0);
            this.flowDishes.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.flowDishes.Name = "flowDishes";
            this.flowDishes.Size = new System.Drawing.Size(662, 624);
            this.flowDishes.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.flowDishes.TabIndex = 0;
            this.flowDishes.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlowDishes_DragOver);
            this.flowDishes.DragOver += new System.Windows.Forms.DragEventHandler(this.FlowDishes_DragOver);
            this.flowDishes.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlowDishes_DragDrop);
            this.flowDishes.Resize += new System.EventHandler(this.FlowDishes_Resize);
            // 
            // sampleCard2
            // 
            this.sampleCard2.Location = new System.Drawing.Point(314, 0);
            this.sampleCard2.Name = "sampleCard2";
            this.sampleCard2.Size = new System.Drawing.Size(300, 378);
            this.sampleCard2.TabIndex = 1;
            // 
            // sampleCard1
            // 
            this.sampleCard1.Location = new System.Drawing.Point(0, 0);
            this.sampleCard1.Name = "sampleCard1";
            this.sampleCard1.Selected = true;
            this.sampleCard1.Size = new System.Drawing.Size(300, 378);
            this.sampleCard1.TabIndex = 0;
            // 
            // editorPanel
            // 
            this.editorPanel.Controls.Add(this.editorBottom);
            this.editorPanel.Controls.Add(this.lblEstado);
            this.editorPanel.Controls.Add(this.btnEliminar);
            this.editorPanel.Controls.Add(this.btnDuplicar);
            this.editorPanel.Controls.Add(this.btnPublicar);
            this.editorPanel.Controls.Add(this.invCard);
            this.editorPanel.Controls.Add(this.lblStockHint);
            this.editorPanel.Controls.Add(this.txtStock);
            this.editorPanel.Controls.Add(this.lblStock);
            this.editorPanel.Controls.Add(this.tglLacteos);
            this.editorPanel.Controls.Add(this.tglGluten);
            this.editorPanel.Controls.Add(this.tglMasVendido);
            this.editorPanel.Controls.Add(this.tglSinLactosa);
            this.editorPanel.Controls.Add(this.tglChef);
            this.editorPanel.Controls.Add(this.tglPicante);
            this.editorPanel.Controls.Add(this.tglVegetariano);
            this.editorPanel.Controls.Add(this.tglSinTacc);
            this.editorPanel.Controls.Add(this.lblEtiquetas);
            this.editorPanel.Controls.Add(this.txtDescripcion);
            this.editorPanel.Controls.Add(this.lblDescripcion);
            this.editorPanel.Controls.Add(this.cardDelivery);
            this.editorPanel.Controls.Add(this.cardSalon);
            this.editorPanel.Controls.Add(this.swDisponible);
            this.editorPanel.Controls.Add(this.btnFoto);
            this.editorPanel.Controls.Add(this.imgPreview);
            this.editorPanel.Controls.Add(this.cmbCategoria);
            this.editorPanel.Controls.Add(this.lblCategoria);
            this.editorPanel.Controls.Add(this.txtNombre);
            this.editorPanel.Controls.Add(this.lblNombre);
            this.editorPanel.Controls.Add(this.lblEditSub);
            this.editorPanel.Controls.Add(this.lblEditTitle);
            this.editorPanel.Controls.Add(this.lblEditIcon);
            this.editorPanel.AutoScroll = true;
            this.editorPanel.CornerRadius = 14;
            this.editorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorPanel.Location = new System.Drawing.Point(676, 0);
            this.editorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(384, 624);
            this.editorPanel.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.editorPanel.TabIndex = 1;
            // 
            // editorBottom
            // 
            this.editorBottom.Location = new System.Drawing.Point(18, 1232);
            this.editorBottom.Name = "editorBottom";
            this.editorBottom.Size = new System.Drawing.Size(326, 16);
            this.editorBottom.TabIndex = 61;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(18, 1210);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(326, 20);
            this.lblEstado.TabIndex = 60;
            this.lblEstado.Text = "Sin cambios pendientes";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstado.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Compact = true;
            this.btnEliminar.Location = new System.Drawing.Point(187, 1166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 36);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.Text = "🗑  Eliminar";
            this.btnEliminar.Variant = app_escritorio.UI.ButtonVariant.Danger;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnDuplicar
            // 
            this.btnDuplicar.Compact = true;
            this.btnDuplicar.Location = new System.Drawing.Point(18, 1166);
            this.btnDuplicar.Name = "btnDuplicar";
            this.btnDuplicar.Size = new System.Drawing.Size(157, 36);
            this.btnDuplicar.TabIndex = 32;
            this.btnDuplicar.Text = "⧉  Duplicar";
            this.btnDuplicar.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnDuplicar.Click += new System.EventHandler(this.BtnDuplicar_Click);
            // 
            // btnPublicar
            // 
            this.btnPublicar.Location = new System.Drawing.Point(18, 1112);
            this.btnPublicar.Name = "btnPublicar";
            this.btnPublicar.Size = new System.Drawing.Size(326, 46);
            this.btnPublicar.TabIndex = 31;
            this.btnPublicar.Text = "⇪  Publicar cambios al instante";
            this.btnPublicar.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnPublicar.Click += new System.EventHandler(this.BtnPublicar_Click);
            // 
            // invCard
            // 
            this.invCard.Controls.Add(this.btnVincular);
            this.invCard.Controls.Add(this.flowInsumos);
            this.invCard.Controls.Add(this.lblInvHint);
            this.invCard.Controls.Add(this.lblInvCount);
            this.invCard.Controls.Add(this.lblInvTitle);
            this.invCard.CornerRadius = 12;
            this.invCard.Location = new System.Drawing.Point(18, 880);
            this.invCard.Name = "invCard";
            this.invCard.Size = new System.Drawing.Size(326, 218);
            this.invCard.Surface = app_escritorio.UI.SurfaceLevel.High;
            this.invCard.TabIndex = 30;
            // 
            // btnVincular
            // 
            this.btnVincular.Compact = true;
            this.btnVincular.Location = new System.Drawing.Point(12, 178);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(302, 30);
            this.btnVincular.TabIndex = 4;
            this.btnVincular.Text = "+  Vincular otro insumo de almacén";
            this.btnVincular.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnVincular.Click += new System.EventHandler(this.BtnVincular_Click);
            // 
            // flowInsumos
            // 
            this.flowInsumos.Controls.Add(this.sampleInsumo2);
            this.flowInsumos.Controls.Add(this.sampleInsumo1);
            this.flowInsumos.AutoScroll = true;
            this.flowInsumos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowInsumos.Location = new System.Drawing.Point(12, 58);
            this.flowInsumos.Name = "flowInsumos";
            this.flowInsumos.Size = new System.Drawing.Size(302, 114);
            this.flowInsumos.Surface = app_escritorio.UI.SurfaceLevel.High;
            this.flowInsumos.TabIndex = 3;
            this.flowInsumos.WrapContents = false;
            // 
            // sampleInsumo2
            // 
            this.sampleInsumo2.Location = new System.Drawing.Point(0, 40);
            this.sampleInsumo2.Name = "sampleInsumo2";
            this.sampleInsumo2.Size = new System.Drawing.Size(296, 34);
            this.sampleInsumo2.TabIndex = 1;
            // 
            // sampleInsumo1
            // 
            this.sampleInsumo1.Location = new System.Drawing.Point(0, 0);
            this.sampleInsumo1.Name = "sampleInsumo1";
            this.sampleInsumo1.Size = new System.Drawing.Size(296, 34);
            this.sampleInsumo1.TabIndex = 0;
            // 
            // lblInvHint
            // 
            this.lblInvHint.Location = new System.Drawing.Point(12, 34);
            this.lblInvHint.Name = "lblInvHint";
            this.lblInvHint.Size = new System.Drawing.Size(302, 18);
            this.lblInvHint.TabIndex = 2;
            this.lblInvHint.Text = "Se descuentan del almacén por cada plato vendido";
            this.lblInvHint.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // lblInvCount
            // 
            this.lblInvCount.Location = new System.Drawing.Point(180, 12);
            this.lblInvCount.Name = "lblInvCount";
            this.lblInvCount.Size = new System.Drawing.Size(134, 18);
            this.lblInvCount.TabIndex = 1;
            this.lblInvCount.Text = "3 insumos vinculados";
            this.lblInvCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblInvCount.TextStyle = app_escritorio.UI.TextStyle.Positive;
            // 
            // lblInvTitle
            // 
            this.lblInvTitle.Location = new System.Drawing.Point(12, 10);
            this.lblInvTitle.Name = "lblInvTitle";
            this.lblInvTitle.Size = new System.Drawing.Size(200, 22);
            this.lblInvTitle.TabIndex = 0;
            this.lblInvTitle.Text = "▤  Descuento de Inventario";
            this.lblInvTitle.TextStyle = app_escritorio.UI.TextStyle.BodyBold;
            // 
            // lblStockHint
            // 
            this.lblStockHint.Location = new System.Drawing.Point(187, 826);
            this.lblStockHint.Name = "lblStockHint";
            this.lblStockHint.Size = new System.Drawing.Size(157, 36);
            this.lblStockHint.TabIndex = 59;
            this.lblStockHint.Text = "Vacío = sin límite · 0 = agotado. Se descuenta con cada venta.";
            this.lblStockHint.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(18, 824);
            this.txtStock.Name = "txtStock";
            this.txtStock.PlaceholderText = "Ilimitado";
            this.txtStock.Size = new System.Drawing.Size(157, 40);
            this.txtStock.TabIndex = 21;
            this.txtStock.TextChanged += new System.EventHandler(this.Editor_Changed);
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(18, 802);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(326, 20);
            this.lblStock.TabIndex = 58;
            this.lblStock.Text = "Porciones disponibles hoy";
            this.lblStock.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // tglLacteos
            // 
            this.tglLacteos.Compact = true;
            this.tglLacteos.Location = new System.Drawing.Point(187, 756);
            this.tglLacteos.Name = "tglLacteos";
            this.tglLacteos.Size = new System.Drawing.Size(157, 34);
            this.tglLacteos.TabIndex = 20;
            this.tglLacteos.Text = "Contiene lácteos";
            this.tglLacteos.Variant = app_escritorio.UI.ButtonVariant.Toggle;
            this.tglLacteos.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // tglGluten
            // 
            this.tglGluten.Compact = true;
            this.tglGluten.Location = new System.Drawing.Point(18, 756);
            this.tglGluten.Name = "tglGluten";
            this.tglGluten.Size = new System.Drawing.Size(157, 34);
            this.tglGluten.TabIndex = 20;
            this.tglGluten.Text = "Contiene gluten";
            this.tglGluten.Variant = app_escritorio.UI.ButtonVariant.Toggle;
            this.tglGluten.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // tglMasVendido
            // 
            this.tglMasVendido.Compact = true;
            this.tglMasVendido.Location = new System.Drawing.Point(187, 716);
            this.tglMasVendido.Name = "tglMasVendido";
            this.tglMasVendido.Size = new System.Drawing.Size(157, 34);
            this.tglMasVendido.TabIndex = 20;
            this.tglMasVendido.Text = "★  Más vendido";
            this.tglMasVendido.Variant = app_escritorio.UI.ButtonVariant.Toggle;
            this.tglMasVendido.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // tglSinLactosa
            // 
            this.tglSinLactosa.Compact = true;
            this.tglSinLactosa.Location = new System.Drawing.Point(18, 716);
            this.tglSinLactosa.Name = "tglSinLactosa";
            this.tglSinLactosa.Size = new System.Drawing.Size(157, 34);
            this.tglSinLactosa.TabIndex = 20;
            this.tglSinLactosa.Text = "🥛  Sin Lactosa";
            this.tglSinLactosa.Variant = app_escritorio.UI.ButtonVariant.Toggle;
            this.tglSinLactosa.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // tglChef
            // 
            this.tglChef.Compact = true;
            this.tglChef.Location = new System.Drawing.Point(187, 676);
            this.tglChef.Name = "tglChef";
            this.tglChef.Size = new System.Drawing.Size(157, 34);
            this.tglChef.TabIndex = 20;
            this.tglChef.Text = "☆  Sugerencia Chef";
            this.tglChef.Variant = app_escritorio.UI.ButtonVariant.Toggle;
            this.tglChef.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // tglPicante
            // 
            this.tglPicante.Compact = true;
            this.tglPicante.Location = new System.Drawing.Point(18, 676);
            this.tglPicante.Name = "tglPicante";
            this.tglPicante.Size = new System.Drawing.Size(157, 34);
            this.tglPicante.TabIndex = 20;
            this.tglPicante.Text = "🌶  Picante";
            this.tglPicante.Variant = app_escritorio.UI.ButtonVariant.Toggle;
            this.tglPicante.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // tglVegetariano
            // 
            this.tglVegetariano.Compact = true;
            this.tglVegetariano.Location = new System.Drawing.Point(187, 636);
            this.tglVegetariano.Name = "tglVegetariano";
            this.tglVegetariano.Size = new System.Drawing.Size(157, 34);
            this.tglVegetariano.TabIndex = 20;
            this.tglVegetariano.Text = "🌿  Vegetariano";
            this.tglVegetariano.Variant = app_escritorio.UI.ButtonVariant.Toggle;
            this.tglVegetariano.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // tglSinTacc
            // 
            this.tglSinTacc.Compact = true;
            this.tglSinTacc.Location = new System.Drawing.Point(18, 636);
            this.tglSinTacc.Name = "tglSinTacc";
            this.tglSinTacc.Size = new System.Drawing.Size(157, 34);
            this.tglSinTacc.TabIndex = 20;
            this.tglSinTacc.Text = "✓  Sin TACC / Celíacos";
            this.tglSinTacc.Variant = app_escritorio.UI.ButtonVariant.Toggle;
            this.tglSinTacc.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // lblEtiquetas
            // 
            this.lblEtiquetas.Location = new System.Drawing.Point(18, 614);
            this.lblEtiquetas.Name = "lblEtiquetas";
            this.lblEtiquetas.Size = new System.Drawing.Size(326, 20);
            this.lblEtiquetas.TabIndex = 57;
            this.lblEtiquetas.Text = "Etiquetas y filtros dietéticos";
            this.lblEtiquetas.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(18, 516);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PlaceholderText = "Cuenta qué lleva el plato y cómo se prepara";
            this.txtDescripcion.Size = new System.Drawing.Size(326, 86);
            this.txtDescripcion.TabIndex = 12;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.Editor_Changed);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(18, 494);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(326, 20);
            this.lblDescripcion.TabIndex = 56;
            this.lblDescripcion.Text = "Descripción gourmet (menú)";
            this.lblDescripcion.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // cardDelivery
            // 
            this.cardDelivery.Controls.Add(this.chipCalcDelivery);
            this.cardDelivery.Controls.Add(this.txtPrecioDelivery);
            this.cardDelivery.Controls.Add(this.lblDeliveryCap);
            this.cardDelivery.CornerRadius = 12;
            this.cardDelivery.Location = new System.Drawing.Point(187, 386);
            this.cardDelivery.Name = "cardDelivery";
            this.cardDelivery.Size = new System.Drawing.Size(157, 96);
            this.cardDelivery.Surface = app_escritorio.UI.SurfaceLevel.High;
            this.cardDelivery.TabIndex = 11;
            // 
            // chipCalcDelivery
            // 
            this.chipCalcDelivery.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(222)))), ((int)(((byte)(163)))));
            this.chipCalcDelivery.ChipStyle = app_escritorio.UI.ChipStyle.Soft;
            this.chipCalcDelivery.Clickable = true;
            this.chipCalcDelivery.Glyph = "↻";
            this.chipCalcDelivery.Location = new System.Drawing.Point(10, 70);
            this.chipCalcDelivery.Margin = new System.Windows.Forms.Padding(0);
            this.chipCalcDelivery.Name = "chipCalcDelivery";
            this.chipCalcDelivery.Size = new System.Drawing.Size(110, 20);
            this.chipCalcDelivery.Small = true;
            this.chipCalcDelivery.TabIndex = 2;
            this.chipCalcDelivery.Text = "+15% · calcular";
            this.chipCalcDelivery.Click += new System.EventHandler(this.BtnCalcDelivery_Click);
            // 
            // txtPrecioDelivery
            // 
            this.txtPrecioDelivery.LargeText = true;
            this.txtPrecioDelivery.Location = new System.Drawing.Point(10, 28);
            this.txtPrecioDelivery.Name = "txtPrecioDelivery";
            this.txtPrecioDelivery.PlaceholderText = "0";
            this.txtPrecioDelivery.Size = new System.Drawing.Size(137, 40);
            this.txtPrecioDelivery.TabIndex = 1;
            this.txtPrecioDelivery.TextChanged += new System.EventHandler(this.Editor_Changed);
            // 
            // lblDeliveryCap
            // 
            this.lblDeliveryCap.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(95)))));
            this.lblDeliveryCap.Location = new System.Drawing.Point(10, 8);
            this.lblDeliveryCap.Name = "lblDeliveryCap";
            this.lblDeliveryCap.Size = new System.Drawing.Size(140, 16);
            this.lblDeliveryCap.TabIndex = 0;
            this.lblDeliveryCap.Text = "🛵  Precio Delivery ($)";
            this.lblDeliveryCap.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // cardSalon
            // 
            this.cardSalon.Controls.Add(this.lblSalonHint);
            this.cardSalon.Controls.Add(this.txtPrecioSalon);
            this.cardSalon.Controls.Add(this.lblSalonCap);
            this.cardSalon.CornerRadius = 12;
            this.cardSalon.Location = new System.Drawing.Point(18, 386);
            this.cardSalon.Name = "cardSalon";
            this.cardSalon.Size = new System.Drawing.Size(157, 96);
            this.cardSalon.Surface = app_escritorio.UI.SurfaceLevel.High;
            this.cardSalon.TabIndex = 10;
            // 
            // lblSalonHint
            // 
            this.lblSalonHint.Location = new System.Drawing.Point(10, 72);
            this.lblSalonHint.Name = "lblSalonHint";
            this.lblSalonHint.Size = new System.Drawing.Size(140, 16);
            this.lblSalonHint.TabIndex = 2;
            this.lblSalonHint.Text = "Sin comisión";
            this.lblSalonHint.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // txtPrecioSalon
            // 
            this.txtPrecioSalon.LargeText = true;
            this.txtPrecioSalon.Location = new System.Drawing.Point(10, 28);
            this.txtPrecioSalon.Name = "txtPrecioSalon";
            this.txtPrecioSalon.PlaceholderText = "0";
            this.txtPrecioSalon.Size = new System.Drawing.Size(137, 40);
            this.txtPrecioSalon.TabIndex = 1;
            this.txtPrecioSalon.TextChanged += new System.EventHandler(this.Editor_Changed);
            // 
            // lblSalonCap
            // 
            this.lblSalonCap.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(222)))), ((int)(((byte)(163)))));
            this.lblSalonCap.Location = new System.Drawing.Point(10, 8);
            this.lblSalonCap.Name = "lblSalonCap";
            this.lblSalonCap.Size = new System.Drawing.Size(140, 16);
            this.lblSalonCap.TabIndex = 0;
            this.lblSalonCap.Text = "▣  Precio Salón ($)";
            this.lblSalonCap.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // swDisponible
            // 
            this.swDisponible.Checked = true;
            this.swDisponible.Location = new System.Drawing.Point(184, 344);
            this.swDisponible.Name = "swDisponible";
            this.swDisponible.Size = new System.Drawing.Size(160, 28);
            this.swDisponible.TabIndex = 3;
            this.swDisponible.Text = "Disponible hoy";
            this.swDisponible.CheckedChanged += new System.EventHandler(this.Editor_Changed);
            // 
            // btnFoto
            // 
            this.btnFoto.Compact = true;
            this.btnFoto.Location = new System.Drawing.Point(18, 342);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(150, 32);
            this.btnFoto.TabIndex = 2;
            this.btnFoto.Text = "↥  Cambiar foto";
            this.btnFoto.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnFoto.Click += new System.EventHandler(this.BtnFoto_Click);
            // 
            // imgPreview
            // 
            this.imgPreview.CategoryText = "";
            this.imgPreview.CornerRadius = 12;
            this.imgPreview.Location = new System.Drawing.Point(18, 214);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.RoundBottom = true;
            this.imgPreview.Size = new System.Drawing.Size(326, 120);
            this.imgPreview.StatusColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(222)))), ((int)(((byte)(163)))));
            this.imgPreview.StatusText = "";
            this.imgPreview.TabIndex = 55;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Location = new System.Drawing.Point(18, 170);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(326, 32);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.Editor_Changed);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(18, 148);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(326, 20);
            this.lblCategoria.TabIndex = 54;
            this.lblCategoria.Text = "Categoría";
            this.lblCategoria.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(18, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ej: Ojo de Bife con Papas Rústicas";
            this.txtNombre.Size = new System.Drawing.Size(326, 40);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.Editor_Changed);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(18, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(326, 20);
            this.lblNombre.TabIndex = 53;
            this.lblNombre.Text = "Nombre del plato en la carta";
            this.lblNombre.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblEditSub
            // 
            this.lblEditSub.Location = new System.Drawing.Point(48, 44);
            this.lblEditSub.Name = "lblEditSub";
            this.lblEditSub.Size = new System.Drawing.Size(290, 18);
            this.lblEditSub.TabIndex = 52;
            this.lblEditSub.Text = "Aplica cambios en tiempo real a mesas y al POS";
            this.lblEditSub.TextStyle = app_escritorio.UI.TextStyle.AccentSmall;
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.Location = new System.Drawing.Point(48, 12);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(290, 32);
            this.lblEditTitle.TabIndex = 51;
            this.lblEditTitle.Text = "Edición Rápida";
            this.lblEditTitle.TextStyle = app_escritorio.UI.TextStyle.Title;
            // 
            // lblEditIcon
            // 
            this.lblEditIcon.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(95)))));
            this.lblEditIcon.Location = new System.Drawing.Point(18, 14);
            this.lblEditIcon.Name = "lblEditIcon";
            this.lblEditIcon.Size = new System.Drawing.Size(28, 30);
            this.lblEditIcon.TabIndex = 50;
            this.lblEditIcon.Text = "⚙";
            this.lblEditIcon.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(272, 0);
            this.topBar.Name = "topBar";
            this.topBar.RoleText = "Administrador";
            this.topBar.RouteText = "Menú digital";
            this.topBar.Size = new System.Drawing.Size(1100, 64);
            this.topBar.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.ActiveRoute = "menu";
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(272, 844);
            this.sidebar.TabIndex = 2;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1372, 844);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestoOS - Modular Core";
            this.Controls.Add(this.root);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sidebar);
            this.cardSalon.ResumeLayout(false);
            this.cardDelivery.ResumeLayout(false);
            this.flowInsumos.ResumeLayout(false);
            this.invCard.ResumeLayout(false);
            this.editorPanel.ResumeLayout(false);
            this.flowDishes.ResumeLayout(false);
            this.mainTable.ResumeLayout(false);
            this.mainTable.PerformLayout();
            this.flowCategorias.ResumeLayout(false);
            this.catBar.ResumeLayout(false);
            this.statsBar.ResumeLayout(false);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.root.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private System.Windows.Forms.TableLayoutPanel layout;
        private app_escritorio.UI.RPanel statsBar;
        private app_escritorio.UI.RButton btnNuevo;
        private app_escritorio.UI.RTextBox txtSearch;
        private app_escritorio.UI.RChip chipChef;
        private app_escritorio.UI.RChip chipAgotados;
        private app_escritorio.UI.RChip chipDisponibles;
        private app_escritorio.UI.RPanel catBar;
        private app_escritorio.UI.RButton btnHistorial;
        private app_escritorio.UI.RButton btnCategorias;
        private app_escritorio.UI.RFlowPanel flowCategorias;
        private app_escritorio.UI.RChip chipCatSample2;
        private app_escritorio.UI.RChip chipCatSample1;
        private app_escritorio.UI.RChip chipCatTodas;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private app_escritorio.UI.RFlowPanel flowDishes;
        private app_escritorio.Views.Carta.DishCard sampleCard2;
        private app_escritorio.Views.Carta.DishCard sampleCard1;
        private app_escritorio.UI.RPanel editorPanel;
        private System.Windows.Forms.Panel editorBottom;
        private app_escritorio.UI.RLabel lblEstado;
        private app_escritorio.UI.RButton btnEliminar;
        private app_escritorio.UI.RButton btnDuplicar;
        private app_escritorio.UI.RButton btnPublicar;
        private app_escritorio.UI.RPanel invCard;
        private app_escritorio.UI.RButton btnVincular;
        private app_escritorio.UI.RFlowPanel flowInsumos;
        private app_escritorio.Views.Carta.InsumoLinkRow sampleInsumo2;
        private app_escritorio.Views.Carta.InsumoLinkRow sampleInsumo1;
        private app_escritorio.UI.RLabel lblInvHint;
        private app_escritorio.UI.RLabel lblInvCount;
        private app_escritorio.UI.RLabel lblInvTitle;
        private app_escritorio.UI.RLabel lblStockHint;
        private app_escritorio.UI.RTextBox txtStock;
        private app_escritorio.UI.RLabel lblStock;
        private app_escritorio.UI.RButton tglLacteos;
        private app_escritorio.UI.RButton tglGluten;
        private app_escritorio.UI.RButton tglMasVendido;
        private app_escritorio.UI.RButton tglSinLactosa;
        private app_escritorio.UI.RButton tglChef;
        private app_escritorio.UI.RButton tglPicante;
        private app_escritorio.UI.RButton tglVegetariano;
        private app_escritorio.UI.RButton tglSinTacc;
        private app_escritorio.UI.RLabel lblEtiquetas;
        private app_escritorio.UI.RTextBox txtDescripcion;
        private app_escritorio.UI.RLabel lblDescripcion;
        private app_escritorio.UI.RPanel cardDelivery;
        private app_escritorio.UI.RChip chipCalcDelivery;
        private app_escritorio.UI.RTextBox txtPrecioDelivery;
        private app_escritorio.UI.RLabel lblDeliveryCap;
        private app_escritorio.UI.RPanel cardSalon;
        private app_escritorio.UI.RLabel lblSalonHint;
        private app_escritorio.UI.RTextBox txtPrecioSalon;
        private app_escritorio.UI.RLabel lblSalonCap;
        private app_escritorio.UI.RSwitch swDisponible;
        private app_escritorio.UI.RButton btnFoto;
        private app_escritorio.Views.Carta.DishImage imgPreview;
        private app_escritorio.UI.RComboBox cmbCategoria;
        private app_escritorio.UI.RLabel lblCategoria;
        private app_escritorio.UI.RTextBox txtNombre;
        private app_escritorio.UI.RLabel lblNombre;
        private app_escritorio.UI.RLabel lblEditSub;
        private app_escritorio.UI.RLabel lblEditTitle;
        private app_escritorio.UI.RLabel lblEditIcon;
        private app_escritorio.Shell.ShellTopBar topBar;
        private app_escritorio.Shell.ShellSidebar sidebar;
    }
}
