using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Forms;

namespace app_escritorio.Forms
{
    public partial class DeliveryForm : Form
    {
        public string Role { get; set; }
        public class PedidoDelivery : INotifyPropertyChanged
        {
            public DateTime Fecha { get; set; }
            public string Plataforma { get; set; }
            public string Id { get; set; }
            public string Cliente { get; set; }
            public string Detalle { get; set; }
            public decimal Total { get; set; }
            
            private string _estado;
            public string Estado
            {
                get => _estado;
                set
                {
                    _estado = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Estado)));
                }
            }

            public string HoraText => Fecha.ToString("HH:mm");
            public string TotalText => Total.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));

            public Color PlataformaColor => Plataforma == "Rappi" ? Color.FromArgb(255, 55, 43) : Plataforma == "Uber Eats" ? Color.FromArgb(6, 193, 103) : Color.FromArgb(255, 106, 0);
            public Color EstadoColor => Estado == "Nuevo" ? Color.FromArgb(255, 185, 95) : Estado == "En preparación" ? Color.FromArgb(255, 107, 53) : Estado == "Listo para rider" ? Color.MediumSeaGreen : Color.Gray;

            public string AccionAvanzarText
            {
                get
                {
                    if (Estado == "Nuevo") return "▶ En preparación";
                    if (Estado == "En preparación") return "✓ Listo rider";
                    if (Estado == "Listo para rider") return "✓ Entregado";
                    return "Entregado";
                }
            }

            public PedidoDelivery(DateTime fecha, string plat, string id, string cliente, string detalle, decimal total, string estado)
            {
                Fecha = fecha; Plataforma = plat; Id = id; Cliente = cliente; Detalle = detalle; Total = total; Estado = estado;
            }

            public event PropertyChangedEventHandler PropertyChanged;
        }

        private readonly BindingList<PedidoDelivery> _all = new BindingList<PedidoDelivery>();
        private readonly BindingList<PedidoDelivery> _filtered = new BindingList<PedidoDelivery>();

        public DeliveryForm()
        {
            InitializeComponent();
            
            plataformaBox.Items.AddRange(new[] { "Todas", "Rappi", "Uber Eats", "DiDi Food" });
            plataformaBox.SelectedIndex = 0;
            
            estadoBox.Items.AddRange(new[] { "Todos", "Nuevo", "En preparación", "Listo para rider", "Entregado" });
            estadoBox.SelectedIndex = 0;

            LoadMock();
            ApplyFilter();
        }

        private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _filtered.Count)
            {
                var r = _filtered[e.RowIndex];
                if (grid.Columns[e.ColumnIndex].DataPropertyName == "Plataforma")
                {
                    e.CellStyle.ForeColor = r.PlataformaColor;
                    e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);
                }
                else if (grid.Columns[e.ColumnIndex].DataPropertyName == "Estado")
                {
                    e.CellStyle.ForeColor = r.EstadoColor;
                    e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);
                }
                else if (grid.Columns[e.ColumnIndex].DataPropertyName == "TotalText")
                {
                    e.CellStyle.ForeColor = Color.FromArgb(255, 107, 53); // Primary color for total
                    e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);
                }
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _filtered.Count)
            {
                var p = _filtered[e.RowIndex];
                
                if (e.ColumnIndex == grid.Columns.Count - 3) // Editar
                {
                    var dlg = new DeliveryDialogForm(p);
                    if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Result != null)
                    {
                        var idx = _all.IndexOf(p);
                        if (idx >= 0) _all[idx] = dlg.Result;
                        ApplyFilter();
                    }
                }
                else if (e.ColumnIndex == grid.Columns.Count - 2) // ×
                {
                    if (MessageBox.Show($"¿Eliminar pedido {p.Id} de {p.Cliente}?", "RestoOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _all.Remove(p);
                        ApplyFilter();
                    }
                }
                else if (e.ColumnIndex == grid.Columns.Count - 1) // Avanzar
                {
                    if (p.Estado != "Entregado")
                    {
                        if (p.Estado == "Nuevo") p.Estado = "En preparación";
                        else if (p.Estado == "En preparación") p.Estado = "Listo para rider";
                        else if (p.Estado == "Listo para rider") p.Estado = "Entregado";
                        
                        grid.InvalidateRow(e.RowIndex);
                        ApplyFilter();
                    }
                }
            }
        }

        private void LoadMock()
        {
            var hoy = DateTime.Today;
            _all.Add(new PedidoDelivery(hoy.AddHours(12.3), "Rappi", "#R-8821", "Valentina R.", "x1 Pizza Napolitana, x1 Cerveza IPA", 19500, "Nuevo"));
            _all.Add(new PedidoDelivery(hoy.AddHours(12.8), "Uber Eats", "#U-4419", "Andrés M.", "x2 Hamburguesa Doble (sin cebolla)", 24000, "En preparación"));
            _all.Add(new PedidoDelivery(hoy.AddHours(13.1), "DiDi Food", "#D-1092", "Familia Gómez", "x1 Bife Chorizo 400g", 22000, "Listo para rider"));
            _all.Add(new PedidoDelivery(hoy.AddHours(13.4), "Rappi", "#R-8822", "Camila S.", "x1 Ensalada César, x1 Limonada", 14000, "Nuevo"));
            _all.Add(new PedidoDelivery(hoy.AddHours(14), "Uber Eats", "#U-4420", "Jorge L.", "x1 Ravioles 4 Quesos", 13500, "Entregado"));
        }

        private void ApplyFilter()
        {
            string plat = plataformaBox.SelectedItem?.ToString() ?? "Todas";
            string est = estadoBox.SelectedItem?.ToString() ?? "Todos";
            string text = searchBox.Text.Trim().ToLower();

            _filtered.Clear();
            var sorted = _all.Where(p =>
                (plat == "Todas" || p.Plataforma == plat) &&
                (est == "Todos" || p.Estado == est) &&
                (string.IsNullOrEmpty(text) || p.Cliente.ToLower().Contains(text) || p.Detalle.ToLower().Contains(text) || p.Id.ToLower().Contains(text))
            ).OrderByDescending(p => p.Fecha).ToList();

            foreach (var item in sorted)
            {
                _filtered.Add(item);
            }

            grid.DataSource = null;
            grid.DataSource = _filtered;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            var dlg = new DeliveryDialogForm(null);
            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Result != null)
            {
                _all.Add(dlg.Result);
                ApplyFilter();
            }
        }
    }
}


