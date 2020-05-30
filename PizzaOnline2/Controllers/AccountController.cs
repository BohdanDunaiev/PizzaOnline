using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;
using System.Threading.Tasks;

namespace PizzaOnline2.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDTO myUser)
        {
            var result = await _accountService.Register(myUser);
            if (result.Succeeded)
                return Ok("User registered");
            else
            {
                string Errors = "";
                foreach (var error in result.Errors)
                    Errors += $"{error.Description}\n";
                return BadRequest(Errors);
            }

        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO User)
        {
            var result = await _accountService.Login(User);
            if (result.successful)
                return Ok(result);
            else
                return BadRequest(result);
        }
        [HttpGet]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            return Ok(await _accountService.Logout());
        }
        [Authorize(Roles = "admin")]
        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _accountService.Delete(id));
        }        
        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> UserList()
        {
            return Ok(await _accountService.UserList());
        }
    }
}
