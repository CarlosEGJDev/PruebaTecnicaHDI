using Microsoft.EntityFrameworkCore;
using Module.Customers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}

        // Customers
        public DbSet<Cliente> Clientes => Set<Cliente>();

        // Products
        public DbSet<Producto> Productos => Set<Producto>();

        // Orders
        public DbSet<Pedido> Pedidos => Set<Pedido>();

        public DbSet<DetallePedido> DetallePedidos => Set<DetallePedido>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplica automáticamente todas las configuraciones
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
