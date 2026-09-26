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
            this.titleLabel = new System.Windows.Forms.Label();
            this.demoLabel = new System.Windows.Forms.Label();
            this.lblCodeDisplay = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(45, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(262, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Acceso Administrador";
            // 
            // demoLabel
            // 
            this.demoLabel.AutoSize = true;
            this.demoLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.demoLabel.ForeColor = System.Drawing.Color.Gray;
            this.demoLabel.Location = new System.Drawing.Point(40, 60);
            this.demoLabel.Name = "demoLabel";
            this.demoLabel.Size = new System.Drawing.Size(267, 38);
            this.demoLabel.TabIndex = 1;
            this.demoLabel.Text = "Código demo: 1234\nExpira 30/09/2026 · 4 dígitos numéricos";
            this.demoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodeDisplay
            // 
            this.lblCodeDisplay.AutoSize = true;
            this.lblCodeDisplay.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold);
            this.lblCodeDisplay.Location = new System.Drawing.Point(135, 120);
            this.lblCodeDisplay.Name = "lblCodeDisplay";
            this.lblCodeDisplay.Size = new System.Drawing.Size(91, 36);
            this.lblCodeDisplay.TabIndex = 2;
            this.lblCodeDisplay.Text = "____";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(90, 160);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(155, 13);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "Código incorrecto. Usa 1234.";
            this.lblError.Visible = false;
            // 
            // btnPanel
            // 
            this.btnPanel.ColumnCount = 3;
            this.btnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.btnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.btnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.btnPanel.Controls.Add(this.btn1, 0, 0);
            this.btnPanel.Controls.Add(this.btn2, 1, 0);
            this.btnPanel.Controls.Add(this.btn3, 2, 0);
            this.btnPanel.Controls.Add(this.btn4, 0, 1);
            this.btnPanel.Controls.Add(this.btn5, 1, 1);
            this.btnPanel.Controls.Add(this.btn6, 2, 1);
            this.btnPanel.Controls.Add(this.btn7, 0, 2);
            this.btnPanel.Controls.Add(this.btn8, 1, 2);
            this.btnPanel.Controls.Add(this.btn9, 2, 2);
            this.btnPanel.Controls.Add(this.btnC, 0, 3);
            this.btnPanel.Controls.Add(this.btn0, 1, 3);
            this.btnPanel.Controls.Add(this.btnBack, 2, 3);
            this.btnPanel.Location = new System.Drawing.Point(40, 190);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.RowCount = 4;
            this.btnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnPanel.Size = new System.Drawing.Size(260, 200);
            this.btnPanel.TabIndex = 4;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Margin = new System.Windows.Forms.Padding(3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 44);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn2.Location = new System.Drawing.Point(89, 3);
            this.btn2.Margin = new System.Windows.Forms.Padding(3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 44);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn3.Location = new System.Drawing.Point(175, 3);
            this.btn3.Margin = new System.Windows.Forms.Padding(3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(82, 44);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn4.Location = new System.Drawing.Point(3, 53);
            this.btn4.Margin = new System.Windows.Forms.Padding(3);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 44);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn5.Location = new System.Drawing.Point(89, 53);
            this.btn5.Margin = new System.Windows.Forms.Padding(3);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 44);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn6.Location = new System.Drawing.Point(175, 53);
            this.btn6.Margin = new System.Windows.Forms.Padding(3);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(82, 44);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn7.Location = new System.Drawing.Point(3, 103);
            this.btn7.Margin = new System.Windows.Forms.Padding(3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 44);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn8.Location = new System.Drawing.Point(89, 103);
            this.btn8.Margin = new System.Windows.Forms.Padding(3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 44);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn9.Location = new System.Drawing.Point(175, 103);
            this.btn9.Margin = new System.Windows.Forms.Padding(3);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(82, 44);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.DarkRed;
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnC.Location = new System.Drawing.Point(3, 153);
            this.btnC.Margin = new System.Windows.Forms.Padding(3);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(80, 44);
            this.btnC.TabIndex = 9;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn0.Location = new System.Drawing.Point(89, 153);
            this.btn0.Margin = new System.Windows.Forms.Padding(3);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 44);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(175, 153);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 44);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "⌫";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.NumBtn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(40, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(53)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(180, 410);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 40);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ingresar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // AdminCodeForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(360, 520);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCodeDisplay);
            this.Controls.Add(this.demoLabel);
            this.Controls.Add(this.titleLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Código Administrador";
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
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
