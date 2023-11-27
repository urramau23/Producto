using Productos.API.Configurations;
using Productos.Core.Entities.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Productos.Core.Interfaces;

namespace Productos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ModelValidationFilter))]
    public class DemoController : ControllerBase
    {
        private readonly ICoreTarjetasGateway _coreTarjetasGateway;
        public DemoController(ICoreTarjetasGateway coreTarjetasGateway)
        {
            _coreTarjetasGateway = coreTarjetasGateway;

        }
        [HttpGet]
        public IActionResult demo(int numero)
        {
            if (numero == 0)
                throw new BusinessException("Error Negocio simulado");

            if (numero == 1)
            {
                throw new InternalServerErrorException("Error Interno Servidor Simulado");
            }
            return Ok();
        }

        [HttpGet("socdox/{sexo}/{documento}")]
        public async Task<IActionResult> socdox(string sexo, string documento)
        {
            return Ok(await _coreTarjetasGateway.SOCDOX(sexo, documento));
        }

        [HttpGet("soccyt/{marcacodi}/{cuenta}")]
        public async Task<IActionResult> soccyt(string marcacodi, string cuenta)
        {
            return Ok(await _coreTarjetasGateway.SOCCYT(marcacodi, cuenta));
        }

        [HttpGet("somlyd/{tarjenume}/{cuenta}")]
        public async Task<IActionResult> somlyd(string tarjenume)
        {
            return Ok(await _coreTarjetasGateway.SOMLYD_WEB(tarjenume));
        }
    }
}
