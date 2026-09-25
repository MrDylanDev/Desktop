using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            ApplyFilter();
        }

        private void LoadTables()
        {
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
        }

        private void NewTable_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new TableDialogWindow(null) { Owner = Window.GetWindow(this) };
            if (dialog.ShowDialog() == true && dialog.Result != null)
            {
                _tables.Add(dialog.Result);
                ApplyFilter();
            }
        }

        private void EditTable_Click(object sender, RoutedEventArgs e)
        {
            var table = (sender as Button)?.Tag as TableInfo;
            if (table == null) return;
            var dialog = new TableDialogWindow(table) { Owner = Window.GetWindow(this) };
            if (dialog.ShowDialog() == true && dialog.Result != null)
            {
                int index = _tables.IndexOf(table);
                if (index >= 0)
                {
                    _tables[index] = dialog.Result;
                    ApplyFilter();
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
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (TablesList == null) return;
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
            DetailItems.Text = table.Status == "Libre" || table.Status == "Reservada" ? "Sin comanda activa." : "Comanda activa de demostración.";
            DetailTotal.Text = table.Total;
            OpenPosButton.IsEnabled = table.CanOpen;
        }

        public class TableInfo
        {
            public string Name { get; private set; }
            public string Number { get { return Name.Split(' ').Length > 1 ? Name.Split(' ')[1] : Name; } }
            public string Sector { get; private set; }
            public string Capacity { get; private set; }
            public string Status { get; private set; }
            public string Total { get; private set; }
            public bool CanOpen { get; private set; }
            public Brush StatusBrush { get { return Status == "Libre" ? (Brush)Application.Current.FindResource("Tertiary") : Status == "Ocupada" ? (Brush)Application.Current.FindResource("Secondary") : Status == "Cuenta pedida" ? (Brush)Application.Current.FindResource("Primary") : Status == "Por limpiar" ? (Brush)Application.Current.FindResource("Error") : (Brush)Application.Current.FindResource("OnSurfaceVariant"); } }
            public TableInfo(string name, string sector, string capacity, string status, string total, bool canOpen) { Name = name; Sector = sector; Capacity = capacity; Status = status; Total = total; CanOpen = canOpen; }
        }
    }
}
