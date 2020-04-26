using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PizzaOnline.BLL.DTOEntities;
using PizzaOnline.DAL.Models;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;
using System.Threading.Tasks;

namespace PizzaOnline2.Controllers
{
    [Route("api/[controller]")]
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
        //Get all categories
        [HttpGet]
        [Route("Deliveries")]
        public async Task<IActionResult> GetOwners([FromQuery]DeliveryQueryParameters categoriesQuery)
        {
            var owners = _deliveryService.GetOwners(categoriesQuery);

            var metadata = new
            {
                owners.TotalCount,
                owners.PageSize,
                owners.CurrentPage,
                owners.TotalPages,
                owners.HasNext,
                owners.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            return Ok(owners);
        }

        [HttpGet]
        [Route("Delivery")]
        [ProducesResponseType(typeof(DTODelivery), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> GetDeliveryPriceRange(int maxPrice, int minPrice)
        {
            return Ok(await _deliveryService.GetDeliveryPriceRange(maxPrice, minPrice));
        }

        [HttpGet]
        [Route("Delivery")]
        [ProducesResponseType(typeof(DTODelivery), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> GetDeliveryId(int id)
        {
            return Ok(await _deliveryService.GetDeliveryId(id));
        }

        [HttpGet]
        [Route("Delivery")]
        [ProducesResponseType(typeof(DTODelivery), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> GetDeliveryName(string namedelivery)
        {
            return Ok(await _deliveryService.GetDeliveryName(namedelivery));
        }

        [HttpGet]
        [Route("Delivery")]
        [ProducesResponseType(typeof(DTODelivery), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> GetPopular()
        {
            return Ok(await _deliveryService.GetPopular());
        }

        //CRUD OP...........................................................
        [HttpGet]
        [Route("Delivery")]
        [ProducesResponseType(typeof(DTODelivery), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _deliveryService.GetAllDelivery());
        }

        [HttpGet]
        [Route("Delivery/{Id}")]
        [ProducesResponseType(typeof(DTODelivery), 201)]
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


        [Route("Delivery/{delivery}")]
        [HttpDelete]
        public async Task<IActionResult> Delete(int delivery)
        {
            try
            {
                await _deliveryService.DeleteDelivery(delivery);
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
