using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Models;
using PizzaOnline.DAL.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline.DAL.Interface.IRepository
{
    public interface ICustomerRepository : IGenericRepository<Customer, int>
    {
        public Task<PagedList<Customer>> GetCustomer(CustomerQueryParameters customerquery);
        public Task<Customer> GetCustomerId(int id);
    }
}
