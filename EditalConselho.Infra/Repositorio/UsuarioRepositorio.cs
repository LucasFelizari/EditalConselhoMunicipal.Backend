using EditalConselho.Dominio;
using EditalConselho.Dominio.Interface;
using EditalConselho.Infra.Database;
using System.Linq;

namespace EditalConselho.Infra.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly EditalContexto _contexto;

        public UsuarioRepositorio(EditalContexto contexto)
        {
            _contexto = contexto;
        }

        public Usuario ObterUsuarioPorId(int idUsuario)
        {
            return _contexto.Usuario.FirstOrDefault(d => d.Id == idUsuario);
        }
    }
}
