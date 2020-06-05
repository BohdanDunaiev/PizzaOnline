using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Models;

namespace PizzaOnline2.BLL.IServices
{
    public interface IPizzaService
    {   
        Task<IEnumerable<DTOPizza>> GetAllPizza();
        Task<DTOPizza> GetByIdPizza(int id);
        Task<int> AddPizza(DTOPizza obj);
        Task UpdatePizza(DTOPizza obj);
        Task DeletePizza(int id);
        //repository
        Task<Pizza> GetPizzaId(int id);
        Task<PagedList<DTOPizza>> GetPizza(PizzaQueryParameters pizzaquery);
        Task<int> GetPizzaCountAsync(PizzaQueryParameters parameters);
        //Task<IEnumerable<DTOPizza>> GetPizzaPriceRange(int maxPrice, int minPrice);
        //Task<IEnumerable<DTOPizza>> GetPopular();
        //Task<IEnumerable<DTOPizza>> GetPizzaName(string namepizza);
        //Task<IEnumerable<DTOPizza>> GetPopularIngredients();
    }
}
