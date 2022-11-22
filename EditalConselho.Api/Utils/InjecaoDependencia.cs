using EditalConselho.Aplicacao;
using EditalConselho.Dominio.Interface;
using EditalConselho.Infra.Repositorio;
using Microsoft.Extensions.DependencyInjection;

namespace EditalConselho.Api.Utils
{
    public static class InjecaoDependencia
    {
        public static void Injetar(IServiceCollection services)
        {
            services.AddScoped<IEditalAplicacao, EditalAplicacao>();
            services.AddScoped<IUsuarioAplicacao, UsuarioAplicacao>();

            services.AddScoped<IEditalRepositorio, EditalRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
        }
    }
}
