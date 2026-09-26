namespace app_escritorio.Forms
{
    partial class CheckoutForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTotal = new Label();
            lblMesa = new Label();
            lblPaid = new Label();
            lblChange = new Label();
            btnFinish = new Button();
            numpad = new TableLayoutPanel();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnNumC = new Button();
            btnNum0 = new Button();
            btnNum000 = new Button();
            rbCash = new RadioButton();
            rbCard = new RadioButton();
            titleLabel = new Label();
            panelInfo = new Panel();
            lblTotalText = new Label();
            lblMethodText = new Label();
            lblChangeText = new Label();
            lblRecibidoText = new Label();
            btnCancel = new Button();
            numpad.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(255, 107, 53);
            lblTotal.Location = new Point(200, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(200, 40);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "$0";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Font = new Font("Segoe UI", 12F);
            lblMesa.ForeColor = Color.LightGray;
            lblMesa.Location = new Point(35, 60);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(47, 21);
            lblMesa.TabIndex = 1;
            lblMesa.Text = "Mesa";
            // 
            // lblPaid
            // 
            lblPaid.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblPaid.ForeColor = Color.White;
            lblPaid.Location = new Point(30, 290);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(200, 40);
            lblPaid.TabIndex = 4;
            lblPaid.Text = "$0";
            // 
            // lblChange
            // 
            lblChange.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblChange.ForeColor = Color.White;
            lblChange.Location = new Point(200, 105);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(200, 30);
            lblChange.TabIndex = 6;
            lblChange.Text = "$0";
            lblChange.TextAlign = ContentAlignment.MiddleRight;
            lblChange.Click += lblChange_Click;
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.FromArgb(255, 107, 53);
            btnFinish.FlatStyle = FlatStyle.Flat;
            btnFinish.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFinish.ForeColor = Color.Black;
            btnFinish.Location = new Point(250, 490);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(200, 50);
            btnFinish.TabIndex = 7;
            btnFinish.Text = "Finalizar";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += Finish_Click;
            // 
            // numpad
            // 
            numpad.ColumnCount = 3;
            numpad.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            numpad.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            numpad.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            numpad.Controls.Add(btnNum1, 0, 0);
            numpad.Controls.Add(btnNum2, 1, 0);
            numpad.Controls.Add(btnNum3, 2, 0);
            numpad.Controls.Add(btnNum4, 0, 1);
            numpad.Controls.Add(btnNum5, 1, 1);
            numpad.Controls.Add(btnNum6, 2, 1);
            numpad.Controls.Add(btnNum7, 0, 2);
            numpad.Controls.Add(btnNum8, 1, 2);
            numpad.Controls.Add(btnNum9, 2, 2);
            numpad.Controls.Add(btnNumC, 0, 3);
            numpad.Controls.Add(btnNum0, 1, 3);
            numpad.Controls.Add(btnNum000, 2, 3);
            numpad.Location = new Point(250, 270);
            numpad.Name = "numpad";
            numpad.RowCount = 4;
            numpad.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            numpad.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            numpad.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            numpad.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            numpad.Size = new Size(200, 200);
            numpad.TabIndex = 5;
            // 
            // btnNum1
            // 
            btnNum1.BackColor = Color.FromArgb(40, 42, 44);
            btnNum1.Dock = DockStyle.Fill;
            btnNum1.FlatAppearance.BorderSize = 0;
            btnNum1.FlatStyle = FlatStyle.Flat;
            btnNum1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNum1.Location = new Point(2, 2);
            btnNum1.Margin = new Padding(2);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(16, 16);
            btnNum1.TabIndex = 0;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += Numpad_Click;
            // 
            // btnNum2
            // 
            btnNum2.BackColor = Color.FromArgb(40, 42, 44);
            btnNum2.Dock = DockStyle.Fill;
            btnNum2.FlatAppearance.BorderSize = 0;
            btnNum2.FlatStyle = FlatStyle.Flat;
            btnNum2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNum2.Location = new Point(22, 2);
            btnNum2.Margin = new Padding(2);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(16, 16);
            btnNum2.TabIndex = 1;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = false;
            btnNum2.Click += Numpad_Click;
            // 
            // btnNum3
            // 
            btnNum3.BackColor = Color.FromArgb(40, 42, 44);
            btnNum3.Dock = DockStyle.Fill;
            btnNum3.FlatAppearance.BorderSize = 0;
            btnNum3.FlatStyle = FlatStyle.Flat;
            btnNum3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNum3.Location = new Point(42, 2);
            btnNum3.Margin = new Padding(2);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(156, 16);
            btnNum3.TabIndex = 2;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = false;
            btnNum3.Click += Numpad_Click;
            // 
            // btnNum4
            // 
            btnNum4.BackColor = Color.FromArgb(40, 42, 44);
            btnNum4.Dock = DockStyle.Fill;
            btnNum4.FlatAppearance.BorderSize = 0;
            btnNum4.FlatStyle = FlatStyle.Flat;
            btnNum4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNum4.Location = new Point(2, 22);
            btnNum4.Margin = new Padding(2);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(16, 16);
            btnNum4.TabIndex = 3;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = false;
            btnNum4.Click += Numpad_Click;
            // 
            // btnNum5
            // 
            btnNum5.BackColor = Color.FromArgb(40, 42, 44);
            btnNum5.Dock = DockStyle.Fill;
            btnNum5.FlatAppearance.BorderSize = 0;
            btnNum5.FlatStyle = FlatStyle.Flat;
            btnNum5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNum5.Location = new Point(22, 22);
            btnNum5.Margin = new Padding(2);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(16, 16);
            btnNum5.TabIndex = 4;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = false;
            btnNum5.Click += Numpad_Click;
            // 
            // btnNum6
            // 
            btnNum6.BackColor = Color.FromArgb(40, 42, 44);
            btnNum6.Dock = DockStyle.Fill;
            btnNum6.FlatAppearance.BorderSize = 0;
            btnNum6.FlatStyle = FlatStyle.Flat;
            btnNum6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNum6.Location = new Point(42, 22);
            btnNum6.Margin = new Padding(2);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(156, 16);
            btnNum6.TabIndex = 5;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = false;
            btnNum6.Click += Numpad_Click;
            // 
            // btnNum7
            // 
            btnNum7.BackColor = Color.FromArgb(40, 42, 44);
            btnNum7.Dock = DockStyle.Fill;
            btnNum7.FlatAppearance.BorderSize = 0;
            btnNum7.FlatStyle = FlatStyle.Flat;
            btnNum7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNum7.Location = new Point(2, 42);
            btnNum7.Margin = new Padding(2);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(16, 16);
            btnNum7.TabIndex = 6;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = false;
            btnNum7.Click += Numpad_Click;
            // 
            // btnNum8
            // 
            btnNum8.BackColor = Color.FromArgb(40, 42, 44);
            btnNum8.Dock = DockStyle.Fill;
            btnNum8.FlatAppearance.BorderSize = 0;
            btnNum8.FlatStyle = FlatStyle.Flat;
            btnNum8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNum8.Location = new Point(22, 42);
            btnNum8.Margin = new Padding(2);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(16, 16);
            btnNum8.TabIndex = 7;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = false;
            btnNum8.Click += Numpad_Click;
            // 
            // btnNum9
            // 
            btnNum9.BackColor = Color.FromArgb(40, 42, 44);
            btnNum9.Dock = DockStyle.Fill;
            btnNum9.FlatAppearance.BorderSize = 0;
            btnNum9.FlatStyle = FlatStyle.Flat;
            btnNum9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNum9.Location = new Point(42, 42);
            btnNum9.Margin = new Padding(2);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(156, 16);
            btnNum9.TabIndex = 8;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = false;
            btnNum9.Click += Numpad_Click;
            // 
            // btnNumC
            // 
            btnNumC.BackColor = Color.DarkRed;
            btnNumC.Dock = DockStyle.Fill;
            btnNumC.FlatAppearance.BorderSize = 0;
            btnNumC.FlatStyle = FlatStyle.Flat;
            btnNumC.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNumC.Location = new Point(2, 62);
            btnNumC.Margin = new Padding(2);
            btnNumC.Name = "btnNumC";
            btnNumC.Size = new Size(16, 136);
            btnNumC.TabIndex = 9;
            btnNumC.Text = "C";
            btnNumC.UseVisualStyleBackColor = false;
            btnNumC.Click += Numpad_Click;
            // 
            // btnNum0
            // 
            btnNum0.BackColor = Color.FromArgb(40, 42, 44);
            btnNum0.Dock = DockStyle.Fill;
            btnNum0.FlatAppearance.BorderSize = 0;
            btnNum0.FlatStyle = FlatStyle.Flat;
            btnNum0.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNum0.Location = new Point(22, 62);
            btnNum0.Margin = new Padding(2);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(16, 136);
            btnNum0.TabIndex = 10;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = false;
            btnNum0.Click += Numpad_Click;
            // 
            // btnNum000
            // 
            btnNum000.BackColor = Color.FromArgb(40, 42, 44);
            btnNum000.Dock = DockStyle.Fill;
            btnNum000.FlatAppearance.BorderSize = 0;
            btnNum000.FlatStyle = FlatStyle.Flat;
            btnNum000.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnNum000.Location = new Point(42, 62);
            btnNum000.Margin = new Padding(2);
            btnNum000.Name = "btnNum000";
            btnNum000.Size = new Size(156, 136);
            btnNum000.TabIndex = 11;
            btnNum000.Text = "000";
            btnNum000.UseVisualStyleBackColor = false;
            btnNum000.Click += Numpad_Click;
            // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.Font = new Font("Segoe UI", 12F);
            rbCash.ForeColor = Color.White;
            rbCash.Location = new Point(200, 70);
            rbCash.Name = "rbCash";
            rbCash.Size = new Size(82, 25);
            rbCash.TabIndex = 3;
            rbCash.Text = "Efectivo";
            rbCash.CheckedChanged += Method_Changed;
            // 
            // rbCard
            // 
            rbCard.AutoSize = true;
            rbCard.Font = new Font("Segoe UI", 12F);
            rbCard.ForeColor = Color.White;
            rbCard.Location = new Point(300, 70);
            rbCard.Name = "rbCard";
            rbCard.Size = new Size(132, 25);
            rbCard.TabIndex = 4;
            rbCard.Text = "Tarjeta / Transf.";
            rbCard.CheckedChanged += Method_Changed;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            titleLabel.Location = new Point(30, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(226, 37);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Completar pago";
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(29, 32, 34);
            panelInfo.Controls.Add(lblTotalText);
            panelInfo.Controls.Add(lblTotal);
            panelInfo.Controls.Add(lblMethodText);
            panelInfo.Controls.Add(rbCash);
            panelInfo.Controls.Add(rbCard);
            panelInfo.Controls.Add(lblChangeText);
            panelInfo.Controls.Add(lblChange);
            panelInfo.Location = new Point(30, 100);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(420, 150);
            panelInfo.TabIndex = 2;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Font = new Font("Segoe UI", 12F);
            lblTotalText.ForeColor = Color.LightGray;
            lblTotalText.Location = new Point(20, 20);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(98, 21);
            lblTotalText.TabIndex = 0;
            lblTotalText.Text = "Total a pagar";
            // 
            // lblMethodText
            // 
            lblMethodText.AutoSize = true;
            lblMethodText.Font = new Font("Segoe UI", 12F);
            lblMethodText.ForeColor = Color.LightGray;
            lblMethodText.Location = new Point(20, 70);
            lblMethodText.Name = "lblMethodText";
            lblMethodText.Size = new Size(64, 21);
            lblMethodText.TabIndex = 2;
            lblMethodText.Text = "Método";
            // 
            // lblChangeText
            // 
            lblChangeText.AutoSize = true;
            lblChangeText.Font = new Font("Segoe UI", 12F);
            lblChangeText.ForeColor = Color.LightGray;
            lblChangeText.Location = new Point(20, 110);
            lblChangeText.Name = "lblChangeText";
            lblChangeText.Size = new Size(55, 21);
            lblChangeText.TabIndex = 5;
            lblChangeText.Text = "Vuelto";
            // 
            // lblRecibidoText
            // 
            lblRecibidoText.AutoSize = true;
            lblRecibidoText.Font = new Font("Segoe UI", 10F);
            lblRecibidoText.ForeColor = Color.Gray;
            lblRecibidoText.Location = new Point(30, 270);
            lblRecibidoText.Name = "lblRecibidoText";
            lblRecibidoText.Size = new Size(165, 19);
            lblRecibidoText.TabIndex = 3;
            lblRecibidoText.Text = "Monto recibido (efectivo):";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(40, 42, 44);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(30, 490);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 50);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // CheckoutForm
            // 
            BackColor = Color.FromArgb(17, 20, 21);
            ClientSize = new Size(500, 600);
            Controls.Add(titleLabel);
            Controls.Add(lblMesa);
            Controls.Add(panelInfo);
            Controls.Add(lblRecibidoText);
            Controls.Add(lblPaid);
            Controls.Add(numpad);
            Controls.Add(btnCancel);
            Controls.Add(btnFinish);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CheckoutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cobro";
            numpad.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TableLayoutPanel numpad;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCard;
        
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNumC;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNum000;
        
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblMethodText;
        private System.Windows.Forms.Label lblChangeText;
        private System.Windows.Forms.Label lblRecibidoText;
        private System.Windows.Forms.Button btnCancel;
    }
}
