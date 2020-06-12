using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface;
using PizzaOnline2.BLL.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Models;

namespace PizzaOnline2.BLL.Services
{
    public class CustomerService : ICustomerService
    {
        IUnitOfWork _unitOfWork; 
        private readonly IMapper _mapper;
        public CustomerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public PagedList<DTOCustomer> GetCustomer(CustomerQueryParameters parameters)
        {
            var x = _unitOfWork.CustomerRepository.GetCustomer(parameters);
            var result = _mapper.Map<PagedList<DTOCustomer>>(x);
            return result;
        }
        public async Task<Customer> GetCustomerId(int id)
        {
            return await _unitOfWork.CustomerRepository.GetCustomerId(id);
        }
        //CRUD
        public async Task<IEnumerable<DTOCustomer>> GetAllCustomer()
        {
            var info = await _unitOfWork.CustomerRepository.GetAllAsyn();

            List<DTOCustomer> transferDTO = new List<DTOCustomer>();

            foreach (var customer in info)
                transferDTO.Add(_mapper.Map<Customer, DTOCustomer>(customer));

            return transferDTO;
        }
        public async Task<DTOCustomer> GetByIdCustomer(int id)
        {
            var info = await _unitOfWork.CustomerRepository.GetByIdAsyn(id);
            return _mapper.Map<Customer, DTOCustomer>(info);
        }
        public async Task<int> InsertCustomer(DTOCustomer customer)
        {
            var info = _mapper.Map<DTOCustomer, Customer>(customer);
            return await _unitOfWork.CustomerRepository.InsertAsyn(info);
        }
        public async Task UpdateCustomer(DTOCustomer customer)
        {
            var data = _mapper.Map<DTOCustomer, Customer>(customer);
            await _unitOfWork.CustomerRepository.UpdateAsyn(data);
        }
        public async Task DeleteCustomer(int id)
        {
            await _unitOfWork.OrderRepository.DeleteAsyn(id);
        }
    }
}
