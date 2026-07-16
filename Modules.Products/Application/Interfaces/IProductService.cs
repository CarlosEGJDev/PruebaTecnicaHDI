using Modules.Products.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Products.Application.Interfaces
{
    public interface IProductService
    {
        Task<ProductoDTO?> GetByIdAsync(long Id);
        Task<List<ProductoDTO>> GetAllAsync();
    }
}
