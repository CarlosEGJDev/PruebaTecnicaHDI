using Microsoft.EntityFrameworkCore;
using Modules.Products.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Products.Infraestructure
{
    public class ProductosDbContext : DbContext
    {

        public ProductosDbContext(DbContextOptions<ProductosDbContext> options) : base(options) { }
        public DbSet<Producto> Productos => Set<Producto>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplica automáticamente todas las configuraciones
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductosDbContext).Assembly);
        }
    }
}
