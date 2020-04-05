using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Interface;
using PizzaOnline2.DAL.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline2.DAL.Services
{
    public class CustomerService : ICustomerService
    {
        IUnitOfWork _unitOfWork;
        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _unitOfWork.CustomerRepository.GetAllAsyn();
        }
        public async Task<Customer> GetByIdCustomer(int id)
        {
            return await _unitOfWork.CustomerRepository.GetByIdAsyn(id);
        }
        public async Task<Customer> InsertCustomer(Customer customer)
        {
            return await _unitOfWork.CustomerRepository.InsertAsyn(customer);
        }
        public async Task<Customer> UpdateCustomer(Customer customer, object key)
        {
            return await _unitOfWork.CustomerRepository.UpdateAsyn(customer, key);
        }
        public async Task<int> DeleteCustomer(Customer id)
        {
            return await _unitOfWork.CustomerRepository.DeleteAsyn(id);
        }        
    }
}
