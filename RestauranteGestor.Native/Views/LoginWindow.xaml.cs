using System;
using System.Windows;

namespace RestauranteGestor.Native.Views
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Role_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var btn = sender as System.Windows.Controls.Button;
                var role = btn?.Tag?.ToString() ?? "Admin";
                if (role == "Admin" || role == "Administrador")
                {
                    var dlg = new AdminCodeWindow { Owner = this };
                    if (dlg.ShowDialog() != true) return;
                    role = "Admin";
                }
                var main = new MainWindow(role);
                main.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir: " + ex.Message + "\n\n" + ex.StackTrace, "RestoOS", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
