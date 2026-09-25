using System;
using System.Windows;

namespace RestauranteGestor.Native.Views
{
    public partial class TableDialogWindow : Window
    {
        public MesasView.TableInfo Result { get; private set; }
        private readonly MesasView.TableInfo _original;

        public TableDialogWindow(MesasView.TableInfo table)
        {
            InitializeComponent();
            _original = table;
            SectorBox.Items.Add("Principal");
            SectorBox.Items.Add("Terraza");
            SectorBox.Items.Add("Barra");
            SectorBox.Items.Add("VIP");
            StatusBox.Items.Add("Libre");
            StatusBox.Items.Add("Ocupada");
            StatusBox.Items.Add("Cuenta pedida");
            StatusBox.Items.Add("Reservada");
            StatusBox.Items.Add("Por limpiar");
            if (table == null)
            {
                Title = "Nueva mesa";
                TitleText.Text = "Nueva mesa";
                NameBox.Text = string.Empty;
                CapacityBox.Text = "4 personas";
                SectorBox.SelectedIndex = 0;
                StatusBox.SelectedIndex = 0;
            }
            else
            {
                Title = "Editar " + table.Name;
                TitleText.Text = "Editar " + table.Name;
                NameBox.Text = table.Name;
                CapacityBox.Text = table.Capacity;
                int sectorIdx = SectorBox.Items.IndexOf(table.Sector);
                SectorBox.SelectedIndex = sectorIdx >= 0 ? sectorIdx : 0;
                StatusBox.SelectedIndex = Math.Max(0, StatusBox.Items.IndexOf(table.Status));
            }
            NameBox.Focus();
            NameBox.SelectAll();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) { DialogResult = false; }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string name = (NameBox.Text ?? string.Empty).Trim();
            if (name.Length == 0)
            {
                MessageBox.Show("Escribe un nombre para la mesa.", "RestoOS", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            string sector = SectorBox.SelectedItem?.ToString() ?? SectorBox.Text?.Trim();
            if (string.IsNullOrWhiteSpace(sector)) sector = "Principal";
            string capacity = (CapacityBox.Text ?? string.Empty).Trim();
            if (capacity.Length == 0) capacity = "4 personas";
            string status = StatusBox.SelectedItem?.ToString() ?? "Libre";
            string total = _original != null ? _original.Total : "$0";
            Result = new MesasView.TableInfo(name, sector, capacity, status, total, status != "Reservada");
            DialogResult = true;
        }
    }
}
