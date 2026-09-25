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

        public bool PaymentConfirmed { get; private set; }
        public string PaymentMethod { get { return _card ? "Tarjeta" : "Efectivo"; } }
        public decimal PaidAmount { get { return _paid; } }
        public decimal ChangeAmount { get { return Math.Max(0, _paid - _total); } }

        public CheckoutWindow(decimal total, string table)
        {
            InitializeComponent();
            _total = total;
            _paid = total;
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
            _paid = _card ? _total : 0;
            UpdateDisplays();
        }

        private void Numpad_Click(object sender, RoutedEventArgs e)
        {
            var key = (sender as System.Windows.Controls.Button)?.Content?.ToString();
            if (string.IsNullOrEmpty(key)) return;
            if (key == "C") { _paid = 0; }
            else if (key == ".") { if (!PaidBox.Text.Contains(".")) _paid = _paid + 0.01m; }
            else { _paid = _paid * 10 + decimal.Parse(key, CultureInfo.InvariantCulture); }
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
