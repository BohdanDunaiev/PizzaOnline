using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PizzaOnline2.DAL;
using PizzaOnline2.DAL.Entities;


namespace PizzaOnline2
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            //using (var context = new AplicationContext())
            //{
            //    Customer customer1 = new Customer { 
            //        Fullname = "Dimon VAsiliv", 
            //        Addres = "Chernivci21",
            //        Orders = new List<Order>
            //            {
            //                new Order { CustomerId = 1}
            //            }
            //    };
            //    Order order1 = new Order { CustomerId = 1};
            //    context.Customers.Add(customer1);
            //    context.Orders.Add(order1);
            //    context.SaveChanges();
            //}
            CreateHostBuilder(args).Build().Run();
        }
            public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    });        
    }
}
