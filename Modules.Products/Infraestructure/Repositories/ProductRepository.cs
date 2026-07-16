using Microsoft.EntityFrameworkCore;
using Modules.Products.Application.Interfaces;
using Modules.Products.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Products.Infraestructure.Repositories
{
    public class ProductRepository(ProductosDbContext context) : IProductRepository
    {
        public async Task<List<Producto>> GetAllAsync()
        {
            return await context.Productos.ToListAsync();
        }

        public async Task<Producto?> GetByIdAsync(long Id)
        {
            return await context.Productos.FirstOrDefaultAsync(p => p.Id == Id);
        }
    }
}
