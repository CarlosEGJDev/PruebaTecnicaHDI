using Modules.Products.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Products.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<Producto?> GetByIdAsync(long Id);
        Task<List<Producto>> GetAllAsync();
    }
}
