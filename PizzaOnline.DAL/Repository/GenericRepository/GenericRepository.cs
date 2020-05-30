using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PizzaOnline.DAL.Interface;

namespace PizzaOnline.DAL.Repository.GenericRepository
{
    public class GenericRepository<TEntity,TId> : IGenericRepository<TEntity, TId> where TEntity : class,IEntity<TId>
    {
        protected readonly AplicationContext _context;
        protected DbSet<TEntity> _dbSet;
        public GenericRepository(AplicationContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }        
        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return this._context.Set<TEntity>()
                .Where(expression)
                .AsNoTracking();
        }
        public async Task<IEnumerable<TEntity>> GetAllAsyn()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<TEntity> GetByIdAsyn(TId id)  
        {
            return await _dbSet.FindAsync(id);
        }
        public  async Task<int> InsertAsyn(TEntity obj)
        {
            //_dbSet.Add(obj);
            //await _context.SaveChangesAsync();
            //return obj; 
            _dbSet.Add(obj);
            await _context.SaveChangesAsync();
            try
            {
                return Int32.Parse(obj.Id.ToString());
            }
            catch
            {
                return 0;
            }
        }
        public async Task UpdateAsyn(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();                              
        }
        public async Task DeleteAsyn(TId id)
        {
            TEntity x = await _dbSet.FindAsync(id);
            _dbSet.Remove(x);
            await _context.SaveChangesAsync();
        }
        public IQueryable<TEntity> FindByConditionAsync(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
