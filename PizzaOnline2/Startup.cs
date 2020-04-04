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
using PizzaOnline2.DAL.Entities;
using PizzaOnline2.DAL.Interface.IRepository;
using PizzaOnline2.DAL.Repository.EntetiesRepository;
using PizzaOnline2.DAL.Interface.IServices;
using PizzaOnline2.DAL.Services;
using PizzaOnline2.DAL.Interface;
using PizzaOnline2.DAL.UnitOfWork;
using PizzaOnline2.DAL;

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
            string con = "Server=(localdb)\\mssqllocaldb;Database=usersdbstore;Trusted_Connection=True;";
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
