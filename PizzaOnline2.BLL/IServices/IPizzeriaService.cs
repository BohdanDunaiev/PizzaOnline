using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline.DAL.Entities;

namespace PizzaOnline2.BLL.IServices
{
    public interface IPizzeriaService
    {
        Task<IEnumerable<Pizzeria>> GetAllPizzeria();
        Task<Pizzeria> GetByIdPizzeria(int id);
        Task<Pizzeria> InsertPizzeria(Pizzeria obj);
        void UpdatePizzeria(Pizzeria obj);
        Task<int> DeletePizzeria(Pizzeria id);        
    }
}
