using EditalConselho.Dominio;
using EditalConselho.Dominio.Interface;
using EditalConselho.Infra.Database;
using System;
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
            try
            {
                return _contexto.Usuario.FirstOrDefault(d => d.Id == idUsuario);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string ObterSenhaUsuario(string loginUsuario)
        {
            try
            {
                return _contexto.Usuario.FirstOrDefault(u => u.Login.Equals(loginUsuario.Trim())).Senha;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ObterIdUsuarioLivre()
        {
            try
            {
                return _contexto.Usuario.Last().Id + 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //TODO: Verificar retorno dessa função.
        public bool CadastrarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioTemp = _contexto.Usuario.Add(usuario).Entity;
                _contexto.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //TODO: Verificar retorno dessa função.
        public Usuario AtualizarUsuario(Usuario usuario)
        {
            try
            {
                var usuarioTemp = _contexto.Usuario.Update(usuario).Entity;
                _contexto.SaveChanges();

                return usuarioTemp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
