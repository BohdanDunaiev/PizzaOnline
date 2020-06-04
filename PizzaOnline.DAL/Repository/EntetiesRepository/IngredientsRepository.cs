using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Repository.EntetiesRepository
{
    public class IngredientsRepository : GenericRepository<Ingredients, int>, IIngredientsRepository
    {
        public IngredientsRepository(AplicationContext _context)
            : base(_context)
        {
        }
        public async Task<Ingredients> GetIngredById(int Id)
        {
            return await _dbSet.FindAsync(Id);
        }
    }
}
