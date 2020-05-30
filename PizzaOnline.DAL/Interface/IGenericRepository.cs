using PizzaOnline.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PizzaOnline.DAL.Repository.GenericRepository
{
    public interface IGenericRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        Task<IEnumerable<TEntity>> GetAllAsyn();
        Task<TEntity> GetByIdAsyn(TId id);
        Task<int> InsertAsyn(TEntity obj);
        Task UpdateAsyn(TEntity obj);
        Task DeleteAsyn(TId id);
        IQueryable<TEntity> FindByConditionAsync(Expression<Func<TEntity, bool>> expression);
    }
}
