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
using PizzaOnline.DAL.Infrastructure;
using PizzaOnline.DAL.Interfaces;
using PizzaOnline.DAL.Interfaces.EntityInterfaces.SQLInterfaces.ISQLServices;
using PizzaOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using PizzaOnline.DAL.Services.SQLServices;
using PizzaOnline.DAL.UnitOfWork;
using PizzaOnline.Repositoryes;

namespace PizzaOnline
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
            services.AddControllers();
            services.AddTransient<ISQLunitOfWork, SQLsqlunitOfWork>();
            services.AddTransient<IConnectionFactory, ConnectionFactory>();

            services.AddTransient<ISQLOrderRepository, SQLOrderRepository>();
            services.AddTransient<ISQLOrderService, SQLOrderService>();
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

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
