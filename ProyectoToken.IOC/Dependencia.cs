using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProyectoToken.BLL.Servicios;
using ProyectoToken.BLL.Servicios.Contrato;
using ProyectoToken.DAL.Repository;
using ProyectoToken.DAL.Repository.Contrato;
using ProyectoToken.MODEL;
using ProyectoToken.UTILITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoToken.IOC
{
   public static class Dependencia
    {
        public static void InyectarDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbautenticacionContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
            });

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddScoped<IAutorizacionService, AutorizacionService>();


        }
    }
}
