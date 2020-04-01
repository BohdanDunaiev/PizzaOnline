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
            using (AplicationContext db = new AplicationContext())
            {             
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
