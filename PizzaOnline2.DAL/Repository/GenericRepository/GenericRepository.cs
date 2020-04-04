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
        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsEnumerable();
        }
        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Insert(TEntity obj)
        {
            if (obj == null) throw new ArgumentNullException("entity");
            _dbSet.Add(obj);
            _context.SaveChanges();
        }
        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(TEntity obj)
        {           
            _dbSet.Remove(obj);
            _context.SaveChanges();
        }
    }
}
