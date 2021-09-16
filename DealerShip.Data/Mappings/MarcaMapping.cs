using DealerShip.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DealerShip.Data.Mappings
{
    public class MarcaMapping : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.Property(opt =>opt.NomeMarca).HasColumnName("marca_nome");
            

            builder.ToTable("TB_VEICULO_MARCA");
        }
    }
}
