using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestauranteGestor.Services;

namespace RestoOSTests
{
    [TestClass]
    public sealed class BridgeTests
    {
        [TestMethod]
        public void Bridge_SaveState_DelegaAStore()
        {
            var store = new ModuleStore();
            var bridge = new Bridge(store);
            string json = "{\"salon\":false,\"kds\":true,\"delivery\":false,\"stock\":true,\"reservas\":false,\"menu\":true,\"fiscal\":false,\"fidelizacion\":true}";
            bridge.SaveState(json);
            string loaded = bridge.LoadState();
            Assert.IsTrue(loaded.Contains("\"salon\":false"));
            Assert.IsTrue(loaded.Contains("\"kds\":true"));
            // restore
            bridge.SaveState("{\"salon\":true,\"kds\":true,\"delivery\":true,\"stock\":true,\"reservas\":true,\"menu\":true,\"fiscal\":false,\"fidelizacion\":false}");
        }

        [TestMethod]
        public void Bridge_ClaseEsComVisible()
        {
            var attr = typeof(Bridge).GetCustomAttributes(typeof(System.Runtime.InteropServices.ComVisibleAttribute), false);
            Assert.IsTrue(attr.Length > 0);
            var com = (System.Runtime.InteropServices.ComVisibleAttribute)attr[0];
            Assert.IsTrue(com.Value);
        }

        [TestMethod]
        public void Bridge_LoadState_RetornaJsonValido()
        {
            var bridge = new Bridge(new ModuleStore());
            string json = bridge.LoadState();
            Assert.IsFalse(string.IsNullOrWhiteSpace(json));
            var dict = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.Dictionary<string,bool>>(json);
            Assert.IsNotNull(dict);
            Assert.IsTrue(dict.ContainsKey("salon"));
        }
    }
}
