using System;
using System.Windows;

namespace RestauranteGestor.Native
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DispatcherUnhandledException += (s, args) =>
            {
                MessageBox.Show("Error: " + args.Exception.Message + "\n\n" + args.Exception.StackTrace, "RestoOS - Error", MessageBoxButton.OK, MessageBoxImage.Error);
                args.Handled = true;
            };
            AppDomain.CurrentDomain.UnhandledException += (s, args) =>
            {
                var ex = args.ExceptionObject as Exception;
                MessageBox.Show("Error fatal: " + ex?.Message, "RestoOS", MessageBoxButton.OK, MessageBoxImage.Error);
            };
        }
    }
}
