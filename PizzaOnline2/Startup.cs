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
using Microsoft.IdentityModel.Logging;
using PizzaOnline2.BLL.IServices;
using PizzaOnline2.BLL.Services;
using Microsoft.AspNetCore.Identity;
using PizzaOnline2.BLL.AutoMapper;
using System.Reflection;
using PizzaOnline.DAL.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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
                options.Password = new PasswordOptions
                {
                    RequireDigit = false,
                    RequiredLength = 6,
                    RequireLowercase = false,
                    RequireUppercase = false,
                    RequireNonAlphanumeric = false
                };

            }).AddEntityFrameworkStores<AplicationContext>();
            services.AddAutoMapper(typeof(AutoMapperProfile).GetTypeInfo().Assembly);
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
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IRoleService, RoleService>();
            #endregion

            //services.AddIdentity<User, Role>(options =>
            //{
            //    options.User.RequireUniqueEmail = true;
            //}).AddEntityFrameworkStores<AplicationContext>();

            

            services.AddTransient<ISortHelper<Pizza>, SortHelper<Pizza>>();
            services.AddTransient<ISortHelper<Customer>, SortHelper<Customer>>();
            //JWT..............................................
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        options.RequireHttpsMetadata = false;
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            
                            ValidateIssuer = true,
                      
                            ValidIssuer = Configuration["JwtIssuer"],
                      
                            ValidateAudience = true,

                            ValidAudience = Configuration["JwtAudience"],

                            ValidateLifetime = true,

                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JwtSecurityKey"])),

                            ValidateIssuerSigningKey = true,
                            ClockSkew = TimeSpan.Zero
                        };
                    });
            services.AddControllers();                            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                IdentityModelEventSource.ShowPII = true;
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();    // подключение аутентификации
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                   //name: "default",
                   //pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
