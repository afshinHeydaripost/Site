using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Identity;
using Site.Areas.Identity.Data;

namespace Site
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			#region Context
			string connection = builder.Configuration.GetConnectionString("MainConnection");
			builder.Services.AddDbContext<dbContext>(options => options.UseSqlServer(connection).EnableSensitiveDataLogging());
			#endregion
		
			#region Post in Ajax
			builder.Services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
			#endregion

			#region Identity
			builder.Services.AddDbContext<UserContext>(options =>
							options.UseSqlServer(connection));

			builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
			//.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedPhoneNumber = true)
				.AddEntityFrameworkStores<UserContext>()
				.AddDefaultTokenProviders();
			builder.Services.ConfigureApplicationCookie(options =>
			{
				// Cookie settings
				options.Cookie.HttpOnly = true;
				options.ExpireTimeSpan = TimeSpan.FromDays(365);


				options.LoginPath = "/Identity/Account/Login";
				options.AccessDeniedPath = "/Identity/Account/AccessDenied";
			});

			builder.Services.Configure<IdentityOptions>(options =>
			{
				options.Password.RequireDigit = false;
				options.Password.RequireLowercase = false;
				options.Password.RequireNonAlphanumeric = false;
				options.Password.RequireUppercase = false;
				options.Password.RequiredLength = 5;
				options.Password.RequiredUniqueChars = 0;
				options.SignIn.RequireConfirmedAccount = false;
				options.SignIn.RequireConfirmedEmail = false;
				options.SignIn.RequireConfirmedPhoneNumber = true;
			});
			builder.Services.Configure<SecurityStampValidatorOptions>(options =>
			{
				// enables immediate logout, after updating the user's stat.
				options.ValidationInterval = TimeSpan.Zero;
			});
			#endregion
			// Add services to the container.
			builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
			}
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();
			app.MapRazorPages();

			app.Run();
		}
	}
}