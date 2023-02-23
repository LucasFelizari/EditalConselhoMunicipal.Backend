using EditalConselho.Dominio;
using EditalConselho.Dominio.Classes;
using EditalConselho.Dominio.Interface;
using EditalConselho.Infra.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditalConselho.Infra.Repositorio
{
    public class EditalRepositorio : IEditalRepositorio
    {
        private readonly EditalContexto _contexto;

        public EditalRepositorio(EditalContexto contexto)
        {
            _contexto = contexto;
        }

        public Edital ObterEditalPorId(int idArquivo)
        {
            try
            {
                return _contexto.Edital.FirstOrDefault(d => d.IdArquivo == idArquivo);
            }
            catch
            {
                return null;
            }
        }

        public List<Edital> BuscarEditalPorUsuario(int idUsuario)
        {
            try
            {
                return _contexto.Edital.Where(d => d.IdUsuario == idUsuario).ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool CadastrarEdital(Edital edital)
        {
            try
            {
                var objEdital = _contexto.Add(edital).Entity;
                _contexto.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public int ObterIdArquivoLivre(int idUsuario)
        {
            try
            {
                return _contexto.Edital.Last(a => a.IdUsuario == idUsuario).IdArquivo + 1;
            }
            catch
            {
                return 0;
            }
        }

        public bool AtualizarEdital(Edital edital)
        {
            try
            {
                _contexto.Edital.Update(edital);
                _contexto.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool DeletarEdital(Edital edital)
        {
            try
            {
                _contexto.Edital.Remove(edital);
                _contexto.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Edital BuscarEdital(int idArquivo)
        {
            try
            {
                return _contexto.Edital.FirstOrDefault(x => x.IdArquivo== idArquivo);
            }
            catch
            {
                return null;
            }
        }
    }
}
