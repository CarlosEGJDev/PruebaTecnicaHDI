using Module.Orders.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Orders.Domain.Entities
{
    public class Pedido
    {
        public long Id { get; set; }
        public long ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public EstadoPedido Estado { get; set; }
        public decimal Total { get; set; }
    }
}
