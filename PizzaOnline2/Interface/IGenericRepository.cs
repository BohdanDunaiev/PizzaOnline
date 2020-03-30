using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline2.Repository.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class 
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity id);       
    }
}
