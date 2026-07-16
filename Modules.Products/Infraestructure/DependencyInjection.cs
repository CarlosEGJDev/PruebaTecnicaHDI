using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Modules.Products.Domain.Entities;
using Shared.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Products.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProductsModule(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<OrdersDbContext>(options => options.UseOracle(configuration.GetConnectionString("Oracle")));

            //services.AddScoped<IPedidoRepository, PedidoRepository>();

            return services;
        }
    }
}
