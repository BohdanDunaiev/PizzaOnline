using PizzaOnline.DAL.Interfaces;
using PizzaOnline.DAL.Interfaces.EntityInterfaces.SQLInterfaces.ISQLServices;
using PizzaOnline.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Services.SQLServices
{
    public class SQLOrderService : ISQLOrderService
    {
        ISQLunitOfWork _SqlsqlunitOfWork;
        public SQLOrderService(ISQLunitOfWork sqlsqlunitOfWork)
        {
            _SqlsqlunitOfWork = sqlsqlunitOfWork;
        }

        public IEnumerable<SQLOrder> GetAllOrders()
        {
            return _SqlsqlunitOfWork.SQLOrderRepository.GetAll();
        }

        public SQLOrder GetOrderById(int Id)
        {
            return _SqlsqlunitOfWork.SQLOrderRepository.Get(Id);
        }
        //public int AddOrder(SQLOrder order)
        //{
        //    return _SqlsqlunitOfWork.SQLOrderRepository.Add(order);
        //}
        public void DeleteOrder(int Id)
        {
            _SqlsqlunitOfWork.SQLOrderRepository.Delete(Id);
        }

        public void Update(SQLOrder entity)
        {
            _SqlsqlunitOfWork.SQLOrderRepository.Update(entity);
        }
    }
}
