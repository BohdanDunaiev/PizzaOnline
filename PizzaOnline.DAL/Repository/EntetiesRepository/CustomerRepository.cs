using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Repository.EntetiesRepository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AplicationContext aplicationContext)
            : base(aplicationContext)
        {

        }
    }
}
