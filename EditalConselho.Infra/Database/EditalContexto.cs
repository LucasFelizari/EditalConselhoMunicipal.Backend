using EditalConselho.Dominio;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapeamento());

            base.OnModelCreating(modelBuilder);
        }
    }
}
