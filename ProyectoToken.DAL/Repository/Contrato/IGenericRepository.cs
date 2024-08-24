using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoToken.DAL.Repository.Contrato
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Obtener(Expression<Func<T, bool>> filtro);

        Task<T> Crear(T entidad);

        Task<bool> Editar(T entidad);

        Task<bool> Eliminar(T entidad);

        Task<IQueryable<T>> ObtenerTodos(Expression<Func<T, bool>> filtro = null);
    }
}
