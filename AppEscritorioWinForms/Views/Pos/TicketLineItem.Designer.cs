namespace app_escritorio.Views.Pos
{
    partial class TicketLineItem
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
            this.lblName = new app_escritorio.UI.RLabel();
            this.lblDetail = new app_escritorio.UI.RLabel();
            this.lblNotes = new app_escritorio.UI.RLabel();
            this.btnMinus = new app_escritorio.UI.RButton();
            this.lblQty = new app_escritorio.UI.RLabel();
            this.btnPlus = new app_escritorio.UI.RButton();
            this.btnRemove = new app_escritorio.UI.RButton();
            this.lblTotal = new app_escritorio.UI.RLabel();
            this.btnNote = new app_escritorio.UI.RButton();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoEllipsis = true;
            this.lblName.Location = new System.Drawing.Point(10, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(134, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Producto";
            this.lblName.TextStyle = app_escritorio.UI.TextStyle.BodyBold;
            // 
            // lblDetail
            // 
            this.lblDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetail.AutoEllipsis = true;
            this.lblDetail.Location = new System.Drawing.Point(10, 32);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(134, 18);
            this.lblDetail.TabIndex = 1;
            this.lblDetail.Text = "$ 0 c/u";
            this.lblDetail.TextStyle = app_escritorio.UI.TextStyle.Muted;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoEllipsis = true;
            this.lblNotes.Location = new System.Drawing.Point(10, 52);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(134, 16);
            this.lblNotes.TabIndex = 2;
            this.lblNotes.Text = "nota";
            this.lblNotes.TextStyle = app_escritorio.UI.TextStyle.AccentSmall;
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinus.Location = new System.Drawing.Point(150, 18);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Padding = new System.Windows.Forms.Padding(0);
            this.btnMinus.Size = new System.Drawing.Size(30, 30);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.Text = "−";
            this.btnMinus.Variant = app_escritorio.UI.ButtonVariant.Icon;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // lblQty
            // 
            this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQty.Location = new System.Drawing.Point(180, 18);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(28, 30);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "1";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQty.TextStyle = app_escritorio.UI.TextStyle.BodyBold;
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlus.Location = new System.Drawing.Point(208, 18);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Padding = new System.Windows.Forms.Padding(0);
            this.btnPlus.Size = new System.Drawing.Size(30, 30);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.Variant = app_escritorio.UI.ButtonVariant.Icon;
            this.btnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(244, 18);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(0);
            this.btnRemove.Size = new System.Drawing.Size(30, 30);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "×";
            this.btnRemove.Variant = app_escritorio.UI.ButtonVariant.Danger;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Location = new System.Drawing.Point(276, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 30);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "$ 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.TextStyle = app_escritorio.UI.TextStyle.Price;
            // 
            // btnNote
            // 
            this.btnNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNote.Location = new System.Drawing.Point(10, 58);
            this.btnNote.Name = "btnNote";
            this.btnNote.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnNote.Size = new System.Drawing.Size(70, 24);
            this.btnNote.TabIndex = 8;
            this.btnNote.Text = "✎ Nota";
            this.btnNote.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnNote.Click += new System.EventHandler(this.BtnNote_Click);
            // 
            // TicketLineItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblName);
            this.CornerRadius = 10;
            this.HoverSurface = app_escritorio.UI.SurfaceLevel.Container;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.Name = "TicketLineItem";
            this.Size = new System.Drawing.Size(360, 92);
            this.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RLabel lblName;
        private app_escritorio.UI.RLabel lblDetail;
        private app_escritorio.UI.RLabel lblNotes;
        private app_escritorio.UI.RButton btnMinus;
        private app_escritorio.UI.RLabel lblQty;
        private app_escritorio.UI.RButton btnPlus;
        private app_escritorio.UI.RButton btnRemove;
        private app_escritorio.UI.RLabel lblTotal;
        private app_escritorio.UI.RButton btnNote;
    }
}
