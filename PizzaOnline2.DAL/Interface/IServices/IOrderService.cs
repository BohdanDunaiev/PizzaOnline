using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.DAL.Entities;

namespace PizzaOnline2.DAL.Interface.IServices
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetByIdOrder(int id);
        Task<Order> InsertOrder(Order obj);
        Task<Order> UpdateOrder(Order obj, object key);
        Task<int> DeleteOrder(Order id);        
    }
}
