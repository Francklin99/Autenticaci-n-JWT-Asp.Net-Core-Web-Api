using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoToken.BLL.Custom;

namespace ProyectoToken.BLL.Servicios.Contrato
{
     public interface IAutorizacionService
    {
        Task<AutorizacionResponse> DevolverToken(AutorizacionRequest autorize);

        Task<AutorizacionResponse> DevolverRefreshToken(RefreshTokenRequest refreshTokenRequest,int idUsuario);

    }
}
