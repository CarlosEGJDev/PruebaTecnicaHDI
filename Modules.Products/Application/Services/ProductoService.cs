using Modules.Products.Application.DTOs;
using Modules.Products.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Products.Application.Services
{
    public class ProductoService(IProductRepository productRepository) : IProductService
    {
        public async Task<List<ProductoDTO>> GetAllAsync()
        {
            var data = await productRepository.GetAllAsync();
            var listar = new List<ProductoDTO>();

            foreach (var item in data)
            {
                listar.Add(new ProductoDTO
                {
                    Id = item.Id,
                    Nombre = item.Nombre,
                    Precio = item.Precio,
                    Activo = item.Activo,
                    Stock = item.Stock
                });
            }
            return listar;
        }

        public async Task<ProductoDTO?> GetByIdAsync(long Id)
        {
            var data = await productRepository.GetByIdAsync(Id);

            if (data == null)
                return null;

            var respuesta = new ProductoDTO
            {
                Id = data.Id,
                Nombre = data.Nombre,
                Precio = data.Precio,
                Activo = data.Activo,
                Stock = data.Stock
            };

            return respuesta;
        }
    }
}
