using Microsoft.AspNetCore.Mvc;
using PizzaOnline2.BLL.IServices;
using PizzaOnline.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PizzaOnline2.Controllers
{
    [ApiController]
    public class UserController
    {
        #region Propertirs
        IUserService _userService;
        #endregion

        #region Constructors
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        #region Api
        //Get all customer
        [Route("Users")]
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            IEnumerable<User> user = await _userService.GetAllUser();
            return user;
        }
        
        // POST: Add new customer
        [Route("User")]
        [HttpPost]
        public async Task<User> Insert([FromBody]User user)
        {
            return await _userService.InsertUser(user);
        }

        // PUT: Update existing customer
        [Route("User/{Id}")]
        [HttpPut]
        public async void Put([FromBody]User user)
        {
            _userService.UpdateUser(user);
        }
        #endregion
    }
}
