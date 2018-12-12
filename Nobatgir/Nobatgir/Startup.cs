using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nobatgir.Data;
using Nobatgir.Services;

namespace Nobatgir
{
    public enum MyRoutes
    {
        SiteCatExpert, SiteCat, Site, CatExpert, Cat, Admin,

        SiteWithDomain, SiteWithoutDomain
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

            services.ConfigureApplicationCookie(delegate (CookieAuthenticationOptions c)
            {
                c.Events = new CookieAuthenticationEvents
                {
                    OnRedirectToAccessDenied =
                        ctx =>
                        {
                            var routedata = ctx.HttpContext.GetRouteData();

                            string url;

                            if (routedata.Values["sitename"] == null)
                                url = "/Account/User/AccessDenied";
                            else
                                url = "/" + routedata.Values["sitename"] + "/Account/User/AccessDenied";

                            url += "?" + c.ReturnUrlParameter + "=" + ctx.Request.Path;

                            ctx.Response.Redirect(url);

                            return Task.CompletedTask;
                        },
                    OnRedirectToLogin =
                         ctx =>
                         {
                             var routedata = ctx.HttpContext.GetRouteData();

                             string url;

                             if (routedata.Values["sitename"] == null)
                                 url = "/Account/User/Login";
                             else
                                 url = "/" + routedata.Values["sitename"] + "/Account/User/Login";

                             url += "?" + c.ReturnUrlParameter + "=" + ctx.Request.Path;

                             ctx.Response.Redirect(url);

                             return Task.CompletedTask;
                         }
                };

                //c.LoginPath = "/" + RRR + "/Account/User/Login";
            });

            //services.Configure<CustomSection1>(Configuration);

            //services.AddSingleton<CustomSection1>();

            //var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

            //using (var db = new MyContext(optionsBuilder.Options))
            //{
            //    var lst = db.Acts.ToList();
            //}

            services.AddMvc(
                //cfg =>
                //cfg.Filters.Add(new AuthorizeFilter())
                );

            services.AddAuthorization(options =>
            {
                options.AddPolicy("nobatpolicy", policy => policy.Requirements.Add(new MyRequirement()));
            });

            services.AddScoped<IAuthorizationHandler, MyAuthorizationHandler>();
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
                    name: nameof(MyRoutes.SiteCatExpert),
                    template: "{sitename}/cat-{catname}/exp-{expertname}/{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: nameof(MyRoutes.SiteCat),
                    template: "{sitename}/cat-{catname}/{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: nameof(MyRoutes.Site),
                    template: "{sitename}/{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: nameof(MyRoutes.CatExpert),
                    template: "cat-{catname}/exp-{expertname}/{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: nameof(MyRoutes.Cat),
                    template: "cat-{catname}/{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: nameof(MyRoutes.Admin),
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


                //routes.MapRoute(
                //    name: "admin",
                //    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: nameof(MyRoutes.SiteWithoutDomain),
                    template: "{sitename}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: nameof(MyRoutes.SiteWithDomain),
                    template: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
