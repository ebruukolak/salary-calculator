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
using SalaryCalculation.Business.Concretes;
using SalaryCalculation.Business.Interfaces;

namespace SalaryCalculation.Api
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
            services.AddScoped<ISalaryCalculatorFactory,SalaryCalculatorFactory>();
            services.AddScoped<ISalaryCalculator, FirstTypeEmployeeSalary>();
            services.AddScoped<ISalaryCalculator, SecondTypeEmployeeSalary>();
            services.AddScoped<ISalaryCalculator, ThirdTypeEmployeeSalary>();
            services.AddScoped<ISalaryCalculator, ForthTypeEmployeeSalary>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddControllers();
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

            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });*/

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Employee}/{action=GetEmployees}");
            });
        }
    }
}
