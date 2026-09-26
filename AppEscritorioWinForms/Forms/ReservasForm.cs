using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Models;
using app_escritorio.UI;

namespace app_escritorio.Forms
{
    /// <summary>
    /// Reservas (migración de ReservasView.xaml de WPF): calendario a la izquierda y agenda del día a la derecha.
    /// Datos DEMO en memoria.
    /// </summary>
    public partial class ReservasForm : Form
    {
        private static readonly CultureInfo Co = CultureInfo.GetCultureInfo("es-CO");
        private readonly List<Reserva> _all = new List<Reserva>();

        public ReservasForm()
        {
            InitializeComponent();
            if (UiHelpers.IsDesignTime) return;

            LoadMock();
            cmbEstado.SelectedIndex = 0;
            ApplyFilter();
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
            DateTime day = calendar.SelectedDate;
            lblFecha.Text = day == DateTime.Today ? "Hoy · " + day.ToString("dddd d MMM", Co) : day.ToString("dddd d MMM yyyy", Co);
            string text = txtSearch.Text.Trim().ToLowerInvariant();
            string estado = cmbEstado.SelectedItem?.ToString() ?? "Todos";

            grid.Rows.Clear();
            foreach (var r in _all.Where(r => r.Fecha.Date == day
                                              && (estado == "Todos" || r.Estado == estado)
                                              && (text.Length == 0 || r.Cliente.ToLowerInvariant().Contains(text) || r.Mesa.ToLowerInvariant().Contains(text)))
                                  .OrderBy(r => r.Fecha))
            {
                int i = grid.Rows.Add(r.HoraText, r.Cliente, r.PersonasText, r.Mesa, r.Estado, r.Telefono);
                grid.Rows[i].Tag = r;
                grid.Rows[i].Cells[colEstado.Index].Style.ForeColor = r.EstadoColor;
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            if (!UiHelpers.IsDesignTime) ApplyFilter();
        }

        private void Calendar_DateChanged(object sender, EventArgs e)
        {
            if (!UiHelpers.IsDesignTime) ApplyFilter();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new ReservaDialogForm(null, calendar.SelectedDate))
                if (dlg.ShowDialog(TopLevelControl ?? this) == DialogResult.OK && dlg.Result != null)
                {
                    _all.Add(dlg.Result);
                    calendar.SelectedDate = dlg.Result.Fecha.Date; // refresca la agenda de ese día
                }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !(grid.Rows[e.RowIndex].Tag is Reserva r)) return;

            if (e.ColumnIndex == colEditar.Index)
            {
                using (var dlg = new ReservaDialogForm(r, r.Fecha.Date))
                    if (dlg.ShowDialog(TopLevelControl ?? this) == DialogResult.OK && dlg.Result != null)
                    {
                        _all[_all.IndexOf(r)] = dlg.Result;
                        calendar.SelectedDate = dlg.Result.Fecha.Date;
                    }
            }
            else if (e.ColumnIndex == colDelete.Index)
            {
                if (MessageBox.Show("¿Eliminar la reserva de " + r.Cliente + "?", "RestoOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _all.Remove(r);
                    ApplyFilter();
                }
            }
        }
    }
}
