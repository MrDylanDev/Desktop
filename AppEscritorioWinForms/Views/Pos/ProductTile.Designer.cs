namespace app_escritorio.Views.Pos
{
    partial class ProductTile
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
            this.lblCategory = new app_escritorio.UI.RLabel();
            this.lblName = new app_escritorio.UI.RLabel();
            this.lblPrice = new app_escritorio.UI.RLabel();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(12, 12);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(166, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Categoría";
            this.lblCategory.TextStyle = app_escritorio.UI.TextStyle.AccentSmall;
            this.lblCategory.Click += new System.EventHandler(this.Part_Click);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(12, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(166, 40);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre del producto";
            this.lblName.TextStyle = app_escritorio.UI.TextStyle.BodyBold;
            this.lblName.Click += new System.EventHandler(this.Part_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Location = new System.Drawing.Point(58, 80);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(120, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "$ 0";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.TextStyle = app_escritorio.UI.TextStyle.Price;
            this.lblPrice.Click += new System.EventHandler(this.Part_Click);
            // 
            // ProductTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCategory);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoverSurface = app_escritorio.UI.SurfaceLevel.Highest;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Name = "ProductTile";
            this.Size = new System.Drawing.Size(190, 112);
            this.Click += new System.EventHandler(this.Part_Click);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RLabel lblCategory;
        private app_escritorio.UI.RLabel lblName;
        private app_escritorio.UI.RLabel lblPrice;
    }
}
