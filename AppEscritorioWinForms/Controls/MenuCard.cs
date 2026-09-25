using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Models;
using app_escritorio.Utils;

namespace app_escritorio.Controls
{
    public class MenuCard : UserControl
    {
        private readonly PictureBox imageBox;
        private readonly Label nameLabel;
        private readonly Label descriptionLabel;
        private readonly Label priceLabel;
        private readonly Label stockLabel;
        private readonly Label categoryLabel;
        private readonly Button editButton;
        private readonly Button deleteButton;
        private readonly ToolTip toolTip;
        private Point dragStart;
        private bool isDragging;

        public event EventHandler EditRequested;
        public event EventHandler DeleteRequested;

        public Models.MenuItem Item { get; private set; }

        public MenuCard()
        {
            Width = 250;
            Height = 250;
            Margin = new Padding(6);
            Padding = new Padding(10);
            BackColor = Theme.BackgroundMedium;
            ForeColor = Theme.TextPrimary;
            AllowDrop = true;

            imageBox = new PictureBox
            {
                Dock = DockStyle.Top,
                Height = 64,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Theme.BackgroundLight
            };

            nameLabel = new Label
            {
                Dock = DockStyle.Top,
                Height = 28,
                AutoEllipsis = true,
                Font = Theme.FontPrimaryBold,
                ForeColor = Theme.TextPrimary
            };

            descriptionLabel = new Label
            {
                Dock = DockStyle.Top,
                Height = 32,
                AutoEllipsis = true,
                Font = Theme.FontSmall,
                ForeColor = Theme.TextSecondary
            };

            priceLabel = new Label
            {
                Dock = DockStyle.Top,
                Height = 26,
                Font = Theme.FontPrimaryBold,
                ForeColor = Theme.AccentPrimary
            };

            stockLabel = new Label
            {
                Dock = DockStyle.Top,
                Height = 20,
                Font = Theme.FontSmall,
                ForeColor = Theme.TextMuted
            };

            categoryLabel = new Label
            {
                Dock = DockStyle.Top,
                Height = 20,
                AutoEllipsis = true,
                Font = Theme.FontSmall,
                ForeColor = Theme.TextMuted
            };

            editButton = new Button
            {
                Width = 105,
                Height = 32,
                Text = "Editar",
                FlatStyle = FlatStyle.Flat,
                BackColor = Theme.AccentSecondary,
                ForeColor = Theme.TertiaryText,
                Margin = new Padding(3)
            };
            editButton.FlatAppearance.BorderSize = 0;
            editButton.Click += (sender, e) => RaiseEditRequested();
            deleteButton = new Button { Width = 105, Height = 32, Text = "Eliminar", FlatStyle = FlatStyle.Flat, BackColor = Theme.DangerBackground, ForeColor = Theme.StatusUnavailable, Margin = new Padding(3) };
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.Click += (sender, e) => DeleteRequested?.Invoke(this, EventArgs.Empty);
            var cardActions = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 38, WrapContents = false, FlowDirection = FlowDirection.LeftToRight, Padding = new Padding(5, 3, 5, 3), BackColor = Theme.BackgroundLight };
            cardActions.Controls.Add(editButton);
            cardActions.Controls.Add(deleteButton);

            toolTip = new ToolTip();
            toolTip.SetToolTip(editButton, "Editar este plato");

            Controls.Add(categoryLabel);
            Controls.Add(stockLabel);
            Controls.Add(priceLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(nameLabel);
            Controls.Add(cardActions);
            Controls.Add(imageBox);

            imageBox.BringToFront();
            DoubleClick += (sender, e) => RaiseEditRequested();
            MouseDown += MenuCard_MouseDown;
            MouseMove += MenuCard_MouseMove;
            MouseUp += MenuCard_MouseUp;
        }

        /// <summary>
        /// Ancho fluido: la tarjeta se estira al ancho de columna calculado y
        /// reparte el espacio entre Editar/Eliminar para que nunca se corten.
        /// </summary>
        public void SetCardWidth(int width)
        {
            if (width < 180) width = 180;
            if (width > 340) width = 340;
            Width = width;
            int buttons = width - 20 - 10 - 6;
            int bw = buttons / 2;
            if (bw < 70) bw = 70;
            editButton.Width = bw;
            deleteButton.Width = bw;
        }

        public void SetData(Models.MenuItem item)
        {
            Item = item;
            if (item == null)
            {
                imageBox.Image = null;
                nameLabel.Text = "(Sin datos)";
                descriptionLabel.Text = string.Empty;
                priceLabel.Text = string.Empty;
                stockLabel.Text = string.Empty;
                categoryLabel.Text = string.Empty;
                return;
            }

            nameLabel.Text = item.Name ?? "(Sin nombre)";
            descriptionLabel.Text = item.Description ?? string.Empty;
            priceLabel.Text = string.Format("Salón: {0:C}    Delivery: {1:C}", item.PriceSalon, item.PriceDelivery);
            stockLabel.Text = item.Stock < 0 ? "Stock: ilimitado" : string.Format("Stock: {0}", item.Stock);
            stockLabel.ForeColor = item.Stock == 0 ? Theme.StatusUnavailable : Theme.TextMuted;
            var tags = new List<string>();
            if (!item.IsAvailable) tags.Add("NO DISPONIBLE");
            if (item.IsSuggestion) tags.Add("★ SUGERENCIA");
            if (item.Tags != null) tags.AddRange(item.Tags.Where(t => !string.IsNullOrWhiteSpace(t)));
            categoryLabel.Text = tags.Count == 0 ? (item.IsAvailable ? "Disponible" : "No disponible") : string.Join(" · ", tags.ToArray());
            categoryLabel.ForeColor = item.IsAvailable ? Theme.StatusAvailable : Theme.StatusUnavailable;
            LoadImage(item.ImageUrl);
        }

        private void LoadImage(string imagePath)
        {
            imageBox.Image = null;
            if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath)) return;

            try
            {
                using (var source = Image.FromFile(imagePath))
                {
                    imageBox.Image = new Bitmap(source);
                }
            }
            catch
            {
                imageBox.Image = null;
            }
        }

        private void RaiseEditRequested()
        {
            if (Item != null)
            {
                EditRequested?.Invoke(this, EventArgs.Empty);
            }
        }

        private void MenuCard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragStart = e.Location;
                isDragging = true;
            }
        }

        private void MenuCard_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDragging) return;
            if (Math.Abs(e.X - dragStart.X) < SystemInformation.DragSize.Width && Math.Abs(e.Y - dragStart.Y) < SystemInformation.DragSize.Height) return;

            isDragging = false;
            DoDragDrop(new DataObject(nameof(MenuCard), this), DragDropEffects.Move);
        }

        private void MenuCard_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
