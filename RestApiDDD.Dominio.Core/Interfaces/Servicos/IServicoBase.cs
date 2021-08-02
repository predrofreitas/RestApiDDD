using System.Collections;
using System.Collections.Generic;

namespace RestApiDDD.Dominio.Core.Interfaces.Servicos
{
    public interface IServicoBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
