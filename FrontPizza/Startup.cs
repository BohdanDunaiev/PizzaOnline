using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
using FrontPizza.JWT;
using Blazored.LocalStorage;
using System.Net.Http;

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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            //string con = "Server= (localdb)\\mssqllocaldb;Database=Pizzeria;Trusted_Connection=True;";    
            //services.AddDbContext<AplicationContext>(options => options.UseSqlServer(con));
            services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();
            services.AddBlazoredLocalStorage();
            //services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
            //    //.AddRoles<IdentityRole>()
            //    .AddEntityFrameworkStores<AplicationContext>();    
            //Google authentication................................................
            services.AddAuthentication().AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
                googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
            });
            services.AddSingleton<HttpClient>();
            services.AddSingleton<WeatherForecastService>();
            services.AddHttpClient<Data.PizzaService>(customer =>
            {
                customer.BaseAddress = new Uri("https://localhost:44360");
            });
            services.AddHttpClient<Data.AccountService>(customer =>
            {
                customer.BaseAddress = new Uri("https://localhost:44360");
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
