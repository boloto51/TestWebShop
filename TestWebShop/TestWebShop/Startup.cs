using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TestWebShop.Converters;
using TestWebShop.Data.DbContext;
using TestWebShop.Data.Repositories;
using TestWebShop.Managers;
using TestWebShop.Servises;

namespace TestWebShop
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
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DataContext"));
            });

            services.AddControllersWithViews();
            services.AddScoped<IXmlDeserialize, XmlDeserialize>();
            services.AddScoped<IContextFactory, ContextFactory>();
            services.AddScoped<IGoodRepository, GoodRepository>();
            services.AddScoped<IGoodTypeRepository, GoodTypeRepository>();
            services.AddScoped<IProducerRepository, ProducerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IGoodConverter, GoodConverter>();
            services.AddScoped<IGoodTypeConverter, GoodTypeConverter>();
            services.AddScoped<IProducerConverter, ProducerConverter>();
            services.AddScoped<IGoodManager, GoodManager>();
            services.AddScoped<IOrderConverter, OrderConverter>();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Shop}/{action=Index}/{id?}");
                    //pattern: "{controller=Order}/{action=CreateOrder}/{id?}");
            });
        }
    }
}
