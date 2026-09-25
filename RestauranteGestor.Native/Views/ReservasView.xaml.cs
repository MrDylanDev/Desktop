using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RestauranteGestor.Native.Views
{
    public partial class ReservasView : UserControl
    {
        private readonly ObservableCollection<Reserva> _all = new ObservableCollection<Reserva>();

        public ReservasView()
        {
            InitializeComponent();
            EstadoBox.Items.Add("Todos");
            EstadoBox.Items.Add("Confirmada");
            EstadoBox.Items.Add("En curso");
            EstadoBox.Items.Add("Cancelada");
            EstadoBox.SelectedIndex = 0;
            var today = DateTime.Today;
            Cal.SelectedDate = today;
            Cal.DisplayDate = today;
            LoadMock();
            ApplyFilter();
        }

        private void LoadMock()
        {
            var today = DateTime.Today;
            _all.Add(new Reserva(today.AddHours(13), "Laura Gómez", 2, "Mesa 2", "Confirmada", "310 555 0123"));
            _all.Add(new Reserva(today.AddHours(19.5), "Familia Rojas", 6, "Mesa 5", "Confirmada", "320 444 0099"));
            _all.Add(new Reserva(today.AddHours(20), "Carlos Pérez", 4, "Terraza 1", "En curso", "300 123 4567"));
            _all.Add(new Reserva(today.AddDays(1).AddHours(12), "Empresa Andina", 8, "VIP 1", "Confirmada", "315 777 0011"));
            _all.Add(new Reserva(today.AddDays(-1).AddHours(18), "Ana Torres", 2, "Barra 1", "Cancelada", "311 222 3344"));
        }

        private void Cal_SelectedDatesChanged(object sender, SelectionChangedEventArgs e) => ApplyFilter();
        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e) => ApplyFilter();
        private void EstadoBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => ApplyFilter();

        private void ApplyFilter()
        {
            if (ReservaList == null) return;
            var selected = Cal?.SelectedDate ?? DateTime.Today;
            if (FechaLabel != null) FechaLabel.Text = selected.ToString("dddd d MMM", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            string text = (SearchBox?.Text ?? "").Trim().ToLower();
            string estado = EstadoBox?.SelectedItem?.ToString() ?? "Todos";
            var filtered = _all.Where(r =>
                r.Fecha.Date == selected.Date &&
                (estado == "Todos" || r.Estado == estado) &&
                (text.Length == 0 || r.Cliente.ToLower().Contains(text) || r.Mesa.ToLower().Contains(text))).OrderBy(r => r.Fecha).ToList();
            ReservaList.ItemsSource = filtered;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new ReservaDialog(null, Cal.SelectedDate ?? DateTime.Today) { Owner = Window.GetWindow(this) };
            if (dlg.ShowDialog() == true && dlg.Result != null)
            {
                _all.Add(dlg.Result);
                Cal.SelectedDate = dlg.Result.Fecha.Date;
                ApplyFilter();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var r = (sender as Button)?.Tag as Reserva;
            if (r == null) return;
            var dlg = new ReservaDialog(r, r.Fecha.Date) { Owner = Window.GetWindow(this) };
            if (dlg.ShowDialog() == true && dlg.Result != null)
            {
                int idx = _all.IndexOf(r);
                if (idx >= 0) _all[idx] = dlg.Result;
                ApplyFilter();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var r = (sender as Button)?.Tag as Reserva;
            if (r == null) return;
            if (MessageBox.Show("Eliminar reserva de " + r.Cliente + "?", "RestoOS", MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
            _all.Remove(r);
            ApplyFilter();
        }

        public class Reserva : INotifyPropertyChanged
        {
            public DateTime Fecha { get; set; }
            public string Cliente { get; set; }
            public int Personas { get; set; }
            public string Mesa { get; set; }
            public string Estado { get; set; }
            public string Telefono { get; set; }
            public string HoraText => Fecha.ToString("HH:mm");
            public string PersonasText => Personas.ToString() + " p";
            public Brush EstadoBg => Estado == "Confirmada" ? (Brush)Application.Current.FindResource("Tertiary") : Estado == "En curso" ? new SolidColorBrush(Color.FromRgb(0xFF,0xB9,0x5F)) : (Brush)Application.Current.FindResource("Error");
            public Brush EstadoFg => new SolidColorBrush(Color.FromRgb(0x3A,0x0F,0x00));
            public Reserva(DateTime fecha, string cliente, int personas, string mesa, string estado, string tel) { Fecha = fecha; Cliente = cliente; Personas = personas; Mesa = mesa; Estado = estado; Telefono = tel; }
            public event PropertyChangedEventHandler PropertyChanged;
        }
    }

    public class ReservaDialog : Window
    {
        public ReservasView.Reserva Result { get; private set; }
        private TextBox ClienteBox, PersonasBox, TelBox, HoraBox;
        private ComboBox MesaBox, EstadoBox;
        private DatePicker FechaPicker;

        public ReservaDialog(ReservasView.Reserva r, DateTime defaultDate)
        {
            Title = r == null ? "Nueva reserva" : "Editar reserva";
            Width = 460; Height = 580; WindowStartupLocation = WindowStartupLocation.CenterOwner; ResizeMode = ResizeMode.NoResize;
            Background = (Brush)FindResource("Surface"); Foreground = (Brush)FindResource("OnSurface");
            var scroll = new ScrollViewer { VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
            var grid = new Grid { Margin = new Thickness(22) };
            for (int i = 0; i < 8; i++) grid.RowDefinitions.Add(new RowDefinition { Height = i == 7 ? new GridLength(1, GridUnitType.Star) : GridLength.Auto });
            var title = new TextBlock { Text = Title, FontSize = 20, FontWeight = FontWeights.Bold, Margin = new Thickness(0,0,0,12) };
            Grid.SetRow(title, 0); grid.Children.Add(title);

            FechaPicker = new DatePicker { Height = 36, SelectedDate = r?.Fecha.Date ?? defaultDate };
            HoraBox = new TextBox { Height = 36, Padding = new Thickness(10,8,10,8), Text = r?.Fecha.ToString("HH:mm") ?? "19:00" };
            ClienteBox = new TextBox { Height = 36, Padding = new Thickness(10,8,10,8), Text = r?.Cliente ?? "" };
            PersonasBox = new TextBox { Height = 36, Padding = new Thickness(10,8,10,8), Text = r?.Personas.ToString() ?? "2" };
            MesaBox = new ComboBox { Height = 36, IsEditable = true, Text = r?.Mesa ?? "Mesa 2" };
            foreach (var m in new[] { "Mesa 1","Mesa 2","Mesa 3","Mesa 4","Terraza 1","Barra 1","VIP 1" }) MesaBox.Items.Add(m);
            TelBox = new TextBox { Height = 36, Padding = new Thickness(10,8,10,8), Text = r?.Telefono ?? "" };
            EstadoBox = new ComboBox { Height = 36 };
            foreach (var s in new[] { "Confirmada","En curso","Cancelada" }) EstadoBox.Items.Add(s);
            EstadoBox.SelectedItem = r?.Estado ?? "Confirmada";

            AddRow(grid, 1, "Fecha", FechaPicker);
            AddRow(grid, 2, "Hora (HH:mm)", HoraBox);
            AddRow(grid, 3, "Cliente *", ClienteBox);
            AddRow(grid, 4, "Personas", PersonasBox);
            AddRow(grid, 5, "Mesa asignada", MesaBox);
            AddRow(grid, 6, "Teléfono", TelBox);
            var estadoPanel = new StackPanel { Margin = new Thickness(0,12,0,0) };
            Grid.SetRow(estadoPanel, 7); estadoPanel.Children.Add(new TextBlock { Text = "Estado", Foreground = (Brush)FindResource("OnSurfaceVariant"), Margin = new Thickness(0,0,0,4) }); estadoPanel.Children.Add(EstadoBox); grid.Children.Add(estadoPanel);
            var btns = new StackPanel { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Right, Margin = new Thickness(0,18,0,0) };
            var cancel = new Button { Content = "Cancelar", Width = 100, Height = 36, Style = (Style)FindResource("SecondaryButton") }; cancel.Click += (s,e)=> DialogResult=false;
            var save = new Button { Content = "Guardar", Width = 100, Height = 36, Margin = new Thickness(8,0,0,0), Style = (Style)FindResource("PrimaryButton") }; save.Click += Save_Click;
            btns.Children.Add(cancel); btns.Children.Add(save);
            var btnRow = new Grid { Margin = new Thickness(0,12,0,0) }; grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); Grid.SetRow(btnRow, 8); btnRow.Children.Add(btns); grid.Children.Add(btnRow);
            scroll.Content = grid; Content = scroll;
        }

        private void AddRow(Grid g, int row, string label, Control ctrl) { var sp = new StackPanel { Margin = new Thickness(0,12,0,0) }; Grid.SetRow(sp, row); sp.Children.Add(new TextBlock { Text = label, Foreground = (Brush)FindResource("OnSurfaceVariant"), Margin = new Thickness(0,0,0,4) }); sp.Children.Add(ctrl); g.Children.Add(sp); }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string cliente = (ClienteBox.Text ?? "").Trim();
            if (cliente.Length == 0) { MessageBox.Show("Cliente requerido.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information); return; }
            DateTime fecha = FechaPicker.SelectedDate ?? DateTime.Today;
            TimeSpan hora = TimeSpan.FromHours(19);
            TimeSpan.TryParse((HoraBox.Text ?? "").Trim(), out hora);
            fecha = fecha.Date + hora;
            int personas = 2; int.TryParse((PersonasBox.Text ?? "").Trim(), out personas); if (personas < 1) personas = 1;
            string mesa = (MesaBox.Text ?? "").Trim(); if (mesa.Length == 0) mesa = "Mesa 1";
            string estado = EstadoBox.SelectedItem?.ToString() ?? "Confirmada";
            string tel = (TelBox.Text ?? "").Trim();
            Result = new ReservasView.Reserva(fecha, cliente, personas, mesa, estado, tel);
            DialogResult = true;
        }
    }
}
