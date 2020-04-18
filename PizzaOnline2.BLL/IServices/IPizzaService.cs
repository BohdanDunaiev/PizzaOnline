using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaOnline.BLL.DTOEntities;

namespace PizzaOnline2.BLL.IServices
{
    public interface IPizzaService
    {
        Task<IEnumerable<DTOPizza>> GetAllPizza();
        Task<DTOPizza> GetByIdPizza(int id);
        Task InsertPizza(DTOPizza obj);
        Task UpdatePizza(DTOPizza obj);
        Task DeletePizza(int id);       
    }
}
