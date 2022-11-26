using EditalConselho.Dominio;
using EditalConselho.Dominio.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EditalConselho.Infra.Mapeamento
{
    public class EditalMapeamento : IEntityTypeConfiguration<Edital>
    {
        public void Configure(EntityTypeBuilder<Edital> builder)
        {
            builder.ToTable("arquivo");

            builder.Property(d => d.IdArquivo).HasColumnType("int");
            builder.Property(d => d.IdUsuario).HasColumnType("int");
            builder.HasKey(d => d.IdArquivo);
            builder.Property(d => d.Titulo).HasColumnType("varchar(100)").HasMaxLength(100);
            builder.Property(d => d.Descricao).HasColumnType("varchar(100)").HasMaxLength(100);
            builder.Property(d => d.DataEnvio).HasColumnType("datetime");
            builder.Property(d => d.Arquivo).HasColumnType("MediumBLOB");
        }
    }
}
