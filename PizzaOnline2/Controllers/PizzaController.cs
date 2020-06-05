using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL.Models;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace PizzaOnline2.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer", Roles = "admin")]
    [Route("api/[controller]")]
    public class PizzaController : Controller
    {
        #region Properties
        IPizzaService _pizzaService;
        #endregion

        #region Constructors      
        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        #endregion

        #region Api
        [AllowAnonymous]
        [HttpGet("count")]
        public async Task<IActionResult> Count([FromQuery] PizzaQueryParameters parameters)
        {
            return Ok(await _pizzaService.GetPizzaCountAsync(parameters));
        }
        [AllowAnonymous]
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetPizzaId(int Id)
        {
            try
            {
                return Ok(await _pizzaService.GetByIdPizza(Id));
            }
            catch
            {
                return StatusCode(404);
            }            
        }
        [HttpGet]        
        [AllowAnonymous]
        public async Task<IActionResult> Get([FromQuery]PizzaQueryParameters parameters)
        {
            var models = await _pizzaService.GetPizza(parameters);            
            if (models == null)
                return NotFound("The list of products is empty");
            else
                return Ok(models);                 
        }        

        [HttpPost]
        public async Task<IActionResult> InsertPizza([FromBody]DTOPizza pizza)
        {
            try
            {
                await _pizzaService.AddPizza(pizza);
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(404);
            }              
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePizza([FromBody]DTOPizza pizza)
        {
            try
            {
                await _pizzaService.UpdatePizza(pizza);
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePizza(int id)
        {
            try
            {
                await _pizzaService.DeletePizza(id);
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
