namespace EditalConselho.Dominio.Interface
{
    public interface IUsuarioRepositorio
    {
        bool CadastrarUsuario(Usuario usuario);
        Usuario BuscarUsuario(LoginDto login);
        bool DeletarUsuario(LoginDto usuario);
        bool AtualizarUsuario(Usuario usuario);
    }
}
