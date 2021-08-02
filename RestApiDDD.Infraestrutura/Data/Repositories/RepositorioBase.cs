using Microsoft.EntityFrameworkCore;
using RestApiDDD.Dominio.Core.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiDDD.Infraestrutura.Data.Repositorios
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _sqlContext;

        public RepositorioBase(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                _sqlContext.Add(obj);
                _sqlContext.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _sqlContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _sqlContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {
                _sqlContext.Set<TEntity>().Remove(obj);
                _sqlContext.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                _sqlContext.Entry(obj).State = EntityState.Modified;
                _sqlContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
