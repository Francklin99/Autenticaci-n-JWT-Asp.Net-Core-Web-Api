using Microsoft.EntityFrameworkCore;
using ProyectoToken.DAL.Repository.Contrato;
using ProyectoToken.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoToken.DAL.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbautenticacionContext _context;

        public GenericRepository(DbautenticacionContext context)
        {
            _context = context;
        }

        public Task<T> Crear(T entidad)
        {
            try
            {
                _context.Add(entidad);
                _context.SaveChanges();
                return Task.FromResult(entidad);
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Editar(T entidad)
        {
            try
            {
                _context.Update(entidad);
               await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Eliminar(T entidad)
        {
            try
            {
                _context.Remove(entidad);
               await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public async Task<T> Obtener(Expression<Func<T, bool>> filtro)
        {
            try
            {
                T model=await _context.Set<T>().FirstOrDefaultAsync(filtro);
                return model;
            }
            catch
            {
                throw;
            }
        }

        public async Task<IQueryable<T>> ObtenerTodos(Expression<Func<T, bool>> filtro = null)
        {
            try
            {
                IQueryable<T> query =_context.Set<T>();
                if (filtro != null)
                {
                    query = query.Where(filtro);
                }
                return query;
                
}
            catch
            {
                throw;
            }
      
        }
    }
}
