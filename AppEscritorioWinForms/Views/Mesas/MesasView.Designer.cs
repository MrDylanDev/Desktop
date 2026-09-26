namespace app_escritorio.Views.Mesas
{
    partial class MesasView
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
            this.leftLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new app_escritorio.UI.RLabel();
            this.btnNew = new app_escritorio.UI.RButton();
            this.cmbSector = new app_escritorio.UI.RComboBox();
            this.flowTables = new app_escritorio.UI.RFlowPanel();
            this.splitter = new System.Windows.Forms.Splitter();
            this.detailPanel = new app_escritorio.UI.RPanel();
            this.lblDetailTitle = new app_escritorio.UI.RLabel();
            this.lblDetailName = new app_escritorio.UI.RLabel();
            this.lblDetailStatus = new app_escritorio.UI.RLabel();
            this.lblDetailInfo = new app_escritorio.UI.RLabel();
            this.itemsCard = new app_escritorio.UI.RPanel();
            this.lblDetailItems = new app_escritorio.UI.RLabel();
            this.lblTotalCaption = new app_escritorio.UI.RLabel();
            this.lblDetailTotal = new app_escritorio.UI.RLabel();
            this.btnOpenPos = new app_escritorio.UI.RButton();
            this.lblNote = new app_escritorio.UI.RLabel();
            this.root.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.headerFlow.SuspendLayout();
            this.detailPanel.SuspendLayout();
            this.itemsCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.leftLayout);
            this.root.Controls.Add(this.splitter);
            this.root.Controls.Add(this.detailPanel);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(20);
            this.root.Size = new System.Drawing.Size(1100, 780);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // leftLayout
            // 
            this.leftLayout.ColumnCount = 1;
            this.leftLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftLayout.Controls.Add(this.headerFlow, 0, 0);
            this.leftLayout.Controls.Add(this.flowTables, 0, 1);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLayout.Location = new System.Drawing.Point(20, 20);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.RowCount = 2;
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftLayout.Size = new System.Drawing.Size(692, 740);
            this.leftLayout.TabIndex = 0;
            // 
            // headerFlow
            // 
            this.headerFlow.Controls.Add(this.lblTitle);
            this.headerFlow.Controls.Add(this.btnNew);
            this.headerFlow.Controls.Add(this.cmbSector);
            this.headerFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerFlow.Location = new System.Drawing.Point(0, 0);
            this.headerFlow.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.headerFlow.Name = "headerFlow";
            this.headerFlow.Size = new System.Drawing.Size(692, 48);
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
            this.lblTitle.Text = "Mesas y Salón";
            this.lblTitle.TextStyle = app_escritorio.UI.TextStyle.Hero;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(222, 6);
            this.btnNew.Margin = new System.Windows.Forms.Padding(20, 6, 0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(132, 36);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "+ Nueva mesa";
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // cmbSector
            // 
            this.cmbSector.Items.AddRange(new object[] {
            "Todos los salones",
            "Principal",
            "Terraza",
            "Barra",
            "VIP"});
            this.cmbSector.Location = new System.Drawing.Point(366, 8);
            this.cmbSector.Margin = new System.Windows.Forms.Padding(12, 8, 0, 0);
            this.cmbSector.Name = "cmbSector";
            this.cmbSector.Size = new System.Drawing.Size(180, 32);
            this.cmbSector.TabIndex = 2;
            this.cmbSector.SelectedIndexChanged += new System.EventHandler(this.CmbSector_SelectedIndexChanged);
            // 
            // flowTables
            // 
            this.flowTables.AutoScroll = true;
            this.flowTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTables.Location = new System.Drawing.Point(0, 64);
            this.flowTables.Margin = new System.Windows.Forms.Padding(0);
            this.flowTables.Name = "flowTables";
            this.flowTables.Size = new System.Drawing.Size(692, 676);
            this.flowTables.TabIndex = 1;
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(712, 20);
            this.splitter.MinExtra = 340;
            this.splitter.MinSize = 300;
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(8, 740);
            this.splitter.TabIndex = 1;
            this.splitter.TabStop = false;
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.lblNote);
            this.detailPanel.Controls.Add(this.btnOpenPos);
            this.detailPanel.Controls.Add(this.lblDetailTotal);
            this.detailPanel.Controls.Add(this.lblTotalCaption);
            this.detailPanel.Controls.Add(this.itemsCard);
            this.detailPanel.Controls.Add(this.lblDetailInfo);
            this.detailPanel.Controls.Add(this.lblDetailStatus);
            this.detailPanel.Controls.Add(this.lblDetailName);
            this.detailPanel.Controls.Add(this.lblDetailTitle);
            this.detailPanel.CornerRadius = 14;
            this.detailPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.detailPanel.Location = new System.Drawing.Point(720, 20);
            this.detailPanel.MaximumSize = new System.Drawing.Size(400, 0);
            this.detailPanel.MinimumSize = new System.Drawing.Size(300, 0);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(360, 740);
            this.detailPanel.TabIndex = 2;
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblDetailTitle.Location = new System.Drawing.Point(18, 18);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(324, 32);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = "Detalle de mesa";
            this.lblDetailTitle.TextStyle = app_escritorio.UI.TextStyle.Title;
            // 
            // lblDetailName
            // 
            this.lblDetailName.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblDetailName.AutoEllipsis = true;
            this.lblDetailName.Location = new System.Drawing.Point(18, 66);
            this.lblDetailName.Name = "lblDetailName";
            this.lblDetailName.Size = new System.Drawing.Size(324, 38);
            this.lblDetailName.TabIndex = 1;
            this.lblDetailName.Text = "Selecciona una mesa";
            this.lblDetailName.TextStyle = app_escritorio.UI.TextStyle.TotalLarge;
            // 
            // lblDetailStatus
            // 
            this.lblDetailStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblDetailStatus.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(222)))), ((int)(((byte)(163)))));
            this.lblDetailStatus.Location = new System.Drawing.Point(18, 106);
            this.lblDetailStatus.Name = "lblDetailStatus";
            this.lblDetailStatus.Size = new System.Drawing.Size(324, 20);
            this.lblDetailStatus.TabIndex = 2;
            this.lblDetailStatus.Text = "";
            this.lblDetailStatus.TextStyle = app_escritorio.UI.TextStyle.BodyBold;
            // 
            // lblDetailInfo
            // 
            this.lblDetailInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblDetailInfo.Location = new System.Drawing.Point(18, 130);
            this.lblDetailInfo.Name = "lblDetailInfo";
            this.lblDetailInfo.Size = new System.Drawing.Size(324, 20);
            this.lblDetailInfo.TabIndex = 3;
            this.lblDetailInfo.Text = "";
            this.lblDetailInfo.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // itemsCard
            // 
            this.itemsCard.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.itemsCard.Controls.Add(this.lblDetailItems);
            this.itemsCard.CornerRadius = 10;
            this.itemsCard.Location = new System.Drawing.Point(18, 168);
            this.itemsCard.Name = "itemsCard";
            this.itemsCard.Padding = new System.Windows.Forms.Padding(14);
            this.itemsCard.Size = new System.Drawing.Size(324, 112);
            this.itemsCard.Surface = app_escritorio.UI.SurfaceLevel.Lowest;
            this.itemsCard.TabIndex = 4;
            // 
            // lblDetailItems
            // 
            this.lblDetailItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetailItems.Location = new System.Drawing.Point(14, 14);
            this.lblDetailItems.Name = "lblDetailItems";
            this.lblDetailItems.Size = new System.Drawing.Size(296, 84);
            this.lblDetailItems.TabIndex = 0;
            this.lblDetailItems.Text = "Sin pedido activo.";
            this.lblDetailItems.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.Location = new System.Drawing.Point(18, 302);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(150, 20);
            this.lblTotalCaption.TabIndex = 5;
            this.lblTotalCaption.Text = "Total consumido";
            this.lblTotalCaption.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblDetailTotal
            // 
            this.lblDetailTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblDetailTotal.Location = new System.Drawing.Point(160, 296);
            this.lblDetailTotal.Name = "lblDetailTotal";
            this.lblDetailTotal.Size = new System.Drawing.Size(182, 30);
            this.lblDetailTotal.TabIndex = 6;
            this.lblDetailTotal.Text = "";
            this.lblDetailTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDetailTotal.TextStyle = app_escritorio.UI.TextStyle.Total;
            // 
            // btnOpenPos
            // 
            this.btnOpenPos.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.btnOpenPos.Enabled = false;
            this.btnOpenPos.Location = new System.Drawing.Point(18, 342);
            this.btnOpenPos.Name = "btnOpenPos";
            this.btnOpenPos.Size = new System.Drawing.Size(324, 52);
            this.btnOpenPos.TabIndex = 7;
            this.btnOpenPos.Text = "Abrir en POS";
            this.btnOpenPos.Click += new System.EventHandler(this.BtnOpenPos_Click);
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblNote.Location = new System.Drawing.Point(18, 408);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(324, 32);
            this.lblNote.TabIndex = 8;
            this.lblNote.Text = "Los datos mostrados son locales de demostración.";
            this.lblNote.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // MesasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.root);
            this.Name = "MesasView";
            this.Size = new System.Drawing.Size(1100, 780);
            this.itemsCard.ResumeLayout(false);
            this.detailPanel.ResumeLayout(false);
            this.headerFlow.ResumeLayout(false);
            this.headerFlow.PerformLayout();
            this.leftLayout.ResumeLayout(false);
            this.leftLayout.PerformLayout();
            this.root.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private System.Windows.Forms.TableLayoutPanel leftLayout;
        private System.Windows.Forms.FlowLayoutPanel headerFlow;
        private app_escritorio.UI.RLabel lblTitle;
        private app_escritorio.UI.RButton btnNew;
        private app_escritorio.UI.RComboBox cmbSector;
        private app_escritorio.UI.RFlowPanel flowTables;
        private System.Windows.Forms.Splitter splitter;
        private app_escritorio.UI.RPanel detailPanel;
        private app_escritorio.UI.RLabel lblDetailTitle;
        private app_escritorio.UI.RLabel lblDetailName;
        private app_escritorio.UI.RLabel lblDetailStatus;
        private app_escritorio.UI.RLabel lblDetailInfo;
        private app_escritorio.UI.RPanel itemsCard;
        private app_escritorio.UI.RLabel lblDetailItems;
        private app_escritorio.UI.RLabel lblTotalCaption;
        private app_escritorio.UI.RLabel lblDetailTotal;
        private app_escritorio.UI.RButton btnOpenPos;
        private app_escritorio.UI.RLabel lblNote;
    }
}
