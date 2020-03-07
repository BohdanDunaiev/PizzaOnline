using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaOnline.DAL.Interfaces.EntityInterfaces.SQLInterfaces.ISQLServices;
using PizzaOnline.DAL.Services.SQLServices;
using PizzaOnline.Models;
using PizzaOnline.Repositoryes;
using PizzaOnline.DAL.Models;

namespace PizzaOnline.Controllers
{
    //[Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        ISQLOrderService _sqlOrderService;
        public OrderController(ISQLOrderService sqlOrderService)
        {
            _sqlOrderService = sqlOrderService;
        }
        [Route("Orders")]
        [HttpGet]
        public IEnumerable<SQLOrder> Get()
        {
            return _sqlOrderService.GetAllOrders();

        }
        [Route("Order/{Id}")]
        [HttpGet]
        public SQLOrder Get(int Id)
        {
            return _sqlOrderService.GetOrderById(Id);
        }
        //[Route("Orders")]
        //[HttpPost]
        //public int Post([FromBody]SQLOrder order)
        //{
        //    return _sqlOrderService.AddOrder(order);
        //}
        [Route("Order/{Id}")]
        [HttpDelete]
        public void Delete(int Id)
        {
            _sqlOrderService.DeleteOrder(Id);
        }
        [Route("Order/order")]
        [HttpPut]
        public void Put([FromBody]SQLOrder order)
        {
            _sqlOrderService.Update(order);
        }

       

    }
}

