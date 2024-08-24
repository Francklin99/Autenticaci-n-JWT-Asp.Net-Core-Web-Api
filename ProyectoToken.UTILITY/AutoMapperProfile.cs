using AutoMapper;
using ProyectoToken.DTO;
using ProyectoToken.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoToken.UTILITY
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() {

            #region Usuario

            CreateMap<Usuario, UsuarioDTO>().ReverseMap();

            #endregion Usuario

        }
    }
}
