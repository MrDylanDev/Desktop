using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RestauranteGestor.Native.Views
{
    public partial class DeliveryView : UserControl
    {
        private readonly ObservableCollection<PedidoDelivery> _all = new ObservableCollection<PedidoDelivery>();

        public DeliveryView()
        {
            InitializeComponent();
            PlataformaBox.Items.Add("Todas");
            PlataformaBox.Items.Add("Rappi");
            PlataformaBox.Items.Add("Uber Eats");
            PlataformaBox.Items.Add("DiDi Food");
            PlataformaBox.SelectedIndex = 0;
            EstadoBox.Items.Add("Todos");
            EstadoBox.Items.Add("Nuevo");
            EstadoBox.Items.Add("En preparación");
            EstadoBox.Items.Add("Listo para rider");
            EstadoBox.Items.Add("Entregado");
            EstadoBox.SelectedIndex = 0;
            LoadMock();
            ApplyFilter();
        }

        private void LoadMock()
        {
            var hoy = DateTime.Today;
            _all.Add(new PedidoDelivery(hoy.AddHours(12.3), "Rappi", "#R-8821", "Valentina R.", "x1 Pizza Napolitana, x1 Cerveza IPA", 19500, "Nuevo"));
            _all.Add(new PedidoDelivery(hoy.AddHours(12.8), "Uber Eats", "#U-4419", "Andrés M.", "x2 Hamburguesa Doble (sin cebolla)", 24000, "En preparación"));
            _all.Add(new PedidoDelivery(hoy.AddHours(13.1), "DiDi Food", "#D-1092", "Familia Gómez", "x1 Bife Chorizo 400g", 22000, "Listo para rider"));
            _all.Add(new PedidoDelivery(hoy.AddHours(13.4), "Rappi", "#R-8822", "Camila S.", "x1 Ensalada César, x1 Limonada", 14000, "Nuevo"));
            _all.Add(new PedidoDelivery(hoy.AddHours(14), "Uber Eats", "#U-4420", "Jorge L.", "x1 Ravioles 4 Quesos", 13500, "Entregado"));
        }

        private void Plataforma_Changed(object sender, SelectionChangedEventArgs e) => ApplyFilter();
        private void Estado_Changed(object sender, SelectionChangedEventArgs e) => ApplyFilter();
        private void Search_Changed(object sender, TextChangedEventArgs e) => ApplyFilter();

        private void ApplyFilter()
        {
            if (PedidosList == null) return;
            string plat = PlataformaBox?.SelectedItem?.ToString() ?? "Todas";
            string est = EstadoBox?.SelectedItem?.ToString() ?? "Todos";
            string text = (SearchBox?.Text ?? "").Trim().ToLower();
            var filtered = _all.Where(p =>
                (plat == "Todas" || p.Plataforma == plat) &&
                (est == "Todos" || p.Estado == est) &&
                (text.Length == 0 || p.Cliente.ToLower().Contains(text) || p.Detalle.ToLower().Contains(text) || p.Id.ToLower().Contains(text))
            ).OrderByDescending(p => p.Fecha).ToList();
            PedidosList.ItemsSource = filtered;
        }

        private void Nuevo_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new PedidoDialog(null) { Owner = Window.GetWindow(this) };
            if (dlg.ShowDialog() == true && dlg.Result != null)
            {
                _all.Add(dlg.Result);
                ApplyFilter();
            }
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            var p = (sender as Button)?.Tag as PedidoDelivery;
            if (p == null) return;
            var dlg = new PedidoDialog(p) { Owner = Window.GetWindow(this) };
            if (dlg.ShowDialog() == true && dlg.Result != null)
            {
                int idx = _all.IndexOf(p);
                if (idx >= 0) _all[idx] = dlg.Result;
                ApplyFilter();
            }
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            var p = (sender as Button)?.Tag as PedidoDelivery;
            if (p == null) return;
            if (MessageBox.Show("¿Eliminar el pedido " + p.Id + " de " + p.Cliente + "?", "RestoOS", MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
            _all.Remove(p);
            ApplyFilter();
        }

        private void Avanzar_Click(object sender, RoutedEventArgs e)
        {
            var p = (sender as Button)?.Tag as PedidoDelivery;
            if (p == null) return;
            if (p.Estado == "Nuevo") p.Estado = "En preparación";
            else if (p.Estado == "En preparación") p.Estado = "Listo para rider";
            else if (p.Estado == "Listo para rider") p.Estado = "Entregado";
            ApplyFilter();
        }

        private void Sincronizar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menú sincronizado con plataformas (precio/disponibilidad) — DEMO frontend.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public class PedidoDelivery : System.ComponentModel.INotifyPropertyChanged
        {
            public DateTime Fecha { get; set; }
            public string Plataforma { get; set; }
            public string Id { get; set; }
            public string Cliente { get; set; }
            public string Detalle { get; set; }
            public decimal Total { get; set; }
            private string _estado;
            public string Estado { get => _estado; set { _estado = value; PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(string.Empty)); } }
            public string HoraText => Fecha.ToString("HH:mm");
            public string TotalText => Total.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            public Brush PlataformaBg => Plataforma == "Rappi" ? new SolidColorBrush(Color.FromRgb(0xFF,0x37,0x2B)) : Plataforma == "Uber Eats" ? new SolidColorBrush(Color.FromRgb(0x06,0xC1,0x67)) : new SolidColorBrush(Color.FromRgb(0xFF,0x6A,0x00));
            public Brush EstadoBg => Estado == "Nuevo" ? new SolidColorBrush(Color.FromRgb(0xFF,0xB9,0x5F)) : Estado == "En preparación" ? (Brush)Application.Current.FindResource("Primary") : Estado == "Listo para rider" ? (Brush)Application.Current.FindResource("Tertiary") : (Brush)Application.Current.FindResource("SurfaceHigh");
            public Brush EstadoFg => Estado == "Entregado" ? (Brush)Application.Current.FindResource("OnSurfaceVariant") : new SolidColorBrush(Color.FromRgb(0x3A,0x0F,0x00));
            public PedidoDelivery(DateTime fecha, string plat, string id, string cliente, string detalle, decimal total, string estado) { Fecha = fecha; Plataforma = plat; Id = id; Cliente = cliente; Detalle = detalle; Total = total; Estado = estado; }
            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        }
    }

    public class PedidoDialog : Window
    {
        public DeliveryView.PedidoDelivery Result { get; private set; }
        private TextBox IdBox, ClienteBox, DetalleBox, TotalBox, HoraBox;
        private ComboBox PlataformaBox, EstadoBox;
        private DatePicker FechaPicker;

        public PedidoDialog(DeliveryView.PedidoDelivery p)
        {
            Title = p == null ? "Nuevo pedido" : "Editar pedido";
            Width = 500; Height = 660; WindowStartupLocation = WindowStartupLocation.CenterOwner; ResizeMode = ResizeMode.NoResize;
            Background = (Brush)FindResource("Surface"); Foreground = (Brush)FindResource("OnSurface");

            var scroll = new ScrollViewer { VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
            var grid = new Grid { Margin = new Thickness(22) };
            for (int i = 0; i < 9; i++) grid.RowDefinitions.Add(new RowDefinition { Height = i == 8 ? new GridLength(1, GridUnitType.Star) : GridLength.Auto });
            var title = new TextBlock { Text = Title, FontSize = 20, FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 12) };
            Grid.SetRow(title, 0); grid.Children.Add(title);

            PlataformaBox = new ComboBox { Height = 36 };
            foreach (var s in new[] { "Rappi", "Uber Eats", "DiDi Food" }) PlataformaBox.Items.Add(s);
            PlataformaBox.SelectedItem = p?.Plataforma ?? "Rappi";
            if (PlataformaBox.SelectedItem == null) PlataformaBox.SelectedIndex = 0;

            IdBox = NewTextBox(p?.Id ?? SugerirId());
            FechaPicker = new DatePicker { Height = 36, SelectedDate = p?.Fecha.Date ?? DateTime.Today };
            HoraBox = NewTextBox(p?.Fecha.ToString("HH:mm") ?? "12:00");
            ClienteBox = NewTextBox(p?.Cliente ?? "");
            DetalleBox = NewTextBox(p?.Detalle ?? "");
            DetalleBox.Height = 76; DetalleBox.AcceptsReturn = true; DetalleBox.TextWrapping = TextWrapping.Wrap; DetalleBox.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            TotalBox = NewTextBox(p != null ? p.Total.ToString("0", CultureInfo.InvariantCulture) : "");

            EstadoBox = new ComboBox { Height = 36 };
            foreach (var s in new[] { "Nuevo", "En preparación", "Listo para rider", "Entregado" }) EstadoBox.Items.Add(s);
            EstadoBox.SelectedItem = p?.Estado ?? "Nuevo";
            if (EstadoBox.SelectedItem == null) EstadoBox.SelectedIndex = 0;

            AddRow(grid, 1, "Plataforma", PlataformaBox);
            AddRow(grid, 2, "ID del pedido", IdBox);
            AddRow(grid, 3, "Fecha", FechaPicker);
            AddRow(grid, 4, "Hora (HH:mm)", HoraBox);
            AddRow(grid, 5, "Cliente *", ClienteBox);
            AddRow(grid, 6, "Detalle del pedido *", DetalleBox);
            AddRow(grid, 7, "Total (COP)", TotalBox);
            var estadoPanel = new StackPanel { Margin = new Thickness(0, 12, 0, 0) };
            Grid.SetRow(estadoPanel, 8);
            estadoPanel.Children.Add(NewLabel("Estado"));
            estadoPanel.Children.Add(EstadoBox);
            grid.Children.Add(estadoPanel);

            var btns = new StackPanel { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Right };
            var cancel = new Button { Content = "Cancelar", Width = 100, Height = 36, Style = (Style)FindResource("SecondaryButton") };
            cancel.Click += (s, e) => DialogResult = false;
            var save = new Button { Content = "Guardar", Width = 100, Height = 36, Margin = new Thickness(8, 0, 0, 0), Style = (Style)FindResource("PrimaryButton") };
            save.Click += Save_Click;
            btns.Children.Add(cancel); btns.Children.Add(save);
            var btnRow = new Grid { Margin = new Thickness(0, 18, 0, 0) };
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            Grid.SetRow(btnRow, 9); btnRow.Children.Add(btns); grid.Children.Add(btnRow);

            scroll.Content = grid; Content = scroll;
        }

        private static string SugerirId() => "#N-" + DateTime.Now.ToString("HHmmss");

        private TextBox NewTextBox(string text) => new TextBox { Height = 36, Padding = new Thickness(10, 8, 10, 8), Text = text ?? "" };

        private TextBlock NewLabel(string text) => new TextBlock { Text = text, Foreground = (Brush)FindResource("OnSurfaceVariant"), Margin = new Thickness(0, 0, 0, 4) };

        private void AddRow(Grid g, int row, string label, Control ctrl)
        {
            var sp = new StackPanel { Margin = new Thickness(0, 12, 0, 0) };
            Grid.SetRow(sp, row);
            sp.Children.Add(NewLabel(label)); sp.Children.Add(ctrl);
            g.Children.Add(sp);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string cliente = (ClienteBox.Text ?? "").Trim();
            if (cliente.Length == 0) { MessageBox.Show("Cliente requerido.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information); return; }
            string detalle = (DetalleBox.Text ?? "").Trim();
            if (detalle.Length == 0) { MessageBox.Show("Detalle del pedido requerido.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information); return; }

            string id = (IdBox.Text ?? "").Trim();
            if (id.Length == 0) id = SugerirId();

            string raw = (TotalBox.Text ?? "").Trim().Replace("$", "").Replace(" ", "").Replace(".", "").Replace(",", ".");
            decimal total;
            if (!decimal.TryParse(raw, NumberStyles.Any, CultureInfo.InvariantCulture, out total) || total <= 0)
            {
                MessageBox.Show("Total inválido. Ejemplo: 19500", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            DateTime fecha = FechaPicker.SelectedDate ?? DateTime.Today;
            TimeSpan hora = TimeSpan.FromHours(12);
            TimeSpan parsed;
            string rawHora = (HoraBox.Text ?? "").Trim();
            if (TimeSpan.TryParse(rawHora, out parsed) && parsed >= TimeSpan.Zero && parsed < TimeSpan.FromDays(1)) hora = parsed;

            Result = new DeliveryView.PedidoDelivery(
                fecha.Date + hora,
                PlataformaBox.SelectedItem?.ToString() ?? "Rappi",
                id, cliente, detalle, total,
                EstadoBox.SelectedItem?.ToString() ?? "Nuevo");
            DialogResult = true;
        }
    }
}
