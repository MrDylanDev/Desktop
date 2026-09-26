using System;
using System.Globalization;
using System.Windows.Forms;
using app_escritorio.Models;
using app_escritorio.UI;

namespace app_escritorio.Forms
{
    /// <summary>Crear o ajustar un insumo.</summary>
    public partial class InsumoDialogForm : RDialogForm
    {
        public Insumo Result { get; private set; }

        public InsumoDialogForm() : this(null) { }

        public InsumoDialogForm(Insumo ins)
        {
            InitializeComponent();
            if (ins == null)
            {
                Text = lblTitle.Text = "Nuevo insumo";
                cmbCategory.SelectedIndex = 0;
                cmbUnit.Text = "kg";
                return;
            }
            Text = lblTitle.Text = "Ajustar " + ins.Name;
            txtName.Text = ins.Name;
            cmbCategory.Text = ins.Category;
            cmbUnit.Text = ins.Unit;
            txtStock.Text = ins.Stock.ToString("0.##", CultureInfo.InvariantCulture);
            txtMin.Text = ins.Min.ToString("0.##", CultureInfo.InvariantCulture);
            txtCost.Text = ins.Cost.ToString("0", CultureInfo.InvariantCulture);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtName.Focus();
        }

        private static decimal Num(string s)
        {
            decimal.TryParse((s ?? "").Replace("$", "").Replace(" ", "").Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal v);
            return Math.Max(0, v);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (name.Length == 0)
            {
                MessageBox.Show("Nombre requerido.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            string cat = string.IsNullOrWhiteSpace(cmbCategory.Text) ? "Secos" : cmbCategory.Text.Trim();
            string unit = string.IsNullOrWhiteSpace(cmbUnit.Text) ? "und" : cmbUnit.Text.Trim();
            Result = new Insumo(name, cat, Num(txtStock.Text), unit, Num(txtMin.Text), Num(txtCost.Text));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
