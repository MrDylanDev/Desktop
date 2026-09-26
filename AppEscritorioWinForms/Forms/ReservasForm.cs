using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Forms;

namespace app_escritorio.Forms
{
    public partial class ReservasForm : Form
    {
        public string Role { get; set; }
        public class Reserva
        {
            public DateTime Fecha { get; set; }
            public string Cliente { get; set; }
            public int Personas { get; set; }
            public string Mesa { get; set; }
            public string Estado { get; set; }
            public string Telefono { get; set; }

            public string HoraText => Fecha.ToString("HH:mm");
            public string PersonasText => $"{Personas} p";

            public Color EstadoColor
            {
                get
                {
                    if (Estado == "Confirmada") return Color.MediumSeaGreen;
                    if (Estado == "En curso") return Color.FromArgb(255, 107, 53);
                    return Color.IndianRed; // Cancelada
                }
            }

            public Reserva(DateTime fecha, string cliente, int personas, string mesa, string estado, string tel)
            {
                Fecha = fecha; Cliente = cliente; Personas = personas; Mesa = mesa; Estado = estado; Telefono = tel;
            }
        }

        private readonly BindingList<Reserva> _all = new BindingList<Reserva>();
        private readonly BindingList<Reserva> _filtered = new BindingList<Reserva>();

        public ReservasForm()
        {
            InitializeComponent();
            
            estadoBox.Items.AddRange(new[] { "Todos", "Confirmada", "En curso", "Cancelada" });
            estadoBox.SelectedIndex = 0;
            
            calendar.SetDate(DateTime.Today);
            
            LoadMock();
            ApplyFilter();
        }

        private void Header_Resize(object sender, EventArgs e)
        {
            if (btnAdd != null && header != null)
                btnAdd.Left = header.Width - btnAdd.Width - 20;
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            ApplyFilter();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void EstadoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _filtered.Count)
            {
                if (grid.Columns[e.ColumnIndex].DataPropertyName == "Estado")
                {
                    var r = _filtered[e.RowIndex];
                    e.CellStyle.ForeColor = r.EstadoColor;
                    e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);
                }
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _filtered.Count)
            {
                var r = _filtered[e.RowIndex];
                if (e.ColumnIndex == grid.Columns.Count - 2) // Editar
                {
                    var dlg = new ReservaDialogForm(r, r.Fecha.Date);
                    if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Result != null)
                    {
                        var idx = _all.IndexOf(r);
                        if (idx >= 0) _all[idx] = dlg.Result;
                        ApplyFilter();
                    }
                }
                else if (e.ColumnIndex == grid.Columns.Count - 1) // ×
                {
                    if (MessageBox.Show($"¿Eliminar reserva de {r.Cliente}?", "RestoOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _all.Remove(r);
                        ApplyFilter();
                    }
                }
            }
        }

        private void LoadMock()
        {
            var today = DateTime.Today;
            _all.Add(new Reserva(today.AddHours(13), "Laura Gómez", 2, "Mesa 2", "Confirmada", "310 555 0123"));
            _all.Add(new Reserva(today.AddHours(19.5), "Familia Rojas", 6, "Mesa 5", "Confirmada", "320 444 0099"));
            _all.Add(new Reserva(today.AddHours(20), "Carlos Pérez", 4, "Terraza 1", "En curso", "300 123 4567"));
            _all.Add(new Reserva(today.AddDays(1).AddHours(12), "Empresa Andina", 8, "VIP 1", "Confirmada", "315 777 0011"));
            _all.Add(new Reserva(today.AddDays(-1).AddHours(18), "Ana Torres", 2, "Barra 1", "Cancelada", "311 222 3344"));
        }

        private void ApplyFilter()
        {
            DateTime selectedDate = calendar.SelectionStart.Date;
            lblFecha.Text = selectedDate.ToString("dddd d MMM", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));

            string text = searchBox.Text.Trim().ToLower();
            string estado = estadoBox.SelectedItem?.ToString() ?? "Todos";

            _filtered.Clear();
            var sorted = _all.Where(r => 
                r.Fecha.Date == selectedDate &&
                (estado == "Todos" || r.Estado == estado) &&
                (string.IsNullOrEmpty(text) || r.Cliente.ToLower().Contains(text) || r.Mesa.ToLower().Contains(text))
            ).OrderBy(r => r.Fecha).ToList();

            foreach (var item in sorted)
            {
                _filtered.Add(item);
            }

            grid.DataSource = null;
            grid.DataSource = _filtered;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var dlg = new ReservaDialogForm(null, calendar.SelectionStart.Date);
            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Result != null)
            {
                _all.Add(dlg.Result);
                calendar.SetDate(dlg.Result.Fecha.Date); // This triggers DateChanged and ApplyFilter
                ApplyFilter(); // Just in case it was already the same date
            }
        }
    }
}




