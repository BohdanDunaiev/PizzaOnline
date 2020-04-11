using Microsoft.AspNetCore.Mvc;
using PizzaOnline2.BLL.IServices;
using PizzaOnline.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline2.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        #region Propertirs
        ICustomerService _customerService;
        #endregion

        #region Constructors
        public  CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        #endregion

        #region Api
        //Get all customer
        [Route("Customers")]
        [HttpGet]
        public async Task<IEnumerable<Customer>> Get()
        {
            IEnumerable<Customer> customer = await _customerService.GetAllCustomers();
            return customer; 
        }
        //Get customer by id
        [Route("Customer/{Id}")]
        [HttpGet]
        public async Task<Customer> GetById(int id)
        {
            return await _customerService.GetByIdCustomer(id);
        }
        // POST: Add new customer
        [Route("Customer")]
        [HttpPost]
        public async Task<Customer> Insert([FromBody]Customer customer)
        {
            return await _customerService.InsertCustomer(customer);
        }

        // PUT: Update existing customer
        [Route("Customer/{Id}")]
        [HttpPut]
        public async void Put([FromBody]Customer customer)
        {
            _customerService.UpdateCustomer(customer);
        }

        // DELETE: Delete existing customer
        [Route("Customer/{Id}")]
        [HttpDelete]
        public async Task<int> Delete([FromBody]Customer id)
        {
            return await _customerService.DeleteCustomer(id);
        }
        #endregion
    }
}
