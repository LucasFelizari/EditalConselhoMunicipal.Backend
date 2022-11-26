using EditalConselho.Dominio;
using EditalConselho.Dominio.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Text.RegularExpressions;

namespace EditalConselho.Api.Controllers
{
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioAplicacao _usuarioAplicacao;

        public UsuarioController(IServiceProvider provider)
        {
            _usuarioAplicacao = provider.GetRequiredService<IUsuarioAplicacao>();
        }

        [HttpGet("Login"), ActionName("Login")]
        [ProducesResponseType(200), ProducesResponseType(400), ProducesResponseType(500)]
        public IActionResult Login(LoginDto login)
        {
            try
            {
                bool sucesso = _usuarioAplicacao.Login(login);

                if (!sucesso) return Unauthorized("Email inválido.");

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("RegistrarUsuario"), ActionName("RegistrarUsuario")]
        [ProducesResponseType(200), ProducesResponseType(400), ProducesResponseType(500)]
        public IActionResult RegistrarUsuario(Usuario usuario)
        {
            try
            {
                //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                //if (!regex.IsMatch(usuario.Email))
                //    return Unauthorized();

                return Ok(_usuarioAplicacao.RegistrarUsuario(usuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
