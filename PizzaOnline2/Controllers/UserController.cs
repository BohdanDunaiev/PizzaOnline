using Microsoft.AspNetCore.Mvc;
using PizzaOnline2.BLL.IServices;
using PizzaOnline.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaOnline2.BLL.DTOEntities;

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
       
        #endregion
    }
}
