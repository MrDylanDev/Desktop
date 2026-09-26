using System;
using System.Drawing;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    partial class TableDialogForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox NameBox;
        private TextBox CapacityBox;
        private ComboBox SectorBox;
        private ComboBox StatusBox;
        private Label titleLabel;
        private Label lblName;
        private Label lblCapacity;
        private Label lblSector;
        private Label lblStatus;
        private Button btnCancel;
        private Button btnOk;

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
            lblName = new Label();
            NameBox = new TextBox();
            lblCapacity = new Label();
            CapacityBox = new TextBox();
            lblSector = new Label();
            SectorBox = new ComboBox();
            lblStatus = new Label();
            StatusBox = new ComboBox();
            btnCancel = new Button();
            btnOk = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.Location = new Point(20, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(139, 30);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Nueva mesa";
            titleLabel.Click += titleLabel_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.LightGray;
            lblName.Location = new Point(20, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(106, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre o número";
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.FromArgb(40, 42, 44);
            NameBox.Font = new Font("Segoe UI", 12F);
            NameBox.ForeColor = Color.White;
            NameBox.Location = new Point(20, 95);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(280, 29);
            NameBox.TabIndex = 2;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.ForeColor = Color.LightGray;
            lblCapacity.Location = new Point(20, 140);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(63, 15);
            lblCapacity.TabIndex = 3;
            lblCapacity.Text = "Capacidad";
            // 
            // CapacityBox
            // 
            CapacityBox.BackColor = Color.FromArgb(40, 42, 44);
            CapacityBox.Font = new Font("Segoe UI", 12F);
            CapacityBox.ForeColor = Color.White;
            CapacityBox.Location = new Point(20, 165);
            CapacityBox.Name = "CapacityBox";
            CapacityBox.Size = new Size(280, 29);
            CapacityBox.TabIndex = 4;
            // 
            // lblSector
            // 
            lblSector.AutoSize = true;
            lblSector.ForeColor = Color.LightGray;
            lblSector.Location = new Point(20, 210);
            lblSector.Name = "lblSector";
            lblSector.Size = new Size(80, 15);
            lblSector.TabIndex = 5;
            lblSector.Text = "Salón / Sector";
            // 
            // SectorBox
            // 
            SectorBox.BackColor = Color.FromArgb(40, 42, 44);
            SectorBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SectorBox.Font = new Font("Segoe UI", 12F);
            SectorBox.ForeColor = Color.White;
            SectorBox.Items.AddRange(new object[] { "Principal", "Terraza", "Barra", "VIP" });
            SectorBox.Location = new Point(20, 235);
            SectorBox.Name = "SectorBox";
            SectorBox.Size = new Size(280, 29);
            SectorBox.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.LightGray;
            lblStatus.Location = new Point(20, 280);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Estado";
            // 
            // StatusBox
            // 
            StatusBox.BackColor = Color.FromArgb(40, 42, 44);
            StatusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusBox.Font = new Font("Segoe UI", 12F);
            StatusBox.ForeColor = Color.White;
            StatusBox.Items.AddRange(new object[] { "Libre", "Ocupada", "Cuenta pedida", "Reservada", "Por limpiar" });
            StatusBox.Location = new Point(20, 305);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(280, 29);
            StatusBox.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(40, 42, 44);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(80, 360);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(255, 107, 53);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.ForeColor = Color.Black;
            btnOk.Location = new Point(200, 360);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 40);
            btnOk.TabIndex = 10;
            btnOk.Text = "Guardar";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += BtnOk_Click;
            // 
            // TableDialogForm
            // 
            BackColor = Color.FromArgb(17, 20, 21);
            ClientSize = new Size(350, 420);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(StatusBox);
            Controls.Add(lblStatus);
            Controls.Add(SectorBox);
            Controls.Add(lblSector);
            Controls.Add(CapacityBox);
            Controls.Add(lblCapacity);
            Controls.Add(NameBox);
            Controls.Add(lblName);
            Controls.Add(titleLabel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TableDialogForm";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
