using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Repository.EntetiesRepository
{
    public class IngredientsRepository : GenericRepository<Ingredients>, IIngredientsRepository
    {
        public IngredientsRepository(AplicationContext _context)
            : base(_context)
        {
        }
        public async Task<IEnumerable<Ingredients>> GetIngredientId(int id)
        {
            var res = _context.Ingredients.Where(x => x.Id == id);
            return res;
        }
    }
}
