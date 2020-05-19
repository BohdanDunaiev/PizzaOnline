using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Models;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Interface.IRepository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        public Task<PagedList<Order>> GetOrder(OrderQueryParameters orderquery);
        public Task<Order> GetOrderId(int id);
    }
}
