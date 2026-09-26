using System;
using System.Globalization;
using System.Windows.Forms;
using app_escritorio.UI;

namespace app_escritorio.Views.Pos
{
    /// <summary>
    /// Cobro de venta (efectivo con teclado numérico y vuelto, o tarjeta por el monto exacto),
    /// igual a CheckoutWindow de WPF. También acepta los números del teclado físico.
    /// </summary>
    public partial class CheckoutDialog : RDialogForm
    {
        private static readonly CultureInfo Co = CultureInfo.GetCultureInfo("es-CO");
        private readonly decimal _total;
        private decimal _paid;
        private bool _card;
        private string _input = string.Empty;

        public bool PaymentConfirmed { get; private set; }
        public string PaymentMethod => _card ? "Tarjeta" : "Efectivo";
        public decimal PaidAmount => _paid;
        public decimal ChangeAmount => Math.Max(0, _paid - _total);

        public CheckoutDialog() : this(0m, null) { }

        public CheckoutDialog(decimal total, string table)
        {
            InitializeComponent();
            _total = total;
            lblTotalValue.Text = Money(total);
            lblMesa.Text = string.IsNullOrWhiteSpace(table) || table == Data.TicketStore.NoTable ? "Venta para llevar" : table;
            UpdateDisplays();
        }

        private static string Money(decimal value) => value.ToString("C0", Co);

        private void BtnPaymentMode_Click(object sender, EventArgs e)
        {
            _card = sender == btnCard;
            btnCard.Selected = _card;
            btnCash.Selected = !_card;
            numpad.Enabled = !_card;
            if (_card) { _paid = _total; _input = _total.ToString("0", CultureInfo.InvariantCulture); }
            else { _paid = 0; _input = string.Empty; }
            UpdateDisplays();
        }

        private void Numpad_Click(object sender, EventArgs e)
        {
            if (sender is Control c) PressKey(c.Text);
        }

        private void PressKey(string key)
        {
            if (_card || string.IsNullOrEmpty(key)) return;
            if (key == "C")
            {
                _input = string.Empty;
                _paid = 0;
            }
            else if (key == "⌫")
            {
                if (_input.Length > 0) _input = _input.Substring(0, _input.Length - 1);
                _paid = ParseInput();
            }
            else if (key == ".")
            {
                if (_input.Contains(".")) return;
                _input = _input.Length == 0 ? "0." : _input + ".";
                _paid = ParseInput();
            }
            else
            {
                if (_input.Length >= 9) return;
                _input += key;
                _input = _input.TrimStart('0');
                if (_input.Length == 0 || _input.StartsWith(".")) _input = "0" + _input;
                _paid = ParseInput();
            }
            UpdateDisplays();
        }

        private decimal ParseInput() =>
            decimal.TryParse(_input, NumberStyles.Any, CultureInfo.InvariantCulture, out var v) ? v : 0m;

        private void UpdateDisplays()
        {
            txtPaid.Text = Money(_paid);
            lblChange.Text = Money(ChangeAmount);
            bool ok = _card || _paid + 0.005m >= _total;
            btnFinish.Enabled = ok;
            btnFinish.Text = ok ? "Finalizar pago" : "Monto insuficiente";
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            if (!_card && _paid + 0.005m < _total) return;
            PaymentConfirmed = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>Teclado físico: números, punto, Retroceso, Supr (= C) y Enter (= Finalizar).</summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData >= Keys.D0 && keyData <= Keys.D9) { PressKey(((int)(keyData - Keys.D0)).ToString()); return true; }
            if (keyData >= Keys.NumPad0 && keyData <= Keys.NumPad9) { PressKey(((int)(keyData - Keys.NumPad0)).ToString()); return true; }
            if (keyData == Keys.Decimal || keyData == Keys.OemPeriod || keyData == Keys.Oemcomma) { PressKey("."); return true; }
            if (keyData == Keys.Back) { PressKey("⌫"); return true; }
            if (keyData == Keys.Delete) { PressKey("C"); return true; }
            if (keyData == Keys.Enter && btnFinish.Enabled) { BtnFinish_Click(this, EventArgs.Empty); return true; }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
