using Microsoft.EntityFrameworkCore;
using Module.Orders.Application.Interfaces;
using Module.Orders.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Orders.Infraestructure.Repositories
{
    public class DetallePedidoRepository(OrdersDbContext ordersDbContext) : IDetallePedidoRepository
    {
        public async Task AddOrdersAsync(DetallePedido order)
        {
            await ordersDbContext.DetallesPedidos.AddAsync(order);
            await ordersDbContext.SaveChangesAsync();
        }

        public async Task<DetallePedido?> GetOrderByIdAsync(long id)
        {
            return await ordersDbContext.DetallesPedidos.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
