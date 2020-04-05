using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.DAL.Entities;

namespace PizzaOnline2.DAL.Interface.IServices
{
    public interface IPizzeriaService
    {
        Task<IEnumerable<Pizzeria>> GetAllPizzeria();
        Task<Pizzeria> GetByIdPizzeria(int id);
        Task<Pizzeria> InsertPizzeria(Pizzeria obj);
        Task<Pizzeria> UpdatePizzeria(Pizzeria obj, object key);
        Task<int> DeletePizzeria(Pizzeria id);        
    }
}
