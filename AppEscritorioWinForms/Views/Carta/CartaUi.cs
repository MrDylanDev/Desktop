using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using app_escritorio.Models;
using app_escritorio.Utils;

namespace app_escritorio.Views.Carta
{
    /// <summary>Textos, colores e íconos compartidos por el Menú digital.</summary>
    public static class CartaUi
    {
        public const string MasVendido = "Plato Más Vendido";
        public const string SugerenciaChef = "Sugerencia Chef";
        private static readonly CultureInfo Co = CultureInfo.GetCultureInfo("es-CO");

        /// <summary>Filtros dietéticos y alérgenos que se pueden marcar en el editor.</summary>
        public static readonly string[] Dietary = { "Sin TACC", "Vegetariano", "Picante", "Sin Lactosa", "Gluten", "Lácteos" };

        public static string Money(decimal v) => v.ToString("C0", Co);

        public static string GlyphFor(string category)
        {
            string c = (category ?? "").ToLowerInvariant();
            if (c.Contains("bebida")) return "🥤";
            if (c.Contains("postre")) return "🍰";
            if (c.Contains("pizza") || c.Contains("pasta")) return "🍕";
            if (c.Contains("mar") || c.Contains("pesca") || c.Contains("pescado")) return "🐟";
            if (c.Contains("parrilla") || c.Contains("carne") || c.Contains("grill")) return "🥩";
            if (c.Contains("entrada") || c.Contains("tapa")) return "🥟";
            if (c.Contains("hamburg")) return "🍔";
            return "🍽";
        }

        public static Color TagColor(string tag)
        {
            switch (tag)
            {
                case "Vegetariano": return Theme.Tertiary;
                case "Picante": return Theme.Error;
                case "Gluten":
                case "Lácteos": return Theme.Primary;
                case SugerenciaChef: return Theme.Secondary;
                default: return Color.Empty;
            }
        }

        /// <summary>Etiquetas que se muestran en la tarjeta: filtros dietéticos + Sugerencia Chef.</summary>
        public static IEnumerable<string> CardTags(MenuItem item)
        {
            foreach (var d in item.DietaryFilters) yield return d;
            if (item.IsSuggestion) yield return SugerenciaChef;
        }

        /// <summary>Acepta "48000", "48.000", "$ 48.000" (pesos, sin decimales).</summary>
        public static bool TryParseMoney(string raw, out decimal value)
        {
            string t = (raw ?? "").Replace("$", "").Replace(" ", "").Replace(".", "").Replace(",", "").Trim();
            return decimal.TryParse(t, NumberStyles.Number, CultureInfo.InvariantCulture, out value) && value >= 0;
        }

        public static string MoneyInput(decimal v) => v.ToString("N0", Co);

        /// <summary>Precio delivery sugerido: salón + comisión, redondeado a la centena.</summary>
        public static decimal DeliveryPrice(decimal salon, decimal pct) => Math.Round(salon * (1 + pct / 100m) / 100m, MidpointRounding.AwayFromZero) * 100m;
    }
}
