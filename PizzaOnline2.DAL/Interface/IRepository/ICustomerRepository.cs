using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline2.DAL.Interface.IRepository
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        
    }
}
