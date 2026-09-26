using System.Globalization;

namespace app_escritorio.Forms
{
    // Modelos del POS (antes estaban dentro de Forms/PosForm.cs).
    // Se mantiene el namespace app_escritorio.Forms para no tocar el resto del código.

    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string PriceText => Price.ToString("C0", CultureInfo.GetCultureInfo("es-CO"));
        public Product(string name, string category, decimal price) { Name = name; Category = category; Price = price; }
    }

    public class OrderLine
    {
        public Product Product { get; private set; }
        public string Name => Product.Name;
        public int Quantity { get; set; } = 1;
        /// <summary>Nota del ítem ("sin cebolla", "término medio").</summary>
        public string Notes { get; set; } = string.Empty;
        /// <summary>Precio unitario formateado ("$ 14.500 c/u").</summary>
        public string Detail => Product.PriceText + " c/u";
        public decimal LineTotal => Product.Price * Quantity;
        public string TotalText => LineTotal.ToString("C0", CultureInfo.GetCultureInfo("es-CO"));

        public OrderLine(Product product) { Product = product; }
    }
}
