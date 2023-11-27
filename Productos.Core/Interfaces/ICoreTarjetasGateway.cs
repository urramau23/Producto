using Productos.Core.Entities.DTO;
using System.Threading.Tasks;

namespace Productos.Core.Interfaces
{
    public interface ICoreTarjetasGateway
    {
        Task<SocdoxResponse> SOCDOX(string sexo, string documento);
        Task<SoccytResponse> SOCCYT(string marcacodi, string cuenta);
        Task<SomlydWebResponse> SOMLYD_WEB(string tarjenume);
        Task<SovlydWebResponse> SOVLYD_WEB(string tarjenume);
    }
}
