using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using app_escritorio.Models;

namespace app_escritorio.Data
{
    public class MenuData
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();
    }

    public static class MenuStore
    {
        public static MenuData Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new MenuData();
            }

            try
            {
                var ser = new XmlSerializer(typeof(MenuData));
                using (var fs = File.OpenRead(filePath))
                {
                    return ser.Deserialize(fs) as MenuData ?? new MenuData();
                }
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
            {
                ser.Serialize(fs, data);
            }
        }

        public static MenuData SampleData()
        {
            var cat1 = new Category { Name = "Entradas y Tapas", Position = 0 };
            var cat2 = new Category { Name = "Platos Principales", Position = 1 };

            var item1 = new MenuItem
            {
                Name = "Ojo de Bife con Papas Rústicas",
                Description = "400g de carne premium...",
                PriceSalon = 22.5m,
                PriceDelivery = 25.8m,
                CategoryId = cat2.Id,
                ImageUrl = "https://via.placeholder.com/800"
            };

            var item2 = new MenuItem
            {
                Name = "Pizza Margherita DOC",
                Description = "Masa madre...",
                PriceSalon = 14.0m,
                PriceDelivery = 15.5m,
                CategoryId = cat2.Id,
                ImageUrl = "https://via.placeholder.com/800"
            };

            cat2.ItemIds.Add(item1.Id);
            cat2.ItemIds.Add(item2.Id);

            return new MenuData
            {
                Categories = new List<Category> { cat1, cat2 },
                Items = new List<MenuItem> { item1, item2 }
            };
        }
    }
}
