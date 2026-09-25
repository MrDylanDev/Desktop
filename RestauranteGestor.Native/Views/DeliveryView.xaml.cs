using System;
using System.Collections.ObjectModel;
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

        private void Ver_Click(object sender, RoutedEventArgs e)
        {
            var p = (sender as Button)?.Tag as PedidoDelivery;
            if (p == null) return;
            MessageBox.Show(p.Plataforma + " " + p.Id + "\n" + p.Cliente + "\n" + p.Detalle + "\nTotal: " + p.TotalText + "\nEstado: " + p.Estado, "RestoOS Delivery", MessageBoxButton.OK, MessageBoxImage.Information);
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
}
