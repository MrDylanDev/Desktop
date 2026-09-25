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
        private readonly KdsView _kds = new KdsView();
        private readonly InventarioView _inventario = new InventarioView();
        private readonly ReservasView _reservas = new ReservasView();
        private readonly DeliveryView _delivery = new DeliveryView();
        private readonly ReportesView _reportes = new ReportesView();
        private readonly ConfiguracionView _configuracion = new ConfiguracionView();
        private readonly string _role;

        public MainWindow() : this("Admin") { }

        public MainWindow(string role)
        {
            _role = string.IsNullOrWhiteSpace(role) ? "Admin" : role;
            InitializeComponent();
            _clock = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            _clock.Tick += (_, __) => LblClock.Text = DateTime.Now.ToString("HH:mm:ss");
            _clock.Start();
            _mesas.MesaParaPos += MesaParaPos;
            _modules.ModuleStateChanged += ModuleStateChanged;
            BtnMesas.IsEnabled = _modules.SalonEnabled;
            BtnMenu.IsEnabled = _modules.MenuEnabled;
            BtnKds.IsEnabled = _modules.KdsEnabled;
            BtnInventario.IsEnabled = _modules.InventarioEnabled;
            BtnReservas.IsEnabled = _modules.ReservasEnabled;
            BtnDelivery.IsEnabled = _modules.DeliveryEnabled;
            BtnReportes.IsEnabled = _modules.ReportesEnabled;
            ApplyRole();
            Navigate(_role == "Empleado" ? "pos" : "modulos");
        }

        private void ApplyRole()
        {
            bool isAdmin = _role == "Admin" || _role == "Administrador";
            string display = isAdmin ? "Administrador" : "Empleados";
            if (LblRole != null) LblRole.Text = display;
            if (AdminPanel != null) AdminPanel.Visibility = isAdmin ? Visibility.Visible : Visibility.Collapsed;
            if (OperacionPanel != null) OperacionPanel.Visibility = isAdmin ? Visibility.Collapsed : Visibility.Visible;
            BtnConfig.Visibility = isAdmin ? Visibility.Visible : Visibility.Collapsed;
            if (isAdmin) return;
            // Empleados ven toda la operación (POS, Mesas, KDS, Inventario, Reservas, Menú) filtrado por módulos
            BtnPos.Visibility = Visibility.Visible;
            BtnMesas.Visibility = Visibility.Visible;
            BtnKds.Visibility = Visibility.Visible;
            BtnInventario.Visibility = Visibility.Visible;
            BtnReservas.Visibility = Visibility.Visible;
            BtnMenu.Visibility = Visibility.Visible;
        }

        private void BtnCambiarPerfil_Click(object sender, RoutedEventArgs e)
        {
            var login = new LoginWindow();
            login.Show();
            Close();
        }

        private void BtnModulos_Click(object sender, RoutedEventArgs e) => Navigate("modulos");
        private void BtnPos_Click(object sender, RoutedEventArgs e) => Navigate("pos");
        private void BtnMesas_Click(object sender, RoutedEventArgs e) => Navigate("mesas");
        private void BtnKds_Click(object sender, RoutedEventArgs e) => Navigate("kds");
        private void BtnInventario_Click(object sender, RoutedEventArgs e) => Navigate("inventario");
        private void BtnReservas_Click(object sender, RoutedEventArgs e) => Navigate("reservas");
        private void BtnDelivery_Click(object sender, RoutedEventArgs e) => Navigate("delivery");
        private void BtnReportes_Click(object sender, RoutedEventArgs e) => Navigate("reportes");
        private void BtnConfiguracion_Click(object sender, RoutedEventArgs e) => Navigate("configuracion");
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
            else if (module == "kds")
            {
                BtnKds.IsEnabled = enabled;
                if (!enabled && LblRoute.Text.Contains("KDS")) Navigate("modulos");
            }
            else if (module == "inventario")
            {
                BtnInventario.IsEnabled = enabled;
                if (!enabled && LblRoute.Text.Contains("Inventario")) Navigate("modulos");
            }
            else if (module == "reservas")
            {
                BtnReservas.IsEnabled = enabled;
                if (!enabled && LblRoute.Text.Contains("Reservas")) Navigate("modulos");
            }
            else if (module == "delivery")
            {
                BtnDelivery.IsEnabled = enabled;
                if (!enabled && LblRoute.Text.Contains("Delivery")) Navigate("modulos");
            }
            else if (module == "reportes")
            {
                BtnReportes.IsEnabled = enabled;
                if (!enabled && LblRoute.Text.Contains("Reportes")) Navigate("modulos");
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
            ClearNavHighlight();
            switch (route)
            {
                case "pos":
                    _pos.ReloadTax();
                    view = _pos;
                    LblRoute.Text = "  POS";
                    BtnPos.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    break;
                case "mesas":
                    view = _mesas;
                    LblRoute.Text = "  Mesas y Salón";
                    BtnMesas.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    break;
                case "kds":
                    view = _kds;
                    LblRoute.Text = "  Cocina KDS · DEMO";
                    BtnKds.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    break;
                case "inventario":
                    view = _inventario;
                    LblRoute.Text = "  Inventario · DEMO";
                    BtnInventario.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    break;
                case "reservas":
                    view = _reservas;
                    LblRoute.Text = "  Reservas · DEMO";
                    BtnReservas.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    break;
                case "delivery":
                    view = _delivery;
                    LblRoute.Text = "  Delivery · DEMO";
                    BtnDelivery.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    break;
                case "reportes":
                    if (_role != "Admin" && _role != "Administrador")
                    {
                        MessageBox.Show("Solo el Administrador puede ver Reportes.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }
                    view = _reportes;
                    LblRoute.Text = "  Reportes · Solo Admin";
                    BtnReportes.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    break;
                case "configuracion":
                    if (_role != "Admin" && _role != "Administrador")
                    {
                        MessageBox.Show("Solo el Administrador puede ver Configuración.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }
                    _configuracion.RefreshData();
                    view = _configuracion;
                    LblRoute.Text = "  Configuración · Solo Admin";
                    BtnConfiguracion.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    break;
                case "menu":
                    view = _menu;
                    LblRoute.Text = "  Menú y productos";
                    BtnMenu.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    break;
                default:
                    view = _modules;
                    LblRoute.Text = "  Módulos";
                    BtnModulos.Background = (System.Windows.Media.Brush)FindResource("SurfaceHigh");
                    break;
            }
            ContentHost.Content = view;
        }

        private void ClearNavHighlight()
        {
            BtnModulos.Background = System.Windows.Media.Brushes.Transparent;
            BtnPos.Background = System.Windows.Media.Brushes.Transparent;
            BtnMesas.Background = System.Windows.Media.Brushes.Transparent;
            BtnKds.Background = System.Windows.Media.Brushes.Transparent;
            BtnInventario.Background = System.Windows.Media.Brushes.Transparent;
            BtnReservas.Background = System.Windows.Media.Brushes.Transparent;
            BtnDelivery.Background = System.Windows.Media.Brushes.Transparent;
            BtnReportes.Background = System.Windows.Media.Brushes.Transparent;
            BtnConfiguracion.Background = System.Windows.Media.Brushes.Transparent;
            BtnMenu.Background = System.Windows.Media.Brushes.Transparent;
        }
    }
}
