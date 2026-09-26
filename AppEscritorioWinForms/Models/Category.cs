using System;
using System.Collections.Generic;

namespace app_escritorio.Models
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Position { get; set; } = 0;
        public List<Guid> ItemIds { get; set; } = new List<Guid>();
    }
}
