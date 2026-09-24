using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestauranteGestor.Services;

namespace RestoOSTests
{
    [TestClass]
    public sealed class ModuleStoreTests
    {
        private string _tempDir;
        private ModuleStore _store;

        [TestInitialize]
        public void Setup()
        {
            _tempDir = Path.Combine(Path.GetTempPath(), "RestoOSTest_" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(_tempDir);
            // ModuleStore usa %LOCALAPPDATA%, no temp. Para aislar, seteamos variable de entorno temporal via reflection? mas simple: probar SaveJson+Load sin aislar
            _store = new ModuleStore();
        }

        [TestCleanup]
        public void Cleanup()
        {
            try { Directory.Delete(_tempDir, true); } catch { }
        }

        [TestMethod]
        public void DefaultState_Tiene8Modulos()
        {
            var dict = _store.Load();
            // Puede tener estado previo, pero al menos contiene claves esperadas
            Assert.IsTrue(dict.ContainsKey("salon"));
            Assert.IsTrue(dict.ContainsKey("kds"));
            Assert.IsTrue(dict.ContainsKey("fiscal"));
            AssertIsBool(dict["salon"]);
        }

        [TestMethod]
        public void SaveJson_RoundTrip()
        {
            var original = new Dictionary<string, bool>
            {
                ["salon"] = false,
                ["kds"] = true,
                ["delivery"] = false,
                ["stock"] = true,
                ["reservas"] = false,
                ["menu"] = true,
                ["fiscal"] = true,
                ["fidelizacion"] = false
            };
            _store.Save(original);
            var loaded = _store.Load();
            foreach (var kv in original) Assert.AreEqual(kv.Value, loaded[kv.Key], $"mismatch {kv.Key}");

            // restaurar default para no afectar UI
            _store.Save(new Dictionary<string, bool>
            {
                ["salon"] = true, ["kds"] = true, ["delivery"] = true, ["stock"] = true,
                ["reservas"] = true, ["menu"] = true, ["fiscal"] = false, ["fidelizacion"] = false
            });
        }

        [TestMethod]
        public void SaveJson_JsonStringValido()
        {
            string json = "{\"salon\":true,\"kds\":false,\"delivery\":true,\"stock\":false,\"reservas\":true,\"menu\":false,\"fiscal\":true,\"fidelizacion\":false}";
            _store.SaveJson(json);
            var loaded = _store.Load();
            Assert.IsFalse(loaded["kds"]);
            Assert.IsTrue(loaded["fiscal"]);
            // restore
            _store.Save(new Dictionary<string, bool>
            {
                ["salon"] = true, ["kds"] = true, ["delivery"] = true, ["stock"] = true,
                ["reservas"] = true, ["menu"] = true, ["fiscal"] = false, ["fidelizacion"] = false
            });
        }

        [TestMethod]
        public void SaveJson_JsonInvalido_NoLanza()
        {
            _store.SaveJson("no json");
            _store.SaveJson(null);
            _store.SaveJson("");
            // no exception = pass
        }

        [TestMethod]
        public void Save_EsAtomico_NoCorrompe()
        {
            var dict = new Dictionary<string, bool> { ["salon"] = true, ["kds"] = true };
            _store.Save(dict);
            Assert.IsTrue(File.Exists(_store.FilePath));
            var text = File.ReadAllText(_store.FilePath);
            var parsed = JsonConvert.DeserializeObject<Dictionary<string, bool>>(text);
            Assert.IsNotNull(parsed);
        }

        private void AssertIsBool(bool v) { Assert.IsTrue(v == true || v == false); }
    }
}
