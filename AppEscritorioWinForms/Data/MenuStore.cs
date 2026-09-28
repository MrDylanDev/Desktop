using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using app_escritorio.Models;

namespace app_escritorio.Data
{
    public class MenuData
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();
    }

    /// <summary>
    /// Carta del restaurante (data\menu.xml). <see cref="Current"/> es la carta compartida por el Menú digital y el POS:
    /// al publicar cambios se llama <see cref="Publish"/> y el POS se actualiza al instante con <see cref="MenuChanged"/>.
    /// </summary>
    public static class MenuStore
    {
        public const string DefaultPath = "data/menu.xml";

        private static MenuData _current;

        /// <summary>Se dispara cuando la carta cambia (precio, disponibilidad, platos nuevos...).</summary>
        public static event Action MenuChanged;

        /// <summary>Carta en memoria (se carga la primera vez; si no hay nada usa la carta de ejemplo).</summary>
        public static MenuData Current
        {
            get
            {
                if (_current != null) return _current;
                var data = Load(DefaultPath);
                if (data.Items.Count == 0 || IsOldPlaceholderSample(data)) data = SampleData();
                Normalize(data);
                _current = data;
                return _current;
            }
        }

        /// <summary>Guarda la carta y avisa a las pantallas que la usan.</summary>
        public static void Publish()
        {
            Save(DefaultPath, Current);
            MenuChanged?.Invoke();
        }

        public static Category CategoryOf(MenuItem item) => Current.Categories.FirstOrDefault(c => c.Id == item.CategoryId);

        public static MenuData Load(string filePath)
        {
            if (!File.Exists(filePath)) return new MenuData();
            try
            {
                var ser = new XmlSerializer(typeof(MenuData));
                using (var fs = File.OpenRead(filePath))
                    return ser.Deserialize(fs) as MenuData ?? new MenuData();
            }
            catch
            {
                return new MenuData();
            }
        }

        public static void Save(string filePath, MenuData data)
        {
            var dir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) Directory.CreateDirectory(dir);
            var ser = new XmlSerializer(typeof(MenuData));
            using (var fs = File.Create(filePath))
                ser.Serialize(fs, data);
        }

        /// <summary>Listas nunca nulas y categorías ordenadas.</summary>
        private static void Normalize(MenuData data)
        {
            if (data.Categories == null) data.Categories = new List<Category>();
            if (data.Items == null) data.Items = new List<MenuItem>();
            foreach (var item in data.Items)
            {
                if (item.Tags == null) item.Tags = new List<string>();
                if (item.DietaryFilters == null) item.DietaryFilters = new List<string>();
                if (item.Variants == null) item.Variants = new List<MenuVariant>();
                if (item.Insumos == null) item.Insumos = new List<InsumoLink>();
            }
            if (data.Categories.Count == 0) data.Categories.Add(new Category { Name = "Platos Principales" });
        }

        /// <summary>La carta de ejemplo anterior (2 platos con imagen de relleno) se reemplaza por la nueva.</summary>
        private static bool IsOldPlaceholderSample(MenuData data) =>
            data.Items.Count <= 2 && data.Items.All(i => (i.ImageUrl ?? "").Contains("via.placeholder.com"));

        // ===================== Carta de ejemplo =====================

        public static MenuData SampleData()
        {
            var entradas = new Category { Name = "Entradas", Position = 0 };
            var parrilla = new Category { Name = "Parrilla", Position = 1 };
            var pizzas = new Category { Name = "Pizzas y Pastas", Position = 2 };
            var mar = new Category { Name = "Del Mar", Position = 3 };
            var bebidas = new Category { Name = "Bebidas", Position = 4 };
            var postres = new Category { Name = "Postres", Position = 5 };
            var data = new MenuData { Categories = new List<Category> { entradas, parrilla, pizzas, mar, bebidas, postres } };

            int pos = 0;
            MenuItem Add(Category cat, string name, string desc, decimal salon, string[] tags, string[] dietary,
                         bool available = true, bool chef = false, params InsumoLink[] insumos)
            {
                var item = new MenuItem
                {
                    Name = name, Description = desc, CategoryId = cat.Id, Position = pos++,
                    PriceSalon = salon, PriceDelivery = Math.Round(salon * 1.15m / 100m) * 100m,
                    IsAvailable = available, IsSuggestion = chef,
                    Tags = new List<string>(tags), DietaryFilters = new List<string>(dietary),
                    Insumos = new List<InsumoLink>(insumos)
                };
                data.Items.Add(item);
                cat.ItemIds.Add(item.Id);
                return item;
            }
            InsumoLink I(string n, decimal q, string u) => new InsumoLink { Nombre = n, Cantidad = q, Unidad = u };

            Add(parrilla, "Ojo de Bife con Papas Rústicas",
                "400 g de carne premium madurada a las brasas de quebracho, terminado con manteca de hierbas frescas y papas crocantes al romero.",
                58000, new[] { "Carnes Grill" }, new[] { "Sin TACC" }, chef: true,
                insumos: new[] { I("Ojo de bife madurado", 0.4m, "kg"), I("Papa criolla", 0.25m, "kg"), I("Mantequilla de romero", 0.02m, "kg") });
            Add(pizzas, "Pizza Margherita DOC",
                "Masa madre con fermentación lenta de 48 h, tomates San Marzano, mozzarella di bufala y albahaca fresca del huerto.",
                36000, new[] { "Horno de Barro" }, new[] { "Vegetariano" },
                insumos: new[] { I("Harina trigo", 0.25m, "kg"), I("Queso mozzarella", 0.18m, "kg"), I("Tomate chonto", 0.12m, "kg") });
            Add(mar, "Salmón Rosado a las Brasas",
                "Filete de salmón chileno con crocante de pie, puré de coliflor al azafrán y espárragos verdes salteados.",
                64000, new[] { "Pesca del Día" }, new[] { "Sin TACC" }, available: false,
                insumos: new[] { I("Salmón fresco", 0.25m, "kg"), I("Coliflor", 0.15m, "kg") });
            Add(parrilla, "Hamburguesa Trufada Deluxe",
                "Doble medallón de picaña premium (240 g), cheddar inglés madurado, cebolla caramelizada y mayonesa de trufa negra.",
                42000, new[] { "Top Ventas QR", "Plato Más Vendido" }, new[] { "Gluten", "Lácteos" },
                insumos: new[] { I("Carne de res molida", 0.24m, "kg"), I("Queso cheddar", 0.06m, "kg"), I("Pan brioche", 1m, "und") });
            Add(entradas, "Empanadas Criollas (x3)",
                "Masa de maíz crocante rellena de carne desmechada y papa, con ají de la casa y guacamole.",
                18000, new[] { "Para compartir" }, new[] { "Sin TACC", "Picante" },
                insumos: new[] { I("Harina de maíz", 0.12m, "kg"), I("Carne desmechada", 0.1m, "kg") });
            Add(entradas, "Burrata con Tomates Asados",
                "Burrata cremosa sobre tomates cherry rostizados, pesto de albahaca y pan de masa madre tostado.",
                32000, new[] { "Nuevo" }, new[] { "Vegetariano", "Lácteos" }, chef: true,
                insumos: new[] { I("Burrata", 1m, "und"), I("Tomate cherry", 0.1m, "kg") });
            Add(pizzas, "Ravioles de Cuatro Quesos",
                "Pasta fresca rellena de ricotta, parmesano, gorgonzola y mozzarella en salsa de mantequilla y salvia.",
                39000, new string[0], new[] { "Vegetariano", "Lácteos" },
                insumos: new[] { I("Pasta fresca", 0.2m, "kg"), I("Queso parmesano", 0.04m, "kg") });
            Add(mar, "Ceviche Peruano",
                "Pesca blanca curada en leche de tigre, cebolla morada, ají limo, choclo y camote glaseado.",
                34000, new[] { "Pesca del Día" }, new[] { "Sin TACC", "Picante" }, available: false,
                insumos: new[] { I("Pescado blanco", 0.18m, "kg"), I("Limón", 0.1m, "kg") });
            Add(bebidas, "Limonada de Coco",
                "Limonada frappé con crema de coco y un toque de hierbabuena.",
                12000, new string[0], new[] { "Vegetariano", "Sin TACC" },
                insumos: new[] { I("Limón", 0.08m, "kg"), I("Crema de coco", 0.05m, "L") });
            Add(bebidas, "Cerveza Artesanal IPA",
                "Pinta de IPA local con notas cítricas y amargor medio.",
                15000, new[] { "Local" }, new[] { "Gluten" },
                insumos: new[] { I("Cerveza artesanal", 1m, "und") });
            Add(postres, "Volcán de Chocolate",
                "Bizcocho tibio de chocolate 70 % con centro líquido y helado de vainilla.",
                19000, new[] { "Postre estrella" }, new[] { "Vegetariano", "Lácteos" }, chef: true,
                insumos: new[] { I("Chocolate 70%", 0.06m, "kg"), I("Helado de vainilla", 0.08m, "L") });
            Add(postres, "Tiramisú Casero",
                "Capas de bizcocho empapado en café, crema de mascarpone y cacao amargo.",
                17000, new string[0], new[] { "Vegetariano", "Lácteos" });
            return data;
        }
    }
}
