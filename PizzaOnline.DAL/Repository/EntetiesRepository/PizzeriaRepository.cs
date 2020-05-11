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
    public class PizzeriaRepository : GenericRepository<Pizzeria>, IPizzeriaRepository
    {
        public PizzeriaRepository(AplicationContext _context)
            : base(_context)
        {
        }
        public async Task<Pizzeria> GetPizzeriaId(int id)
        {
            var res = await _context.Pizzeria
               .Include(i => i.Orders)
               .Where(j => j.Id == id)
               .FirstOrDefaultAsync();
            return res;   
        }       
        //public async Task<IEnumerable<Pizzeria>> GetPizzeriaName(string namepizzeria)
        //{
        //    var res = _context.Pizzeria.Where(x => x.NamePizzeria == namepizzeria);
        //    return res;
        //}
        //public async Task<IEnumerable<Pizzeria>> GetPizzeriaLocation(string address)
        //{
        //    var res = _context.Pizzeria.Where(x => x.Address == address);
        //    return res;
        //}
        //public async Task<IEnumerable<Pizzeria>> GetPopular()
        //{
        //    var res1 = _context.Pizzeria
        //        .OrderByDescending(e => e.Orders.Count());
        //    return res1;
        //}
    }
}