using EditalConselho.Dominio;
using EditalConselho.Dominio.Classes;
using EditalConselho.Infra.Mapeamento;
using Microsoft.EntityFrameworkCore;

namespace EditalConselho.Infra.Database
{
    public class EditalContexto : DbContext
    {
        public EditalContexto(DbContextOptions<EditalContexto> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Edital> Edital { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapeamento());
            modelBuilder.ApplyConfiguration(new EditalMapeamento());

            base.OnModelCreating(modelBuilder);
        }
    }
}
