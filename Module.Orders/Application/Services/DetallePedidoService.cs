using Module.Orders.Application.DTOs;
using Module.Orders.Application.Interfaces;
using Module.Orders.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Orders.Application.Services
{
    public class DetallePedidoService(IDetallePedidoRepository detallePedidoRepository) : IDetallePedidoService
    {
        public async Task AddOrdersAsync(OrderDetailDTO order)
        {
            var result = new Domain.Entities.DetallePedido    
            {
                Id = order.Id,
                PedidoId = order.PedidoId,
                ProductoId = order.ProductoId,
                Cantidad = order.Cantidad,
                PrecioUnitario = order.PrecioUnitario,
            };

            await detallePedidoRepository.AddOrdersAsync(result);
        }

        public async Task<OrderDetailDTO?> GetOrderByIdAsync(long id)
        {
            var result = await detallePedidoRepository.GetOrderByIdAsync(id);
            if (result == null) return null;

            var respuesta = new OrderDetailDTO
            {
                Id = result.Id,
                PedidoId = result.PedidoId,
                ProductoId = result.ProductoId,
                Cantidad = result.Cantidad,
                PrecioUnitario = result.PrecioUnitario
            };

            return respuesta;
        }
    }
}
