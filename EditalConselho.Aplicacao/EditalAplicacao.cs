using EditalConselho.Dominio.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EditalConselho.Aplicacao
{
    public class EditalAplicacao : IEditalAplicacao
    {
        private readonly IEditalRepositorio _editalRepositorio;

        public EditalAplicacao(IServiceProvider provider)
        {
            _editalRepositorio = provider.GetRequiredService<IEditalRepositorio>();
        }
    }
}
