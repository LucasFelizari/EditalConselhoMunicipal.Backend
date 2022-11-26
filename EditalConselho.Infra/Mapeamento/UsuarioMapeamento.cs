using EditalConselho.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Runtime.ConstrainedExecution;

namespace EditalConselho.Infra.Mapeamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.Property(d => d.Id).HasColumnType("int").HasColumnName("idusuario");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Nome).HasColumnType("varchar(150)").HasMaxLength(150);
          //  builder.Property(d => d.Login).HasColumnType("varchar");
            builder.Property(d => d.Senha).HasColumnType("varchar(40)").HasMaxLength(40);
            builder.Property(d => d.Email).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(d => d.Telefone).HasColumnType("varchar(20)").HasMaxLength(20);
            builder.Property(d => d.CPF).HasColumnType("varchar(15)").HasMaxLength(15);
            builder.Property(d => d.Cidade).HasColumnType("varchar(150)").HasMaxLength(150);
            builder.Property(d => d.Endereco).HasColumnType("varchar(150)").HasMaxLength(150);
            builder.Property(d => d.CEP).HasColumnType("varchar(9)").HasMaxLength(9);
        }
    }
}
