using System.Windows;
using System.Windows.Controls;

namespace RestauranteGestor.Native.Views
{
    public partial class ReceiptWindow : Window
    {
        public ReceiptWindow(string receipt)
        {
            InitializeComponent();
            ReceiptText.Text = receipt;
        }

        private void Close_Click(object sender, RoutedEventArgs e) { Close(); }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new PrintDialog();
            if (dialog.ShowDialog() == true)
            {
                // La vista previa queda disponible; la impresión usa el diálogo nativo de Windows.
                MessageBox.Show("Vista de recibo preparada para impresión.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
