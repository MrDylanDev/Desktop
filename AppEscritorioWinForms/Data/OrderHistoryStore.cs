using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using app_escritorio.Models;

namespace app_escritorio.Data
{
    public static class OrderHistoryStore
    {
        public static List<OrderRecord> Load(string filePath)
        {
            if (!File.Exists(filePath)) return new List<OrderRecord>();
            try
            {
                var serializer = new XmlSerializer(typeof(List<OrderRecord>));
                using (var stream = File.OpenRead(filePath)) return serializer.Deserialize(stream) as List<OrderRecord> ?? new List<OrderRecord>();
            }
            catch { return new List<OrderRecord>(); }
        }

        public static void Save(string filePath, List<OrderRecord> records)
        {
            var folder = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(folder) && !Directory.Exists(folder)) Directory.CreateDirectory(folder);
            var serializer = new XmlSerializer(typeof(List<OrderRecord>));
            using (var stream = File.Create(filePath)) serializer.Serialize(stream, records ?? new List<OrderRecord>());
        }
    }

    public static class SettingsStore
    {
        public static RestaurantSettings Load(string filePath)
        {
            if (!File.Exists(filePath)) return new RestaurantSettings();
            try
            {
                var serializer = new XmlSerializer(typeof(RestaurantSettings));
                using (var stream = File.OpenRead(filePath)) return serializer.Deserialize(stream) as RestaurantSettings ?? new RestaurantSettings();
            }
            catch { return new RestaurantSettings(); }
        }

        public static void Save(string filePath, RestaurantSettings settings)
        {
            var folder = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(folder) && !Directory.Exists(folder)) Directory.CreateDirectory(folder);
            var serializer = new XmlSerializer(typeof(RestaurantSettings));
            using (var stream = File.Create(filePath)) serializer.Serialize(stream, settings ?? new RestaurantSettings());
        }
    }
}
