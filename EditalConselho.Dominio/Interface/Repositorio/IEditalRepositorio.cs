using EditalConselho.Dominio.Classes;
using System.Collections.Generic;

namespace EditalConselho.Dominio.Interface
{
    public interface IEditalRepositorio
    {
        bool CadastrarEdital(Edital edital);
        Edital BuscarEdital(int IdEdital);
        bool DeletarEdital(Edital edital);
        bool AtualizarEdital(Edital edital);
        List<Edital> BuscarEditalPorUsuario(int IdUsuario);
        int ObterIdArquivoLivre(int IdUsuario);
    }
}
