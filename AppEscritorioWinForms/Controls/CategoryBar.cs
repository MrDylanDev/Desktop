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
            this.Height = 60;
            this.BackColor = Theme.BackgroundDark;
            this.ForeColor = Theme.TextPrimary;
            this.Padding = new Padding(10);

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
                Text = $"⬤ {name}",
                Size = new Size(120, 40),
                Font = Theme.FontPrimary,
                FlatStyle = FlatStyle.Flat,
                BackColor = isActive ? Theme.AccentPrimary : Theme.BackgroundMedium,
                ForeColor = isActive ? Color.White : Theme.TextSecondary,
                Margin = new Padding(4),
                Tag = catId
            };

            btn.FlatAppearance.BorderColor = Theme.BorderLight;
            btn.FlatAppearance.BorderSize = 1;

            btn.Click += (s, e) =>
            {
                SelectCategory(catId);
            };

            btn.MouseEnter += (s, e) =>
            {
                if (!isActive)
                    btn.BackColor = Theme.BackgroundLight;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = (catId == selectedCategoryId) ? Theme.AccentPrimary : Theme.BackgroundMedium;
            };

            return btn;
        }

        private void SelectCategory(Guid? catId)
        {
            selectedCategoryId = catId;

            // Actualizar estilos
            foreach (Button btn in categoryFlow.Controls.OfType<Button>())
            {
                var btnCatId = btn.Tag as Guid?;
                btn.BackColor = (btnCatId == catId) ? Theme.AccentPrimary : Theme.BackgroundMedium;
                btn.ForeColor = (btnCatId == catId) ? Color.White : Theme.TextSecondary;
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
