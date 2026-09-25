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
    public class OrderForm : Form
    {
        private readonly MenuData menuData;
        private readonly FlowLayoutPanel productsPanel;
        private readonly ListView orderLines;
        private readonly NumericUpDown quantityInput;
        private readonly Label totalLabel;
        private readonly TextBox customerInput;
        private readonly TextBox tableInput;
        private readonly ComboBox statusInput;
        private readonly List<OrderLine> lines = new List<OrderLine>();
        private MenuItem selectedItem;

        public OrderForm(MenuData data)
        {
            menuData = data ?? new MenuData();
            Text = "Crear pedido";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(1400, 850);
            MinimumSize = new Size(1100, 700);
            BackColor = Theme.BackgroundDark;
            ForeColor = Theme.TextPrimary;
            ShowInTaskbar = false;

            var header = new Panel { Dock = DockStyle.Top, Height = 80, BackColor = Theme.BackgroundMedium, Padding = new Padding(12) };
            var title = new Label
            {
                Text = "Crear pedido",
                Dock = DockStyle.Left,
                Width = 220,
                Height = 44,
                Font = Theme.FontTitle,
                ForeColor = Theme.TextPrimary
            };
            var search = new TextBox
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(8),
                Font = Theme.FontSmall,
                BackColor = Theme.BackgroundDark,
                ForeColor = Theme.TextPrimary
            };
            customerInput = new TextBox { Width = 150, Height = 30, BackColor = Theme.BackgroundDark, ForeColor = Theme.TextPrimary, Font = Theme.FontSmall, Margin = new Padding(8, 8, 4, 4) };
            tableInput = new TextBox { Width = 100, Height = 30, BackColor = Theme.BackgroundDark, ForeColor = Theme.TextPrimary, Font = Theme.FontSmall, Margin = new Padding(4, 8, 4, 4) };
            statusInput = new ComboBox { Width = 125, Height = 30, DropDownStyle = ComboBoxStyle.DropDownList, Text = "Pendiente", BackColor = Theme.BackgroundDark, ForeColor = Theme.TextPrimary, Font = Theme.FontSmall, Margin = new Padding(4, 8, 8, 4) };
            statusInput.Items.AddRange(new object[] { "Pendiente", "En curso", "Listo", "Entregado" });
            statusInput.SelectedIndex = 0;
            search.TextChanged += (sender, e) => RefreshProducts(search.Text);
            header.Controls.Add(search);
            header.Controls.Add(statusInput);
            header.Controls.Add(tableInput);
            header.Controls.Add(customerInput);
            header.Controls.Add(title);

            var leftPanel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10), BackColor = Theme.BackgroundDark };
            productsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                BackColor = Theme.BackgroundDark
            };
            leftPanel.Controls.Add(productsPanel);

            var rightPanel = new Panel { Dock = DockStyle.Right, Width = 470, Padding = new Padding(10), BackColor = Theme.BackgroundMedium };
            orderLines = new ListView
            {
                Dock = DockStyle.Fill,
                Height = 440,
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                BackColor = Theme.BackgroundDark,
                ForeColor = Theme.TextPrimary
            };
            orderLines.Columns.Add("Producto", 190);
            orderLines.Columns.Add("Cant.", 55);
            orderLines.Columns.Add("Precio", 85);
            orderLines.Columns.Add("Total", 90);
            orderLines.DoubleClick += OrderLines_DoubleClick;

            quantityInput = new NumericUpDown
            {
                Minimum = 1,
                Maximum = 999,
                Value = 1,
                Width = 70,
                Font = Theme.FontSmall,
                BackColor = Theme.BackgroundDark,
                ForeColor = Theme.TextPrimary
            };
            var quantityLabel = new Label { Text = "Cantidad", Width = 75, TextAlign = ContentAlignment.MiddleLeft, ForeColor = Theme.TextSecondary };
            var addButton = CreateButton("Agregar", Theme.AccentSecondary, 105);
            addButton.Click += (sender, e) => AddSelectedItem();
            var removeButton = CreateButton("Quitar", Theme.BorderLight, 105);
            removeButton.Click += (sender, e) => RemoveSelectedLine();
            var confirmButton = CreateButton("Confirmar pedido", Theme.AccentPrimary, 220);
            confirmButton.Click += (sender, e) => ConfirmOrder();
            var cancelButton = CreateButton("Cancelar", Theme.BorderLight, 120);
            cancelButton.Click += (sender, e) => { DialogResult = DialogResult.Cancel; Close(); };

            var actions = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 54, WrapContents = false, Padding = new Padding(4, 7, 4, 4), BackColor = Theme.BackgroundLight };
            actions.Controls.Add(quantityLabel);
            actions.Controls.Add(quantityInput);
            actions.Controls.Add(addButton);
            actions.Controls.Add(removeButton);

            var totalPanel = new Panel { Dock = DockStyle.Bottom, Height = 62, BackColor = Theme.BackgroundLight, Padding = new Padding(10) };
            totalLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = "Total: $0.00",
                TextAlign = ContentAlignment.MiddleRight,
                Font = Theme.FontLarge,
                ForeColor = Theme.TextPrimary
            };
            totalPanel.Controls.Add(totalLabel);

            var bottomActions = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 62, FlowDirection = FlowDirection.RightToLeft, WrapContents = false, Padding = new Padding(8, 10, 8, 8), BackColor = Theme.BackgroundMedium };
            bottomActions.Controls.Add(confirmButton);
            bottomActions.Controls.Add(cancelButton);

            var orderLayout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 4, BackColor = Theme.BackgroundMedium, Padding = new Padding(0, 0, 0, 0) };
            orderLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            orderLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            orderLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            orderLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            orderLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            orderLayout.Controls.Add(orderLines, 0, 0);
            orderLayout.Controls.Add(totalPanel, 0, 1);
            orderLayout.Controls.Add(actions, 0, 2);
            orderLayout.Controls.Add(bottomActions, 0, 3);

            rightPanel.Controls.Add(orderLayout);

            Controls.Add(leftPanel);
            Controls.Add(rightPanel);
            Controls.Add(header);

            RefreshProducts(string.Empty);
            UpdateOrderDisplay();
        }

        private static Button CreateButton(string text, Color color, int width)
        {
            return new Button
            {
                Text = text,
                Width = width,
                Height = 42,
                FlatStyle = FlatStyle.Flat,
                BackColor = color,
                ForeColor = Color.White,
                Margin = new Padding(4)
            };
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
