using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL.Models;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;
using AutoMapper;
using PizzaOnline.DAL.Entities;
using System.Linq;

namespace PizzaOnline2.Controllers
{
    public class PizzaController : Controller
    {
        #region Properties
        IPizzaService _pizzaService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors      
        public PizzaController(IPizzaService pizzaService, IMapper mapper)
        {
            _pizzaService = pizzaService;
            _mapper = mapper;
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
        //[ProducesResponseType(typeof(IEnumerable<DTOPizza>), 201)]
        //[ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public IActionResult Get([FromQuery]PizzaQueryParameters parameters)
        {
            var models = _pizzaService.GetPizza(parameters).ToList();
            var list = _mapper.Map<List<Pizza>, List<DTOPizza>>(models);
            if (list == null)
                return NotFound("The list of products is empty");
            else
                return View(list);
            //try
            //{
            //    return Ok(_pizzaService.GetPizza(parameters));
            //}
            //catch
            //{
            //    return NotFound();
            //}
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
