using EditalConselho.Dominio;
using EditalConselho.Dominio.Interface;
using System.Text.RegularExpressions;

namespace EditalConselho.Aplicacao
{
    public class UsuarioAplicacao : IUsuarioAplicacao
    {
        public bool Login(LoginDto login)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.IsMatch(login.Email))
                return false;
            else return true;

            //se login.usuario for encontrado no banco de dados
            //      valida senha informada com a salva no banco de dados.
            //          caso informações estejam ok, return ok();
            //      caso senha não bata, return senha inválida.
            //se não for encontrado return usuário não encontrado.
        }
    }
}
