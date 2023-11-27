using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Productos.Core.Interfaces;
using Productos.Infrastructure.Gateway;

namespace Productos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaCreditoController : ControllerBase
    {
        private readonly ITarjetaCreditoServices _tarjetaCreditoServices;
        public TarjetaCreditoController(ITarjetaCreditoServices tarjetaCreditoServices)
        {
            _tarjetaCreditoServices = tarjetaCreditoServices;
        }
        [HttpGet("{sexo}/{documento}")]
        public async Task<IActionResult> socdox(string sexo, string documento)
        {
            return Ok(await _tarjetaCreditoServices.GetTarjetaCreditoAsync(sexo, documento));
        }
    }
}
