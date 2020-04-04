using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Interface;
using PizzaOnline2.DAL.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline2.DAL.Services
{
    public class CustomerService : ICustomerService
    {
        IUnitOfWork _unitOfWork;
        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _unitOfWork.CustomerRepository.GetAll();
        }
        public Customer GetByIdCustomer(int id)
        {
            return _unitOfWork.CustomerRepository.GetById(id);
        }
        public void InsertCustomer(Customer customer)
        {
            _unitOfWork.CustomerRepository.Insert(customer);
        }
        public void UpdateCustomer(Customer customer)
        {
            _unitOfWork.CustomerRepository.Update(customer);
        }
        public void DeleteCustomer(Customer id)
        {
            _unitOfWork.CustomerRepository.Delete(id);
        }        
    }
}
