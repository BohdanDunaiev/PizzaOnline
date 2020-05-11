using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Models;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;

namespace PizzaOnline2.Controllers
{
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class OrderController : ControllerBase
    {
        #region Properties
        IOrderService _orderService;
        #endregion

        #region Constructors      
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        #endregion

        #region Api
        [HttpGet]
        [Route("OrderId")]
        [ProducesResponseType(typeof(IEnumerable<DTOOrder>), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> GetOrderId(int id)
        {
            return Ok(await _orderService.GetOrderId(id));
        }
        [HttpGet]
        [Route("OrderAll")]
        [ProducesResponseType(typeof(IEnumerable<DTOOrder>), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public IActionResult GetOrder([FromQuery]OrderQueryParameters parameters)
        {
            try
            {
                return Ok(_orderService.GetOrder(parameters));
            }
            catch
            {
                return NotFound();
            }
        }
        //CRUD..............................................
        [HttpGet]
        [Route("Orders")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _orderService.GetAllOrders());
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [HttpGet]
        [Route("Order/{Id}")]
        [ProducesResponseType(typeof(IEnumerable<DTOOrder>), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _orderService.GetByIdOrder(id));
        }

        [HttpPost]
        [Route("Order")]
        [ProducesResponseType(typeof(DTOOrder), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> Insert([FromBody]DTOOrder order)
        {
            try
            {
                await _orderService.InsertOrder(order);
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [Route("Order/{orders}")]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DTOOrder order)
        {
            try
            {
                await _orderService.UpdateOrder(order);
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(404);
            }
        }


        [Route("Order/{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _orderService.DeleteOrder(id);
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
