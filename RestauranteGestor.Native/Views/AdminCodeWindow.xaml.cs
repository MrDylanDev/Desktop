using System;
using System.Windows;
using System.Windows.Controls;

namespace RestauranteGestor.Native.Views
{
    public partial class AdminCodeWindow : Window
    {
        private const string DemoCode = "1234";
        private static readonly DateTime Expiry = new DateTime(2026, 9, 30);
        private string _code = string.Empty;

        public AdminCodeWindow()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) => DialogResult = false;

        private void Num_Click(object sender, RoutedEventArgs e)
        {
            var d = (sender as Button)?.Content?.ToString();
            if (string.IsNullOrEmpty(d) || _code.Length >= 4) return;
            if (d.Length == 1 && char.IsDigit(d[0])) _code += d;
            UpdateDisplay();
        }

        private void Clear_Click(object sender, RoutedEventArgs e) { _code = string.Empty; UpdateDisplay(); }
        private void Back_Click(object sender, RoutedEventArgs e) { if (_code.Length > 0) _code = _code.Substring(0, _code.Length - 1); UpdateDisplay(); }

        private void UpdateDisplay()
        {
            D1.Text = _code.Length >= 1 ? "●" : "";
            D2.Text = _code.Length >= 2 ? "●" : "";
            D3.Text = _code.Length >= 3 ? "●" : "";
            D4.Text = _code.Length >= 4 ? "●" : "";
            ErrorText.Visibility = Visibility.Collapsed;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (DateTime.Today > Expiry)
            {
                ErrorText.Text = "Código expirado (30/09/2026).";
                ErrorText.Visibility = Visibility.Visible;
                return;
            }
            if (_code != DemoCode)
            {
                ErrorText.Text = "Código incorrecto. Usa 1234.";
                ErrorText.Visibility = Visibility.Visible;
                return;
            }
            DialogResult = true;
        }
    }
}
