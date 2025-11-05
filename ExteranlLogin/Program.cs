using ExteranlLogin.Data;
using Microsoft.AspNetCore.Authentication.MicrosoftAccount;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ExteranlLogin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddControllersWithViews();


            //External login
            builder.Services.AddAuthentication()
                .AddMicrosoftAccount
                (
                    options => 
                    {
                        options.ClientId = builder.Configuration["Auth:Microsoft:clientID"];
                        options.ClientSecret = builder.Configuration["Auth:Microsoft:secritID"];
                    }

                )
                .AddGoogle
                (
                    options =>
                    {
                        options.ClientId = builder.Configuration["Auth:Google:clientID"];
                        options.ClientSecret = builder.Configuration["Auth:Google:secritID"];
                    }
                )
                .AddFacebook
                (
                    options =>
                    {
                        options.AppId = builder.Configuration["Auth:Facebook:clientID"];
                        options.AppSecret = builder.Configuration["Auth:Facebook:secritID"];
                    }
                );



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
