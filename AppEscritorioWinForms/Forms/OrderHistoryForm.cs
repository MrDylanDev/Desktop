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
    public partial class OrderHistoryForm : Form
    {
        private readonly string filePath;
        private List<OrderRecord> records;

        public OrderHistoryForm(string historyFile)
        {
            filePath = historyFile;
            InitializeComponent();
            LoadRecords();
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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Footer_Resize(object sender, EventArgs e)
        {
            this.close.Left = this.footer.ClientSize.Width - 125;
            this.refresh.Left = this.footer.ClientSize.Width - 245;
        }
    }
}
