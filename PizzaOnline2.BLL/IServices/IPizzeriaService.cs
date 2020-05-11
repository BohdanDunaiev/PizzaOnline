using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.BLL.DTOEntities;

namespace PizzaOnline2.BLL.IServices
{
    public interface IPizzeriaService
    {
        Task<IEnumerable<DTOPizzeria>> GetAllPizzeria();
        Task<DTOPizzeria> GetByIdPizzeria(int id);
        Task InsertPizzeria(DTOPizzeria obj);
        Task UpdatePizzeria(DTOPizzeria obj);
        Task DeletePizzeria(int id);
        //repository
        Task<DTOPizzeria> GetPizzeriaId(int id);
        //Task<IEnumerable<DTOPizzeria>> GetPopular();
        //Task<IEnumerable<DTOPizzeria>> GetPizzeriaName(string namepizzeria);
        //Task<IEnumerable<DTOPizzeria>> GetPizzeriaLocation(string address);
    }
}
