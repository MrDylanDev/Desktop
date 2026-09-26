using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace app_escritorio.Models
{
    public class OrderRecord
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string CustomerName { get; set; } = "Cliente";
        public string TableNumber { get; set; } = "";
        public string Status { get; set; } = "Pendiente";
        public decimal Total { get; set; }
        public List<OrderRecordLine> Lines { get; set; } = new List<OrderRecordLine>();
    }

    public class OrderRecordLine
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
