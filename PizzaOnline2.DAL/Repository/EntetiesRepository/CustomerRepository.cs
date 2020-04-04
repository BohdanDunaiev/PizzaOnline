using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Interface.IRepository;
using PizzaOnline2.DAL.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline2.DAL.Repository.EntetiesRepository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AplicationContext aplicationContext)
            : base(aplicationContext)
        {

        }
    }
}
