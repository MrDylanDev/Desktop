using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Forms;

namespace app_escritorio.Forms
{
    public partial class MesasForm : Form
    {
        public string Role { get; set; }
        private readonly List<TableInfo> _tables = new List<TableInfo>();
        private TableInfo _selected;
        
        public event Action<string> MesaParaPos;

        private static string StorePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestoOS", "mesas.dat");

        public MesasForm()
        {
            InitializeComponent();
            LoadTables();
            ApplyFilter();
        }

        private void SectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void LoadTables()
        {
            try
            {
                if (File.Exists(StorePath))
                {
                    var lines = File.ReadAllLines(StorePath);
                    foreach (var line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        var parts = line.Split('|');
                        if (parts.Length < 6) continue;
                        _tables.Add(new TableInfo(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5] == "1"));
                    }
                    if (_tables.Count > 0) return;
                }
            }
            catch { }
            
            _tables.Add(new TableInfo("Mesa 1", "Principal", "2 personas", "Libre", "$0", true));
            _tables.Add(new TableInfo("Mesa 2", "Principal", "4 personas", "Ocupada", "$42.500", true));
            _tables.Add(new TableInfo("Mesa 3", "Principal", "4 personas", "Ocupada", "$64.200", true));
            _tables.Add(new TableInfo("Mesa 4", "Principal", "6 personas", "Libre", "$0", true));
            _tables.Add(new TableInfo("Mesa 5", "Principal", "2 personas", "Cuenta pedida", "$87.900", true));
            _tables.Add(new TableInfo("Mesa 6", "Principal", "4 personas", "Por limpiar", "$51.000", true));
            _tables.Add(new TableInfo("Mesa 7", "Terraza", "4 personas", "Reservada", "$0", false));
            _tables.Add(new TableInfo("Mesa 8", "Terraza", "4 personas", "Libre", "$0", true));
            _tables.Add(new TableInfo("Barra 1", "Barra", "2 personas", "Ocupada", "$18.500", true));
            _tables.Add(new TableInfo("VIP 1", "VIP", "8 personas", "Reservada", "$0", false));
            SaveTables();
        }

        private void SaveTables()
        {
            try
            {
                var dir = Path.GetDirectoryName(StorePath);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                var lines = _tables.Select(t => string.Join("|", new[] { t.Name, t.Sector, t.Capacity, t.Status, t.Total, t.CanOpen ? "1" : "0" }));
                File.WriteAllLines(StorePath, lines);
            }
            catch { }
        }

        private void ApplyFilter()
        {
            tablesPanel.SuspendLayout();
            tablesPanel.Controls.Clear();
            string sector = sectorBox.SelectedItem?.ToString() ?? "Todos los salones";

            foreach (var t in _tables)
            {
                if (sector != "Todos los salones" && t.Sector != sector) continue;
                tablesPanel.Controls.Add(CreateTableCard(t));
            }
            tablesPanel.ResumeLayout();
        }

        private Control CreateTableCard(TableInfo t)
        {
            var pnl = new Panel { Width = 220, Height = 150, Margin = new Padding(0, 0, 15, 15), BackColor = Color.FromArgb(29, 32, 34), Cursor = Cursors.Hand };
            pnl.Paint += (s, e) => { ControlPaint.DrawBorder(e.Graphics, pnl.ClientRectangle, t.StatusColor, ButtonBorderStyle.Solid); };
            
            var lblNum = new Label { Text = t.Number, Font = new Font("Segoe UI", 24, FontStyle.Bold), Location = new Point(10, 10), AutoSize = true, ForeColor = Color.White };
            var lblStat = new Label { Text = t.Status, Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = t.StatusColor, Location = new Point(120, 20), AutoSize = true };
            var lblCap = new Label { Text = t.Capacity, ForeColor = Color.LightGray, Location = new Point(15, 55), AutoSize = true };
            var lblTot = new Label { Text = t.Total, ForeColor = Color.FromArgb(255, 107, 53), Font = new Font("Segoe UI", 12, FontStyle.Bold), Location = new Point(15, 75), AutoSize = true };

            var btnOpen = new Button { Text = "POS", Size = new Size(50, 30), Location = new Point(15, 110), BackColor = Color.FromArgb(255, 107, 53), ForeColor = Color.Black, FlatStyle = FlatStyle.Flat, Enabled = t.CanOpen };
            var btnEdit = new Button { Text = "✎", Size = new Size(40, 30), Location = new Point(75, 110), BackColor = Color.FromArgb(40, 42, 44), FlatStyle = FlatStyle.Flat };
            var btnDel = new Button { Text = "X", Size = new Size(40, 30), Location = new Point(125, 110), BackColor = Color.DarkRed, FlatStyle = FlatStyle.Flat };
            
            btnOpen.Click += (s, e) => { SelectTable(t); MesaParaPos?.Invoke(t.Name); };
            btnEdit.Click += (s, e) => EditTable(t);
            btnDel.Click += (s, e) => DeleteTable(t);
            pnl.Click += (s, e) => SelectTable(t);

            pnl.Controls.Add(lblNum);
            pnl.Controls.Add(lblStat);
            pnl.Controls.Add(lblCap);
            pnl.Controls.Add(lblTot);
            pnl.Controls.Add(btnOpen);
            pnl.Controls.Add(btnEdit);
            pnl.Controls.Add(btnDel);

            return pnl;
        }

        private void SelectTable(TableInfo table)
        {
            _selected = table;
            detailName.Text = table.Name;
            detailStatus.Text = table.Status;
            detailStatus.ForeColor = table.StatusColor;
            detailInfo.Text = $"{table.Sector} · {table.Capacity}";
            
            var ticket = PosForm.GetTicketFor(table.Name);
            if (ticket.Count == 0)
                detailItems.Text = table.Status == "Libre" || table.Status == "Reservada" ? "Sin pedido activo." : "Pedido activo de demostración.";
            else
                detailItems.Text = string.Join("\n", ticket.Select(l => $"{l.Name}  {l.TotalText}"));
            
            detailTotal.Text = table.Total;
            btnOpenPos.Enabled = table.CanOpen;
        }

        private void NewTable_Click(object sender, EventArgs e)
        {
            var dialog = new TableDialogForm(null);
            if (dialog.ShowDialog(this) == DialogResult.OK && dialog.Result != null)
            {
                if (_tables.Any(t => t.Name.Equals(dialog.Result.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Ya existe una mesa con ese nombre.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _tables.Add(dialog.Result);
                SaveTables();
                ApplyFilter();
            }
        }

        private void EditTable(TableInfo table)
        {
            var dialog = new TableDialogForm(table);
            if (dialog.ShowDialog(this) == DialogResult.OK && dialog.Result != null)
            {
                if (_tables.Any(t => t != table && t.Name.Equals(dialog.Result.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Ya existe otra mesa con ese nombre.", "RestoOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int index = _tables.IndexOf(table);
                if (index >= 0)
                {
                    _tables[index] = dialog.Result;
                    if (_selected == table) SelectTable(dialog.Result);
                    SaveTables();
                    ApplyFilter();
                }
            }
        }

        private void DeleteTable(TableInfo table)
        {
            if (MessageBox.Show($"¿Eliminar {table.Name}?", "RestoOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _tables.Remove(table);
                if (_selected == table) _selected = null;
                SaveTables();
                ApplyFilter();
            }
        }

        private void OpenSelectedPos_Click(object sender, EventArgs e)
        {
            if (_selected != null && _selected.CanOpen)
            {
                MesaParaPos?.Invoke(_selected.Name);
            }
        }
    }

    public class TableInfo
    {
        public string Name { get; set; }
        public string Number => Name.Split(' ').Length > 1 ? Name.Split(' ')[1] : Name;
        public string Sector { get; set; }
        public string Capacity { get; set; }
        public string Status { get; set; }
        public string MockTotal { get; set; }
        public bool CanOpen { get; set; }

        public string Total
        {
            get
            {
                var real = PosForm.GetTicketFor(Name).Sum(l => l.LineTotal);
                if (real > 0) return real.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("es-CO"));
                return MockTotal ?? "$0";
            }
        }

        public Color StatusColor
        {
            get
            {
                if (Status == "Libre") return Color.MediumSeaGreen;
                if (Status == "Ocupada") return Color.CornflowerBlue;
                if (Status == "Cuenta pedida") return Color.FromArgb(255, 107, 53);
                if (Status == "Por limpiar") return Color.IndianRed;
                return Color.Gray;
            }
        }

        public TableInfo(string name, string sector, string capacity, string status, string total, bool canOpen)
        {
            Name = name; Sector = sector; Capacity = capacity; Status = status; MockTotal = total; CanOpen = canOpen;
        }
    }
}


