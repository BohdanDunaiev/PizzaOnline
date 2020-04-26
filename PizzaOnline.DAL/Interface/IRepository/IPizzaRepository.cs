using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Interface.IRepository
{
    public interface IPizzaRepository : IGenericRepository<Pizza>
    {

        Task<IEnumerable<Pizza>> GetPopular();
        Task<IEnumerable<Pizza>> GetPopularIngredients();
        Task<IEnumerable<Pizza>> GetPizzaName(string namepizza);
        Task<IEnumerable<Pizza>> GetPizzaId(int id);
        Task<IEnumerable<Pizza>> GetPizzaPriceRange(int maxPrice, int minPrice);
    }
}
