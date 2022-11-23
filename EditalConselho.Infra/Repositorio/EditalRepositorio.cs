using EditalConselho.Dominio;
using EditalConselho.Dominio.Classes;
using EditalConselho.Dominio.Interface;
using EditalConselho.Infra.Database;
using System.Collections.Generic;
using System.Linq;

namespace EditalConselho.Infra.Repositorio
{
    public class EditalRepositorio : IEditalRepositorio
    {
        private readonly EditalContexto _contexto;

        public EditalRepositorio(EditalContexto contexto)
        {
            _contexto = contexto;
        }

        public Edital ObterArquivoPorId(int idArquivo)
        {
            return _contexto.Edital.FirstOrDefault(d => d.IdArquivo == idArquivo);
        }

        public List<Edital> ObterArquivoPorUsuario(int idUsuario)
        {
            return _contexto.Edital.Where(d => d.IdUsuario == idUsuario).ToList();
        }
    }
}
