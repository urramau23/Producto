using Productos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Core.Interfaces
{
    public interface ITarjetaCreditoServices
    {
        Task<TarjetaCreditoResponse> GetTarjetaCreditoAsync(string sexo, string documento);
    }
}
