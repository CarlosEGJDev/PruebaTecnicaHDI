using Module.Orders.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Orders.Application.Interfaces
{
    public interface IPedidoService
    {
        Task<OrderDTO?> GetOrderByIdAsync(long id);
        Task<List<OrderDTO>> GetAllOrdersAsync();
        Task AddOrdersAsync(OrderDTO order);
    }
}
