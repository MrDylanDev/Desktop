using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    public partial class CheckoutForm : Form
    {
        private decimal _total;
        private decimal _paid;
        private bool _card;
        private string _input = string.Empty;

        public bool PaymentConfirmed { get; private set; }
        public string PaymentMethod => _card ? "Tarjeta" : "Efectivo";
        public decimal PaidAmount => _paid;
        public decimal ChangeAmount => Math.Max(0, _paid - _total);

        public CheckoutForm(decimal total, string table)
        {
            _total = total;
            InitializeComponent();
            lblTotal.Text = FormatMoney(total);
            lblMesa.Text = string.IsNullOrWhiteSpace(table) ? "Venta para llevar" : table;
            rbCash.Checked = true;
            UpdateDisplays();
        }

        private static string FormatMoney(decimal value) => value.ToString("C0", CultureInfo.GetCultureInfo("es-CO"));

        private void Method_Changed(object sender, EventArgs e)
        {
            _card = rbCard.Checked;
            numpad.Enabled = !_card;
            if (_card)
            {
                _paid = _total;
                _input = _total.ToString("0", CultureInfo.InvariantCulture);
            }
            else
            {
                _paid = 0;
                _input = string.Empty;
            }
            UpdateDisplays();
        }

        private void Numpad_Click(object sender, EventArgs e)
        {
            if (_card) return;
            var key = ((Button)sender).Text;
            if (key == "C") { _input = string.Empty; _paid = 0; }
            else
            {
                if (_input.Length >= 12) return;
                _input += key;
                _input = _input.TrimStart('0');
                if (_input.Length == 0) _input = "0";
                if (decimal.TryParse(_input, NumberStyles.Any, CultureInfo.InvariantCulture, out var tmp)) _paid = tmp;
            }
            UpdateDisplays();
        }

        private void UpdateDisplays()
        {
            lblPaid.Text = FormatMoney(_paid);
            lblChange.Text = FormatMoney(ChangeAmount);
            btnFinish.Enabled = _card || _paid >= _total;
            btnFinish.Text = btnFinish.Enabled ? "Finalizar pago" : "Insuficiente";
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            if (!_card && _paid < _total) return;
            PaymentConfirmed = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblChange_Click(object sender, EventArgs e)
        {

        }
    }
}
