using System;
using System.Drawing;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    public partial class AdminCodeForm : Form
    {
        private const string DemoCode = "1234";
        private string _code = string.Empty;

        public AdminCodeForm()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private void NumBtn_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            if (text == "C") _code = "";
            else if (text == "⌫") { if (_code.Length > 0) _code = _code.Substring(0, _code.Length - 1); }
            else if (_code.Length < 4) _code += text;
            
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            string display = "";
            for (int i = 0; i < 4; i++)
            {
                display += (i < _code.Length ? "●" : "_") + " ";
            }
            lblCodeDisplay.Text = display.Trim();
            lblError.Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (_code != DemoCode)
            {
                lblError.Text = "Código incorrecto. Usa 1234.";
                lblError.Visible = true;
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
