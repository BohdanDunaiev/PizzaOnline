using PizzaOnline.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Interfaces.EntityInterfaces.SQLInterfaces.ISQLServices
{
    public interface ISQLOrderService
    {
        IEnumerable<SQLOrder> GetAllOrders();
        SQLOrder GetOrderById(int Id);
        //int AddOrder(SQLOrder order);
        void Update(SQLOrder entity);
        void DeleteOrder(int Id);
    }
}
