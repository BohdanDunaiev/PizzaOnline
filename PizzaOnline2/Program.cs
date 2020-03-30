using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PizzaOnline2.Entities;

namespace PizzaOnline2
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            //using (AplicationContext db = new AplicationContext())
            //{
            //    Customer customer1 = new Customer { Fullname = "Bogdan Dunaev", Addres = "Chernivci" };
            //    Customer customer2 = new Customer { Fullname = "Bogdan Dunaev", Addres = "Chernivci" };
            //    Customer customer3 = new Customer { Fullname = "Bogdan Dunaev", Addres = "Chernivci" };

            //    Order order1 = new Order { CustomerId = 1, PizzaId = 466454, PizzeriaId = 729353, DeliveryId = 430344 };
            //    Order order2 = new Order { CustomerId = 2, PizzaId = 848394, PizzeriaId = 121502, DeliveryId = 214214 };
            //    Order order3 = new Order { CustomerId = 3, PizzaId = 994934, PizzeriaId = 643044, DeliveryId = 732952 };
            //    db.Customers.Add(customer1);
            //    db.Customers.Add(customer2);
            //    db.Customers.Add(customer3);
            //    db.Orders.Add(order1);
            //    db.Orders.Add(order2);
            //    db.Orders.Add(order3);
            //    db.SaveChanges();
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
