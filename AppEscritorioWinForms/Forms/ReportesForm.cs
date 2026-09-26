using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using app_escritorio.Models;
using app_escritorio.UI;
using app_escritorio.Utils;

namespace app_escritorio.Forms
{
    /// <summary>
    /// Reportes + Trazabilidad (migración de ReportesView.xaml de WPF). Solo Admin.
    /// Genera ventas DEMO de los últimos 30 días y calcula KPIs, gráfico, top platos, ventas por mesa e historial.
    /// </summary>
    public partial class ReportesForm : Form
    {
        private static readonly CultureInfo Co = CultureInfo.GetCultureInfo("es-CO");
        private readonly List<Venta> _ventas = new List<Venta>();
        private bool _ready;

        public ReportesForm()
        {
            InitializeComponent();
            if (UiHelpers.IsDesignTime) return;

            GenerateMock();
            cmbPeriodo.SelectedIndex = 1;
            cmbOrigen.SelectedIndex = 0;
            cmbMetodo.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            _ready = true;
            RefreshData();
        }

        private static string Money(decimal v) => v.ToString("C0", Co);

        // ===================== Datos DEMO =====================

        private void GenerateMock()
        {
            var platos = new (string Name, decimal Price)[]
            {
                ("Bife de Chorizo 400g", 22000), ("Pizza Napolitana Familiar", 14500), ("Hamburguesa Doble Queso", 12000),
                ("Cerveza Tirada IPA", 5000), ("Ensalada César con Pollo", 11000), ("Ravioles 4 Quesos", 13500),
                ("Limonada Menta", 4500), ("Tiramisú Casero", 7000)
            };
            var mesas = new[] { "Mesa 2", "Mesa 3", "Mesa 5", "Barra 1", "Terraza 1", "VIP 1" };
            var cajeros = new[] { "Ana", "Carlos" };
            var rnd = new Random(2026);

            for (int d = 29; d >= 0; d--)
            {
                int count = d == 0 ? 4 : 2 + rnd.Next(4);
                for (int i = 0; i < count; i++)
                {
                    var fecha = DateTime.Today.AddDays(-d).AddHours(12 + rnd.Next(10)).AddMinutes(rnd.Next(60));
                    if (fecha > DateTime.Now) fecha = DateTime.Now.AddMinutes(-5 - 20 * i);
                    bool delivery = rnd.Next(5) == 0;
                    var v = new Venta(fecha, delivery ? "Delivery" : mesas[rnd.Next(mesas.Length)], "", 0,
                                      rnd.Next(2) == 0 ? "Efectivo" : "Tarjeta", cajeros[rnd.Next(2)],
                                      rnd.Next(12) == 0 ? "Anulado" : "Cobrado", delivery ? "Delivery" : "Salón");
                    int lines = 1 + rnd.Next(3);
                    for (int l = 0; l < lines; l++)
                    {
                        var p = platos[rnd.Next(platos.Length)];
                        v.Items.Add(new VentaItem(p.Name, 1 + rnd.Next(3), p.Price));
                    }
                    v.Total = v.Items.Sum(x => x.Subtotal);
                    v.Detalle = string.Join(", ", v.Items.Select(x => "x" + x.Cantidad + " " + x.Plato));
                    _ventas.Add(v);
                }
            }
        }

        private DateTime PeriodStart()
        {
            switch (cmbPeriodo.SelectedIndex)
            {
                case 0: return DateTime.Today;
                case 2: return DateTime.Today.AddDays(-29);
                case 3: return new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                default: return DateTime.Today.AddDays(-6);
            }
        }

        private IEnumerable<Venta> InPeriod()
        {
            var from = PeriodStart();
            string origen = cmbOrigen.SelectedIndex == 1 ? "Salón" : cmbOrigen.SelectedIndex == 2 ? "Delivery" : null;
            return _ventas.Where(v => v.Fecha >= from && (origen == null || v.Origen == origen));
        }

        // ===================== Pintado =====================

        private void RefreshData()
        {
            var cobradas = InPeriod().Where(v => v.Estado == "Cobrado").ToList();
            decimal total = cobradas.Sum(v => v.Total);
            int tickets = cobradas.Count;

            lblTotal.Text = Money(total);
            lblTotalSub.Text = tickets + " tickets · " + cmbPeriodo.Text.ToLower(Co);
            lblTicket.Text = Money(tickets == 0 ? 0 : Math.Round(total / tickets));
            lblTax.Text = Money(Math.Round(total - total / 1.08m));
            lblMetodo.Text = Money(cobradas.Where(v => v.Metodo == "Efectivo").Sum(v => v.Total)) + " / " +
                             Money(cobradas.Where(v => v.Metodo == "Tarjeta").Sum(v => v.Total));

            // Gráfico: siempre los últimos 7 días
            var values = new decimal[7];
            var labels = new string[7];
            for (int i = 0; i < 7; i++)
            {
                var day = DateTime.Today.AddDays(i - 6);
                values[i] = _ventas.Where(v => v.Estado == "Cobrado" && v.Fecha.Date == day).Sum(v => v.Total);
                labels[i] = Co.TextInfo.ToTitleCase(day.ToString("ddd", Co).TrimEnd('.'));
            }
            chart.SetData(values, labels);

            gridTop.Rows.Clear();
            int rank = 1;
            foreach (var g in cobradas.SelectMany(v => v.Items).GroupBy(x => x.Plato)
                                      .Select(g => new { Plato = g.Key, Cant = g.Sum(x => x.Cantidad), Total = g.Sum(x => x.Subtotal) })
                                      .OrderByDescending(x => x.Total).Take(6))
                gridTop.Rows.Add(rank++, g.Plato, g.Cant, Money(g.Total));

            gridMesa.Rows.Clear();
            foreach (var g in cobradas.GroupBy(v => v.Mesa).OrderByDescending(g => g.Sum(v => v.Total)))
                gridMesa.Rows.Add(g.Key, g.Count(), Money(g.Sum(v => v.Total)),
                                  g.GroupBy(v => v.Cajero).OrderByDescending(c => c.Count()).First().Key);

            RefreshHistorial();
        }

        private void RefreshHistorial()
        {
            string text = txtHistSearch.Text.Trim().ToLowerInvariant();
            string metodo = cmbMetodo.SelectedItem?.ToString() ?? "Todos";
            string estado = cmbEstado.SelectedItem?.ToString() ?? "Todos";

            var rows = InPeriod().Where(v => (metodo == "Todos" || v.Metodo == metodo)
                                             && (estado == "Todos" || v.Estado == estado)
                                             && (text.Length == 0 || v.Mesa.ToLowerInvariant().Contains(text)
                                                 || v.Detalle.ToLowerInvariant().Contains(text) || v.Cajero.ToLowerInvariant().Contains(text)))
                                 .OrderByDescending(v => v.Fecha).ToList();

            gridHist.Rows.Clear();
            foreach (var v in rows)
            {
                int i = gridHist.Rows.Add(v.Fecha.ToString("dd/MM HH:mm"), v.Mesa, v.Detalle, v.TotalText, v.Metodo, v.Cajero, v.Estado);
                gridHist.Rows[i].Tag = v;
                gridHist.Rows[i].Cells[colHEstado.Index].Style.ForeColor = v.EstadoColor;
                gridHist.Rows[i].Cells[colHTotal.Index].Style.ForeColor = Theme.Primary;
            }
            decimal cobrado = rows.Where(v => v.Estado == "Cobrado").Sum(v => v.Total);
            lblRango.Text = cmbPeriodo.Text + ": " + Money(cobrado) + " · " + rows.Count + " ventas";
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            if (_ready) RefreshData();
        }

        private void Hist_Changed(object sender, EventArgs e)
        {
            if (_ready) RefreshHistorial();
        }

        private void BtnRefresh_Click(object sender, EventArgs e) => RefreshData();

        private void GridHist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colHVer.Index || !(gridHist.Rows[e.RowIndex].Tag is Venta v)) return;

            var sb = new StringBuilder();
            sb.AppendLine("RESTOOS — TRAZABILIDAD POS");
            sb.AppendLine(v.Fecha.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine("Mesa: " + v.Mesa + " — Cajero: " + v.Cajero);
            sb.AppendLine("----------------------------");
            foreach (var it in v.Items) sb.AppendLine("x" + it.Cantidad + " " + it.Plato + "   " + Money(it.Subtotal));
            sb.AppendLine("----------------------------");
            sb.AppendLine("Total: " + v.TotalText);
            sb.AppendLine("Método: " + v.Metodo);
            sb.AppendLine("Estado: " + v.Estado);
            MessageBox.Show(sb.ToString(), "Detalle de venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
