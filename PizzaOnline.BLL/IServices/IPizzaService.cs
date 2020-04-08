using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.DAL.Entities;

namespace PizzaOnline2.BLL.IServices
{
    public interface IPizzaService
    {
        Task<IEnumerable<Pizza>> GetAllPizza();
        Task<Pizza> GetByIdPizza(int id);
        Task<Pizza> InsertPizza(Pizza obj);
        void UpdatePizza(Pizza obj);
        Task<int> DeletePizza(Pizza id);       
    }
}
