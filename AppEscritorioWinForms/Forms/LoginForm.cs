using System;
using System.Drawing;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    public partial class LoginForm : Form
    {
        public string Role { get; private set; } = "Empleado";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            var adminCode = new AdminCodeForm();
            if (adminCode.ShowDialog(this) == DialogResult.OK)
            {
                this.Role = "Admin";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            this.Role = "Empleado";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}



