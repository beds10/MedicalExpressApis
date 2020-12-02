using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.CORE.Services;
using MedicalExpress.INFRASTRUCTURE.Data;

using MedicalExpress.INFRASTRUCTURE.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MedicalExpress.API
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
            ///MAPEOS AUTOMAPPER
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            }
            ).ConfigureApiBehaviorOptions(options => {
                options.SuppressModelStateInvalidFilter = true;
            });

         


            services.AddDbContext<MedicalExpressDBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("MedicalExpressDB"))
            );

            services.AddTransient<IPharmacyService, PharmacyService>();
            services.AddTransient<IPharmacyRepository, PharmacyRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IAlarmRepository, AlarmRepository>();
            services.AddTransient<IAlarmService, AlarmService>();
            services.AddTransient<IDetailordRepository, DetailordRepository>();
            services.AddTransient<IDetailordService, DetailordService>();
            services.AddTransient<IMethodPaymentRepository, MethodPaymentRepository>();
            services.AddTransient<IMethodPaymentService, MethodPaymentService>();
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
