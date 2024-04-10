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
    internal class ArquivoExcelMapping : IEntityTypeConfiguration<ArquivoExcel>
    {
        public void Configure(EntityTypeBuilder<ArquivoExcel> builder)
        {
            builder.ToTable("Arquivos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.LinkExcel).IsRequired();

        }
    }
}
