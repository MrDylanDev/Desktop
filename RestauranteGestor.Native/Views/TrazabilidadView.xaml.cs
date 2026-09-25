using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RestauranteGestor.Native.Views
{
    public partial class TrazabilidadView : UserControl
    {
        private readonly ObservableCollection<Venta> _all = new ObservableCollection<Venta>();

        public TrazabilidadView()
        {
            InitializeComponent();
            MetodoBox.Items.Add("Todos");
            MetodoBox.Items.Add("Efectivo");
            MetodoBox.Items.Add("Tarjeta");
            MetodoBox.SelectedIndex = 0;
            EstadoBox.Items.Add("Todos");
            EstadoBox.Items.Add("Cobrado");
            EstadoBox.Items.Add("Anulado");
            EstadoBox.SelectedIndex = 0;
            FechaPicker.SelectedDate = DateTime.Today;
            LoadMock();
            ApplyFilter();
        }

        private void LoadMock()
        {
            var hoy = DateTime.Today;
            _all.Add(new Venta(hoy.AddHours(13.2), "Mesa 2", "x1 Bife Chorizo 400g (término medio), x1 Cerveza IPA", 27000, "Efectivo", "Ana", "Cobrado"));
            _all.Add(new Venta(hoy.AddHours(13.45), "Mesa 3", "x2 Hamburguesa Doble (sin cebolla)", 24000, "Tarjeta", "Carlos", "Cobrado"));
            _all.Add(new Venta(hoy.AddHours(14.1), "Para llevar", "x1 Pizza Napolitana Familiar", 14500, "Efectivo", "Ana", "Cobrado"));
            _all.Add(new Venta(hoy.AddHours(19.3), "Mesa 5", "x1 Ensalada César, x1 Ravioles 4 Quesos", 23000, "Tarjeta", "Ana", "Cobrado"));
            _all.Add(new Venta(hoy.AddHours(19.8), "Barra 1", "x3 Cerveza IPA", 15000, "Efectivo", "Carlos", "Anulado"));
            _all.Add(new Venta(hoy.AddDays(-1).AddHours(20), "Mesa 4", "x2 Limonada Menta, x1 Tiramisú", 15000, "Efectivo", "Ana", "Cobrado"));
            _all.Add(new Venta(hoy.AddDays(-1).AddHours(21), "VIP 1", "x4 Bife, x2 Pizza", 89000, "Tarjeta", "Carlos", "Cobrado"));
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e) => ApplyFilter();
        private void Filter_Changed(object sender, SelectionChangedEventArgs e) => ApplyFilter();
        private void Filter_Changed(object sender, RoutedEventArgs e) => ApplyFilter();
        private void Refresh_Click(object sender, RoutedEventArgs e) => ApplyFilter();

        private void ApplyFilter()
        {
            if (VentasList == null) return;
            string text = (SearchBox?.Text ?? "").Trim().ToLower();
            string metodo = MetodoBox?.SelectedItem?.ToString() ?? "Todos";
            string estado = EstadoBox?.SelectedItem?.ToString() ?? "Todos";
            var fecha = FechaPicker?.SelectedDate;

            var filtered = _all.Where(v =>
                (fecha == null || v.Fecha.Date == fecha.Value.Date) &&
                (metodo == "Todos" || v.Metodo == metodo) &&
                (estado == "Todos" || v.Estado == estado) &&
                (text.Length == 0 || v.Mesa.ToLower().Contains(text) || v.Detalle.ToLower().Contains(text) || v.Cajero.ToLower().Contains(text))
            ).OrderByDescending(v => v.Fecha).ToList();

            VentasList.ItemsSource = filtered;
            if (TotalLabel != null)
            {
                var totalHoy = filtered.Where(v => v.Estado == "Cobrado").Sum(v => v.Total);
                TotalLabel.Text = (fecha?.ToString("dd MMM") ?? "Hoy") + ": " + totalHoy.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")) + " · " + filtered.Count + " ventas";
            }
        }

        private void Ver_Click(object sender, RoutedEventArgs e)
        {
            var v = (sender as Button)?.Tag as Venta;
            if (v == null) return;
            var sb = new StringBuilder();
            sb.AppendLine("RESTOOS · TRAZABILIDAD POS");
            sb.AppendLine(v.Fecha.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine("Mesa: " + v.Mesa + " · Cajero: " + v.Cajero);
            sb.AppendLine("----------------------------");
            sb.AppendLine(v.Detalle);
            sb.AppendLine("----------------------------");
            sb.AppendLine("Total: " + v.TotalText);
            sb.AppendLine("Método: " + v.Metodo);
            sb.AppendLine("Estado: " + v.Estado);
            new ReceiptWindow(sb.ToString()) { Owner = Window.GetWindow(this) }.ShowDialog();
        }

        public class Venta
        {
            public DateTime Fecha { get; set; }
            public string Mesa { get; set; }
            public string Detalle { get; set; }
            public decimal Total { get; set; }
            public string Metodo { get; set; }
            public string Cajero { get; set; }
            public string Estado { get; set; }
            public string FechaText => Fecha.ToString("dd/MM HH:mm");
            public string TotalText => Total.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            public Brush MetodoBg => Metodo == "Efectivo" ? new SolidColorBrush(Color.FromRgb(0x1D,0x20,0x22)) : (Brush)Application.Current.FindResource("SurfaceHigh");
            public Brush MetodoFg => Metodo == "Efectivo" ? (Brush)Application.Current.FindResource("Tertiary") : (Brush)Application.Current.FindResource("OnSurface");
            public Brush EstadoBg => Estado == "Cobrado" ? (Brush)Application.Current.FindResource("Tertiary") : (Brush)Application.Current.FindResource("Error");
            public Brush EstadoFg => new SolidColorBrush(Color.FromRgb(0x3A,0x0F,0x00));
            public Venta(DateTime fecha, string mesa, string detalle, decimal total, string metodo, string cajero, string estado) { Fecha = fecha; Mesa = mesa; Detalle = detalle; Total = total; Metodo = metodo; Cajero = cajero; Estado = estado; }
        }
    }
}
