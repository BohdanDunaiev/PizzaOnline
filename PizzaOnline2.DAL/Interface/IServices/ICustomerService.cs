using PizzaOnline2.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline2.DAL.Interface.IServices
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetByIdCustomer(int id);
        void InsertCustomer(Customer obj);
        void UpdateCustomer(Customer obj);
        void DeleteCustomer(Customer id);
    }
}
