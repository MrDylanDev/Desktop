using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace RestauranteGestor.Native.Views
{
    public partial class KdsView : UserControl
    {
        private readonly ObservableCollection<KdsOrder> _orders = new ObservableCollection<KdsOrder>();
        private readonly DispatcherTimer _timer;

        public KdsView()
        {
            InitializeComponent();
            StationBox.Items.Add("Todas las estaciones");
            StationBox.Items.Add("Parrilla");
            StationBox.Items.Add("Fría");
            StationBox.Items.Add("Barra");
            StationBox.SelectedIndex = 0;
            LoadMock();
            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            _timer.Tick += (_, __) => RefreshAll();
            _timer.Start();
            RefreshAll();
        }

        private void LoadMock()
        {
            _orders.Add(new KdsOrder("Mesa 2", "Parrilla", DateTime.Now.AddMinutes(-4),
                new[] { new KdsItem("x1 Bife de Chorizo 400g", "término medio"), new KdsItem("x1 Cerveza Tirada IPA", "") }));
            _orders.Add(new KdsOrder("Mesa 3", "Parrilla", DateTime.Now.AddMinutes(-11),
                new[] { new KdsItem("x2 Hamburguesa Doble Queso", "sin cebolla"), new KdsItem("x1 Limonada Menta", "") }));
            _orders.Add(new KdsOrder("Barra 1", "Barra", DateTime.Now.AddMinutes(-2),
                new[] { new KdsItem("x2 Cerveza Tirada IPA", ""), new KdsItem("x1 Tiramisú Casero", "extra salsa") }));
            _orders.Add(new KdsOrder("Mesa 5", "Fría", DateTime.Now.AddMinutes(-7),
                new[] { new KdsItem("x1 Ensalada César con Pollo", "sin crutones"), new KdsItem("x1 Ravioles 4 Quesos", "") }));
            _orders[1].Status = KdsStatus.Preparacion;
            _orders[3].Status = KdsStatus.Listo;
        }

        private void StationBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => RefreshAll();

        private void Preparar_Click(object sender, RoutedEventArgs e) { var o = (sender as Button)?.Tag as KdsOrder; if (o != null) { o.Status = KdsStatus.Preparacion; RefreshAll(); } }
        private void Listo_Click(object sender, RoutedEventArgs e) { var o = (sender as Button)?.Tag as KdsOrder; if (o != null) { o.Status = KdsStatus.Listo; RefreshAll(); } }
        private void Devolver_Click(object sender, RoutedEventArgs e) { var o = (sender as Button)?.Tag as KdsOrder; if (o != null) { o.Status = KdsStatus.Nuevo; RefreshAll(); } }
        private void Reabrir_Click(object sender, RoutedEventArgs e) { var o = (sender as Button)?.Tag as KdsOrder; if (o != null) { o.Status = KdsStatus.Preparacion; RefreshAll(); } }
        private void Entregado_Click(object sender, RoutedEventArgs e)
        {
            var o = (sender as Button)?.Tag as KdsOrder;
            if (o == null) return;
            _orders.Remove(o);
            RefreshAll();
        }

        private void RefreshAll()
        {
            if (ClockText != null) ClockText.Text = DateTime.Now.ToString("HH:mm:ss");
            foreach (var o in _orders) o.Refresh();
            string station = StationBox?.SelectedItem?.ToString() ?? "Todas las estaciones";
            var filtered = _orders.Where(o => station == "Todas las estaciones" || o.Station == station).ToList();
            if (NuevoList != null)
            {
                NuevoList.ItemsSource = filtered.Where(o => o.Status == KdsStatus.Nuevo).ToList();
                NuevoCount.Text = filtered.Count(o => o.Status == KdsStatus.Nuevo).ToString();
            }
            if (PrepList != null)
            {
                PrepList.ItemsSource = filtered.Where(o => o.Status == KdsStatus.Preparacion).ToList();
                PrepCount.Text = filtered.Count(o => o.Status == KdsStatus.Preparacion).ToString();
            }
            if (ListoList != null)
            {
                ListoList.ItemsSource = filtered.Where(o => o.Status == KdsStatus.Listo).ToList();
                ListoCount.Text = filtered.Count(o => o.Status == KdsStatus.Listo).ToString();
            }
            if (PendingCount != null) PendingCount.Text = filtered.Count(o => o.Status != KdsStatus.Listo).ToString() + " pendientes";
        }

        public enum KdsStatus { Nuevo, Preparacion, Listo }

        public class KdsItem
        {
            public string Line { get; private set; }
            public string Note { get; private set; }
            public KdsItem(string line, string note) { Line = line; Note = note ?? string.Empty; }
        }

        public class KdsOrder : INotifyPropertyChanged
        {
            public string Mesa { get; private set; }
            public string Station { get; private set; }
            public DateTime CreatedAt { get; private set; }
            public ObservableCollection<KdsItem> Items { get; private set; }
            private KdsStatus _status = KdsStatus.Nuevo;
            public KdsStatus Status { get => _status; set { _status = value; Raise(); } }
            public string CreatedText => "Pedido " + CreatedAt.ToString("HH:mm");
            public string Elapsed
            {
                get
                {
                    var m = (int)(DateTime.Now - CreatedAt).TotalMinutes;
                    if (m < 1) return "ahora";
                    return "hace " + m + "m";
                }
            }
            public Brush ElapsedBrush
            {
                get
                {
                    var m = (DateTime.Now - CreatedAt).TotalMinutes;
                    if (m > 15) return (Brush)Application.Current.FindResource("Error");
                    if (m > 10) return (Brush)Application.Current.FindResource("Secondary");
                    return (Brush)Application.Current.FindResource("Tertiary");
                }
            }
            public KdsOrder(string mesa, string station, DateTime created, KdsItem[] items)
            {
                Mesa = mesa; Station = station; CreatedAt = created;
                Items = new ObservableCollection<KdsItem>(items);
            }
            public void Refresh() => Raise();
            public event PropertyChangedEventHandler PropertyChanged;
            private void Raise() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
        }
    }
}
