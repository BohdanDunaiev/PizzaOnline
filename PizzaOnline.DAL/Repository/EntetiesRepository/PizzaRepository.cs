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
    public class PizzaRepository : GenericRepository<Pizza>, IPizzaRepository
    {
        public PizzaRepository(AplicationContext _context)
            : base(_context)
        {           
        }
        public async Task<IEnumerable<Pizza>> GetPizzaId(int id)
        {
            var res = _context.Pizza.Where(x => x.Id == id);
            return res;
        }
        public async Task<IEnumerable<Pizza>> GetPizzaPriceRange(int maxPrice, int minPrice)
        {
            var res = _context.Pizza.Where(x => x.Price >= minPrice && x.Price <= maxPrice);
            return res;
        }
        public async Task<IEnumerable<Pizza>> GetPizzaName(string namepizza)
        {
            var res = _context.Pizza.Where(x => x.NamePizza == namepizza);
            return res;
        }
        public async Task<IEnumerable<Pizza>> GetPopular()
        {
            var res1 = _context.Pizza
                .OrderByDescending(e => e.Orders.Count());
            return res1;
        }
        public async Task<IEnumerable<Pizza>> GetPopularIngredients()
        {
            var res1 = _context.Pizza
                .OrderByDescending(e => e.Ingredients.Count());
            return res1;
        }
    }
}
