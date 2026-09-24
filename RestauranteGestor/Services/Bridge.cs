using System;
using System.Runtime.InteropServices;

namespace RestauranteGestor.Services
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Bridge
    {
        private readonly ModuleStore _store;
        public Bridge(ModuleStore store) { _store = store; }

        public void SaveState(string json)
        {
            _store.SaveJson(json);
        }

        public string LoadState()
        {
            var dict = _store.Load();
            return Newtonsoft.Json.JsonConvert.SerializeObject(dict);
        }
    }
}
