using Core.Entities;
using Infrastructure;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web.ViewsModels;

namespace web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));
            });
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            services.AddSession(options => options.IdleTimeout = TimeSpan.FromMinutes(15));
            services.AddIdentity<Rater, IdentityRole<Guid>>()
                .AddEntityFrameworkStores<DataContext>();
            services.AddHttpContextAccessor();
            services.AddRazorPages();
            services.AddAuthentication()
       .AddGoogle(options =>
       {
           IConfigurationSection googleAuthNSection =
               Configuration.GetSection("Authentication:Google");

           options.ClientId = googleAuthNSection["ClientId"];
           options.ClientSecret = googleAuthNSection["ClientSecret"];
           options.ClaimActions.MapJsonKey("Account:picture", "picture", "url");
       })
       .AddFacebook(options =>
       {
           IConfigurationSection facebookAuthNSection =
               Configuration.GetSection("Authentication:Facebook");

           options.AppId = facebookAuthNSection["AppId"];
           options.AppSecret = facebookAuthNSection["AppSecret"];
           options.ClaimActions.MapJsonKey("Account:picture", "picture", "url");
       }).AddMicrosoftAccount(options =>
       {
           IConfigurationSection microsoftAccountAuthNSection =
               Configuration.GetSection("Authentication:MicrosoftAccount");

           options.ClientId = microsoftAccountAuthNSection["ClientId"];
           options.ClientSecret = microsoftAccountAuthNSection["ClientSecret"];
           options.ClaimActions.MapJsonKey("Account:picture", "picture", "url");
        //}).AddTwitter(options =>
        //    {
        //    IConfigurationSection facebookAuthNSection =
        //        Configuration.GetSection("Authentication:Facebook");

        //    options. = facebookAuthNSection["AppId"];
        //    options.AppSecret = facebookAuthNSection["AppSecret"];
        //    options.ClaimActions.MapJsonKey("urn:facebook:picture", "picture", "url");
        });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
