using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace RestauranteGestor.Services
{
    public class ModuleStore
    {
        private static readonly object _lock = new object();
        private readonly string _filePath;

        public ModuleStore()
        {
            var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RestoOS");
            Directory.CreateDirectory(dir);
            _filePath = Path.Combine(dir, "modulos.json");
        }

        public string FilePath => _filePath;

        public Dictionary<string, bool> Load()
        {
            lock (_lock)
            {
                try
                {
                    if (!File.Exists(_filePath)) return DefaultState();
                    var json = File.ReadAllText(_filePath);
                    var dict = JsonConvert.DeserializeObject<Dictionary<string, bool>>(json);
                    return dict ?? DefaultState();
                }
                catch { return DefaultState(); }
            }
        }

        public void Save(Dictionary<string, bool> state)
        {
            lock (_lock)
            {
                try
                {
                    var json = JsonConvert.SerializeObject(state, Formatting.Indented);
                    var tmp = _filePath + ".tmp";
                    File.WriteAllText(tmp, json);
                    if (File.Exists(_filePath)) File.Replace(tmp, _filePath, null);
                    else File.Move(tmp, _filePath);
                }
                catch { }
            }
        }

        public void SaveJson(string json)
        {
            try
            {
                var dict = JsonConvert.DeserializeObject<Dictionary<string, bool>>(json);
                if (dict != null) Save(dict);
            }
            catch { }
        }

        private Dictionary<string, bool> DefaultState()
        {
            return new Dictionary<string, bool>
            {
                ["salon"] = true,
                ["kds"] = true,
                ["delivery"] = true,
                ["stock"] = true,
                ["reservas"] = true,
                ["menu"] = true,
                ["fiscal"] = false,
                ["fidelizacion"] = false
            };
        }
    }
}
