using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using PizzaOnline.DAL.Models;
using PizzaOnline.DAL.Services.SQLServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace PizzaOnline.WEBAPI.Controllers
{
        [Route("api/[controller]")]
        public class JoinController : Controller
        {
            JoinService join = new JoinService();

            [HttpGet]
            public IEnumerable<OrderJoin> GetInfo()
            {
                return join.GetInfo();
            }
        }
}
