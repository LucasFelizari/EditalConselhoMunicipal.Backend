namespace EditalConselho.Dominio.Interface
{
    public interface IUsuarioAplicacao
    {
        bool Login(LoginDto login);
        bool RegistrarUsuario(Usuario usuario);
        bool DeletarUsuario(LoginDto login);
    }
}
