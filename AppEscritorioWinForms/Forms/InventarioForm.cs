using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Models;
using app_escritorio.UI;
using app_escritorio.Utils;

namespace app_escritorio.Forms
{
    /// <summary>
    /// Inventario (migración de InventarioView.xaml de WPF): insumos con filtros, estado de stock y acciones.
    /// Los datos son DEMO en memoria; el diseño completo está en InventarioForm.Designer.cs.
    /// </summary>
    public partial class InventarioForm : Form
    {
        private readonly List<Insumo> _all = new List<Insumo>();

        public InventarioForm()
        {
            InitializeComponent();
            if (UiHelpers.IsDesignTime) return;

            LoadMock();
            cmbCategory.SelectedIndex = 0;
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

        private void ApplyFilter()
        {
            string text = txtSearch.Text.Trim().ToLowerInvariant();
            string cat = cmbCategory.SelectedItem?.ToString() ?? "Todas";
            bool lowOnly = swLowOnly.Checked;

            grid.Rows.Clear();
            foreach (var i in _all)
            {
                if (cat != "Todas" && i.Category != cat) continue;
                if (text.Length > 0 && !i.Name.ToLowerInvariant().Contains(text)) continue;
                if (lowOnly && !i.IsLow) continue;

                int r = grid.Rows.Add(i.Name, i.Category, i.StockText, i.MinText, i.Estado, i.CostText);
                var row = grid.Rows[r];
                row.Tag = i;
                row.Cells[colStock.Index].Style.ForeColor = i.IsLow ? i.EstadoColor : Theme.OnSurface;
                row.Cells[colStock.Index].Style.Font = Theme.GetFont(9.75F, FontStyle.Bold);
                row.Cells[colEstado.Index].Style.ForeColor = i.EstadoColor;
            }

            int alerts = _all.Count(i => i.IsLow);
            lblAlerts.Text = alerts == 1 ? "1 alerta stock bajo" : alerts + " alertas stock bajo";
            pnlAlert.Visible = alerts > 0;
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            if (!UiHelpers.IsDesignTime) ApplyFilter();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new InsumoDialogForm(null))
                if (dlg.ShowDialog(TopLevelControl ?? this) == DialogResult.OK && dlg.Result != null)
                {
                    _all.Add(dlg.Result);
                    ApplyFilter();
                }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !(grid.Rows[e.RowIndex].Tag is Insumo ins)) return;

            if (e.ColumnIndex == colAjustar.Index)
            {
                using (var dlg = new InsumoDialogForm(ins))
                    if (dlg.ShowDialog(TopLevelControl ?? this) == DialogResult.OK && dlg.Result != null)
                    {
                        _all[_all.IndexOf(ins)] = dlg.Result;
                        ApplyFilter();
                    }
            }
            else if (e.ColumnIndex == colDelete.Index)
            {
                if (MessageBox.Show("¿Eliminar " + ins.Name + "?", "RestoOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _all.Remove(ins);
                    ApplyFilter();
                }
            }
        }
    }
}
