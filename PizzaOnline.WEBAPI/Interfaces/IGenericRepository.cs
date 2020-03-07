using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Interfaces.EntityInterfaces
{
    public interface IGenericRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(TId Id);

        //int Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TId Id);
    }
}
