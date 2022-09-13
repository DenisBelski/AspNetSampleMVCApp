using AspNetSample.DataBase;
using AspNetSample.Business.ServicesImplementations;
using AspNetSample.Core;
using AspNetSample.Core.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Routing.Constraints;
using Serilog;
using Serilog.Events;

namespace AspNetSampleMvcApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Host.UseSerilog((ctx, lc) => 
                lc.WriteTo.File(@"D:\IT\C#\AspNetSampleMVCApp\Logs\data.log",
                LogEventLevel.Information)
                .WriteTo.Console(LogEventLevel.Verbose));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var connectionString = builder.Configuration.GetConnectionString("Default");
                //"Server=DESKTOP-LNVP1TV;Database=GoodNewsAggregatorDataBase;Trusted_Connection=True;";

            builder.Services.AddDbContext<GoodNewsAggregatorContext>(optionsBuilder => optionsBuilder.UseSqlServer(connectionString));
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddScoped<IArticleService, ArticleService>();

            var app = builder.Build();

            builder.Configuration.AddJsonFile("secrets.json");
            //builder.Configuration.Add(new TxtConfigurationSource());

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

            //app.MapControllerRoute(
            //    name: "default1",
            //    pattern: "{action}/{controller}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "article",
                pattern: "{page}/{action=Index}/{controller=Article}",
                defaults: new {controller= "Article", action = "Index"},
                constraints: new {page = new IntRouteConstraint()});

            app.Run();
        }
    }
}