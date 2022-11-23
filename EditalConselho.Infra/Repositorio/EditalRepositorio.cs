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
            catch (Exception)
            {
                return null;
            }
        }

        public List<Edital> ObterEditalPorUsuario(int idUsuario)
        {
            try
            {
                return _contexto.Edital.Where(d => d.IdUsuario == idUsuario).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        //TODO: Verificar retorno dessa função.
        public Edital CadastrarEdital(Edital edital)
        {
            try
            {
                var arquivo = _contexto.Add(edital).Entity;
                _contexto.SaveChanges();

                return arquivo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ObterIdArquivoLivre(int idUsuario)
        {
            try
            {
                return _contexto.Edital.Last(a => a.IdUsuario == idUsuario).IdArquivo + 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //TODO: Verificar retorno dessa função.
        public Edital AtualizarEdital(Edital edital)
        {
            try
            {
                var arquivo = _contexto.Edital.Update(edital).Entity;
                _contexto.SaveChanges();
                return arquivo;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
