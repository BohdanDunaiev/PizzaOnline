using Microsoft.AspNetCore.Mvc;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace PizzaOnline2.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer", Roles = "admin")]
    [Route("api/[controller]")]
    public class RolesController : Controller
    {
        private readonly IRoleService _role;
        //IUserProfileServices UserProfile;
        public RolesController(IRoleService rol)
        {
            _role = rol;
        }

        [HttpPost]// назначает роль юзеру
        [Route("GiveRole")]
        public async Task GiveRole([FromQuery]string id, [FromQuery]string role)
        {
            await _role.AppointRole(id, role);
        }       

        [HttpGet]// все роли юзера
        [Route("GetUserRoles")]
        public async Task<IList<string>> GetURoles([FromQuery]string id)
        {
            return await _role.GetAllRolesUser(id);
        }        

        [HttpPost]// создать новую роль
        [Route("CreateRole")]
        public async Task<IActionResult> CreateRole([FromBody]RoleDTO role)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid model");
            await _role.CreateRole(role);
            return Ok(role);
        }   
    }
}
