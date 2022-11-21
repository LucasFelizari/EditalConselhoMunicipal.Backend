using EditalConselho.Dominio;
using Microsoft.AspNetCore.Mvc;
using System;

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
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
