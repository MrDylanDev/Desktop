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
                TitleText.Text = "Nueva mesa";
                NameBox.Text = "Mesa ";
                CapacityBox.Text = "4 personas";
                SectorBox.SelectedIndex = 0;
                StatusBox.SelectedIndex = 0;
            }
            else
            {
                TitleText.Text = "Editar " + table.Name;
                NameBox.Text = table.Name;
                CapacityBox.Text = table.Capacity;
                SectorBox.SelectedItem = table.Sector;
                StatusBox.SelectedIndex = Math.Max(0, StatusBox.Items.IndexOf(table.Status));
            }
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
            string sector = SectorBox.SelectedItem?.ToString() ?? "Principal";
            string capacity = (CapacityBox.Text ?? string.Empty).Trim();
            string status = StatusBox.SelectedItem?.ToString() ?? "Libre";
            Result = new MesasView.TableInfo(name, sector, capacity.Length == 0 ? "4 personas" : capacity, status, "$0", status != "Reservada");
            DialogResult = true;
        }
    }
}
