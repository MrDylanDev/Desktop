using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;


namespace app_escritorio.Forms
{
    public partial class InsumoDialogForm : Form
    {
        public InventarioForm.Insumo Result { get; private set; }

        public InsumoDialogForm(InventarioForm.Insumo ins)
        {
            InitializeComponent();

            this.Text = ins == null ? "Nuevo insumo" : "Ajustar " + ins.Name;
            titleLabel.Text = this.Text;

            if (ins != null)
            {
                nameBox.Text = ins.Name;
                categoryBox.Text = ins.Category;
                stockBox.Text = ins.Stock.ToString("0.##", CultureInfo.InvariantCulture);
                unitBox.Text = ins.Unit;
                minBox.Text = ins.Min.ToString("0.##", CultureInfo.InvariantCulture);
                costBox.Text = ins.Cost.ToString("0", CultureInfo.InvariantCulture);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Nombre requerido.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string cat = categoryBox.Text.Trim(); if (string.IsNullOrEmpty(cat)) cat = "Secos";
            
            decimal.TryParse(stockBox.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal stock);
            decimal.TryParse(minBox.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal min);
            decimal.TryParse(costBox.Text.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal cost);
            
            string unit = unitBox.Text.Trim(); if (string.IsNullOrEmpty(unit)) unit = "und";
            
            Result = new InventarioForm.Insumo(name, cat, stock, unit, min, cost);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
