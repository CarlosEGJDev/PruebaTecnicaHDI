using Module.Orders.Application.DTOs;
using Module.Orders.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Orders.Application.Services
{
    public class PedidoService(IPedidoRepository pedidoRepository) : IPedidoService
    {
        public async Task AddOrdersAsync(OrderDTO order)
        {
            var result = new Domain.Entities.Pedido
            {
                ClienteId = order.ClienteId,
                Fecha = order.Fecha,
                Estado = order.Estado,
                Total = order.Total
            };
            await pedidoRepository.AddOrdersAsync(result);
        }

        public async Task<List<OrderDTO>> GetAllOrdersAsync()
        {
            var data = await pedidoRepository.GetAllOrdersAsync();
            var listar = new List<OrderDTO>();

            foreach (var item in data)
            {
                listar.Add(new OrderDTO
                {
                    Id = item.Id,
                    ClienteId = item.ClienteId,
                    Fecha = item.Fecha,
                    Estado = item.Estado,
                    Total = item.Total

                });
            }

            return listar;
        }

        public async Task<OrderDTO?> GetOrderByIdAsync(long id)
        {
            var data = await pedidoRepository.GetOrderByIdAsync(id);

            if (data == null)
                return null;

            var respuesta = new OrderDTO
            {
                Id = data.Id,
                ClienteId = data.ClienteId,
                Fecha = data.Fecha,
                Estado = data.Estado,
                Total = data.Total
            };

            return respuesta;
        }

    }
}
