using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RestauranteGestor.Native.Views
{
    public partial class InventarioView : UserControl
    {
        private readonly ObservableCollection<Insumo> _all = new ObservableCollection<Insumo>();

        public InventarioView()
        {
            InitializeComponent();
            CategoryBox.Items.Add("Todas");
            CategoryBox.Items.Add("Carnes");
            CategoryBox.Items.Add("Verduras");
            CategoryBox.Items.Add("Lácteos");
            CategoryBox.Items.Add("Bebidas");
            CategoryBox.Items.Add("Secos");
            CategoryBox.SelectedIndex = 0;
            LoadMock();
            ApplyFilter();
        }

        private void LoadMock()
        {
            _all.Add(new Insumo("Carne de res (lomo)", "Carnes", 4.2m, "kg", 5m, 28000m));
            _all.Add(new Insumo("Queso mozzarella", "Lácteos", 1.1m, "kg", 2m, 18000m));
            _all.Add(new Insumo("Tomate chonto", "Verduras", 8m, "kg", 3m, 3500m));
            _all.Add(new Insumo("Cerveza artesanal", "Bebidas", 2m, "und", 6m, 4500m));
            _all.Add(new Insumo("Harina trigo", "Secos", 12m, "kg", 5m, 2800m));
            _all.Add(new Insumo("Lechuga crespa", "Verduras", 0.8m, "kg", 1.5m, 4000m));
            _all.Add(new Insumo("Pollo entero", "Carnes", 6m, "kg", 4m, 11000m));
            _all.Add(new Insumo("Aceite vegetal", "Secos", 3.5m, "L", 2m, 9000m));
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e) => ApplyFilter();
        private void CategoryBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => ApplyFilter();
        private void LowCheck_Changed(object sender, RoutedEventArgs e) => ApplyFilter();

        private void ApplyFilter()
        {
            if (InsumoList == null) return;
            string text = (SearchBox?.Text ?? string.Empty).Trim().ToLower();
            string cat = CategoryBox?.SelectedItem?.ToString() ?? "Todas";
            bool lowOnly = LowCheck?.IsChecked == true;
            var filtered = _all.Where(i =>
                (cat == "Todas" || i.Category == cat) &&
                (text.Length == 0 || i.Name.ToLower().Contains(text)) &&
                (!lowOnly || i.IsLow)).ToList();
            InsumoList.ItemsSource = filtered;
            int alerts = _all.Count(i => i.IsLow);
            if (AlertCount != null) AlertCount.Text = alerts + " alertas stock bajo";
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new InsumoDialog(null) { Owner = Window.GetWindow(this) };
            if (dlg.ShowDialog() == true && dlg.Result != null)
            {
                _all.Add(dlg.Result);
                ApplyFilter();
            }
        }

        private void Ajustar_Click(object sender, RoutedEventArgs e)
        {
            var ins = (sender as Button)?.Tag as Insumo;
            if (ins == null) return;
            var dlg = new InsumoDialog(ins) { Owner = Window.GetWindow(this) };
            if (dlg.ShowDialog() == true && dlg.Result != null)
            {
                int idx = _all.IndexOf(ins);
                if (idx >= 0) _all[idx] = dlg.Result;
                ApplyFilter();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var ins = (sender as Button)?.Tag as Insumo;
            if (ins == null) return;
            if (MessageBox.Show("Eliminar " + ins.Name + "?", "RestoOS", MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
            _all.Remove(ins);
            ApplyFilter();
        }

        public class Insumo : INotifyPropertyChanged
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Stock { get; set; }
            public string Unit { get; set; }
            public decimal Min { get; set; }
            public decimal Cost { get; set; }
            public string StockText => Stock.ToString("0.##");
            public string MinText => Min.ToString("0.##") + " " + Unit;
            public string CostText => Cost.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            public bool IsLow => Stock <= Min;
            public bool IsCritical => Stock <= Min * 0.5m;
            public string Estado => IsCritical ? "Crítico" : IsLow ? "Bajo" : "OK";
            public Brush EstadoBg => IsCritical ? (Brush)Application.Current.FindResource("Error") : IsLow ? new SolidColorBrush(Color.FromRgb(0xFF, 0xB9, 0x5F)) : (Brush)Application.Current.FindResource("Tertiary");
            public Brush EstadoFg => IsCritical || IsLow ? new SolidColorBrush(Color.FromRgb(0x3A, 0x0F, 0x00)) : new SolidColorBrush(Color.FromRgb(0x00, 0x38, 0x24));
            public Brush StockBrush => IsCritical ? (Brush)Application.Current.FindResource("Error") : IsLow ? new SolidColorBrush(Color.FromRgb(0xFF, 0xB9, 0x5F)) : (Brush)Application.Current.FindResource("OnSurface");
            public Insumo(string name, string category, decimal stock, string unit, decimal min, decimal cost) { Name = name; Category = category; Stock = stock; Unit = unit; Min = min; Cost = cost; }
            public event PropertyChangedEventHandler PropertyChanged;
        }
    }

    public partial class InsumoDialog : Window
    {
        public InventarioView.Insumo Result { get; private set; }
        public InsumoDialog(InventarioView.Insumo ins)
        {
            InitializeComponent();
            Title = ins == null ? "Nuevo insumo" : "Ajustar " + ins.Name;
            if (ins != null)
            {
                NameBox.Text = ins.Name;
                CategoryBox.Text = ins.Category;
                StockBox.Text = ins.Stock.ToString("0.##", System.Globalization.CultureInfo.InvariantCulture);
                UnitBox.Text = ins.Unit;
                MinBox.Text = ins.Min.ToString("0.##", System.Globalization.CultureInfo.InvariantCulture);
                CostBox.Text = ins.Cost.ToString("0", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
        private void InitializeComponent()
        {
            Width = 440; Height = 520; WindowStartupLocation = WindowStartupLocation.CenterOwner; ResizeMode = ResizeMode.NoResize;
            Background = (Brush)FindResource("Surface"); Foreground = (Brush)FindResource("OnSurface");
            var grid = new Grid { Margin = new Thickness(22) };
            for (int i = 0; i < 7; i++) grid.RowDefinitions.Add(new RowDefinition { Height = i == 6 ? new GridLength(1, GridUnitType.Star) : GridLength.Auto });
            var title = new TextBlock { Text = Title, FontSize = 18, FontWeight = FontWeights.Bold, Margin = new Thickness(0,0,0,12) };
            Grid.SetRow(title, 0); grid.Children.Add(title);
            NameBox = NewTextBox("Nombre ej: Tomate chonto"); AddRow(grid, 1, "Nombre *", NameBox);
            CategoryBox = NewCombo(new[] { "Carnes","Verduras","Lácteos","Bebidas","Secos" }); AddRow(grid, 2, "Categoría", CategoryBox);
            StockBox = NewTextBox("4.2"); AddRow(grid, 3, "Stock actual", StockBox);
            UnitBox = NewCombo(new[] { "kg","L","und","g" }); AddRow(grid, 4, "Unidad", UnitBox);
            MinBox = NewTextBox("5"); AddRow(grid, 5, "Mínimo alerta", MinBox);
            CostBox = NewTextBox("28000"); var costPanel = new StackPanel { Margin = new Thickness(0,12,0,0) };
            Grid.SetRow(costPanel, 6); costPanel.Children.Add(new TextBlock { Text = "Costo unitario", Foreground = (Brush)FindResource("OnSurfaceVariant"), Margin = new Thickness(0,0,0,4) }); costPanel.Children.Add(CostBox); grid.Children.Add(costPanel);
            var btns = new StackPanel { Orientation = Orientation.Horizontal, HorizontalAlignment = HorizontalAlignment.Right, VerticalAlignment = VerticalAlignment.Bottom, Margin = new Thickness(0,16,0,0) };
            var cancel = new Button { Content = "Cancelar", Width = 100, Height = 36, Style = (Style)FindResource("SecondaryButton") }; cancel.Click += (s,e)=> DialogResult=false;
            var save = new Button { Content = "Guardar", Width = 100, Height = 36, Margin = new Thickness(8,0,0,0), Style = (Style)FindResource("PrimaryButton") }; save.Click += Save_Click;
            btns.Children.Add(cancel); btns.Children.Add(save);
            var btnRow = new Grid { Margin = new Thickness(0,18,0,0) }; Grid.SetRow(btnRow, 7);
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); btnRow.Children.Add(btns); grid.Children.Add(btnRow);
            Content = new ScrollViewer { Content = grid, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
        }
        private TextBox NameBox, StockBox, MinBox, CostBox;
        private ComboBox CategoryBox, UnitBox;
        private TextBox NewTextBox(string placeholder) => new TextBox { Height = 36, Padding = new Thickness(10,8,10,8) };
        private ComboBox NewCombo(string[] items) { var cb = new ComboBox { Height = 36, IsEditable = true }; foreach (var it in items) cb.Items.Add(it); return cb; }
        private void AddRow(Grid g, int row, string label, Control ctrl) { var sp = new StackPanel { Margin = new Thickness(0,12,0,0) }; Grid.SetRow(sp, row); sp.Children.Add(new TextBlock { Text = label, Foreground = (Brush)FindResource("OnSurfaceVariant"), Margin = new Thickness(0,0,0,4) }); sp.Children.Add(ctrl); g.Children.Add(sp); }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string name = (NameBox.Text ?? "").Trim();
            if (name.Length == 0) { MessageBox.Show("Nombre requerido.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information); return; }
            string cat = (CategoryBox.Text ?? "").Trim(); if (cat.Length == 0) cat = "Secos";
            decimal stock = 0, min = 0, cost = 0;
            decimal.TryParse((StockBox.Text ?? "").Replace(",","."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out stock);
            decimal.TryParse((MinBox.Text ?? "").Replace(",","."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out min);
            decimal.TryParse((CostBox.Text ?? "").Replace(",","."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out cost);
            string unit = (UnitBox.Text ?? "").Trim(); if (unit.Length == 0) unit = "und";
            Result = new InventarioView.Insumo(name, cat, stock, unit, min, cost);
            DialogResult = true;
        }
    }
}
