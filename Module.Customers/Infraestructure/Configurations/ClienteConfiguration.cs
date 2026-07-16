using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module.Customers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Customers.Infraestructure.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Domain.Entities.Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("CLIENTE");
            builder.Property(x => x.Id).HasColumnName("ID").ValueGeneratedOnAdd();
            builder.Property(x => x.Nombre).HasColumnName("NOMBRE");
            builder.Property(x => x.Email).HasColumnName("EMAIL");
            builder.Property(x => x.FechaCreacion).HasColumnName("FECHACREACION");
        }
    }
}
