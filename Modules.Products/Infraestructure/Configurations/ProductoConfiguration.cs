using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Products.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Products.Infraestructure.Configurations
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Domain.Entities.Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("PRODUCTO");
            builder.Property(x => x.Id).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(x => x.Nombre).HasColumnName("NOMBRE");
            builder.Property(x => x.Precio).HasColumnName("PRECIO");
            builder.Property(x => x.Stock).HasColumnName("STOCK");
        }
    }
}
