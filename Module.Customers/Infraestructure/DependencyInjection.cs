
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Customers.Application.Interfaces;
using Module.Customers.Application.Services;
using Module.Customers.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Customers.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomerModule(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<CustomerDBContext>(options => options.UseOracle(configuration.GetConnectionString("Oracle")));
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteRepository, ClienteRepository>();

            return services;
        }
    }
}
