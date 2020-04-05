using PizzaOnline2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline2.DAL.Interface.IServices
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetByIdCustomer(int id);
        Task<Customer> InsertCustomer(Customer obj);
        Task<Customer> UpdateCustomer(Customer obj, object key);
        Task<int> DeleteCustomer(Customer id);                
    }
}
