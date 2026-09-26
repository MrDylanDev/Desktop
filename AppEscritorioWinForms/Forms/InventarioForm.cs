using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Forms;

namespace app_escritorio.Forms
{
    public partial class InventarioForm : Form
    {
        public string Role { get; set; }
        public class Insumo
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Stock { get; set; }
            public string Unit { get; set; }
            public decimal Min { get; set; }
            public decimal Cost { get; set; }

            public string StockText => $"{Stock:0.##} {Unit}";
            public string MinText => $"{Min:0.##} {Unit}";
            public string CostText => Cost.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
            public bool IsLow => Stock <= Min;
            public bool IsCritical => Stock <= Min * 0.5m;
            public string Estado => IsCritical ? "Crítico" : IsLow ? "Bajo" : "OK";

            public Color EstadoColor => IsCritical ? Color.IndianRed : IsLow ? Color.FromArgb(255, 107, 53) : Color.MediumSeaGreen;

            public Insumo(string name, string category, decimal stock, string unit, decimal min, decimal cost)
            {
                Name = name; Category = category; Stock = stock; Unit = unit; Min = min; Cost = cost;
            }
        }

        private readonly BindingList<Insumo> _all = new BindingList<Insumo>();
        private readonly BindingList<Insumo> _filtered = new BindingList<Insumo>();

        public InventarioForm()
        {
            InitializeComponent();
            
            categoryBox.Items.AddRange(new[] { "Todas", "Carnes", "Verduras", "Lácteos", "Bebidas", "Secos" });
            categoryBox.SelectedIndex = 0;
            
            LoadMock();
            ApplyFilter();
        }

        private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _filtered.Count)
            {
                var ins = _filtered[e.RowIndex];
                if (grid.Columns[e.ColumnIndex].DataPropertyName == "Estado")
                {
                    e.CellStyle.ForeColor = ins.EstadoColor;
                    e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);
                }
                if (grid.Columns[e.ColumnIndex].DataPropertyName == "StockText")
                {
                    e.CellStyle.ForeColor = ins.IsLow ? ins.EstadoColor : Color.Black;
                    e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);
                }
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _filtered.Count)
            {
                var ins = _filtered[e.RowIndex];
                if (e.ColumnIndex == grid.Columns.Count - 2) // Ajustar
                {
                    var dlg = new InsumoDialogForm(ins);
                    if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Result != null)
                    {
                        var idx = _all.IndexOf(ins);
                        if (idx >= 0) _all[idx] = dlg.Result;
                        ApplyFilter();
                    }
                }
                else if (e.ColumnIndex == grid.Columns.Count - 1) // ×
                {
                    if (MessageBox.Show($"¿Eliminar {ins.Name}?", "RestoOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _all.Remove(ins);
                        ApplyFilter();
                    }
                }
            }
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
            string text = searchBox.Text.Trim().ToLower();
            string cat = categoryBox.SelectedItem?.ToString() ?? "Todas";
            bool lowOnly = lowCheck.Checked;

            _filtered.Clear();
            foreach (var i in _all)
            {
                if (cat != "Todas" && i.Category != cat) continue;
                if (!string.IsNullOrEmpty(text) && !i.Name.ToLower().Contains(text)) continue;
                if (lowOnly && !i.IsLow) continue;
                _filtered.Add(i);
            }

            grid.DataSource = null;
            grid.DataSource = _filtered;

            int alerts = _all.Count(i => i.IsLow);
            lblAlerts.Text = $"{alerts} alertas stock bajo";
            lblAlerts.Visible = alerts > 0;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var dlg = new InsumoDialogForm(null);
            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Result != null)
            {
                _all.Add(dlg.Result);
                ApplyFilter();
            }
        }
    }
}


