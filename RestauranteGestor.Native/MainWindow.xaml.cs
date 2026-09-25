using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using RestauranteGestor.Native.Views;

namespace RestauranteGestor.Native
{
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _clock;
        private readonly ModulesView _modules = new ModulesView();
        private readonly PosView _pos = new PosView();
        private readonly MesasView _mesas = new MesasView();
        private readonly MenuView _menu = new MenuView();

        public MainWindow()
        {
            InitializeComponent();
            _clock = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            _clock.Tick += (_, __) => LblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            _clock.Start();
            _mesas.MesaParaPos += MesaParaPos;
            _modules.ModuleStateChanged += ModuleStateChanged;
            BtnMesas.IsEnabled = _modules.SalonEnabled;
            BtnMenu.IsEnabled = _modules.MenuEnabled;
            Navigate("modulos");
        }

        private void BtnModulos_Click(object sender, RoutedEventArgs e) => Navigate("modulos");
        private void BtnPos_Click(object sender, RoutedEventArgs e) => Navigate("pos");
        private void BtnMesas_Click(object sender, RoutedEventArgs e) => Navigate("mesas");
        private void BtnMenu_Click(object sender, RoutedEventArgs e) => Navigate("menu");

        private void ModuleStateChanged(string module, bool enabled)
        {
            if (module == "salon")
            {
                BtnMesas.IsEnabled = enabled;
                if (!enabled && LblRoute.Text.Contains("Mesas")) Navigate("modulos");
            }
            else if (module == "menu")
            {
                BtnMenu.IsEnabled = enabled;
                if (!enabled && LblRoute.Text.Contains("Menú")) Navigate("modulos");
            }
        }

        private void MesaParaPos(string mesa)
        {
            _pos.SetMesa(mesa);
            Navigate("pos");
        }

        private void Navigate(string route)
        {
            UserControl view;
            switch (route)
            {
                case "pos":
                    view = _pos;
                    LblRoute.Text = "  POS";
                    BtnPos.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    BtnModulos.Background = System.Windows.Media.Brushes.Transparent;
                    BtnMesas.Background = System.Windows.Media.Brushes.Transparent;
                    BtnMenu.Background = System.Windows.Media.Brushes.Transparent;
                    break;
                case "mesas":
                    view = _mesas;
                    LblRoute.Text = "  Mesas y Salón";
                    BtnMesas.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    BtnModulos.Background = System.Windows.Media.Brushes.Transparent;
                    BtnPos.Background = System.Windows.Media.Brushes.Transparent;
                    BtnMenu.Background = System.Windows.Media.Brushes.Transparent;
                    break;
                case "menu":
                    view = _menu;
                    LblRoute.Text = "  Menú y productos";
                    BtnMenu.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    BtnModulos.Background = System.Windows.Media.Brushes.Transparent;
                    BtnPos.Background = System.Windows.Media.Brushes.Transparent;
                    BtnMesas.Background = System.Windows.Media.Brushes.Transparent;
                    break;
                default:
                    view = _modules;
                    LblRoute.Text = "  Módulos";
                    BtnModulos.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    BtnPos.Background = System.Windows.Media.Brushes.Transparent;
                    BtnMesas.Background = System.Windows.Media.Brushes.Transparent;
                    BtnMenu.Background = System.Windows.Media.Brushes.Transparent;
                    break;
            }
            ContentHost.Content = view;
        }
    }
}
