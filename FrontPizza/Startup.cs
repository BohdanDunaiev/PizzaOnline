using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FrontPizza.Data;
using FrontPizza.JWT;
using Blazored.LocalStorage;
using System.Net.Http;
using System.Globalization;
using System.Collections.Generic;

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
            services.AddSingleton<HttpClient>();
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            var supportedCultures = new List<CultureInfo> { new CultureInfo("en"), new CultureInfo("uk") };
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en");
                options.SupportedUICultures = supportedCultures;
            });
            services.AddHttpClient<Data.CustomerService>(customer =>
            {
                customer.BaseAddress = new Uri("https://localhost:44360");
            });
            services.AddHttpClient<Data.PizzaService>(customer =>
            {
                customer.BaseAddress = new Uri("https://localhost:44360");
            });
            services.AddHttpClient<Data.AccountService>(customer =>
            {
                customer.BaseAddress = new Uri("https://localhost:44360");
            });
            services.AddHttpClient<Data.IngrefientsService>(customer =>
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
