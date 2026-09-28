using System;
using System.Drawing;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    partial class AdminCodeForm
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

        private void InitializeComponent()
        {
            titleLabel = new Label();
            demoLabel = new Label();
            lblCodeDisplay = new Label();
            lblError = new Label();
            btnPanel = new TableLayoutPanel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnC = new Button();
            btn0 = new Button();
            btnBack = new Button();
            btnCancel = new Button();
            btnOk = new Button();
            btnPanel.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.Location = new Point(45, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(267, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Acceso Administrador";
            // 
            // demoLabel
            // 
            demoLabel.AutoSize = true;
            demoLabel.Font = new Font("Segoe UI", 10F);
            demoLabel.ForeColor = Color.Gray;
            demoLabel.Location = new Point(40, 60);
            demoLabel.Name = "demoLabel";
            demoLabel.Size = new Size(254, 38);
            demoLabel.TabIndex = 1;
            demoLabel.Text = "Código demo: 1234\nExpira 30/09/2026 · 4 dígitos numéricos";
            demoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodeDisplay
            // 
            lblCodeDisplay.AutoSize = true;
            lblCodeDisplay.Font = new Font("Courier New", 24F, FontStyle.Bold);
            lblCodeDisplay.Location = new Point(135, 120);
            lblCodeDisplay.Name = "lblCodeDisplay";
            lblCodeDisplay.Size = new Size(91, 36);
            lblCodeDisplay.TabIndex = 2;
            lblCodeDisplay.Text = "____";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(90, 160);
            lblError.Name = "lblError";
            lblError.Size = new Size(158, 15);
            lblError.TabIndex = 3;
            lblError.Text = "Código incorrecto. Usa 1234.";
            lblError.Visible = false;
            // 
            // btnPanel
            // 
            btnPanel.ColumnCount = 3;
            btnPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            btnPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            btnPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            btnPanel.Controls.Add(btn1, 0, 0);
            btnPanel.Controls.Add(btn2, 1, 0);
            btnPanel.Controls.Add(btn3, 2, 0);
            btnPanel.Controls.Add(btn4, 0, 1);
            btnPanel.Controls.Add(btn5, 1, 1);
            btnPanel.Controls.Add(btn6, 2, 1);
            btnPanel.Controls.Add(btn7, 0, 2);
            btnPanel.Controls.Add(btn8, 1, 2);
            btnPanel.Controls.Add(btn9, 2, 2);
            btnPanel.Controls.Add(btnC, 0, 3);
            btnPanel.Controls.Add(btn0, 1, 3);
            btnPanel.Controls.Add(btnBack, 2, 3);
            btnPanel.Location = new Point(40, 190);
            btnPanel.Name = "btnPanel";
            btnPanel.RowCount = 4;
            btnPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            btnPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            btnPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            btnPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            btnPanel.Size = new Size(260, 200);
            btnPanel.TabIndex = 4;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(40, 42, 44);
            btn1.Dock = DockStyle.Fill;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 44);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += NumBtn_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(40, 42, 44);
            btn2.Dock = DockStyle.Fill;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn2.Location = new Point(89, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 44);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += NumBtn_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(40, 42, 44);
            btn3.Dock = DockStyle.Fill;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn3.Location = new Point(175, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(82, 44);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += NumBtn_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(40, 42, 44);
            btn4.Dock = DockStyle.Fill;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn4.Location = new Point(3, 53);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 44);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += NumBtn_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(40, 42, 44);
            btn5.Dock = DockStyle.Fill;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn5.Location = new Point(89, 53);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 44);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += NumBtn_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(40, 42, 44);
            btn6.Dock = DockStyle.Fill;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn6.Location = new Point(175, 53);
            btn6.Name = "btn6";
            btn6.Size = new Size(82, 44);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += NumBtn_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(40, 42, 44);
            btn7.Dock = DockStyle.Fill;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn7.Location = new Point(3, 103);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 44);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += NumBtn_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(40, 42, 44);
            btn8.Dock = DockStyle.Fill;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn8.Location = new Point(89, 103);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 44);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += NumBtn_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(40, 42, 44);
            btn9.Dock = DockStyle.Fill;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn9.Location = new Point(175, 103);
            btn9.Name = "btn9";
            btn9.Size = new Size(82, 44);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += NumBtn_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.DarkRed;
            btnC.Dock = DockStyle.Fill;
            btnC.FlatAppearance.BorderSize = 0;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnC.Location = new Point(3, 153);
            btnC.Name = "btnC";
            btnC.Size = new Size(80, 44);
            btnC.TabIndex = 9;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += NumBtn_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(40, 42, 44);
            btn0.Dock = DockStyle.Fill;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn0.Location = new Point(89, 153);
            btn0.Name = "btn0";
            btn0.Size = new Size(80, 44);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += NumBtn_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkGray;
            btnBack.Dock = DockStyle.Fill;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnBack.Location = new Point(175, 153);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(82, 44);
            btnBack.TabIndex = 11;
            btnBack.Text = "⌫";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += NumBtn_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(40, 42, 44);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(40, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(255, 107, 53);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = Color.Black;
            btnOk.Location = new Point(180, 410);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 40);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ingresar";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += BtnOk_Click;
            // 
            // AdminCodeForm
            // 
            BackColor = Color.FromArgb(17, 20, 21);
            ClientSize = new Size(360, 520);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(btnPanel);
            Controls.Add(lblError);
            Controls.Add(lblCodeDisplay);
            Controls.Add(demoLabel);
            Controls.Add(titleLabel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminCodeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Código Administrador";
            btnPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label demoLabel;
        private System.Windows.Forms.Label lblCodeDisplay;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TableLayoutPanel btnPanel;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}
