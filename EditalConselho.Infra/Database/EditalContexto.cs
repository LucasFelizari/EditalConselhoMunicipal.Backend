using Microsoft.EntityFrameworkCore;

namespace EditalConselho.Infra.Database
{
    public class EditalContexto : DbContext
    {
        public EditalContexto(DbContextOptions<EditalContexto> options) : base(options)
        {

        }
    }
}
