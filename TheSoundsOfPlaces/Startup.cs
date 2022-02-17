using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSoundsOfPlaces.Database;

namespace TheSoundsOfPlaces
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
            services.AddRazorPages();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddDbContextPool<TheSoundsOfPlacesDBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("TheSoundsOfPlacesConnection")));

            // authorize kýsmýný bütün projeye ekledik. Her yere [Authorize] key'inin eklemektense bu daha mantýklý. 
            // gerekmeyen yerlere örneðin ana sayfaya [AllowAnnanymus] ekledik
            services.AddMvc(options =>
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

                options.Filters.Add(new AuthorizeFilter(policy));
            }).AddXmlSerializerFormatters();


            // cookie & session authentication iþlemi için gerekli olan yapýlandýrmalar.
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.Cookie.Name = "ADMIN_AUTHENTICATION";
                options.LoginPath = "/administration/login"; // authentication yoksa yönlendirilecek yer
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30); // oturum süresi ayarý
                options.SlidingExpiration = false; // oturum süresi boyunca yeni istek gelir veya iþlem yapýlýrsa oturum süresi sýfýrlanýr.
                options.AccessDeniedPath = "/administration/login"; // authentication yoksa yönlendirilecek yer
            });


            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // cookie transaction services

            services.Configure<CookiePolicyOptions>(options => // coocike write to user pc transaction services
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "home",
                    pattern: "/",
                    defaults: new { controller = "Home", action = "Index" });


                endpoints.MapAreaControllerRoute(
                    name: "adminLogin",
                    areaName: "administration",
                    pattern: "/administration/login",
                    defaults: new { controller = "Login", action = "Index" });




            });
        }
    }
}
