using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL.Models;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaOnline2.Controllers
{
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        #region Properties
        IDeliveryService _deliveryService;
        #endregion

        #region Constructors      
        public DeliveryController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }
        #endregion

        #region Api
        

        //[HttpGet]
        //[Route("DeliveryPrice")]
        //[ProducesResponseType(typeof(IEnumerable<DTODelivery>), 201)]
        //[ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        //public async Task<IActionResult> GetDeliveryPriceRange(int maxPrice, int minPrice)
        //{
        //    return Ok(await _deliveryService.GetDeliveryPriceRange(maxPrice, minPrice));
        //}

        [HttpGet]
        [Route("DeliveryId")]
        [ProducesResponseType(typeof(IEnumerable<DTODelivery>), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> GetDeliveryId(int id)
        {
            return Ok(await _deliveryService.GetDeliveryId(id));
        }

        //[HttpGet]
        //[Route("DeliveryName")]
        //[ProducesResponseType(typeof(IEnumerable<DTODelivery>), 201)]
        //[ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        //public async Task<IActionResult> GetDeliveryName(string namedelivery)
        //{
        //    return Ok(await _deliveryService.GetDeliveryName(namedelivery));
        //}

        //[HttpGet]
        //[Route("DeliveryPopular")]
        //[ProducesResponseType(typeof(IEnumerable<DTODelivery>), 201)]
        //[ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        //public async Task<IActionResult> GetPopular()
        //{
        //    return Ok(await _deliveryService.GetPopular());
        //}

        //CRUD OP...........................................................
        [HttpGet]
        [Route("DeliveryAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _deliveryService.GetAll());
            }
            catch
            {
                return StatusCode(404);
            }
            //return Ok(await _deliveryService.GetAll());
        }

        [HttpGet]
        [Route("Delivery/{Id}")]
        [ProducesResponseType(typeof(IEnumerable<DTODelivery>), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _deliveryService.GetByIdDelivery(id));
        }

        [HttpPost]
        [Route("Delivery")]   
        [ProducesResponseType(typeof(DTODelivery), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> Insert([FromBody]DTODelivery delivery)
        {
            try
            {
                await _deliveryService.InsertDelivery(delivery);
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [Route("Delivery/{delivery}")]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DTODelivery delivery)
        {
            try
            {
                await _deliveryService.UpdateDelivery(delivery);
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(404);
            }
        }


        [Route("Delivery/{id}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _deliveryService.DeleteDelivery(id);
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
