using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSharedModule(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<OrdersDbContext>(options => options.UseOracle(configuration.GetConnectionString("Oracle")));

            //services.AddScoped<IPedidoRepository, PedidoRepository>();

            return services;
        }
    }
}
