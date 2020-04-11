using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Repository.EntetiesRepository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AplicationContext aplicationContext)
            : base(aplicationContext)
        {

        }
    }
}