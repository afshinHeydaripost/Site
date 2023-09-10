//using Microsoft.AspNetCore.Hosting;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Repository.Identity;
//using Site.Areas.Identity.Data;
//using System;

//[assembly: HostingStartup(typeof(Site.Areas.Identity.IdentityHostingStartup))]
//namespace Site.Areas.Identity
//{
//    public class IdentityHostingStartup : IHostingStartup
//    {
//        public void Configure(IWebHostBuilder builder)
//        {
//            builder.ConfigureServices((context, services) =>
//            {
//                services.AddDbContext<UserContext>(options =>
//                    options.UseSqlServer(
//                        context.Configuration.GetConnectionString("MainConnection")));

//                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
//                    .AddEntityFrameworkStores<UserContext>()
//                    .AddErrorDescriber<LocalizedIdentityErrorDescriber>();
//                services.ConfigureApplicationCookie(options =>
//                {
//                    // Cookie settings
//                    options.Cookie.HttpOnly = true;
//                    options.ExpireTimeSpan = TimeSpan.FromMinutes(10000);

//                    options.LoginPath = "/Identity/Account/Login";
//                    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
//                });
//            });
//        }
//    }
//}