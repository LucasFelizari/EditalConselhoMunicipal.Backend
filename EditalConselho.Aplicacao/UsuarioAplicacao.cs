using EditalConselho.Dominio;
using EditalConselho.Dominio.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Text.RegularExpressions;

namespace EditalConselho.Aplicacao
{
    public class UsuarioAplicacao : IUsuarioAplicacao
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioAplicacao(IServiceProvider provider)
        {
            _usuarioRepositorio = provider.GetRequiredService<IUsuarioRepositorio>();
        }

        public bool DeletarUsuario(LoginDto login)
        {
            try
            {
                return _usuarioRepositorio.DeletarUsuario(login);
            }
            catch
            {
                return false;
            }
        }

        public bool Login(LoginDto login)
        {
            try
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!regex.IsMatch(login.Email))
                    if (_usuarioRepositorio.BuscarUsuario(login) != null)
                        return true;

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RegistrarUsuario(Usuario usuario)
        {
            return _usuarioRepositorio.CadastrarUsuario(usuario);
        }
    }
}
