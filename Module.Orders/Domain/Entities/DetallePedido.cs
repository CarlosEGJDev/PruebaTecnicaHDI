using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Orders.Domain.Entities
{
    public class DetallePedido
    {
        public long Id { get; set; }
        public long PedidoId { get; set; }
        public long ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        // Columna virtual en Oracle
        public decimal Subtotal { get; private set; }
    }
}
