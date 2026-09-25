using System;
using System.Globalization;
using System.Windows;

namespace RestauranteGestor.Native.Views
{
    public partial class CheckoutWindow : Window
    {
        private decimal _total;
        private decimal _paid;
        private bool _card;
        private string _input = string.Empty;

        public bool PaymentConfirmed { get; private set; }
        public string PaymentMethod { get { return _card ? "Tarjeta" : "Efectivo"; } }
        public decimal PaidAmount { get { return _paid; } }
        public decimal ChangeAmount { get { return Math.Max(0, _paid - _total); } }

        public CheckoutWindow(decimal total, string table)
        {
            InitializeComponent();
            _total = total;
            _paid = 0;
            _input = string.Empty;
            _card = false;
            TotalText.Text = FormatMoney(total);
            MesaText.Text = string.IsNullOrWhiteSpace(table) ? "Venta para llevar" : table;
            UpdateDisplays();
        }

        private static string FormatMoney(decimal value) => value.ToString("C0", CultureInfo.GetCultureInfo("es-CO"));

        private void PaymentMode_Changed(object sender, RoutedEventArgs e)
        {
            if (!IsLoaded) return;
            _card = CardRadio.IsChecked == true;
            Numpad.Opacity = _card ? 0.35 : 1.0;
            Numpad.IsEnabled = !_card;
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

        private void Numpad_Click(object sender, RoutedEventArgs e)
        {
            if (_card) return;
            var key = (sender as System.Windows.Controls.Button)?.Content?.ToString();
            if (string.IsNullOrEmpty(key)) return;
            if (key == "C") { _input = string.Empty; _paid = 0; }
            else if (key == ".")
            {
                if (_input.Contains(".")) return;
                _input = _input.Length == 0 ? "0." : _input + ".";
                decimal tmp;
                if (decimal.TryParse(_input, NumberStyles.Any, CultureInfo.InvariantCulture, out tmp)) _paid = tmp;
            }
            else
            {
                if (_input.Length >= 9) return;
                _input += key;
                // Evita ceros a la izquierda innecesarios
                _input = _input.TrimStart('0');
                if (_input.Length == 0) _input = key == "0" ? "0" : key;
                if (_input == "0") _paid = 0;
                else
                {
                    decimal tmp;
                    if (decimal.TryParse(_input, NumberStyles.Any, CultureInfo.InvariantCulture, out tmp)) _paid = tmp;
                }
            }
            UpdateDisplays();
        }

        private void UpdateDisplays()
        {
            PaidBox.Text = FormatMoney(_paid);
            ChangeText.Text = FormatMoney(ChangeAmount);
            FinishButton.IsEnabled = _card || _paid + 0.005m >= _total;
            FinishButton.Content = FinishButton.IsEnabled ? "Finalizar pago" : "Monto insuficiente";
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            if (!_card && _paid + 0.005m < _total)
            {
                MessageBox.Show("El monto recibido es menor que el total.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            PaymentConfirmed = true;
            DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) { DialogResult = false; }
    }
}
