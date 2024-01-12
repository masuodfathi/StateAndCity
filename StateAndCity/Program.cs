using Microsoft.EntityFrameworkCore;
using StateAndCity.Data;
using StateAndCity.Interfaces;
using StateAndCity.Repository;
using StateAndCity.Services;

namespace StateAndCity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DataContext>(options => 
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddTransient<IStateRepository, StateRepository>();
            builder.Services.AddTransient<ICityRepository, CityRepository>();
            builder.Services.AddTransient<IStateService,StateService>();
            builder.Services.AddTransient<ICityService, CityService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
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

            app.Run();
        }
    }
}
