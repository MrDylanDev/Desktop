using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using app_escritorio.Models;
using app_escritorio.UI;
using app_escritorio.Utils;

namespace app_escritorio.Views.Carta
{
    /// <summary>
    /// Tarjeta de un plato del Menú digital: foto con estado, nombre, descripción, etiquetas dietéticas,
    /// precios salón / delivery y los botones "Pausar por falta de stock" y editar.
    /// Se puede arrastrar desde la foto para reordenar la carta.
    /// </summary>
    [ToolboxItem(true)]
    [DefaultEvent("CardClicked")]
    public partial class DishCard : RCardControl
    {
        private bool _selected;
        private Point _downAt;

        public event EventHandler CardClicked;
        public event EventHandler EditClicked;
        public event EventHandler PauseClicked;

        public DishCard()
        {
            InitializeComponent();
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MenuItem Item { get; private set; }

        /// <summary>Borde resaltado cuando el plato está abierto en el editor.</summary>
        [Category("RestoOS"), DefaultValue(false)]
        public bool Selected
        {
            get => _selected;
            set
            {
                _selected = value;
                BorderColor = value ? Theme.Primary : Theme.Blend(Theme.Outline, Theme.SurfaceContainer, 0.6);
                BorderWidth = value ? 2 : 1;
            }
        }

        public void SetItem(MenuItem item, string categoryName)
        {
            Item = item;
            lblName.Text = item.Name;
            lblDescription.Text = item.Description;

            bool agotado = !item.IsAvailable || item.Stock == 0;
            dishImage.Image = DishImage.LoadCached(item.ImageUrl);
            dishImage.Glyph = CartaUi.GlyphFor(categoryName);
            dishImage.Dimmed = agotado;
            dishImage.HighlightText = item.Tags.Contains(CartaUi.MasVendido) ? "Plato Más Vendido" : "";
            if (agotado) { dishImage.StatusText = "⚠ AGOTADO HOY"; dishImage.StatusColor = Theme.Error; }
            else if (item.Stock > 0 && item.Stock <= 5) { dishImage.StatusText = "● QUEDAN " + item.Stock; dishImage.StatusColor = Theme.Secondary; }
            else { dishImage.StatusText = "● DISPONIBLE"; dishImage.StatusColor = Theme.Tertiary; }
            dishImage.CategoryText = item.Tags.FirstOrDefault(t => t != CartaUi.MasVendido) ?? categoryName ?? "";

            flowTags.SuspendLayout();
            foreach (Control c in flowTags.Controls.Cast<Control>().ToList()) c.Dispose();
            flowTags.Controls.Clear();
            foreach (var tag in CartaUi.CardTags(item))
                flowTags.Controls.Add(new RChip { Text = tag, Small = true, ChipStyle = ChipStyle.Outline, AccentColor = CartaUi.TagColor(tag), Height = 22 });
            flowTags.ResumeLayout(true);

            lblSalon.Text = CartaUi.Money(item.PriceSalon);
            lblDelivery.Text = CartaUi.Money(item.PriceDelivery);
            lblDeliveryCaption.Text = item.NoCommission ? "Precio Delivery" : "Precio Delivery (+" + item.CommissionPercentage.ToString("0.#") + "%)";
            lblName.ColorOverride = agotado ? Theme.OnSurfaceVariant : Color.Empty;
            lblSalon.ColorOverride = agotado ? Theme.OnSurfaceVariant : Color.Empty;

            btnPause.Text = item.IsAvailable ? "⏸  Pausar por falta de stock" : "▶  Reactivar plato";
            btnPause.Variant = item.IsAvailable ? ButtonVariant.Secondary : ButtonVariant.Primary;
            Selected = _selected;
        }

        private void Part_Click(object sender, EventArgs e) => CardClicked?.Invoke(this, EventArgs.Empty);
        private void BtnEdit_Click(object sender, EventArgs e) => EditClicked?.Invoke(this, EventArgs.Empty);
        private void BtnPause_Click(object sender, EventArgs e) => PauseClicked?.Invoke(this, EventArgs.Empty);

        // Arrastrar desde la foto para reordenar
        private void Part_MouseDown(object sender, MouseEventArgs e) => _downAt = e.Location;

        private void Part_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || Item == null) return;
            if (Math.Abs(e.X - _downAt.X) + Math.Abs(e.Y - _downAt.Y) < 10) return;
            DoDragDrop(this, DragDropEffects.Move);
        }
    }
}
