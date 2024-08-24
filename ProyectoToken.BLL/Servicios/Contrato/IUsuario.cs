using ProyectoToken.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoToken.BLL.Servicios.Contrato
{
    public interface IUsuario
    {
        Task<List<UsuarioDTO>> ObtenerTodos();

        Task<UsuarioDTO> registrar(UsuarioDTO usuarioDTO);

        Task<bool> editar(UsuarioDTO usuarioDTO);

        Task<bool> Eliminar(int id);

        Task<UsuarioDTO> ObtenerPorId(int id);
    }
}
