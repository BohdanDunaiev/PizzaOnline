using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Models;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Repository.EntetiesRepository
{
    public class OrderRepository : GenericRepository<Order, int>, IOrderRepository
    {
        public OrderRepository(AplicationContext aplicationContext)
            : base(aplicationContext)
        {           
        }
        public async Task<Order> GetOrderId(int id)
        {
            var res = await _context.Order
                .Include(i => i.Customer)
                .Include(i => i.Pizza)
                .Include(i => i.Pizzeria)
                .Include(i => i.Delivery)
                .Where(j => j.Id == id)
                .FirstOrDefaultAsync();
            return res;
        }
        public async Task<PagedList<Order>> GetOrder(OrderQueryParameters parameters)
        {
            return await PagedList<Order>.ToPagedListAsync(_dbSet, parameters.PageNumber, parameters.PageSize);
        }
    }
}