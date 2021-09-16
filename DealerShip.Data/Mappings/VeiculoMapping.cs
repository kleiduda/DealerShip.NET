using DealerShip.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DealerShip.Data.Mappings
{
    public class VeiculoMapping : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(v =>v.Id);

            //1 : N Veiculo : Opcionais
            builder.HasMany(f => f.Opcionais)
                .WithOne(p => p.VeiculoNome)
                .HasForeignKey(p => p.Id);
            builder.Property(opt=>opt.CondicaoNovoUsado).HasColumnName("condicao");
            builder.Property(opt=>opt.Versao).HasColumnName("versao");
            builder.Property(opt=>opt.Marca).HasColumnName("marca_id");

            //1 : 1 Veiculo : Marca
            builder.HasOne(v=>v.Marca).WithOne();

            builder.ToTable("TB_VEICULO");
        }
    }
}
