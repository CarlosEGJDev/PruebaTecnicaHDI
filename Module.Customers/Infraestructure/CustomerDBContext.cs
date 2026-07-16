using Microsoft.EntityFrameworkCore;
using Module.Customers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Customers.Infraestructure
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions<CustomerDBContext> options) : base(options){}

        public DbSet<Cliente> Clientes => Set<Cliente>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplica automáticamente todas las configuraciones
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerDBContext).Assembly);
        }
    }
}
