using System;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Repository.EntetiesRepository;
using PizzaOnline.DAL.Interface;
using PizzaOnline.DAL.UnitOfWork;
using PizzaOnline.DAL;
using PizzaOnline2.BLL.IServices;
using PizzaOnline2.BLL.Services;
using Microsoft.AspNetCore.Identity;
using PizzaOnline2.BLL.AutoMapper;
using System.Reflection;
using PizzaOnline.DAL.Helpers;

namespace PizzaOnline2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {            
            string con = "Server= (localdb)\\mssqllocaldb;Database=Pizzeria;Trusted_Connection=True;";
            //(localdb)\\mssqllocaldb
            services.AddDbContext<AplicationContext>(options => options.UseSqlServer(con));
            services.AddControllers();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            #region Entities repositories            
            services.AddTransient<IDeliveryRepository, DeliveryRepository>();
            services.AddTransient<IIngredientsRepository, IngredientsRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IPizzaRepository, PizzaRepository>();
            services.AddTransient<IPizzeriaRepository, PizzeriaRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            #endregion

            #region SQL services
            services.AddTransient<IDeliveryService, DeliveryService>();
            services.AddTransient<IIngredientsService, IngredientsService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IPizzaService, PizzaService>();
            services.AddTransient<IPizzeriaService, PizzaeriaService>();
            services.AddTransient<ICustomerService, CustomerService>();
            #endregion
            services.AddDbContext<AplicationContext>(options =>
            {
                options
                    .UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                        assembly =>
                            assembly.MigrationsAssembly("PizzaOnline.DAL"));
            });

            services.AddIdentity<User, Role>(options =>
            {
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<AplicationContext>();

            services.AddAutoMapper(typeof(AutoMapperProfile).GetTypeInfo().Assembly);

            services.AddTransient<ISortHelper<Pizza>, SortHelper<Pizza>>();
            services.AddTransient<ISortHelper<Customer>, SortHelper<Customer>>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

           

        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();    // подключение аутентификации
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
