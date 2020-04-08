using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PizzaOnline2.DAL.Repository.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly AplicationContext _context;
        private Microsoft.EntityFrameworkCore.DbSet<TEntity> _dbSet;
        public GenericRepository(AplicationContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public async Task<IEnumerable<TEntity>> GetAllAsyn()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        public async Task<TEntity> GetByIdAsyn(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
        public  async Task<TEntity> InsertAsyn(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            await _context.SaveChangesAsync();
            return obj;
        }
        public async void UpdateAsyn(TEntity obj)
        {
            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;                    
        }
        public async Task<int> DeleteAsyn(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            return await _context.SaveChangesAsync();
        }
    }
}
