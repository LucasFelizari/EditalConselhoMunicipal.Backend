using EditalConselho.Dominio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.RegularExpressions;

namespace EditalConselho.Api.Controllers
{
    public class UsuarioController : ControllerBase
    {
        [HttpGet("Login"), ActionName("Login")]
        [ProducesResponseType(200), ProducesResponseType(400), ProducesResponseType(500)]
        public IActionResult Login(LoginDto login)
        {
            try
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!regex.IsMatch(login.Email))
                    return Unauthorized("Email inválido.");

                //se login.usuario for encontrado no banco de dados
                //      valida senha informada com a salva no banco de dados.
                //          caso informações estejam ok, return ok();
                //      caso senha não bata, return senha inválida.
                //se não for encontrado return usuário não encontrado.

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
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!regex.IsMatch(usuario.Email))
                    return Unauthorized();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
