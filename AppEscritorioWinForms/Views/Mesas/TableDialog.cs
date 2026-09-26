using System;
using System.Windows.Forms;
using app_escritorio.Data;
using app_escritorio.UI;

namespace app_escritorio.Views.Mesas
{
    /// <summary>Crear o editar una mesa (TableDialogWindow de WPF).</summary>
    public partial class TableDialog : RDialogForm
    {
        private readonly MesaInfo _original;

        public MesaInfo Result { get; private set; }

        public TableDialog() : this(null) { }

        public TableDialog(MesaInfo mesa)
        {
            InitializeComponent();
            _original = mesa;
            if (mesa == null)
            {
                Text = lblTitle.Text = "Nueva mesa";
                cmbSector.SelectedIndex = 0;
                cmbCapacity.Text = "4 personas";
                cmbStatus.SelectedIndex = 0;
            }
            else
            {
                Text = lblTitle.Text = "Editar " + mesa.Name;
                txtName.Text = mesa.Name;
                int s = cmbSector.Items.IndexOf(mesa.Sector);
                cmbSector.SelectedIndex = s >= 0 ? s : 0;
                cmbCapacity.Text = mesa.Capacity;
                int st = cmbStatus.Items.IndexOf(mesa.Status);
                cmbStatus.SelectedIndex = st >= 0 ? st : 0;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtName.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (name.Length == 0)
            {
                MessageBox.Show("Escribe un nombre para la mesa.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            string capacity = string.IsNullOrWhiteSpace(cmbCapacity.Text) ? "4 personas" : cmbCapacity.Text.Trim();
            string status = cmbStatus.SelectedItem?.ToString() ?? "Libre";
            string sector = cmbSector.SelectedItem?.ToString() ?? "Principal";

            Result = new MesaInfo(name, sector, capacity, status, _original?.MockTotal ?? "$0", status != "Reservada");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
