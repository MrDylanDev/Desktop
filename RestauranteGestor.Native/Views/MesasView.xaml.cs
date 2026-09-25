using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RestauranteGestor.Native.Views
{
    public partial class MesasView : UserControl
    {
        private readonly ObservableCollection<TableInfo> _tables = new ObservableCollection<TableInfo>();
        private TableInfo _selected;
        public event Action<string> MesaParaPos;

        private static string StorePath
        {
            get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestoOS", "mesas.dat"); }
        }

        public MesasView()
        {
            InitializeComponent();
            LoadTables();
            SectorBox.Items.Add("Todos los salones");
            SectorBox.Items.Add("Principal");
            SectorBox.Items.Add("Terraza");
            SectorBox.Items.Add("Barra");
            SectorBox.Items.Add("VIP");
            SectorBox.SelectedIndex = 0;
            PosView.TicketChanged += () => { try { ApplyFilter(); if (_selected != null) SelectTable(_tables.FirstOrDefault(t => t.Name == _selected.Name) ?? _selected); } catch { } };
            ApplyFilter();
        }

        public void RefreshView() => ApplyFilter();

        private void LoadTables()
        {
            try
            {
                if (File.Exists(StorePath))
                {
                    var lines = File.ReadAllLines(StorePath);
                    foreach (var line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        var parts = line.Split('|');
                        if (parts.Length < 6) continue;
                        _tables.Add(new TableInfo(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5] == "1"));
                    }
                    if (_tables.Count > 0) return;
                }
            }
            catch { }
            _tables.Add(new TableInfo("Mesa 1", "Principal", "2 personas", "Libre", "$0", true));
            _tables.Add(new TableInfo("Mesa 2", "Principal", "4 personas", "Ocupada", "$42.500", true));
            _tables.Add(new TableInfo("Mesa 3", "Principal", "4 personas", "Ocupada", "$64.200", true));
            _tables.Add(new TableInfo("Mesa 4", "Principal", "6 personas", "Libre", "$0", true));
            _tables.Add(new TableInfo("Mesa 5", "Principal", "2 personas", "Cuenta pedida", "$87.900", true));
            _tables.Add(new TableInfo("Mesa 6", "Principal", "4 personas", "Por limpiar", "$51.000", true));
            _tables.Add(new TableInfo("Mesa 7", "Terraza", "4 personas", "Reservada", "$0", false));
            _tables.Add(new TableInfo("Mesa 8", "Terraza", "4 personas", "Libre", "$0", true));
            _tables.Add(new TableInfo("Barra 1", "Barra", "2 personas", "Ocupada", "$18.500", true));
            _tables.Add(new TableInfo("VIP 1", "VIP", "8 personas", "Reservada", "$0", false));
            SaveTables();
        }

        private void SaveTables()
        {
            try
            {
                var dir = Path.GetDirectoryName(StorePath);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                var lines = _tables.Select(t => string.Join("|", new[] { t.Name, t.Sector, t.Capacity, t.Status, t.Total, t.CanOpen ? "1" : "0" }));
                File.WriteAllLines(StorePath, lines);
            }
            catch { }
        }

        private void NewTable_Click(object sender, RoutedEventArgs e)
        {
            var owner = Window.GetWindow(this);
            var dialog = new TableDialogWindow(null) { Owner = owner };
            if (owner == null) dialog.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            if (dialog.ShowDialog() == true && dialog.Result != null)
            {
                if (_tables.Any(t => t.Name.Equals(dialog.Result.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Ya existe una mesa con ese nombre.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                _tables.Add(dialog.Result);
                SaveTables();
                ApplyFilter();
            }
        }

        private void EditTable_Click(object sender, RoutedEventArgs e)
        {
            var table = (sender as Button)?.Tag as TableInfo;
            if (table == null) return;
            var owner = Window.GetWindow(this);
            var dialog = new TableDialogWindow(table) { Owner = owner };
            if (owner == null) dialog.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            if (dialog.ShowDialog() == true && dialog.Result != null)
            {
                if (_tables.Any(t => t != table && t.Name.Equals(dialog.Result.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Ya existe otra mesa con ese nombre.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                int index = _tables.IndexOf(table);
                if (index < 0)
                {
                    for (int i = 0; i < _tables.Count; i++) if (_tables[i].Name == table.Name) { index = i; break; }
                }
                if (index >= 0)
                {
                    bool wasSelected = _selected == table || (_selected != null && _selected.Name == table.Name);
                    _tables[index] = dialog.Result;
                    if (wasSelected) SelectTable(dialog.Result);
                    SaveTables();
                    ApplyFilter();
                }
                else
                {
                    MessageBox.Show("No se encontró la mesa original para actualizar. Refresca el filtro a 'Todos los salones'.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void DeleteTable_Click(object sender, RoutedEventArgs e)
        {
            var table = (sender as Button)?.Tag as TableInfo;
            if (table == null) return;
            if (MessageBox.Show("Eliminar " + table.Name + "?", "RestoOS", MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) return;
            _tables.Remove(table);
            if (_selected == table) _selected = null;
            SaveTables();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (TablesList == null) return;
            foreach (var t in _tables) t.RefreshTotal();
            string sector = SectorBox?.SelectedItem?.ToString() ?? "Todos los salones";
            TablesList.ItemsSource = _tables.Where(t => sector == "Todos los salones" || t.Sector == sector).ToList();
        }

        private void SectorBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => ApplyFilter();

        private void OpenPos_Click(object sender, RoutedEventArgs e)
        {
            var table = (sender as Button)?.Tag as TableInfo;
            if (table == null || !table.CanOpen) return;
            SelectTable(table);
            MesaParaPos?.Invoke(table.Name);
        }

        private void OpenSelectedPos_Click(object sender, RoutedEventArgs e)
        {
            if (_selected == null || !_selected.CanOpen) return;
            MesaParaPos?.Invoke(_selected.Name);
        }

        private void SelectTable(TableInfo table)
        {
            _selected = table;
            DetailName.Text = table.Name;
            DetailStatus.Text = table.Status;
            DetailStatus.Foreground = table.StatusBrush;
            DetailInfo.Text = table.Sector + " · " + table.Capacity;
            var ticket = PosView.GetTicketFor(table.Name);
            if (ticket.Count == 0)
                DetailItems.Text = table.Status == "Libre" || table.Status == "Reservada" ? "Sin pedido activo." : "Pedido activo de demostración.";
            else
                DetailItems.Text = string.Join("\n", ticket.Select(l => l.Name + "  " + l.TotalText + (string.IsNullOrEmpty(l.Notes) ? "" : " (" + l.Notes + ")")));
            var tot = PosView.GetTotalFor(table.Name);
            DetailTotal.Text = tot > 0 ? tot.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")) : table.Total;
            OpenPosButton.IsEnabled = table.CanOpen;
        }

        public class TableInfo : INotifyPropertyChanged
        {
            private string _name;
            private string _sector;
            private string _capacity;
            private string _status;
            private string _mockTotal;
            private bool _canOpen;
            public string Name { get => _name; set { _name = value; Raise(); } }
            public string Number { get { return Name.Split(' ').Length > 1 ? Name.Split(' ')[1] : Name; } }
            public string Sector { get => _sector; set { _sector = value; Raise(); } }
            public string Capacity { get => _capacity; set { _capacity = value; Raise(); } }
            public string Status { get => _status; set { _status = value; Raise(); } }
            public string MockTotal { get => _mockTotal; set { _mockTotal = value; Raise(); } }
            public string Total
            {
                get
                {
                    var real = PosView.GetTotalFor(Name);
                    if (real > 0) return real.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
                    return _mockTotal ?? "$0";
                }
            }
            public bool CanOpen { get => _canOpen; set { _canOpen = value; Raise(); } }
            public Brush StatusBrush { get { return Status == "Libre" ? (Brush)Application.Current.FindResource("Tertiary") : Status == "Ocupada" ? (Brush)Application.Current.FindResource("Secondary") : Status == "Cuenta pedida" ? (Brush)Application.Current.FindResource("Primary") : Status == "Por limpiar" ? (Brush)Application.Current.FindResource("Error") : (Brush)Application.Current.FindResource("OnSurfaceVariant"); } }
            public TableInfo(string name, string sector, string capacity, string status, string total, bool canOpen) { _name = name; _sector = sector; _capacity = capacity; _status = status; _mockTotal = total; _canOpen = canOpen; }
            public event PropertyChangedEventHandler PropertyChanged;
            private void Raise([System.Runtime.CompilerServices.CallerMemberName] string p = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(p));
            public void RefreshTotal() => Raise("Total");
        }
    }
}
