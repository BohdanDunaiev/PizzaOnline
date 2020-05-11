using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Models;

namespace PizzaOnline2.BLL.IServices
{
    public interface IOrderService
    {
        Task<IEnumerable<DTOOrder>> GetAllOrders();
        Task<DTOOrder> GetByIdOrder(int id);
        Task InsertOrder(DTOOrder obj);
        Task UpdateOrder(DTOOrder obj);
        Task DeleteOrder(int id);
        //repository
        public  PagedList<DTOOrder> GetOrder(OrderQueryParameters orderquery);
        public Task<Order> GetOrderId(int id);
    }
}
