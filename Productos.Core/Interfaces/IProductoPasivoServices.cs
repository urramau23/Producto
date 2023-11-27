using Productos.Core.Entities;
using System.Threading.Tasks;

namespace Productos.Core.Interfaces
{
    public interface IProductoPasivoServices
    {
        Task<ProductoPasivoResponse> GetListadoAsync(int idEnte);
    }
}