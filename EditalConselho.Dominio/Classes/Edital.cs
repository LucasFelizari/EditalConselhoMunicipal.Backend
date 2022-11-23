using System;

namespace EditalConselho.Dominio.Classes
{
    public class Edital
    {
        public int IdUsuario { get; set; }
        public int IdArquivo { get; set; }
        public byte[] Arquivo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEnvio { get; set; }
        public string Titulo { get; set; }
    }
}
