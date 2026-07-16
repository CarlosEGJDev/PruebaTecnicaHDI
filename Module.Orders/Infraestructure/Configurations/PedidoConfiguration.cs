using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Orders.Infraestructure.Configurations
{
    public class PedidoConfiguration:IEntityTypeConfiguration<Domain.Entities.Pedido>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Entities.Pedido> builder)
        {
            builder.ToTable("PEDIDO");
            builder.Property(x => x.Id).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(x => x.ClienteId).HasColumnName("CLIENTEID");
            builder.Property(x => x.Fecha).HasColumnName("FECHA");
            builder.Property(x => x.Estado).HasColumnName("ESTADO");
            builder.Property(x => x.Total).HasColumnName("TOTAL");
        }
    
    }
}
