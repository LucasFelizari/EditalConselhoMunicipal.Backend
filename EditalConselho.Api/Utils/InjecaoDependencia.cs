using EditalConselho.Aplicacao;
using EditalConselho.Dominio.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace EditalConselho.Api.Utils
{
    public static class InjecaoDependencia
    {
        public static void Injetar(IServiceCollection services)
        {
            services.AddScoped<IEditalAplicacao, EditalAplicacao>();
        }
    }
}
