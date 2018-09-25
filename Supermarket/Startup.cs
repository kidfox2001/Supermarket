using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rotativa.AspNetCore;
using Supermarket.Data;
using Supermarket.Models;
using Supermarket.Services;

namespace Supermarket
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
            // AddScoped คือ  Singleton per request 
            services.AddSingleton<ILog, LineLog>(); // singleton ไม่ตายและสามารถแชร์ข้าม section ได้
            //services.AddTransient() สร้าง object ให้ใหม่ทุกครั้งที่มีการขอครับ
            //services.AddSingleton<Product>(); 
            services.AddDbContext<SupermarketDb>(options =>
            {
                
               
                options
                .UseLazyLoadingProxies()  //  เอาไว้ใช้ lazy load และ ต้องใส่ virtual ที่ relation ตรงไหนไม่ต้องการให้เป็น lazy ให้ใช้แนว eager load ไป
                //.UseInMemoryDatabase("MyDemo") // ใช้เล่นใน memory  ef เก่าอาจเล่นไม่ได้ต้องเป็น core
                .UseSqlServer(Configuration.GetConnectionString("SupermarketDb"));
            }
            );


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Development, Staging, Production
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
           // app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                   name: "areas",
                   template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                 );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            RotativaConfiguration.Setup(env);
        }
    }
}
