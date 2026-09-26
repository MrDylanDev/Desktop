using System;
using System.Collections.Generic;

namespace app_escritorio.Models
{
    public class MenuItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PriceSalon { get; set; }
        public decimal PriceDelivery { get; set; }
        public decimal CommissionPercentage { get; set; } = 15m; // % de comisión delivery
        public bool NoCommission { get; set; } = false; // Sin comisión
        public bool IsAvailable { get; set; } = true;
        public bool IsSuggestion { get; set; } = false; // Sugerencia del Chef
        public Guid CategoryId { get; set; }
        public int Position { get; set; } = 0; // order inside category
        public string ImageUrl { get; set; }
        public int Stock { get; set; } = -1; // -1 = unlimited
        public bool IsFavorite { get; set; } = false;
        public List<MenuVariant> Variants { get; set; } = new List<MenuVariant>();
        public List<string> Tags { get; set; } = new List<string>(); // DISPONIBLE, Carnes Grill, Plato Más Vendido, etc
        public List<string> DietaryFilters { get; set; } = new List<string>(); // Sin TACC, Vegetariano, Picante, Chef
        public int InventoryDiscount { get; set; } = 0; // Descuento de inventario por unidades vendidas
    }

    public class MenuVariant
    {
        public string Name { get; set; }
        public decimal PriceDelta { get; set; }
        public int Stock { get; set; } = -1;
    }
}

