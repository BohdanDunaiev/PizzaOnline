using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Models;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Interface.IRepository
{
    public interface IPizzaRepository : IGenericRepository<Pizza, int>
    {
        public Task<Pizza> GetPizzaId(int id);
        public Task<PagedList<Pizza>> GetPizza(PizzaQueryParameters pizzaquery);
        public Task<int> GetPizzaCountAsync(PizzaQueryParameters parameters);
        //Task<IEnumerable<Pizza>> GetPizzaName(string namepizza);
        //Task<IEnumerable<Pizza>> GetPizzaPriceRange(int maxPrice, int minPrice);
        //Task<IEnumerable<Pizza>> GetPopular();
        //Task<IEnumerable<Pizza>> GetPopularIngredients();
    }
}
