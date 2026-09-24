using System.Collections.Generic;

namespace RestauranteGestor.Models
{
    public class ModuleState
    {
        public Dictionary<string, bool> Modules { get; set; } = new Dictionary<string, bool>();
        public string ActivePreset { get; set; } = "restaurante";
    }
}
