namespace app_escritorio.Views.Carta
{
    partial class DishCard
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
            this.dishImage = new app_escritorio.Views.Carta.DishImage();
            this.lblName = new app_escritorio.UI.RLabel();
            this.lblDescription = new app_escritorio.UI.RLabel();
            this.flowTags = new app_escritorio.UI.RFlowPanel();
            this.chipSample2 = new app_escritorio.UI.RChip();
            this.chipSample1 = new app_escritorio.UI.RChip();
            this.pricePanel = new app_escritorio.UI.RPanel();
            this.lblDelivery = new app_escritorio.UI.RLabel();
            this.lblDeliveryCaption = new app_escritorio.UI.RLabel();
            this.lblSalon = new app_escritorio.UI.RLabel();
            this.lblSalonCaption = new app_escritorio.UI.RLabel();
            this.btnPause = new app_escritorio.UI.RButton();
            this.btnEdit = new app_escritorio.UI.RButton();
            this.flowTags.SuspendLayout();
            this.pricePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dishImage
            // 
            this.dishImage.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dishImage.CategoryText = "Carnes Grill";
            this.dishImage.Location = new System.Drawing.Point(0, 0);
            this.dishImage.Name = "dishImage";
            this.dishImage.Size = new System.Drawing.Size(300, 150);
            this.dishImage.StatusColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(222)))), ((int)(((byte)(163)))));
            this.dishImage.TabIndex = 0;
            this.dishImage.Click += new System.EventHandler(this.Part_Click);
            this.dishImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Part_MouseDown);
            this.dishImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Part_MouseMove);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblName.AutoEllipsis = true;
            this.lblName.Location = new System.Drawing.Point(14, 160);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(272, 26);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ojo de Bife con Papas Rústicas";
            this.lblName.TextStyle = app_escritorio.UI.TextStyle.Heading;
            this.lblName.Click += new System.EventHandler(this.Part_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 188);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(272, 38);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "400 g de carne premium madurada a las brasas de quebracho, terminado con manteca de hierbas.";
            this.lblDescription.TextStyle = app_escritorio.UI.TextStyle.Muted;
            this.lblDescription.Click += new System.EventHandler(this.Part_Click);
            // 
            // flowTags
            // 
            this.flowTags.Controls.Add(this.chipSample2);
            this.flowTags.Controls.Add(this.chipSample1);
            this.flowTags.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.flowTags.Location = new System.Drawing.Point(14, 230);
            this.flowTags.Name = "flowTags";
            this.flowTags.Size = new System.Drawing.Size(272, 26);
            this.flowTags.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.flowTags.TabIndex = 3;
            this.flowTags.WrapContents = false;
            this.flowTags.Click += new System.EventHandler(this.Part_Click);
            // 
            // chipSample2
            // 
            this.chipSample2.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(95)))));
            this.chipSample2.ChipStyle = app_escritorio.UI.ChipStyle.Outline;
            this.chipSample2.Name = "chipSample2";
            this.chipSample2.Size = new System.Drawing.Size(90, 22);
            this.chipSample2.Small = true;
            this.chipSample2.Text = "Sugerencia Chef";
            // 
            // chipSample1
            // 
            this.chipSample1.ChipStyle = app_escritorio.UI.ChipStyle.Outline;
            this.chipSample1.Name = "chipSample1";
            this.chipSample1.Size = new System.Drawing.Size(90, 22);
            this.chipSample1.Small = true;
            this.chipSample1.Text = "Sin TACC";
            // 
            // pricePanel
            // 
            this.pricePanel.Controls.Add(this.lblDelivery);
            this.pricePanel.Controls.Add(this.lblDeliveryCaption);
            this.pricePanel.Controls.Add(this.lblSalon);
            this.pricePanel.Controls.Add(this.lblSalonCaption);
            this.pricePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pricePanel.CornerRadius = 10;
            this.pricePanel.Location = new System.Drawing.Point(12, 262);
            this.pricePanel.Name = "pricePanel";
            this.pricePanel.Size = new System.Drawing.Size(276, 60);
            this.pricePanel.Surface = app_escritorio.UI.SurfaceLevel.High;
            this.pricePanel.TabIndex = 4;
            this.pricePanel.Click += new System.EventHandler(this.Part_Click);
            // 
            // lblDelivery
            // 
            this.lblDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblDelivery.Location = new System.Drawing.Point(140, 28);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(124, 24);
            this.lblDelivery.TabIndex = 3;
            this.lblDelivery.Text = "$ 66.700";
            this.lblDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDelivery.TextStyle = app_escritorio.UI.TextStyle.BodyBold;
            this.lblDelivery.Click += new System.EventHandler(this.Part_Click);
            // 
            // lblDeliveryCaption
            // 
            this.lblDeliveryCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblDeliveryCaption.Location = new System.Drawing.Point(120, 8);
            this.lblDeliveryCaption.Name = "lblDeliveryCaption";
            this.lblDeliveryCaption.Size = new System.Drawing.Size(144, 16);
            this.lblDeliveryCaption.TabIndex = 2;
            this.lblDeliveryCaption.Text = "Precio Delivery (+15%)";
            this.lblDeliveryCaption.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblDeliveryCaption.TextStyle = app_escritorio.UI.TextStyle.Caption;
            this.lblDeliveryCaption.Click += new System.EventHandler(this.Part_Click);
            // 
            // lblSalon
            // 
            this.lblSalon.Location = new System.Drawing.Point(12, 24);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(140, 30);
            this.lblSalon.TabIndex = 1;
            this.lblSalon.Text = "$ 58.000";
            this.lblSalon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSalon.TextStyle = app_escritorio.UI.TextStyle.Total;
            this.lblSalon.Click += new System.EventHandler(this.Part_Click);
            // 
            // lblSalonCaption
            // 
            this.lblSalonCaption.Location = new System.Drawing.Point(12, 8);
            this.lblSalonCaption.Name = "lblSalonCaption";
            this.lblSalonCaption.Size = new System.Drawing.Size(110, 16);
            this.lblSalonCaption.TabIndex = 0;
            this.lblSalonCaption.Text = "Precio Salón";
            this.lblSalonCaption.TextStyle = app_escritorio.UI.TextStyle.Caption;
            this.lblSalonCaption.Click += new System.EventHandler(this.Part_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.btnPause.Compact = true;
            this.btnPause.Location = new System.Drawing.Point(12, 332);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(232, 34);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "⏸  Pausar por falta de stock";
            this.btnPause.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnEdit.Location = new System.Drawing.Point(252, 332);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(36, 34);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "✎";
            this.btnEdit.Variant = app_escritorio.UI.ButtonVariant.Icon;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // DishCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(47)))), ((int)(((byte)(43)))));
            this.BorderWidth = 1;
            this.CornerRadius = 14;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoverSurface = app_escritorio.UI.SurfaceLevel.Container;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 14, 14);
            this.Name = "DishCard";
            this.Size = new System.Drawing.Size(300, 378);
            this.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.Controls.Add(this.dishImage);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.flowTags);
            this.Controls.Add(this.pricePanel);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnEdit);
            this.pricePanel.ResumeLayout(false);
            this.flowTags.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.Views.Carta.DishImage dishImage;
        private app_escritorio.UI.RLabel lblName;
        private app_escritorio.UI.RLabel lblDescription;
        private app_escritorio.UI.RFlowPanel flowTags;
        private app_escritorio.UI.RChip chipSample2;
        private app_escritorio.UI.RChip chipSample1;
        private app_escritorio.UI.RPanel pricePanel;
        private app_escritorio.UI.RLabel lblDelivery;
        private app_escritorio.UI.RLabel lblDeliveryCaption;
        private app_escritorio.UI.RLabel lblSalon;
        private app_escritorio.UI.RLabel lblSalonCaption;
        private app_escritorio.UI.RButton btnPause;
        private app_escritorio.UI.RButton btnEdit;
    }
}
