using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nobatgir.Data;
using Nobatgir.Services;

namespace Nobatgir
{
    public class CustomSection1
    {
        public string Hi { get; set; }
        public string Hello { get; set; }
    }

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
            services.AddDbContext<MyContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<Repository>();

            services.AddIdentity<Model.User, Model.Role>(config =>
            {
                config.Password.RequireDigit = false;
                config.Password.RequiredLength = 3;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
                config.Password.RequiredUniqueChars = 0;
                config.Password.RequireLowercase = false;

            }).AddEntityFrameworkStores<IdentityContext>()
              .AddDefaultTokenProviders();

            services.AddTransient<IEmailSender, EmailSender>();

            services.ConfigureApplicationCookie(c => c.LoginPath = "/Account/User/Login");

            //services.Configure<CustomSection1>(Configuration);

            //services.AddSingleton<CustomSection1>();

            //var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

            //using (var db = new MyContext(optionsBuilder.Options))
            //{
            //    var lst = db.Acts.ToList();
            //}

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "admin",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
