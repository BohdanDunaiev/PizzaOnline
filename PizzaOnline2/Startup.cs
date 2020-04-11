using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Repository.EntetiesRepository;
using PizzaOnline.DAL.Interface;
using PizzaOnline.DAL.UnitOfWork;
using PizzaOnline.DAL;
using PizzaOnline2.BLL.IServices;
using PizzaOnline2.BLL.Services;

namespace PizzaOnline2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string con = "Server= (localdb)\\mssqllocaldb;Database=Pizzeria;Trusted_Connection=True;";
            //(localdb)\\mssqllocaldb
            services.AddDbContext<AplicationContext>(options => options.UseSqlServer(con));
            services.AddControllers();
            #region Entities repositories
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IDeliveryRepository, DeliveryRepository>();
            services.AddTransient<IIngredientsRepository, IngredientsRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IPizzaRepository, PizzaRepository>();
            services.AddTransient<IPizzeriaRepository, PizzeriaRepository>();
            #endregion

            #region SQL services
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IDeliveryService, DeliveryService>();
            services.AddTransient<IIngredientsService, IngredientsService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IPizzaService, PizzaService>();
            services.AddTransient<IPizzeriaService, PizzaeriaService>();
            #endregion

            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
