using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL.Models;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;

namespace PizzaOnline2.Controllers
{
    [ApiController]
    public class PizzaController : ControllerBase
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
        [HttpGet]
        [Route("PizzaId")]
        [ProducesResponseType(typeof(IEnumerable<DTOPizza>), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> GetPizzaId(int id)
        {
            return Ok(await _pizzaService.GetPizzaId(id));
        }
        [HttpGet]
        [Route("PizzaAll")]
        [ProducesResponseType(typeof(IEnumerable<DTOPizza>), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public IActionResult GetPizza([FromQuery]PizzaQueryParameters parameters)
        {
            try
            {
                return Ok(_pizzaService.GetPizza(parameters));
            }
            catch
            {
                return NotFound();
            }
        }
        //CRUD..............................................
        [HttpGet]
        [Route("Pizza")]
        public async Task<IActionResult> GetAllPizza()
        {
            try
            {
                return Ok(await _pizzaService.GetAllPizza());
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [HttpGet]
        [Route("Pizza/{Id}")]
        [ProducesResponseType(typeof(IEnumerable<DTOPizza>), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> GetByIdPizza(int id)
        {
            return Ok(await _pizzaService.GetByIdPizza(id));
        }

        [HttpPost]
        [Route("Pizza")]
        [ProducesResponseType(typeof(DTOPizza), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> InsertPizza([FromBody]DTOPizza pizza)
        {
            try
            {
                await _pizzaService.InsertPizza(pizza);
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [Route("Pizza/{pizza}")]
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

        [Route("Pizza/{id}")]
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
