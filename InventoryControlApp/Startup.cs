using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using InventoryControlApp.Models;
using Microsoft.AspNetCore.Identity;
namespace InventoryControlApp
{
    public class Startup
    {
        IConfigurationRoot Configuration;
        public Startup(IWebHostEnvironment env)
        {
            Configuration = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IItemRepository, EFItemRepository>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddMvc()
        .AddSessionStateTempDataProvider();
            services.AddSession();
            services.AddIdentity<AppUser, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory
    loggerFactory)
        {
            app.UseAuthentication();
            app.UseSession();
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");

            });
            app.UseMvcWithDefaultRoute();
        }
    }
}