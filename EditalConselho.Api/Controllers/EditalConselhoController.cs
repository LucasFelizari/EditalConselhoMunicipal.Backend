using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditalConselho.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EditalConselhoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return null;
          
        }
    }
}
