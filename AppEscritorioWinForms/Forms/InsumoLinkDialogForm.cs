using System;
using System.Globalization;
using System.Windows.Forms;
using app_escritorio.Models;
using app_escritorio.UI;

namespace app_escritorio.Forms
{
    /// <summary>Vincula un insumo del almacén a un plato (cantidad que se descuenta por cada venta).</summary>
    public partial class InsumoLinkDialogForm : RDialogForm
    {
        public InsumoLink Result { get; private set; }

        public InsumoLinkDialogForm()
        {
            InitializeComponent();
            cmbUnidad.Text = "kg";
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            cmbInsumo.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string nombre = cmbInsumo.Text.Trim();
            if (nombre.Length == 0)
            {
                MessageBox.Show("Elige o escribe el insumo.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbInsumo.Focus();
                return;
            }
            string raw = txtCantidad.Text.Trim().Replace(",", ".");
            if (!decimal.TryParse(raw, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida. Ejemplo: 0,25", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Focus();
                return;
            }
            string unidad = string.IsNullOrWhiteSpace(cmbUnidad.Text) ? "und" : cmbUnidad.Text.Trim();
            Result = new InsumoLink { Nombre = nombre, Cantidad = cantidad, Unidad = unidad };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
