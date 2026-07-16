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
    public class PedidoRepository(OrdersDbContext context) : IPedidoRepository
    {
        public async Task AddOrdersAsync(Pedido order)
        {
            await context.Pedidos.AddAsync(order);
            await context.SaveChangesAsync();
        }

        public async Task<List<Pedido>> GetAllOrdersAsync()
        {
            return await context.Pedidos.ToListAsync();
        }

        public async Task<Pedido?> GetOrderByIdAsync(long id)
        {
            return await context.Pedidos.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
