using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Models;
using app_escritorio.Utils;

namespace app_escritorio.Controls
{
    public class StatusBar : UserControl
    {
        private Label lblAvailable;
        private Label lblOutOfStock;
        private Label lblSuggestions;
        private List<app_escritorio.Models.MenuItem> items = new List<app_escritorio.Models.MenuItem>();

        public StatusBar()
        {
            this.Dock = DockStyle.Top;
            this.Height = 34;
            this.BackColor = Theme.BackgroundDark;
            this.ForeColor = Theme.TextPrimary;
            this.Padding = new Padding(10);

            // Disponibles
            lblAvailable = new Label
            {
                Text = "✓ 0 Disponibles",
                ForeColor = Theme.StatusAvailable,
                Font = Theme.FontSmall,
                Dock = DockStyle.Left,
                Width = 105,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(3)
            };

            // Agotados
            lblOutOfStock = new Label
            {
                Text = "✗ 0 Agotado hoy",
                ForeColor = Theme.StatusUnavailable,
                Font = Theme.FontSmall,
                Dock = DockStyle.Left,
                Width = 105,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(3)
            };

            // Sugerencias Chef
            lblSuggestions = new Label
            {
                Text = "★ 0 Sugerencias",
                ForeColor = Theme.AccentPrimary,
                Font = Theme.FontSmall,
                Dock = DockStyle.Left,
                Width = 150,
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(3)
            };

            this.Controls.Add(lblSuggestions);
            this.Controls.Add(lblOutOfStock);
            this.Controls.Add(lblAvailable);
        }

        public void SetItems(List<app_escritorio.Models.MenuItem> itemList)
        {
            items = itemList ?? new List<app_escritorio.Models.MenuItem>();
            UpdateIndicators();
        }

        private void UpdateIndicators()
        {
            int available = items.Count(i => i.IsAvailable && i.Stock != 0);
            int outOfStock = items.Count(i => i.Stock == 0);
            int suggestions = items.Count(i => i.IsSuggestion);

            lblAvailable.Text = string.Format("✓ {0} Disponibles", available);
            lblOutOfStock.Text = string.Format("✗ {0} Agotado hoy", outOfStock);
            lblSuggestions.Text = string.Format("★ {0} Sugerencias", suggestions);
        }

        public void Refresh(List<app_escritorio.Models.MenuItem> itemList)
        {
            SetItems(itemList);
        }
    }
}



