using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using app_escritorio.Forms;

namespace app_escritorio.Data
{
    /// <summary>
    /// Tickets abiertos por mesa (en memoria). Lo comparten el POS nuevo, el PosForm viejo y Mesas.
    /// </summary>
    public static class TicketStore
    {
        public const string NoTable = "Mesa no seleccionada";
        private static readonly Dictionary<string, BindingList<OrderLine>> _tickets = new Dictionary<string, BindingList<OrderLine>>();

        /// <summary>Se dispara cuando cambia cualquier ticket (para refrescar Mesas).</summary>
        public static event Action TicketChanged;

        public static BindingList<OrderLine> GetTicketFor(string mesa)
        {
            string key = string.IsNullOrWhiteSpace(mesa) || mesa == NoTable ? "__GENERAL__" : mesa;
            if (!_tickets.TryGetValue(key, out var list))
            {
                list = new BindingList<OrderLine>();
                _tickets[key] = list;
            }
            return list;
        }

        public static decimal GetSubtotalFor(string mesa) => GetTicketFor(mesa).Sum(l => l.LineTotal);

        public static void NotifyChanged() => TicketChanged?.Invoke();
    }
}
