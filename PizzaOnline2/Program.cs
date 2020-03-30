using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PizzaOnline2.Models;

namespace PizzaOnline2
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            using (PizzaOnlineContext db = new PizzaOnlineContext())
            {
                Customer customer1 = new Customer { fullname = "Bogdan Dunaev", addres = "Chernivci" };
                Customer customer2 = new Customer { fullname = "Bogdan Dunaev", addres = "Chernivci" };
                Customer customer3 = new Customer { fullname = "Bogdan Dunaev", addres = "Chernivci" };

                Order order1 = new Order { customerId = 1, pizzaId = 466454, pizzeriaId = 729353, deliveryId = 430344 };
                Order order2 = new Order { customerId = 2, pizzaId = 848394, pizzeriaId = 121502, deliveryId = 214214 };
                Order order3 = new Order { customerId = 3, pizzaId = 994934, pizzeriaId = 643044, deliveryId = 732952 };
                db.Customers.Add(customer1);
                db.Customers.Add(customer2);
                db.Customers.Add(customer3);
                db.Orders.Add(order1);
                db.Orders.Add(order2);
                db.Orders.Add(order3);                  
                db.SaveChanges();
            }   
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
