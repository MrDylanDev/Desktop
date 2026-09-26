using System;
using System.Drawing;
using System.Windows.Forms;


namespace app_escritorio.Forms
{
    public partial class TableDialogForm : Form
    {
        public TableInfo Result { get; private set; }
        private readonly TableInfo _original;

        public TableDialogForm(TableInfo table)
        {
            _original = table;
            InitializeComponent();

            if (table == null)
            {
                this.Text = "Nueva mesa";
                titleLabel.Text = "Nueva mesa";
                NameBox.Text = string.Empty;
                CapacityBox.Text = "4 personas";
                SectorBox.SelectedIndex = 0;
                StatusBox.SelectedIndex = 0;
            }
            else
            {
                this.Text = "Editar " + table.Name;
                titleLabel.Text = "Editar " + table.Name;
                NameBox.Text = table.Name;
                CapacityBox.Text = table.Capacity;
                int sectorIdx = SectorBox.Items.IndexOf(table.Sector);
                SectorBox.SelectedIndex = sectorIdx >= 0 ? sectorIdx : 0;
                StatusBox.SelectedIndex = Math.Max(0, StatusBox.Items.IndexOf(table.Status));
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Escribe un nombre para la mesa.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sector = SectorBox.SelectedItem?.ToString() ?? "Principal";
            string capacity = CapacityBox.Text.Trim();
            if (string.IsNullOrEmpty(capacity)) capacity = "4 personas";
            string status = StatusBox.SelectedItem?.ToString() ?? "Libre";
            string total = _original != null ? _original.Total : "$0";

            Result = new TableInfo(name, sector, capacity, status, total, status != "Reservada");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
