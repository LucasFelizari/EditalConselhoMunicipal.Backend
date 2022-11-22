using EditalConselho.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EditalConselho.Infra.Mapeamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("NomeDaTabela");

            builder.Property(d => d.Nome).HasColumnType("varchar");
            builder.Property(d => d.Senha).HasColumnType("varchar");

        }
    }
}
