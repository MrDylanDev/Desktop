using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Data;
using app_escritorio.Models;
using app_escritorio.Utils;

namespace app_escritorio.Forms
{
    public class OrderHistoryForm : Form
    {
        private readonly string filePath;
        private List<OrderRecord> records;
        private readonly ListView list;
        private readonly Label summary;

        public OrderHistoryForm(string historyFile)
        {
            filePath = historyFile;
            Text = "Historial de pedidos";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(1050, 650);
            MinimumSize = new Size(800, 500);
            BackColor = Theme.BackgroundDark;
            ForeColor = Theme.TextPrimary;
            ShowInTaskbar = false;

            var header = new Panel { Dock = DockStyle.Top, Height = 68, BackColor = Theme.BackgroundMedium, Padding = new Padding(14) };
            summary = new Label { Dock = DockStyle.Fill, Text = "", Font = Theme.FontTitle, ForeColor = Theme.TextPrimary, TextAlign = ContentAlignment.MiddleLeft };
            header.Controls.Add(summary);

            list = new ListView { Dock = DockStyle.Fill, View = View.Details, FullRowSelect = true, GridLines = true, BackColor = Theme.BackgroundDark, ForeColor = Theme.TextPrimary, BorderStyle = BorderStyle.FixedSingle };
            list.Columns.Add("Fecha", 145);
            list.Columns.Add("Cliente", 180);
            list.Columns.Add("Mesa", 70);
            list.Columns.Add("Estado", 110);
            list.Columns.Add("Total", 100);
            list.Columns.Add("Productos", 280);

            var footer = new Panel { Dock = DockStyle.Bottom, Height = 62, BackColor = Theme.BackgroundMedium, Padding = new Padding(10) };
            var refresh = CreateButton("Actualizar", Theme.BackgroundLight, 110);
            refresh.Click += (s, e) => LoadRecords();
            var close = CreateButton("Cerrar", Theme.AccentPrimary, 110);
            close.Click += (s, e) => Close();
            footer.Controls.Add(close);
            footer.Controls.Add(refresh);
            close.Location = new Point(footer.Width - 125, 13);
            refresh.Location = new Point(footer.Width - 245, 13);
            footer.Resize += (s, e) => { close.Left = footer.ClientSize.Width - 125; refresh.Left = footer.ClientSize.Width - 245; };

            Controls.Add(list);
            Controls.Add(footer);
            Controls.Add(header);
            LoadRecords();
        }

        private static Button CreateButton(string text, Color color, int width)
        {
            var button = new Button { Text = text, Width = width, Height = 38, BackColor = color, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = Theme.FontSmall };
            button.FlatAppearance.BorderSize = 0;
            return button;
        }

        private void LoadRecords()
        {
            records = OrderHistoryStore.Load(filePath).OrderByDescending(r => r.CreatedAt).ToList();
            summary.Text = string.Format("Pedidos: {0}    Ventas: {1:C}    Hoy: {2}", records.Count, records.Sum(r => r.Total), records.Count(r => r.CreatedAt.Date == DateTime.Today));
            list.BeginUpdate();
            list.Items.Clear();
            foreach (var record in records)
            {
                var row = new ListViewItem(record.CreatedAt.ToString("dd/MM/yyyy HH:mm"));
                row.SubItems.Add(record.CustomerName ?? "");
                row.SubItems.Add(record.TableNumber ?? "");
                row.SubItems.Add(record.Status ?? "Pendiente");
                row.SubItems.Add(record.Total.ToString("C"));
                row.SubItems.Add((record.Lines ?? new List<OrderRecordLine>()).Count + " productos");
                list.Items.Add(row);
            }
            list.EndUpdate();
        }
    }
}
