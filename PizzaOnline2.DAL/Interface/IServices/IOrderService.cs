using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline2.DAL.Entities;

namespace PizzaOnline2.DAL.Interface.IServices
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        Order GetByIdOrder(int id);
        void InsertOrder(Order obj);
        void UpdateOrder(Order obj);
        void DeleteOrder(Order id);
    }
}
