namespace Eventmi
{
	using Microsoft.AspNetCore.Identity;
	using Microsoft.EntityFrameworkCore;

	using Data;
	using Eventmi.Services.Contracts;
	using Eventmi.Services;

	public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            string connectionString = builder.Configuration.GetConnectionString("TyanataConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<EventmiDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
			})
                .AddEntityFrameworkStores<EventmiDbContext>();

            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IEventService, EventServie>();

            WebApplication app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                //Added developer exception page
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //Changed the controller route to the default one
            app.MapDefaultControllerRoute();
            app.MapRazorPages();

            app.Run();
        }
    }
}