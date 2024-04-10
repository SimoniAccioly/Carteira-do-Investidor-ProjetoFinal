using CarteiraDoInvestidor.Domain.Carteira;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Repository.Mapping
{
    public class AtivosMapping : IEntityTypeConfiguration<Ativos>
    {
        public void Configure(EntityTypeBuilder<Ativos> builder)
        {
            builder.ToTable("Ativos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Papel).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Quantidade).IsRequired();
            builder.Property(x => x.PrecoMedio).IsRequired();
            builder.Property(x => x.Corretora).IsRequired();
            builder.Property(x => x.TaxaDeCorretagem).IsRequired();

        }
    }
}

