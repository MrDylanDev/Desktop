using System;
using System.ComponentModel;
using app_escritorio.Forms;
using app_escritorio.UI;

namespace app_escritorio.Views.Pos
{
    /// <summary>Tarjeta de producto del POS (categoría, nombre, precio), como el DataTemplate de WPF.</summary>
    [ToolboxItem(false)]
    public partial class ProductTile : RCardControl
    {
        /// <summary>Se dispara al hacer clic en cualquier parte de la tarjeta.</summary>
        public event EventHandler ProductClicked;

        public ProductTile()
        {
            InitializeComponent();
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Product Product { get; private set; }

        public void SetProduct(Product product)
        {
            Product = product;
            lblCategory.Text = product?.Category ?? string.Empty;
            lblName.Text = product?.Name ?? string.Empty;
            lblPrice.Text = product?.PriceText ?? string.Empty;
        }

        private void Part_Click(object sender, EventArgs e) => ProductClicked?.Invoke(this, EventArgs.Empty);
    }
}
