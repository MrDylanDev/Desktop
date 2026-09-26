using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Data;
using app_escritorio.Models;
using MenuItem = app_escritorio.Models.MenuItem;
using app_escritorio.Utils;

namespace app_escritorio.Forms
{
    public partial class OrderForm : Form
    {
        private readonly MenuData menuData;
        private readonly List<OrderLine> lines = new List<OrderLine>();
        private MenuItem selectedItem;

        public OrderForm(MenuData data)
        {
            menuData = data ?? new MenuData();
            InitializeComponent();
            RefreshProducts(string.Empty);
            UpdateOrderDisplay();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            RefreshProducts(textBox?.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddSelectedItem();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedLine();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            ConfirmOrder();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void RefreshProducts(string query)
        {
            if (productsPanel == null) return;
            productsPanel.SuspendLayout();
            productsPanel.Controls.Clear();
            string value = (query ?? string.Empty).Trim().ToLowerInvariant();
            foreach (var item in menuData.Items.Where(i => i != null && (string.IsNullOrEmpty(value) || (i.Name ?? string.Empty).ToLowerInvariant().Contains(value))))
            {
                productsPanel.Controls.Add(CreateProductCard(item));
            }
            productsPanel.ResumeLayout();
        }

        private Control CreateProductCard(MenuItem item)
        {
            var card = new Panel
            {
                Width = 235,
                Height = 245,
                Margin = new Padding(6),
                BackColor = Theme.BackgroundMedium,
                Tag = item,
                Cursor = Cursors.Hand
            };
            var picture = new PictureBox
            {
                Dock = DockStyle.Top,
                Height = 115,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Theme.BackgroundLight
            };
            LoadImage(picture, item.ImageUrl);
            var name = new Label
            {
                Text = item.Name ?? "(Sin nombre)",
                Dock = DockStyle.Top,
                Height = 30,
                AutoEllipsis = true,
                Font = Theme.FontPrimaryBold,
                ForeColor = Theme.TextPrimary
            };
            var description = new Label
            {
                Text = item.Description ?? string.Empty,
                Dock = DockStyle.Top,
                Height = 42,
                AutoEllipsis = true,
                Font = Theme.FontSmall,
                ForeColor = Theme.TextSecondary
            };
            var price = new Label
            {
                Text = string.Format("Precio: {0:C}", item.PriceSalon),
                Dock = DockStyle.Bottom,
                Height = 28,
                Font = Theme.FontPrimaryBold,
                ForeColor = Theme.AccentPrimary
            };
            card.Controls.Add(description);
            card.Controls.Add(name);
            card.Controls.Add(price);
            card.Controls.Add(picture);
            card.Click += (sender, e) => SelectProduct(item);
            picture.Click += (sender, e) => SelectProduct(item);
            name.Click += (sender, e) => SelectProduct(item);
            description.Click += (sender, e) => SelectProduct(item);
            price.Click += (sender, e) => SelectProduct(item);
            return card;
        }

        private static void LoadImage(PictureBox picture, string imageUrl)
        {
            try
            {
                string path = imageUrl;
                if (string.IsNullOrEmpty(path) || !File.Exists(path))
                {
                    path = ImageFetcher.DownloadImage(imageUrl);
                }
                if (File.Exists(path))
                {
                    using (var source = Image.FromFile(path))
                    {
                        picture.Image = new Bitmap(source);
                    }
                }
            }
            catch
            {
                picture.Image = null;
            }
        }

        private void SelectProduct(MenuItem item)
        {
            selectedItem = item;
            foreach (Control control in productsPanel.Controls)
            {
                control.BackColor = ReferenceEquals(control.Tag, item) ? Theme.AccentPrimary : Theme.BackgroundMedium;
            }
        }

        private void AddSelectedItem()
        {
            if (selectedItem == null)
            {
                MessageBox.Show("Selecciona un producto primero.", "Crear pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int quantity = (int)quantityInput.Value;
            var line = lines.FirstOrDefault(l => l.Item.Id == selectedItem.Id);
            if (line == null)
            {
                lines.Add(new OrderLine { Item = selectedItem, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
            UpdateOrderDisplay();
        }

        private void RemoveSelectedLine()
        {
            if (orderLines.SelectedIndices.Count == 0) return;
            lines.RemoveAt(orderLines.SelectedIndices[0]);
            UpdateOrderDisplay();
        }

        private void OrderLines_DoubleClick(object sender, EventArgs e)
        {
            RemoveSelectedLine();
        }

        private void UpdateOrderDisplay()
        {
            orderLines.BeginUpdate();
            orderLines.Items.Clear();
            foreach (var line in lines)
            {
                var row = new ListViewItem(line.Item.Name ?? "(Sin nombre)");
                row.SubItems.Add(line.Quantity.ToString());
                row.SubItems.Add(line.Item.PriceSalon.ToString("C"));
                row.SubItems.Add((line.Item.PriceSalon * line.Quantity).ToString("C"));
                orderLines.Items.Add(row);
            }
            orderLines.EndUpdate();
            totalLabel.Text = string.Format("Total: {0:C}", lines.Sum(l => l.Item.PriceSalon * l.Quantity));
        }

        private void ConfirmOrder()
        {
            if (lines.Count == 0)
            {
                MessageBox.Show("Agrega al menos un producto al pedido.", "Crear pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var history = OrderHistoryStore.Load("data/orders.xml");
            history.Add(new OrderRecord
            {
                CustomerName = string.IsNullOrWhiteSpace(customerInput.Text) ? "Cliente" : customerInput.Text.Trim(),
                TableNumber = tableInput.Text.Trim(),
                Status = statusInput.SelectedItem == null ? "Pendiente" : statusInput.SelectedItem.ToString(),
                Total = lines.Sum(l => l.Item.PriceSalon * l.Quantity),
                Lines = lines.Select(l => new OrderRecordLine { Name = l.Item.Name, Quantity = l.Quantity, UnitPrice = l.Item.PriceSalon }).ToList()
            });
            OrderHistoryStore.Save("data/orders.xml", history);
            DialogResult = DialogResult.OK;
            Close();
        }

        private class OrderLine
        {
            public MenuItem Item { get; set; }
            public int Quantity { get; set; }
        }
    }
}
