using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Productos.Core.Entities;
using Productos.Core.Entities.DTO;
using Productos.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace Productos.Core.Services
{
    public class ProductoPasivoServices : IProductoPasivoServices
    {
        private readonly ILogger<ProductoPasivoServices> _logger;
        private readonly IOptions<Parametros> _parametros;
        public ProductoPasivoServices(ILogger<ProductoPasivoServices> logger,
            IOptions<Parametros> parametros)
        {
            _logger = logger;
            _parametros = parametros;
        }

        public async Task<ProductoPasivoResponse> GetListadoAsync(int idEnte)
        {
            throw new NotImplementedException();
        }
    }
}
