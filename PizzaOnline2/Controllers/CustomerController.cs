using Microsoft.AspNetCore.Mvc;
using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Interface.IServices;
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
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        #endregion

        #region Api
        //Get all customer
        [Route("Customers")]
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerService.GetAllCustomers(); 
        }
        //Get customer by id
        [Route("Customer/{Id}")]
        [HttpGet]
        public Customer GetById(int id)
        {
            return _customerService.GetByIdCustomer(id);
        }
        // POST: Add new customer
        [Route("Customer")]
        [HttpPost]
        public void Post([FromBody]Customer customer)
        {
            _customerService.InsertCustomer(customer);
        }

        // PUT: Update existing customer
        [Route("Customer/{customer}")]
        [HttpPut]
        public void Put([FromBody]Customer customer)
        {
            _customerService.UpdateCustomer(customer);
        }

        // DELETE: Delete existing customer
        [Route("Customer/{customer}")]
        [HttpDelete]
        public void Delete([FromBody]Customer id)
        {
            _customerService.DeleteCustomer(id);
        }
        #endregion
    }
}
