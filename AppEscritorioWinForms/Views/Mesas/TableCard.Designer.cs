namespace app_escritorio.Views.Mesas
{
    partial class TableCard
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
            this.lblNumber = new app_escritorio.UI.RLabel();
            this.lblStatus = new app_escritorio.UI.RLabel();
            this.lblCapacity = new app_escritorio.UI.RLabel();
            this.lblTotal = new app_escritorio.UI.RLabel();
            this.btnOpen = new app_escritorio.UI.RButton();
            this.btnEdit = new app_escritorio.UI.RButton();
            this.btnDelete = new app_escritorio.UI.RButton();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(14, 10);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(110, 42);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "1";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumber.TextStyle = app_escritorio.UI.TextStyle.Number;
            this.lblNumber.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(124, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(102, 18);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Libre";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblStatus.TextStyle = app_escritorio.UI.TextStyle.Overline;
            this.lblStatus.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblCapacity
            // 
            this.lblCapacity.Location = new System.Drawing.Point(14, 56);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(212, 18);
            this.lblCapacity.TabIndex = 2;
            this.lblCapacity.Text = "2 personas";
            this.lblCapacity.TextStyle = app_escritorio.UI.TextStyle.Muted;
            this.lblCapacity.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(14, 78);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(212, 20);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "$0";
            this.lblTotal.TextStyle = app_escritorio.UI.TextStyle.AccentBold;
            this.lblTotal.Click += new System.EventHandler(this.Card_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Compact = true;
            this.btnOpen.Location = new System.Drawing.Point(14, 112);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnOpen.Size = new System.Drawing.Size(96, 30);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Abrir en POS";
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Compact = true;
            this.btnEdit.Location = new System.Drawing.Point(116, 112);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnEdit.Size = new System.Drawing.Size(60, 30);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(182, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0);
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "×";
            this.btnDelete.Variant = app_escritorio.UI.ButtonVariant.Danger;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TableCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(222)))), ((int)(((byte)(163)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNumber);
            this.CornerRadius = 14;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoverSurface = app_escritorio.UI.SurfaceLevel.Container;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            this.Name = "TableCard";
            this.Size = new System.Drawing.Size(240, 160);
            this.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.Click += new System.EventHandler(this.Card_Click);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RLabel lblNumber;
        private app_escritorio.UI.RLabel lblStatus;
        private app_escritorio.UI.RLabel lblCapacity;
        private app_escritorio.UI.RLabel lblTotal;
        private app_escritorio.UI.RButton btnOpen;
        private app_escritorio.UI.RButton btnEdit;
        private app_escritorio.UI.RButton btnDelete;
    }
}
