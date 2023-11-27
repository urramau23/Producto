using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Productos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamoController : ControllerBase
    {
        private readonly ILogger<PrestamoController> _logger;

        public PrestamoController(ILogger<PrestamoController> logger)
        {
            _logger = logger;
        }

        /*[HttpGet("{id_columbia}")]
        public Task<IActionResult> Get(string id_columbia)
        {
            return Ok();
        }*/
    }
}
