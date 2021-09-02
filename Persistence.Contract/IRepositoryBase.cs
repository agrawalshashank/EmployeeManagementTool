using System;
using System.Collections;
using System.Collections.Generic;

namespace Persistence.Contract
{
    public interface IRepositoryBase<TEntity>
    {
        void Create(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Update(int id, TEntity entity);
        void Delete(int id);
    }
}
