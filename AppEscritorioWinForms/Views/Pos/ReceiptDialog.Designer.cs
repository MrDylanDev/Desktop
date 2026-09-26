namespace app_escritorio.Views.Pos
{
    partial class ReceiptDialog
    {
        /// <summary>Variable del diseñador requerida.</summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.root = new app_escritorio.UI.RPanel();
            this.paper = new System.Windows.Forms.Panel();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.btnClose = new app_escritorio.UI.RButton();
            this.btnPrint = new app_escritorio.UI.RButton();
            this.root.SuspendLayout();
            this.paper.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.Controls.Add(this.btnPrint);
            this.root.Controls.Add(this.btnClose);
            this.root.Controls.Add(this.paper);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(404, 584);
            this.root.Surface = app_escritorio.UI.SurfaceLevel.Surface;
            this.root.TabIndex = 0;
            // 
            // paper
            // 
            this.paper.BackColor = System.Drawing.Color.White;
            this.paper.Controls.Add(this.txtReceipt);
            this.paper.Location = new System.Drawing.Point(22, 22);
            this.paper.Name = "paper";
            this.paper.Padding = new System.Windows.Forms.Padding(18);
            this.paper.Size = new System.Drawing.Size(360, 490);
            this.paper.TabIndex = 0;
            // 
            // txtReceipt
            // 
            this.txtReceipt.BackColor = System.Drawing.Color.White;
            this.txtReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceipt.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.txtReceipt.ForeColor = System.Drawing.Color.Black;
            this.txtReceipt.Location = new System.Drawing.Point(18, 18);
            this.txtReceipt.Multiline = true;
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.ReadOnly = true;
            this.txtReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceipt.Size = new System.Drawing.Size(324, 454);
            this.txtReceipt.TabIndex = 0;
            this.txtReceipt.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(162, 528);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cerrar";
            this.btnClose.Variant = app_escritorio.UI.ButtonVariant.Secondary;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(272, 528);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 38);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // ReceiptDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(404, 584);
            this.Controls.Add(this.root);
            this.Name = "ReceiptDialog";
            this.Text = "Vista previa del recibo";
            this.root.ResumeLayout(false);
            this.paper.ResumeLayout(false);
            this.paper.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private app_escritorio.UI.RPanel root;
        private System.Windows.Forms.Panel paper;
        private System.Windows.Forms.TextBox txtReceipt;
        private app_escritorio.UI.RButton btnClose;
        private app_escritorio.UI.RButton btnPrint;
    }
}
