using Module.Orders.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Orders.Application.Interfaces
{
    public interface IDetallePedidoService
    {
        Task<OrderDetailDTO?> GetOrderByIdAsync(long id);
        Task AddOrdersAsync(OrderDetailDTO order);

    }
}
