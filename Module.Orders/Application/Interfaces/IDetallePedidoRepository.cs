using Module.Orders.Application.DTOs;
using Module.Orders.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Orders.Application.Interfaces
{
    public interface IDetallePedidoRepository
    {
        Task<DetallePedido?> GetOrderByIdAsync(long id);
        Task AddOrdersAsync(DetallePedido order);

    }
}
