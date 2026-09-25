using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Models;
using app_escritorio.Utils;

namespace app_escritorio.Controls
{
    public class CategoryBar : UserControl
    {
        private FlowLayoutPanel categoryFlow;
        private Button btnAll;
        private List<Category> categories = new List<Category>();
        private Guid? selectedCategoryId = null;

        public event EventHandler<CategorySelectedEventArgs> CategorySelected;

        public CategoryBar()
        {
            this.Dock = DockStyle.Top;
            this.Height = 48;
            this.BackColor = Theme.BackgroundDark;
            this.ForeColor = Theme.TextPrimary;
            this.Padding = new Padding(10, 2, 10, 2);

            categoryFlow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = false
            };

            btnAll = CreateCategoryButton("Todas", null, true);
            categoryFlow.Controls.Add(btnAll);

            this.Controls.Add(categoryFlow);
        }

        public void SetCategories(List<Category> cats)
        {
            categories = cats?.OrderBy(c => c.Position).ToList() ?? new List<Category>();
            categoryFlow.Controls.Clear();
            categoryFlow.Controls.Add(btnAll);

            foreach (var cat in categories)
            {
                var btn = CreateCategoryButton(cat.Name, cat.Id);
                categoryFlow.Controls.Add(btn);
            }
        }

        private Button CreateCategoryButton(string name, Guid? catId, bool isActive = false)
        {
            var btn = new Button
            {
                Text = name,
                Size = new Size(140, 36),
                Font = Theme.FontSmall,
                FlatStyle = FlatStyle.Flat,
                BackColor = isActive ? Theme.ButtonPrimary : Theme.BackgroundMedium,
                ForeColor = isActive ? Theme.ButtonPrimaryText : Theme.TextSecondary,
                Margin = new Padding(4),
                Tag = catId
            };

            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = isActive ? Theme.ButtonPrimary : Theme.BackgroundLight;
            btn.Region = new Region(RoundedRect(new Rectangle(0, 0, 140, 36), 14));

            btn.Click += (s, e) =>
            {
                SelectCategory(catId);
            };

            btn.MouseEnter += (s, e) =>
            {
                if (catId != selectedCategoryId)
                    btn.BackColor = Theme.BackgroundLight;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = (catId == selectedCategoryId) ? Theme.ButtonPrimary : Theme.BackgroundMedium;
            };

            return btn;
        }

        private static System.Drawing.Drawing2D.GraphicsPath RoundedRect(Rectangle rect, int diameter)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void SelectCategory(Guid? catId)
        {
            selectedCategoryId = catId;

            // Actualizar estilos
            foreach (Button btn in categoryFlow.Controls.OfType<Button>())
            {
                var btnCatId = btn.Tag as Guid?;
                btn.BackColor = (btnCatId == catId) ? Theme.ButtonPrimary : Theme.BackgroundMedium;
                btn.ForeColor = (btnCatId == catId) ? Theme.ButtonPrimaryText : Theme.TextSecondary;
            }

            // Disparar evento
            CategorySelected?.Invoke(this, new CategorySelectedEventArgs { SelectedCategoryId = catId });
        }
    }

    public class CategorySelectedEventArgs : EventArgs
    {
        public Guid? SelectedCategoryId { get; set; }
    }
}
