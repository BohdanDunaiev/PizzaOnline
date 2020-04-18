using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline.BLL.DTOEntities;

namespace PizzaOnline2.BLL.IServices
{
    public interface IOrderService
    {
        Task<IEnumerable<DTOOrder>> GetAllOrders();
        Task<DTOOrder> GetByIdOrder(int id);
        Task InsertOrder(DTOOrder obj);
        Task UpdateOrder(DTOOrder obj);
        Task DeleteOrder(int id);        
    }
}
