using Microsoft.AspNetCore.Mvc;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaOnline2.Controllers
{
    [ApiController]
    public class PizzeriaController : ControllerBase
    {
        #region Properties
        IPizzeriaService _pizzeriaService;
        #endregion

        #region Constructors      
        public PizzeriaController(IPizzeriaService pizzeriaService)
        {
            _pizzeriaService = pizzeriaService;
        }
        #endregion

        #region Api
        [HttpGet]
        [Route("PizzeriaId")]
        [ProducesResponseType(typeof(IEnumerable<DTOPizzeria>), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> GetPizzeriaId(int id)
        {
            return Ok(await _pizzeriaService.GetPizzeriaId(id));
        }
        //CRUD OP...........................................................
        [HttpGet]
        [Route("PizzeriaAll")]
        public async Task<IActionResult> GetAllPizzeria()
        {
            try
            {
                return Ok(await _pizzeriaService.GetAllPizzeria());
            }
            catch
            {
                return StatusCode(404);
            }
            //return Ok(await _deliveryService.GetAll());
        }

        [HttpGet]
        [Route("Pizzeria/{Id}")]
        [ProducesResponseType(typeof(IEnumerable<DTOPizzeria>), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _pizzeriaService.GetByIdPizzeria(id));
        }

        [HttpPost]
        [Route("Pizzeria")]
        [ProducesResponseType(typeof(DTOPizzeria), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> Insert([FromBody]DTOPizzeria pizzeria)
        {
            try
            {
                await _pizzeriaService.InsertPizzeria(pizzeria);
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [Route("Pizzeria/{pizzeria}")]
        [HttpPut]
        public async Task<IActionResult> UpdatePizzeria([FromBody]DTOPizzeria pizzeria)
        {
            try
            {
                await _pizzeriaService.UpdatePizzeria(pizzeria);
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(404);
            }
        }


        [Route("Pizzeria/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeletePizzeria(int id)
        {
            try
            {
                await _pizzeriaService.DeletePizzeria(id);
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
