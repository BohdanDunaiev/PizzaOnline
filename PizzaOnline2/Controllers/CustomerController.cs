using System.Collections.Generic;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaOnline.DAL.Models;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;

namespace PizzaOnline2.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]  
    public class CustomerController : Controller
    {
        #region Properties
        ICustomerService _customerService;
        #endregion

        #region Constructors      
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        #endregion

        #region Api
        [Authorize(Roles = "admin")]
        [HttpGet]       
        public IActionResult GetCustomer([FromQuery]CustomerQueryParameters parameters)
        {
            try
            {
                return Ok(_customerService.GetCustomer(parameters));
            }
            catch
            {
                return NotFound();
            }
        } 

        [Authorize]
        [HttpGet("{id}")]      
        public async Task<IActionResult> GetByIdCustomer(int id)
        {
            try
            {
                return Ok(await _customerService.GetByIdCustomer(id));
            }
            catch
            {
                return StatusCode(404);
            }            
        }

        [HttpPost]
        [Route("Customer")]
        [ProducesResponseType(typeof(DTOCustomer), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> Insert([FromBody]DTOCustomer customer)
        {
            try
            {
                await _customerService.InsertCustomer(customer);
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DTOCustomer customer)
        {
            try
            {
                await _customerService.UpdateCustomer(customer);
                return Ok(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [Route("Customer/{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _customerService.DeleteCustomer(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        #endregion
    }
}
