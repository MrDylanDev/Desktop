using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using app_escritorio.Models; // For any standard models if needed

namespace app_escritorio.Forms
{
    public partial class ReportesForm : Form
    {
        public string Role { get; set; }

        private Label lblTotalVentas, lblTotalSub, lblTicketProm, lblImpuesto, lblMetodo;
        private TableLayoutPanel chartGrid;
        private DataGridView topList, mesaList, ventasList;
        private TextBox searchTrazabilidad;
        private ComboBox metodoTrazabilidad, estadoTrazabilidad;
        private DateTimePicker desdePicker, hastaPicker;
        private Label lblTotalTrazabilidad;

        private List<VentaMock> _ventas = new List<VentaMock>();
        private List<VentaMock> _ventasFiltered = new List<VentaMock>();

        public ReportesForm()
        {
            InitializeComponent();
            LoadMockData();
            BuildUI();
            RefreshData();
        }

        private void BuildUI()
        {
            mainLayout.Controls.Clear();

            // HEADER ROW
            var headerPanel = new Panel { Width = 1100, Height = 60, Margin = new Padding(0, 0, 0, 20) };
            
            var lblTitle = new Label { Text = "Reportes", Font = new Font("Segoe UI", 26, FontStyle.Bold), ForeColor = Color.White, AutoSize = true, Location = new Point(0, 5) };
            headerPanel.Controls.Add(lblTitle);

            var badge1 = CreateBadge("Solo Admin", Color.FromArgb(243, 146, 0), new Point(160, 20));
            var badge2 = CreateBadge("DEMO frontend", Color.FromArgb(243, 146, 0), new Point(250, 20));
            headerPanel.Controls.Add(badge1);
            headerPanel.Controls.Add(badge2);

            // FILTERS
            var filterPanel = new Panel { Width = 650, Height = 40, Location = new Point(450, 15) };
            
            var lblDesde = new Label { Text = "Desde", ForeColor = Color.DarkGray, Font = new Font("Segoe UI", 10), Location = new Point(0, 10), AutoSize = true };
            desdePicker = new DateTimePicker { Location = new Point(50, 8), Width = 100, Format = DateTimePickerFormat.Short };
            desdePicker.Value = DateTime.Now.AddDays(-7);
            
            var lblHasta = new Label { Text = "Hasta", ForeColor = Color.DarkGray, Font = new Font("Segoe UI", 10), Location = new Point(160, 10), AutoSize = true };
            hastaPicker = new DateTimePicker { Location = new Point(210, 8), Width = 100, Format = DateTimePickerFormat.Short };
            
            var comboTodo = new ComboBox { Location = new Point(320, 8), Width = 150, DropDownStyle = ComboBoxStyle.DropDownList };
            comboTodo.Items.Add("Todo (salón + ...)");
            comboTodo.SelectedIndex = 0;

            var btnActualizar = new Button { Text = "↻ Actualizar", Location = new Point(480, 6), Width = 100, Height = 28, BackColor = Color.FromArgb(30, 30, 35), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.Click += (s, e) => RefreshData();

            filterPanel.Controls.Add(lblDesde);
            filterPanel.Controls.Add(desdePicker);
            filterPanel.Controls.Add(lblHasta);
            filterPanel.Controls.Add(hastaPicker);
            filterPanel.Controls.Add(comboTodo);
            filterPanel.Controls.Add(btnActualizar);

            headerPanel.Controls.Add(filterPanel);
            mainLayout.Controls.Add(headerPanel);

            // ROW 1: 3 CARDS
            var row1 = new FlowLayoutPanel { Width = 1100, Height = 140, Margin = new Padding(0, 0, 0, 10), WrapContents = false };
            
            var card1 = CreateReportCard("Total ventas", "$ 2.185.778", "25 tickets · 7 días", Color.White, out lblTotalVentas, out lblTotalSub);
            var card2 = CreateReportCard("Ticket promedio", "$ 87.431", "por cuenta", Color.White, out lblTicketProm, out var sub2);
            var card3 = CreateReportCard("Impuesto recaudado", "$ 174.862", "INC 8% / IVA 19% unificado", Color.FromArgb(243, 146, 0), out lblImpuesto, out var sub3);
            
            row1.Controls.Add(card1);
            row1.Controls.Add(card2);
            row1.Controls.Add(card3);
            mainLayout.Controls.Add(row1);

            // ROW 2: 1 CARD (Efectivo/Tarjeta)
            var row2 = new FlowLayoutPanel { Width = 1100, Height = 140, Margin = new Padding(0, 0, 0, 20), WrapContents = false };
            var card4 = CreateWideCard("Efectivo / Tarjeta", "$ 1.267.751 / $ 918.027", "salón + delivery (mock)", out lblMetodo);
            row2.Controls.Add(card4);
            mainLayout.Controls.Add(row2);

            // ROW 3: CHARTS & TOP PLATOS
            var row3 = new FlowLayoutPanel { Width = 1100, Height = 280, Margin = new Padding(0, 0, 0, 20), WrapContents = false };
            
            var chartPanel = new RoundedPanel { Width = 680, Height = 270, BackColor = Color.FromArgb(30, 30, 35), CornerRadius = 15, Margin = new Padding(0, 0, 20, 0) };
            var lblChartTitle = new Label { Text = "Ventas últimos 7 días", Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.White, Location = new Point(20, 20), AutoSize = true };
            chartGrid = new TableLayoutPanel { Location = new Point(20, 50), Width = 640, Height = 170, ColumnCount = 7, RowCount = 2 };
            var lblChartSub = new Label { Text = "* Barras mock escala relativa al máximo del período", Font = new Font("Segoe UI", 9, FontStyle.Italic), ForeColor = Color.DarkGray, Location = new Point(20, 240), AutoSize = true };
            chartPanel.Controls.Add(lblChartTitle);
            chartPanel.Controls.Add(chartGrid);
            chartPanel.Controls.Add(lblChartSub);

            var topPanel = new RoundedPanel { Width = 380, Height = 270, BackColor = Color.FromArgb(30, 30, 35), CornerRadius = 15 };
            var lblTopTitle = new Label { Text = "Top platos", Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.White, Location = new Point(20, 20), AutoSize = true };
            topList = CreateDarkGrid(new[] { "#", "Plato", "Cant.", "Total" }, new[] { 30, 180, 50, 80 }, 340, 200);
            topList.Location = new Point(20, 50);
            topPanel.Controls.Add(lblTopTitle);
            topPanel.Controls.Add(topList);

            row3.Controls.Add(chartPanel);
            row3.Controls.Add(topPanel);
            mainLayout.Controls.Add(row3);

            // ROW 4: VENTAS POR MESA
            var row4 = new RoundedPanel { Width = 1080, Height = 220, BackColor = Color.FromArgb(30, 30, 35), CornerRadius = 15, Margin = new Padding(0, 0, 0, 20) };
            var lblMesaTitle = new Label { Text = "Ventas por mesa", Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.White, Location = new Point(20, 20), AutoSize = true };
            mesaList = CreateDarkGrid(new[] { "Mesa", "Tickets", "Total", "Mesero" }, new[] { 150, 150, 200, 200 }, 1040, 150);
            mesaList.Location = new Point(20, 50);
            row4.Controls.Add(lblMesaTitle);
            row4.Controls.Add(mesaList);
            mainLayout.Controls.Add(row4);

            // ROW 5: HISTORIAL DE COBROS
            var row5 = new RoundedPanel { Width = 1080, Height = 400, BackColor = Color.FromArgb(30, 30, 35), CornerRadius = 15, Margin = new Padding(0, 0, 0, 20) };
            var lblTrazTitle = new Label { Text = "Historial de cobros — qué se vendió (trazabilidad POS)", Font = new Font("Segoe UI", 12, FontStyle.Bold), ForeColor = Color.White, Location = new Point(20, 20), AutoSize = true };
            lblTotalTrazabilidad = new Label { Text = "Rango: $ 192.500 · 7 ventas", Font = new Font("Segoe UI", 11, FontStyle.Bold), ForeColor = Color.FromArgb(243, 146, 0), Location = new Point(800, 20), AutoSize = true };
            
            searchTrazabilidad = new TextBox { Location = new Point(20, 60), Width = 300, Font = new Font("Segoe UI", 12), BackColor = Color.FromArgb(40, 40, 40), ForeColor = Color.White };
            searchTrazabilidad.Text = "Buscar mesa, producto, cajero...";
            searchTrazabilidad.ForeColor = Color.Gray;
            searchTrazabilidad.GotFocus += (s, e) => { if (searchTrazabilidad.Text == "Buscar mesa, producto, cajero...") { searchTrazabilidad.Text = ""; searchTrazabilidad.ForeColor = Color.White; } };
            searchTrazabilidad.LostFocus += (s, e) => { if (string.IsNullOrWhiteSpace(searchTrazabilidad.Text)) { searchTrazabilidad.Text = "Buscar mesa, producto, cajero..."; searchTrazabilidad.ForeColor = Color.Gray; } };
            searchTrazabilidad.TextChanged += (s, e) => { if (searchTrazabilidad.Text != "Buscar mesa, producto, cajero...") RefreshTrazabilidad(); };

            metodoTrazabilidad = new ComboBox { Location = new Point(340, 60), Width = 150, Font = new Font("Segoe UI", 12), DropDownStyle = ComboBoxStyle.DropDownList, BackColor = Color.FromArgb(40, 40, 40), ForeColor = Color.White };
            metodoTrazabilidad.Items.AddRange(new[] { "Todos", "Efectivo", "Tarjeta" });
            metodoTrazabilidad.SelectedIndex = 0;
            metodoTrazabilidad.SelectedIndexChanged += (s, e) => RefreshTrazabilidad();

            estadoTrazabilidad = new ComboBox { Location = new Point(510, 60), Width = 150, Font = new Font("Segoe UI", 12), DropDownStyle = ComboBoxStyle.DropDownList, BackColor = Color.FromArgb(40, 40, 40), ForeColor = Color.White };
            estadoTrazabilidad.Items.AddRange(new[] { "Todos", "Cobrado", "Anulado" });
            estadoTrazabilidad.SelectedIndex = 0;
            estadoTrazabilidad.SelectedIndexChanged += (s, e) => RefreshTrazabilidad();

            ventasList = CreateDarkGrid(new[] { "Fecha", "Mesa", "Qué se vendió", "Total", "Método", "Cajero", "Estado", "Acción" }, new[] { 100, 80, 300, 90, 90, 90, 90, 70 }, 1040, 280);
            ventasList.Location = new Point(20, 110);
            
            var btnCol = new DataGridViewButtonColumn { HeaderText = "", Text = "Ver", UseColumnTextForButtonValue = true, Width = 70, FlatStyle = FlatStyle.Flat };
            btnCol.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            ventasList.Columns.RemoveAt(7); 
            ventasList.Columns.Add(btnCol);

            ventasList.CellFormatting += VentasList_CellFormatting;
            ventasList.CellClick += VentasList_CellClick;

            row5.Controls.Add(lblTrazTitle);
            row5.Controls.Add(lblTotalTrazabilidad);
            row5.Controls.Add(searchTrazabilidad);
            row5.Controls.Add(metodoTrazabilidad);
            row5.Controls.Add(estadoTrazabilidad);
            row5.Controls.Add(ventasList);
            mainLayout.Controls.Add(row5);
        }

        private RoundedPanel CreateReportCard(string title, string defVal, string defSub, Color valColor, out Label valLabel, out Label subLabel)
        {
            var p = new RoundedPanel { Width = 355, Height = 130, BackColor = Color.FromArgb(30, 30, 35), CornerRadius = 15, Margin = new Padding(0, 0, 15, 0) };
            var lblTitle = new Label { Text = title, Font = new Font("Segoe UI", 11), ForeColor = Color.Gray, Location = new Point(20, 20), AutoSize = true };
            valLabel = new Label { Text = defVal, Font = new Font("Segoe UI", 22, FontStyle.Bold), ForeColor = valColor, Location = new Point(15, 45), AutoSize = true };
            subLabel = new Label { Text = defSub, Font = new Font("Segoe UI", 10), ForeColor = Color.Gray, Location = new Point(20, 95), AutoSize = true };
            p.Controls.Add(lblTitle);
            p.Controls.Add(valLabel);
            p.Controls.Add(subLabel);
            return p;
        }

        private RoundedPanel CreateWideCard(string title, string defVal, string defSub, out Label valLabel)
        {
            var p = new RoundedPanel { Width = 730, Height = 130, BackColor = Color.FromArgb(30, 30, 35), CornerRadius = 15, Margin = new Padding(0, 0, 0, 0) };
            var lblTitle = new Label { Text = title, Font = new Font("Segoe UI", 11), ForeColor = Color.Gray, Location = new Point(20, 20), AutoSize = true };
            valLabel = new Label { Text = defVal, Font = new Font("Segoe UI", 22, FontStyle.Bold), ForeColor = Color.White, Location = new Point(15, 45), AutoSize = true };
            var subLabel = new Label { Text = defSub, Font = new Font("Segoe UI", 10), ForeColor = Color.Gray, Location = new Point(20, 95), AutoSize = true };
            p.Controls.Add(lblTitle);
            p.Controls.Add(valLabel);
            p.Controls.Add(subLabel);
            return p;
        }

        private Label CreateBadge(string text, Color color, Point loc)
        {
            var p = new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = color,
                BackColor = Color.FromArgb(40, 40, 40),
                Location = loc,
                AutoSize = true,
                Padding = new Padding(4)
            };
            return p;
        }

        private DataGridView CreateDarkGrid(string[] headers, int[] widths, int w, int h)
        {
            var g = new DataGridView
            {
                Width = w,
                Height = h,
                BackgroundColor = Color.FromArgb(30, 30, 35),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                GridColor = Color.FromArgb(50, 50, 50),
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 35);
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkGray;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 35);
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(50, 50, 50);
            g.DefaultCellStyle.SelectionForeColor = Color.White;
            g.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            for (int i = 0; i < headers.Length; i++)
            {
                g.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = headers[i], Width = widths[i] });
            }
            return g;
        }

        private void LoadMockData()
        {
            var hoy = DateTime.Now;
            _ventas.Clear();
            _ventas.Add(new VentaMock(hoy.AddHours(-1), "Mesa 5", "x1 Bife de Chorizo", 22000, "Tarjeta", "Carlos", "Cobrado"));
            _ventas.Add(new VentaMock(hoy.AddHours(-2), "Barra 1", "x2 Cerveza IPA", 10000, "Efectivo", "Ana", "Cobrado"));
            _ventas.Add(new VentaMock(hoy.AddHours(-3), "Mesa 3", "x1 Hamburguesa, x1 Papas", 15000, "Efectivo", "Carlos", "Anulado"));
            _ventas.Add(new VentaMock(hoy.AddDays(-1), "Terraza 1", "x3 Pizza Familiar", 43500, "Tarjeta", "Ana", "Cobrado"));
            _ventas.Add(new VentaMock(hoy.AddDays(-2), "Mesa 2", "x1 Ensalada, x1 Agua", 8000, "Efectivo", "Carlos", "Cobrado"));
        }

        private void RefreshData()
        {
            // Update labels based on requirement
            lblTotalVentas.Text = "$ 2.185.778";
            lblTotalSub.Text = "25 tickets · 7 días";
            lblTicketProm.Text = "$ 87.431";
            lblImpuesto.Text = "$ 174.862";
            lblMetodo.Text = "$ 1.267.751 / $ 918.027";

            // CHART
            chartGrid.Controls.Clear();
            chartGrid.ColumnStyles.Clear();
            chartGrid.RowStyles.Clear();
            chartGrid.RowCount = 2;
            chartGrid.ColumnCount = 7;
            chartGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            chartGrid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            
            var ventas = new[] { 100, 150, 120, 180, 200, 250, 160 }; // Mock heights
            long max = ventas.Max();
            var diasLbl = new[] { "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb", "Dom" };
            
            for (int i = 0; i < 7; i++)
            {
                chartGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));
                double h = max > 0 ? 140 * ventas[i] / (double)max : 0;
                
                var bar = new Panel 
                { 
                    BackColor = (i == 6) ? Color.FromArgb(243, 146, 0) : Color.FromArgb(250, 180, 160), 
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                    Margin = new Padding(15, 0, 15, 0),
                    Height = Math.Max(10, (int)h)
                };
                chartGrid.Controls.Add(bar, i, 0);

                var lbl = new Label 
                { 
                    Text = diasLbl[i], 
                    ForeColor = Color.DarkGray, 
                    Font = new Font("Segoe UI", 9), 
                    TextAlign = ContentAlignment.MiddleCenter, 
                    Dock = DockStyle.Fill 
                };
                chartGrid.Controls.Add(lbl, i, 1);
            }

            // LISTS
            topList.Rows.Clear();
            topList.Rows.Add("1", "Bife de Chorizo 400g", "12", "$264.000");
            topList.Rows.Add("2", "Pizza Napolitana Familiar", "9", "$130.500");
            topList.Rows.Add("3", "Hamburguesa Doble Queso", "8", "$96.000");
            topList.Rows.Add("4", "Cerveza Tirada IPA", "15", "$75.000");

            mesaList.Rows.Clear();
            mesaList.Rows.Add("Mesa 5", "5", "$187.900", "Ana");
            mesaList.Rows.Add("Mesa 3", "4", "$164.200", "Carlos");
            mesaList.Rows.Add("Barra 1", "6", "$118.500", "Ana");
            mesaList.Rows.Add("Terraza 1", "3", "$92.300", "—");

            RefreshTrazabilidad();
        }

        private void RefreshTrazabilidad()
        {
            if (ventasList == null) return;
            string text = searchTrazabilidad.Text.Trim().ToLower();
            if (text == "buscar mesa, producto, cajero...") text = "";

            string metodo = metodoTrazabilidad.SelectedItem?.ToString() ?? "Todos";
            string estado = estadoTrazabilidad.SelectedItem?.ToString() ?? "Todos";
            var desde = desdePicker.Value.Date;
            var hasta = hastaPicker.Value.Date.AddDays(1).AddSeconds(-1);

            _ventasFiltered.Clear();
            var filtered = _ventas.Where(v =>
                v.Fecha >= desde &&
                v.Fecha <= hasta &&
                (metodo == "Todos" || v.Metodo == metodo) &&
                (estado == "Todos" || v.Estado == estado) &&
                (string.IsNullOrEmpty(text) || v.Mesa.ToLower().Contains(text) || v.Detalle.ToLower().Contains(text) || v.Cajero.ToLower().Contains(text))
            ).OrderByDescending(v => v.Fecha).ToList();

            ventasList.Rows.Clear();
            foreach (var v in filtered)
            {
                _ventasFiltered.Add(v);
                ventasList.Rows.Add(v.Fecha.ToString("dd/MM HH:mm"), v.Mesa, v.Detalle, v.Total.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO")), v.Metodo, v.Cajero, v.Estado, "Ver");
            }

            var total = filtered.Where(v => v.Estado == "Cobrado").Sum(v => v.Total);
            lblTotalTrazabilidad.Text = $"Rango: {total.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"))} · {filtered.Count} ventas";
        }

        private void VentasList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _ventasFiltered.Count)
            {
                var v = _ventasFiltered[e.RowIndex];
                if (e.ColumnIndex == 3) // Total
                {
                    e.CellStyle.ForeColor = Color.FromArgb(243, 146, 0); // Orange
                    e.CellStyle.Font = new Font(ventasList.Font, FontStyle.Bold);
                }
                else if (e.ColumnIndex == 4) // Metodo
                {
                    e.CellStyle.ForeColor = v.Metodo == "Efectivo" ? Color.FromArgb(0, 200, 150) : Color.White;
                }
                else if (e.ColumnIndex == 6) // Estado
                {
                    e.CellStyle.ForeColor = v.Estado == "Cobrado" ? Color.FromArgb(0, 200, 150) : Color.FromArgb(220, 50, 50);
                }
            }
        }

        private void VentasList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _ventasFiltered.Count)
            {
                if (e.ColumnIndex == 7) // Ver button
                {
                    var v = _ventasFiltered[e.RowIndex];
                    var sb = new StringBuilder();
                    sb.AppendLine("RESTOOS — TRAZABILIDAD POS");
                    sb.AppendLine(v.Fecha.ToString("dd/MM/yyyy HH:mm"));
                    sb.AppendLine($"Mesa: {v.Mesa} — Cajero: {v.Cajero}");
                    sb.AppendLine("----------------------------");
                    sb.AppendLine(v.Detalle);
                    sb.AppendLine("----------------------------");
                    sb.AppendLine($"Total: {v.Total.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"))}");
                    sb.AppendLine($"Método: {v.Metodo}");
                    sb.AppendLine($"Estado: {v.Estado}");
                    
                    MessageBox.Show(sb.ToString(), "Receipt Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

    public class VentaMock
    {
        public DateTime Fecha { get; set; }
        public string Mesa { get; set; }
        public string Detalle { get; set; }
        public decimal Total { get; set; }
        public string Metodo { get; set; }
        public string Cajero { get; set; }
        public string Estado { get; set; }

        public VentaMock(DateTime f, string m, string d, decimal t, string met, string c, string e)
        {
            Fecha = f; Mesa = m; Detalle = d; Total = t; Metodo = met; Cajero = c; Estado = e;
        }
    }
}
