using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace app_escritorio.Forms
{
    public partial class KdsForm : Form
    {
        public string Role { get; set; }
        public enum KdsStatus { Nuevo, Preparacion, Listo }

        public class KdsItem
        {
            public string Line { get; set; }
            public string Note { get; set; }
            public KdsItem(string line, string note) { Line = line; Note = note ?? string.Empty; }
        }

        public class KdsOrder
        {
            public string Mesa { get; set; }
            public string Station { get; set; }
            public DateTime CreatedAt { get; set; }
            public List<KdsItem> Items { get; set; }
            public KdsStatus Status { get; set; } = KdsStatus.Nuevo;

            public string CreatedText => $"Pedido {CreatedAt:HH:mm}";
            
            public string Elapsed
            {
                get
                {
                    var m = (int)(DateTime.Now - CreatedAt).TotalMinutes;
                    return m < 1 ? "ahora" : $"hace {m}m";
                }
            }

            public Color ElapsedColor
            {
                get
                {
                    var m = (DateTime.Now - CreatedAt).TotalMinutes;
                    if (m > 15) return Color.IndianRed;
                    if (m > 10) return Color.FromArgb(255, 107, 53); // Secondary
                    return Color.MediumSeaGreen;
                }
            }

            public KdsOrder(string mesa, string station, DateTime created, KdsItem[] items)
            {
                Mesa = mesa; Station = station; CreatedAt = created;
                Items = new List<KdsItem>(items);
            }
        }

        private readonly List<KdsOrder> _orders = new List<KdsOrder>();
        private System.Windows.Forms.Timer _timer;

        public KdsForm()
        {
            InitializeComponent();
            LoadMock();
            
            stationBox.Items.Add("Todas las estaciones");
            stationBox.Items.Add("Parrilla");
            stationBox.Items.Add("Fría");
            stationBox.Items.Add("Barra");
            stationBox.SelectedIndex = 0;
            stationBox.SelectedIndexChanged += (s, e) => RefreshAll();

            _timer = new System.Windows.Forms.Timer { Interval = 1000 };
            _timer.Tick += (s, e) => { lblClock.Text = DateTime.Now.ToString("HH:mm:ss"); RefreshTime(); };
            _timer.Start();

            RefreshAll();
        }

        private void Header_Resize(object sender, EventArgs e)
        {
            lblClock.Left = header.Width - lblClock.Width - 20;
        }

        private void HeaderNuevo_Resize(object sender, EventArgs e)
        {
            lblNuevoCount.Left = headerNuevo.Width - lblNuevoCount.Width - 10;
        }

        private void HeaderPrep_Resize(object sender, EventArgs e)
        {
            lblPrepCount.Left = headerPrep.Width - lblPrepCount.Width - 10;
        }

        private void HeaderListo_Resize(object sender, EventArgs e)
        {
            lblListoCount.Left = headerListo.Width - lblListoCount.Width - 10;
        }

        private void List_Resize(object sender, EventArgs e)
        {
            if (sender is FlowLayoutPanel list)
            {
                foreach (Control c in list.Controls) 
                    c.Width = list.ClientSize.Width - 10;
            }
        }

        private void LoadMock()
        {
            _orders.Add(new KdsOrder("Mesa 2", "Parrilla", DateTime.Now.AddMinutes(-4), new[] { new KdsItem("x1 Bife de Chorizo 400g", "término medio"), new KdsItem("x1 Cerveza Tirada IPA", "") }));
            _orders.Add(new KdsOrder("Mesa 3", "Parrilla", DateTime.Now.AddMinutes(-11), new[] { new KdsItem("x2 Hamburguesa Doble Queso", "sin cebolla"), new KdsItem("x1 Limonada Menta", "") }));
            _orders.Add(new KdsOrder("Barra 1", "Barra", DateTime.Now.AddMinutes(-2), new[] { new KdsItem("x2 Cerveza Tirada IPA", ""), new KdsItem("x1 Tiramisú Casero", "extra salsa") }));
            _orders.Add(new KdsOrder("Mesa 5", "Fría", DateTime.Now.AddMinutes(-7), new[] { new KdsItem("x1 Ensalada César con Pollo", "sin crutones"), new KdsItem("x1 Ravioles 4 Quesos", "") }));
            
            _orders[1].Status = KdsStatus.Preparacion;
            _orders[3].Status = KdsStatus.Listo;
        }

        private void RefreshAll()
        {
            listNuevo.SuspendLayout();
            listPrep.SuspendLayout();
            listListo.SuspendLayout();
            
            listNuevo.Controls.Clear();
            listPrep.Controls.Clear();
            listListo.Controls.Clear();

            string station = stationBox.SelectedItem?.ToString() ?? "Todas las estaciones";
            var filtered = _orders.Where(o => station == "Todas las estaciones" || o.Station == station).ToList();

            foreach (var o in filtered)
            {
                var card = CreateOrderCard(o);
                if (o.Status == KdsStatus.Nuevo) 
                { 
                    listNuevo.Controls.Add(card); 
                    card.Width = listNuevo.ClientSize.Width - 10; 
                }
                else if (o.Status == KdsStatus.Preparacion) 
                { 
                    listPrep.Controls.Add(card); 
                    card.Width = listPrep.ClientSize.Width - 10; 
                }
                else 
                { 
                    listListo.Controls.Add(card); 
                    card.Width = listListo.ClientSize.Width - 10; 
                }
            }

            lblNuevoCount.Text = filtered.Count(o => o.Status == KdsStatus.Nuevo).ToString();
            lblPrepCount.Text = filtered.Count(o => o.Status == KdsStatus.Preparacion).ToString();
            lblListoCount.Text = filtered.Count(o => o.Status == KdsStatus.Listo).ToString();
            lblPendingCount.Text = $"{filtered.Count(o => o.Status != KdsStatus.Listo)} pendientes";

            listNuevo.ResumeLayout();
            listPrep.ResumeLayout();
            listListo.ResumeLayout();
        }

        private void RefreshTime()
        {
            Action<FlowLayoutPanel> updateTime = (list) =>
            {
                foreach (Control card in list.Controls)
                {
                    if (card.Tag is KdsOrder o)
                    {
                        var lblTime = card.Controls.Find("lblTime", true).FirstOrDefault() as Label;
                        if (lblTime != null)
                        {
                            lblTime.Text = o.Elapsed;
                            lblTime.ForeColor = o.ElapsedColor;
                        }
                    }
                }
            };
            updateTime(listNuevo);
            updateTime(listPrep);
            updateTime(listListo);
        }

        private Control CreateOrderCard(KdsOrder o)
        {
            var pnl = new Panel { Margin = new Padding(0, 0, 0, 10), BackColor = Color.FromArgb(40, 42, 44), Tag = o };
            
            int y = 10;
            var lblMesa = new Label { Text = o.Mesa, Font = new Font("Segoe UI", 14, FontStyle.Bold), AutoSize = true, Location = new Point(10, y) };
            var lblTime = new Label { Name = "lblTime", Text = o.Elapsed, Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = o.ElapsedColor, AutoSize = true, Location = new Point(pnl.Width - 80, y), Anchor = AnchorStyles.Top | AnchorStyles.Right };
            y += 25;
            var lblCreated = new Label { Text = o.CreatedText, ForeColor = Color.LightGray, AutoSize = true, Location = new Point(10, y) };
            y += 20;

            foreach (var item in o.Items)
            {
                var lblLine = new Label { Text = item.Line, Font = new Font("Segoe UI", 12), AutoSize = true, Location = new Point(10, y) };
                y += 20;
                if (!string.IsNullOrWhiteSpace(item.Note))
                {
                    var lblNote = new Label { Text = item.Note, Font = new Font("Segoe UI", 10, FontStyle.Italic), ForeColor = Color.FromArgb(255, 107, 53), AutoSize = true, Location = new Point(20, y) };
                    y += 20;
                    pnl.Controls.Add(lblNote);
                }
                pnl.Controls.Add(lblLine);
            }
            y += 10;

            var actionPanel = new Panel { Location = new Point(10, y), Height = 40, Width = pnl.Width - 20, Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top };
            
            if (o.Status == KdsStatus.Nuevo)
            {
                var btnPrep = new Button { Text = "▶ Preparar", Dock = DockStyle.Fill, BackColor = Color.FromArgb(255, 107, 53), ForeColor = Color.Black, Font = new Font("Segoe UI", 10, FontStyle.Bold), FlatStyle = FlatStyle.Flat };
                btnPrep.Click += (s, e) => { o.Status = KdsStatus.Preparacion; RefreshAll(); };
                actionPanel.Controls.Add(btnPrep);
            }
            else if (o.Status == KdsStatus.Preparacion)
            {
                var btnNew = new Button { Text = "◀ Nuevo", Dock = DockStyle.Left, Width = actionPanel.Width / 2 - 5, BackColor = Color.Gray, FlatStyle = FlatStyle.Flat };
                var btnListo = new Button { Text = "✓ Listo", Dock = DockStyle.Right, Width = actionPanel.Width / 2 - 5, BackColor = Color.MediumSeaGreen, ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), FlatStyle = FlatStyle.Flat };
                btnNew.Click += (s, e) => { o.Status = KdsStatus.Nuevo; RefreshAll(); };
                btnListo.Click += (s, e) => { o.Status = KdsStatus.Listo; RefreshAll(); };
                actionPanel.Controls.Add(btnNew);
                actionPanel.Controls.Add(btnListo);
                actionPanel.Resize += (s, e) => { btnNew.Width = actionPanel.Width / 2 - 5; btnListo.Width = actionPanel.Width / 2 - 5; };
            }
            else
            {
                var btnPrep = new Button { Text = "↺ Prep.", Dock = DockStyle.Left, Width = actionPanel.Width / 2 - 5, BackColor = Color.Gray, FlatStyle = FlatStyle.Flat };
                var btnDone = new Button { Text = "✓ Entregado", Dock = DockStyle.Right, Width = actionPanel.Width / 2 - 5, BackColor = Color.IndianRed, ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), FlatStyle = FlatStyle.Flat };
                btnPrep.Click += (s, e) => { o.Status = KdsStatus.Preparacion; RefreshAll(); };
                btnDone.Click += (s, e) => { _orders.Remove(o); RefreshAll(); };
                actionPanel.Controls.Add(btnPrep);
                actionPanel.Controls.Add(btnDone);
                actionPanel.Resize += (s, e) => { btnPrep.Width = actionPanel.Width / 2 - 5; btnDone.Width = actionPanel.Width / 2 - 5; };
            }
            y += 45;

            pnl.Height = y;
            pnl.Controls.Add(lblMesa);
            pnl.Controls.Add(lblTime);
            pnl.Controls.Add(lblCreated);
            pnl.Controls.Add(actionPanel);
            
            pnl.Resize += (s, e) => {
                lblTime.Left = pnl.Width - lblTime.Width - 10;
                actionPanel.Width = pnl.Width - 20;
            };

            return pnl;
        }
    }
}


