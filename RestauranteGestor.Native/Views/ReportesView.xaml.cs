using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace RestauranteGestor.Native.Views
{
    public partial class ReportesView : UserControl
    {
        private readonly ObservableCollection<Venta> _ventas = new ObservableCollection<Venta>();

        public ReportesView()
        {
            InitializeComponent();
            OrigenBox.Items.Add("Todo (salón + delivery)");
            OrigenBox.Items.Add("Solo salón");
            OrigenBox.Items.Add("Solo delivery");
            OrigenBox.SelectedIndex = 0;
            var today = DateTime.Today;
            DesdePicker.SelectedDate = today.AddDays(-6);
            HastaPicker.SelectedDate = today;
            MetodoTrazabilidad.Items.Add("Todos");
            MetodoTrazabilidad.Items.Add("Efectivo");
            MetodoTrazabilidad.Items.Add("Tarjeta");
            MetodoTrazabilidad.SelectedIndex = 0;
            EstadoTrazabilidad.Items.Add("Todos");
            EstadoTrazabilidad.Items.Add("Cobrado");
            EstadoTrazabilidad.Items.Add("Anulado");
            EstadoTrazabilidad.SelectedIndex = 0;
            LoadVentasMock();
            Loaded += (_, __) => Refresh();
        }

        private void LoadVentasMock()
        {
            var hoy = DateTime.Today;
            _ventas.Add(new Venta(hoy.AddHours(13.2), "Mesa 2", "x1 Bife Chorizo 400g (término medio), x1 Cerveza IPA", 27000, "Efectivo", "Ana", "Cobrado"));
            _ventas.Add(new Venta(hoy.AddHours(13.45), "Mesa 3", "x2 Hamburguesa Doble (sin cebolla)", 24000, "Tarjeta", "Carlos", "Cobrado"));
            _ventas.Add(new Venta(hoy.AddHours(14.1), "Para llevar", "x1 Pizza Napolitana Familiar", 14500, "Efectivo", "Ana", "Cobrado"));
            _ventas.Add(new Venta(hoy.AddHours(19.3), "Mesa 5", "x1 Ensalada César, x1 Ravioles 4 Quesos", 23000, "Tarjeta", "Ana", "Cobrado"));
            _ventas.Add(new Venta(hoy.AddHours(19.8), "Barra 1", "x3 Cerveza IPA", 15000, "Efectivo", "Carlos", "Anulado"));
            _ventas.Add(new Venta(hoy.AddDays(-1).AddHours(20), "Mesa 4", "x2 Limonada Menta, x1 Tiramisú", 15000, "Efectivo", "Ana", "Cobrado"));
            _ventas.Add(new Venta(hoy.AddDays(-1).AddHours(21), "VIP 1", "x4 Bife, x2 Pizza", 89000, "Tarjeta", "Carlos", "Cobrado"));
        }

        private void Filtro_Changed(object sender, RoutedEventArgs e) => Refresh();
        private void Filtro_Changed(object sender, SelectionChangedEventArgs e) => Refresh();
        private void SearchTrazabilidad_TextChanged(object sender, TextChangedEventArgs e) => RefreshTrazabilidad();
        private void FiltroTrazabilidad_Changed(object sender, SelectionChangedEventArgs e) => RefreshTrazabilidad();

        private void Refresh()
        {
            if (TotalVentas == null) return;
            var rnd = new Random(42);
            int dias = 7;
            var ventas = Enumerable.Range(0, dias).Select(i => 180000 + rnd.Next(80000, 220000)).ToArray();
            int tickets = ventas.Length * 3 + rnd.Next(2, 6);
            long total = ventas.Sum(v => (long)v);
            long promedio = tickets > 0 ? total / tickets : 0;
            long impuesto = (long)(total * 0.08m);
            long efectivo = (long)(total * 0.58m);
            long tarjeta = total - efectivo;

            TotalVentas.Text = total.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            TotalSub.Text = tickets + " tickets · " + dias + " días";
            TicketProm.Text = promedio.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            ImpuestoText.Text = impuesto.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            MetodoText.Text = efectivo.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")) + " / " + tarjeta.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));

            if (ChartGrid != null)
            {
                ChartGrid.Children.Clear();
                long max = ventas.Max();
                var diasLbl = new[] { "Lun","Mar","Mié","Jue","Vie","Sáb","Dom" };
                for (int i = 0; i < dias; i++)
                {
                    double h = max > 0 ? 110 * ventas[i] / (double)max : 0;
                    var bar = new Border { Background = (Brush)FindResource("Primary"), CornerRadius = new CornerRadius(6,6,0,0), VerticalAlignment = VerticalAlignment.Bottom, Height = Math.Max(8, h), Margin = new Thickness(6,0,6,0) };
                    if (i == dias-1) bar.Background = (Brush)FindResource("Secondary");
                    Grid.SetColumn(bar, i); Grid.SetRow(bar, 0);
                    ChartGrid.Children.Add(bar);
                    var lbl = new TextBlock { Text = diasLbl[i % 7], Foreground = (Brush)FindResource("OnSurfaceVariant"), FontSize = 10, HorizontalAlignment = HorizontalAlignment.Center, Margin = new Thickness(0,6,0,0) };
                    Grid.SetColumn(lbl, i); Grid.SetRow(lbl, 1);
                    ChartGrid.Children.Add(lbl);
                    var tip = new TextBlock { Text = ventas[i].ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")), Foreground = (Brush)FindResource("OnSurfaceVariant"), FontSize = 9, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Top, Margin = new Thickness(0,0,0,0) };
                }
            }

            if (TopList != null)
            {
                TopList.ItemsSource = new[]
                {
                    new { Rank="1", Name="Bife de Chorizo 400g", Qty="12", TotalText="$264.000" },
                    new { Rank="2", Name="Pizza Napolitana Familiar", Qty="9", TotalText="$130.500" },
                    new { Rank="3", Name="Hamburguesa Doble Queso", Qty="8", TotalText="$96.000" },
                    new { Rank="4", Name="Cerveza Tirada IPA", Qty="15", TotalText="$75.000" },
                };
            }

            if (MesaList != null)
            {
                MesaList.ItemsSource = new[]
                {
                    new { Mesa="Mesa 5", Tickets="5", TotalText="$187.900", Mesero="Ana" },
                    new { Mesa="Mesa 3", Tickets="4", TotalText="$164.200", Mesero="Carlos" },
                    new { Mesa="Barra 1", Tickets="6", TotalText="$118.500", Mesero="Ana" },
                    new { Mesa="Terraza 1", Tickets="3", TotalText="$92.300", Mesero="—" },
                };
            }
            RefreshTrazabilidad();
        }

        private void RefreshTrazabilidad()
        {
            if (VentasList == null) return;
            string text = (SearchTrazabilidad?.Text ?? "").Trim().ToLower();
            string metodo = MetodoTrazabilidad?.SelectedItem?.ToString() ?? "Todos";
            string estado = EstadoTrazabilidad?.SelectedItem?.ToString() ?? "Todos";
            var desde = DesdePicker?.SelectedDate;
            var hasta = HastaPicker?.SelectedDate;
            var filtered = _ventas.Where(v =>
                (desde == null || v.Fecha.Date >= desde.Value.Date) &&
                (hasta == null || v.Fecha.Date <= hasta.Value.Date) &&
                (metodo == "Todos" || v.Metodo == metodo) &&
                (estado == "Todos" || v.Estado == estado) &&
                (text.Length == 0 || v.Mesa.ToLower().Contains(text) || v.Detalle.ToLower().Contains(text) || v.Cajero.ToLower().Contains(text))
            ).OrderByDescending(v => v.Fecha).ToList();
            VentasList.ItemsSource = filtered;
            if (TotalTrazabilidad != null)
            {
                var total = filtered.Where(v => v.Estado == "Cobrado").Sum(v => v.Total);
                TotalTrazabilidad.Text = "Rango: " + total.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")) + " · " + filtered.Count + " ventas";
            }
        }

        private void VerVenta_Click(object sender, RoutedEventArgs e)
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
