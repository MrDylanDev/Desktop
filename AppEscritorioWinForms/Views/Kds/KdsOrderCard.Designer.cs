namespace app_escritorio.Views.Kds
{
    partial class KdsOrderCard
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
            this.lblMesa = new app_escritorio.UI.RLabel();
            this.lblElapsed = new app_escritorio.UI.RLabel();
            this.lblCreated = new app_escritorio.UI.RLabel();
            this.pnlItems = new app_escritorio.UI.RPanel();
            this.lblSampleNote = new app_escritorio.UI.RLabel();
            this.lblSampleLine = new app_escritorio.UI.RLabel();
            this.btnBack = new app_escritorio.UI.RButton();
            this.btnForward = new app_escritorio.UI.RButton();
            this.pnlItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMesa
            // 
            this.lblMesa.Location = new System.Drawing.Point(12, 10);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(190, 26);
            this.lblMesa.TabIndex = 0;
            this.lblMesa.Text = "Mesa 2";
            this.lblMesa.TextStyle = app_escritorio.UI.TextStyle.Heading;
            // 
            // lblElapsed
            // 
            this.lblElapsed.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.lblElapsed.ColorOverride = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(222)))), ((int)(((byte)(163)))));
            this.lblElapsed.Location = new System.Drawing.Point(200, 14);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(88, 18);
            this.lblElapsed.TabIndex = 1;
            this.lblElapsed.Text = "hace 4m";
            this.lblElapsed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblElapsed.TextStyle = app_escritorio.UI.TextStyle.Overline;
            // 
            // lblCreated
            // 
            this.lblCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblCreated.Location = new System.Drawing.Point(12, 36);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(276, 16);
            this.lblCreated.TabIndex = 2;
            this.lblCreated.Text = "Pedido 12:30";
            this.lblCreated.TextStyle = app_escritorio.UI.TextStyle.Caption;
            // 
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.lblSampleNote);
            this.pnlItems.Controls.Add(this.lblSampleLine);
            this.pnlItems.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlItems.Location = new System.Drawing.Point(12, 58);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(276, 64);
            this.pnlItems.Surface = app_escritorio.UI.SurfaceLevel.Transparent;
            this.pnlItems.TabIndex = 3;
            // 
            // lblSampleNote
            // 
            this.lblSampleNote.Location = new System.Drawing.Point(0, 22);
            this.lblSampleNote.Name = "lblSampleNote";
            this.lblSampleNote.Size = new System.Drawing.Size(276, 16);
            this.lblSampleNote.TabIndex = 1;
            this.lblSampleNote.Text = "término medio";
            this.lblSampleNote.TextStyle = app_escritorio.UI.TextStyle.AccentSmall;
            // 
            // lblSampleLine
            // 
            this.lblSampleLine.Location = new System.Drawing.Point(0, 0);
            this.lblSampleLine.Name = "lblSampleLine";
            this.lblSampleLine.Size = new System.Drawing.Size(276, 20);
            this.lblSampleLine.TabIndex = 0;
            this.lblSampleLine.Text = "x1 Bife de Chorizo 400g";
            this.lblSampleLine.TextStyle = app_escritorio.UI.TextStyle.Body;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 130);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 36);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "◀ Nuevo";
            this.btnBack.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(12, 130);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(276, 36);
            this.btnForward.TabIndex = 5;
            this.btnForward.Text = "▶  Preparar";
            this.btnForward.Variant = app_escritorio.UI.ButtonVariant.Primary;
            this.btnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // KdsOrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(95)))));
            this.BorderWidth = 1;
            this.CornerRadius = 12;
            this.HoverSurface = app_escritorio.UI.SurfaceLevel.Container;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "KdsOrderCard";
            this.Size = new System.Drawing.Size(300, 178);
            this.Surface = app_escritorio.UI.SurfaceLevel.Container;
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.lblElapsed);
            this.Controls.Add(this.lblCreated);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForward);
            this.pnlItems.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RLabel lblMesa;
        private app_escritorio.UI.RLabel lblElapsed;
        private app_escritorio.UI.RLabel lblCreated;
        private app_escritorio.UI.RPanel pnlItems;
        private app_escritorio.UI.RLabel lblSampleNote;
        private app_escritorio.UI.RLabel lblSampleLine;
        private app_escritorio.UI.RButton btnBack;
        private app_escritorio.UI.RButton btnForward;
    }
}
