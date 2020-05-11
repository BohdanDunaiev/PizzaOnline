using Microsoft.AspNetCore.Mvc;
using PizzaOnline2.BLL.DTOEntities;
using PizzaOnline2.BLL.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline2.Controllers
{
    [Route("api/[controller]")]
    public class RolesController : Controller
    {
        private readonly IRolesServices _role;
        //IUserProfileServices UserProfile;
        public RolesController(IRolesServices rol)
        {
            _role = rol;
        }

        [HttpPost]// назначает роль юзеру
        [Route("GiveRole")]
        public async Task GiveRole(string id, string role)
        {
            await _role.AppointRole(id, role);
        }

        [HttpGet]// все роли юзера
        [Route("GetUserRoles")]
        public async Task<IList<string>> GetURoles(string id)
        {
            return await _role.GetAllRolesUser(id);
        }


        [HttpPost]// создать новую роль
        [Route("CreateRole")]
        public async Task CreateRole([FromBody]RoleDTO role)
        {
            await _role.CreateRole(role);
        }


    }
}
