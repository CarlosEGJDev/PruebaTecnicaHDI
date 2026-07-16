using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Orders.Application.Interfaces;
using Module.Orders.Application.Services;
using Module.Orders.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Orders.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddOrdersModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OrdersDbContext>(options => options.UseOracle(configuration.GetConnectionString("Oracle")));

            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            
            services.AddScoped<IDetallePedidoService, DetallePedidoService>();
            services.AddScoped<IDetallePedidoRepository, DetallePedidoRepository>();

            return services;
        }
    }
}
