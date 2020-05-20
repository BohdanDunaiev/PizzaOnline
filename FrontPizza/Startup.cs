using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FrontPizza.Areas.Identity;
using FrontPizza.Data;
using PizzaOnline.DAL.Entities;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.EntityFrameworkCore;
using PizzaOnline.DAL;
using PizzaOnline2.BLL.IServices;
using PizzaOnline2.BLL.Services;
using PizzaOnline.DAL.Interface;
using PizzaOnline.DAL.UnitOfWork;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Repository.EntetiesRepository;
using PizzaOnline.DAL.Helpers;
using AutoMapper;
using PizzaOnline2.BLL.AutoMapper;
using System.Reflection;
using Microsoft.AspNetCore.Identity;

namespace FrontPizza
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            string con = "Server= (localdb)\\mssqllocaldb;Database=Pizzeria;Trusted_Connection=True;";
            //(localdb)\\mssqllocaldb
            services.AddDbContext<AplicationContext>(options => options.UseSqlServer(con));
            //services.AddControllers();
            //services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //#region Entities repositories            
            //services.AddTransient<IDeliveryRepository, DeliveryRepository>();
            //services.AddTransient<IIngredientsRepository, IngredientsRepository>();
            //services.AddTransient<IOrderRepository, OrderRepository>();
            //services.AddTransient<IPizzaRepository, PizzaRepository>();
            //services.AddTransient<IPizzeriaRepository, PizzeriaRepository>();
            //services.AddTransient<ICustomerRepository, CustomerRepository>();
            //#endregion

            //#region SQL services
            //services.AddTransient<IDeliveryService, DeliveryService>();
            //services.AddTransient<IIngredientsService, IngredientsService>();
            //services.AddTransient<IOrderService, OrderService>();
            //services.AddTransient<IPizzaService, PizzaOnline2.BLL.Services.PizzaService>();
            //services.AddTransient<IPizzeriaService, PizzaeriaService>();
            //services.AddTransient<ICustomerService, CustomerService>();
            //#endregion

            services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<AplicationContext>();
            //services.AddIdentity<User, Role>(options =>
            //{
            //    options.User.RequireUniqueEmail = true;
            //}).AddEntityFrameworkStores<AplicationContext>();

            //services.AddAutoMapper(typeof(AutoMapperProfile).GetTypeInfo().Assembly);

            //services.AddTransient<ISortHelper<Pizza>, SortHelper<Pizza>>();
            //services.AddTransient<ISortHelper<Customer>, SortHelper<Customer>>();

            //services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddRazorPages();
            services.AddServerSideBlazor();
            //Google authentication................................................
            services.AddAuthentication().AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
                googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
            });
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddSingleton<WeatherForecastService>();
            services.AddHttpClient<Data.PizzaService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:44360");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
