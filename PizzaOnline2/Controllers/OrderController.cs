using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaOnline.DAL;
using PizzaOnline.DAL.Entities;

namespace PizzaOnline2.Controllers
{
    [ApiController]
    public class OrderController 
    {
        //private AplicationContext db = new AplicationContext();
        //[Route("api/[controller]")]
        //[HttpGet]
        //public IEnumerable<Order> GetAllOrder()
        //{
        //    return db.Orders;
        //}
        //[Route("api/[controller]/{Id}")]
        //[HttpGet]
        //public async Task<ActionResult<Order>> GetOrderById(int id)
        //{
        //    var order = from b in db.Orders
        //                where b.Id == id
        //                select new Order()
        //                {
        //                    Id = b.Id,
        //                    CustomerId = b.CustomerId,
        //                    PizzaId = b.PizzaId,
        //                    PizzeriaId = b.PizzeriaId,
        //                    DeliveryId = b.DeliveryId
        //                };
        //    if (order == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(new ObjectResult(order));
        //}
        //[Route("api/[controller]")]
        //[HttpPost]
        //public async Task<ActionResult<Order>> Post(Order order)
        //{
        //    if (order == null)
        //    {
        //        return BadRequest();
        //    }
        //    db.Orders.Add(order);
        //    await db.SaveChangesAsync();
        //    return Ok(order);
        //    //db.Orders.Add(order);
        //    //await db.SaveChangesAsync();

        //    //db.Entry(order);

        //    //var ord = new Order()
        //    //{
        //    //    Id = order.Id,
        //    //    customerId = order.customerId,
        //    //    pizzaId = order.pizzaId,
        //    //    pizzeriaId = order.pizzeriaId,
        //    //    deliveryId = order.deliveryId
        //    //};

        //    //return CreatedAtRoute("DefaultApi", new { id = order.Id }, ord);

        //}
        //[Route("api/[controller]/{Id}")]
        //[HttpPut]
        //public async Task<ActionResult<Order>> PutOrder(int id, Order order)
        //{
        //    if (order == null)
        //    {
        //        return BadRequest();
        //    }
        //    if (!db.Orders.Any(x => x.Id == order.Id))
        //    {
        //        return NotFound();
        //    }

        //    db.Update(order);
        //    await db.SaveChangesAsync();
        //    return Ok(order);
        //}
        //[Route("api/[controller]/{Id}")]
        //[HttpDelete("{Id}")] 
        //public async Task<ActionResult<Order>> Delete(int id)
        //{
        //    Order user = db.Orders.FirstOrDefault(x => x.Id == id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    db.Orders.Remove(user);
        //    await db.SaveChangesAsync();
        //    return Ok(user);
        //}

    }
}