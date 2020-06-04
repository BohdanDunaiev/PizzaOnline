using Microsoft.AspNetCore.Mvc;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaOnline2.Controllers
{
    [Route("api/[controller]")]
    public class IngredientController : Controller
    {
        #region Properties
        IIngredientsService _ingredientsService;
        #endregion

        #region Constructors      
        public IngredientController(IIngredientsService ingredientsService)
        {
            _ingredientsService = ingredientsService;
        }
        #endregion

        #region Api  
        [Route("IngredientAll")]
        [HttpGet]
        public async Task<IActionResult> GetAllPizzeria()
        {
            try
            {
                return Ok(await _ingredientsService.GetAllIngredients());
            }
            catch
            {
                return StatusCode(404);
            }   
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetByIdIngredient(int id)
        {
            try
            {
                return Ok(await _ingredientsService.GetByIdIngredient(id));
            }
            catch
            {
                return StatusCode(404);
            }                   
        }

        [HttpPost]
        [Route("Ingredient")]
        [ProducesResponseType(typeof(DTOIngredients), 201)]
        [ProducesResponseType(typeof(ErrorResponseDTO), 400)]
        public async Task<IActionResult> InsertIngredient([FromBody]DTOIngredients ingredient)
        {
            try
            {
                await _ingredientsService.InsertIngredient(ingredient);
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [Route("Ingredient/{ingredient}")]
        [HttpPut]
        public async Task<IActionResult> UpdateIngredient([FromBody]DTOIngredients ingredient)
        {
            try
            {
                await _ingredientsService.UpdateIngredient(ingredient);
                return StatusCode(200);
            }
            catch
            {
                return StatusCode(404);
            }
        }


        [Route("Ingredient/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteIngredient(int id)
        {
            try
            {
                await _ingredientsService.DeleteIngredient(id);
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
