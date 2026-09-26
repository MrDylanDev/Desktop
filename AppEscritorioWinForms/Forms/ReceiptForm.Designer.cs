namespace app_escritorio.Forms
{
    partial class ReceiptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReceipt
            // 
            this.txtReceipt.Multiline = true;
            this.txtReceipt.ReadOnly = true;
            this.txtReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReceipt.Height = 380;
            this.txtReceipt.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceipt.BackColor = System.Drawing.Color.White;
            this.txtReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceipt.Margin = new System.Windows.Forms.Padding(10);
            this.txtReceipt.Name = "txtReceipt";
            // 
            // btnPrint
            // 
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.Size = new System.Drawing.Size(100, 40);
            this.btnPrint.Location = new System.Drawing.Point(50, 400);
            this.btnPrint.BackColor = System.Drawing.Color.LightGray;
            this.btnPrint.Name = "btnPrint";
            // 
            // btnClose
            // 
            this.btnClose.Text = "Cerrar";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.Location = new System.Drawing.Point(180, 400);
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Name = "btnClose";
            // 
            // ReceiptForm
            // 
            this.Text = "Recibo";
            this.Size = new System.Drawing.Size(350, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ReceiptForm";
            this.Controls.Add(this.txtReceipt);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
    }
}
