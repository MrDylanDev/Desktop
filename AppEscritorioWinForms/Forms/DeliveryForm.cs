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
    /// Delivery (migración de DeliveryView.xaml de WPF): cola de pedidos Rappi / Uber Eats / DiDi Food (DEMO).
    /// </summary>
    public partial class DeliveryForm : Form
    {
        private readonly List<PedidoDelivery> _all = new List<PedidoDelivery>();

        public DeliveryForm()
        {
            InitializeComponent();
            if (UiHelpers.IsDesignTime) return;

            LoadMock();
            cmbPlataforma.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            ApplyFilter();
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
            string plat = cmbPlataforma.SelectedItem?.ToString() ?? "Todas";
            string est = cmbEstado.SelectedItem?.ToString() ?? "Todos";
            string text = txtSearch.Text.Trim().ToLowerInvariant();

            grid.Rows.Clear();
            foreach (var p in _all.Where(p => (plat == "Todas" || p.Plataforma == plat)
                                              && (est == "Todos" || p.Estado == est)
                                              && (text.Length == 0 || p.Cliente.ToLowerInvariant().Contains(text)
                                                  || p.Detalle.ToLowerInvariant().Contains(text) || p.Id.ToLowerInvariant().Contains(text)))
                                  .OrderByDescending(p => p.Fecha))
            {
                int i = grid.Rows.Add(p.HoraText, p.Plataforma, p.Id, p.Cliente, p.Detalle, p.TotalText, p.Estado, null, null, p.AccionAvanzar);
                var row = grid.Rows[i];
                row.Tag = p;
                row.Cells[colPlataforma.Index].Style.ForeColor = p.PlataformaColor;
                row.Cells[colEstado.Index].Style.ForeColor = p.EstadoColor;
                row.Cells[colTotal.Index].Style.ForeColor = Theme.Primary;
                row.Cells[colTotal.Index].Style.Font = Theme.GetFont(9.75F, FontStyle.Bold);
            }
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            if (!UiHelpers.IsDesignTime) ApplyFilter();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            using (var dlg = new DeliveryDialogForm(null))
                if (dlg.ShowDialog(TopLevelControl ?? this) == DialogResult.OK && dlg.Result != null)
                {
                    _all.Add(dlg.Result);
                    ApplyFilter();
                }
        }

        private void BtnSync_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menú sincronizado con Rappi, Uber Eats y DiDi Food (DEMO).\nPrecios y disponibilidad actualizados en las plataformas.",
                "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !(grid.Rows[e.RowIndex].Tag is PedidoDelivery p)) return;

            if (e.ColumnIndex == colEditar.Index)
            {
                using (var dlg = new DeliveryDialogForm(p))
                    if (dlg.ShowDialog(TopLevelControl ?? this) == DialogResult.OK && dlg.Result != null)
                    {
                        _all[_all.IndexOf(p)] = dlg.Result;
                        ApplyFilter();
                    }
            }
            else if (e.ColumnIndex == colDelete.Index)
            {
                if (MessageBox.Show("¿Eliminar el pedido " + p.Id + " de " + p.Cliente + "?", "RestoOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _all.Remove(p);
                    ApplyFilter();
                }
            }
            else if (e.ColumnIndex == colAvanzar.Index && p.AccionAvanzar.Length > 0)
            {
                p.Avanzar();
                ApplyFilter();
            }
        }
    }
}
