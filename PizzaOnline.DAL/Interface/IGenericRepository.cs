using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline.DAL.Repository.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class 
    {
        Task<IEnumerable<TEntity>> GetAllAsyn();
        Task<TEntity> GetByIdAsyn(int id);
        Task<TEntity> InsertAsyn(TEntity obj);
        void UpdateAsyn(TEntity obj);
        Task<int> DeleteAsyn(TEntity id);       
    }
}
