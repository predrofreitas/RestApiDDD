using RestApiDDD.Dominio.Core.Interfaces.Repositorios;
using RestApiDDD.Dominio.Core.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace RestApiDDD.Dominio.Servico
{
    public class ServicoBase<TEntity> : IServicoBase<TEntity> where TEntity : class
    {
        private readonly IRepositorioBase<TEntity> _repositorioBase;

        public ServicoBase(IRepositorioBase<TEntity> repositorioBase)
        {
            _repositorioBase = repositorioBase;
        }

        public void Add(TEntity obj)
        {
            _repositorioBase.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositorioBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repositorioBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _repositorioBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repositorioBase.Update(obj);
        }
    }
}
