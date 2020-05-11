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

        [HttpGet]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody]CrUserDTO User)
        {
            return Ok(await _accountService.Create(User));
        }

        [HttpGet]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDTO User)
        {
            return Ok(await _accountService.Register(User));
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO User)
        {
            return Ok(await _accountService.Login(User));
        }

        [HttpGet]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            return Ok(await _accountService.Logout());
        }

        [HttpGet]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _accountService.Delete(id));
        }

        [HttpGet]
        public async Task<IActionResult> UserList()
        {
            return Ok(await _accountService.UserList());
        }
    }
}
