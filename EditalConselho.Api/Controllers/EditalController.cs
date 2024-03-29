﻿using EditalConselho.Dominio;
using EditalConselho.Dominio.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EditalConselho.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EditalController : ControllerBase
    {
        private readonly IEditalAplicacao _editalAplicacao;

        public EditalController(IServiceProvider provider)
        {
            _editalAplicacao = provider.GetRequiredService<IEditalAplicacao>();
        }

        [HttpPost("RegistrarEdital"), ActionName("RegistrarEdital")]
        [ProducesResponseType(200), ProducesResponseType(400), ProducesResponseType(500)]
        public IActionResult RegistrarEdital()
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

        [HttpGet("BuscarEditaisUsuario"), ActionName("BuscarEditaisUsuario")]
        [ProducesResponseType(200), ProducesResponseType(400), ProducesResponseType(500)]
        public IActionResult BuscarEditaisUsuario(LoginDto login)
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

        [HttpGet("BuscarEnvios"), ActionName("BuscarEnvios")]
        [ProducesResponseType(200), ProducesResponseType(400), ProducesResponseType(500)]
        public IActionResult BuscarEnvios(LoginDto login)
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
