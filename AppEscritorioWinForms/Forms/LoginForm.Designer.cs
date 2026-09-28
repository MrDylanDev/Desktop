namespace app_escritorio.Forms
{
    partial class LoginForm
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
            subtitleLabel = new Label();
            roleLabel = new Label();
            btnAdmin = new Button();
            btnEmpleado = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(255, 107, 53);
            titleLabel.Location = new Point(130, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(183, 45);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "◉ RestoOS";
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 12F);
            subtitleLabel.ForeColor = Color.LightGray;
            subtitleLabel.Location = new Point(155, 65);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(141, 21);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Selecciona tu perfil";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            roleLabel.ForeColor = Color.Gray;
            roleLabel.Location = new Point(175, 110);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(106, 19);
            roleLabel.TabIndex = 2;
            roleLabel.Text = "Ingresar como";
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(255, 107, 53);
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.FromArgb(93, 24, 0);
            btnAdmin.Location = new Point(30, 140);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(380, 80);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "◆ Administrador\nSolo Administración: Módulos y Reportes";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += BtnAdmin_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackColor = Color.FromArgb(40, 42, 44);
            btnEmpleado.FlatAppearance.BorderSize = 0;
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEmpleado.ForeColor = Color.White;
            btnEmpleado.Location = new Point(30, 240);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(380, 80);
            btnEmpleado.TabIndex = 4;
            btnEmpleado.Text = "▦ Empleados\nOperación: POS, Mesas, KDS, Inventario...";
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += BtnEmpleado_Click;
            // 
            // LoginForm
            // 
            BackColor = Color.FromArgb(17, 20, 21);
            ClientSize = new Size(460, 420);
            Controls.Add(btnEmpleado);
            Controls.Add(btnAdmin);
            Controls.Add(roleLabel);
            Controls.Add(subtitleLabel);
            Controls.Add(titleLabel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RestoOS - Ingreso";
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnEmpleado;
    }
}
