using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Orders.Infraestructure.Configurations
{
    public class DetallePedidoConfiguration : IEntityTypeConfiguration<Domain.Entities.DetallePedido>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Entities.DetallePedido> builder)
        {
            builder.ToTable("DETALLEPEDIDO");
            builder.Property(x => x.Id).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(x => x.PedidoId).HasColumnName("PEDIDOID");
            builder.Property(x => x.ProductoId).HasColumnName("PRODUCTOID");
            builder.Property(x => x.Cantidad).HasColumnName("CANTIDAD");
            builder.Property(x => x.PrecioUnitario).HasColumnName("PRECIOUNITARIO");
            builder.Property(x => x.Subtotal).HasColumnName("SUBTOTAL");
        }
    
    }
}
