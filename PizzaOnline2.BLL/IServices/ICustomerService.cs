using PizzaOnline.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline2.BLL.IServices
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetByIdCustomer(int id);
        Task<Customer> InsertCustomer(Customer obj);
        void UpdateCustomer(Customer obj);
        Task<int> DeleteCustomer(Customer id);                
    }
}
