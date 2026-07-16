using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Customers.Domain.Entities
{
    public class Cliente
    {
        public long Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public DateTime FechaCreacion { get; set; }
    }
}
