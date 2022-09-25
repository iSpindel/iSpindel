using iSpindel.App.Data;
using iSpindel.Database;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace iSpindel.App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var dbAppContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                dbAppContext.Database.Migrate();
                var db = scope.ServiceProvider.GetRequiredService<iSpindelContext>();
                db.Database.Migrate();
            }

            host.Run();
        }

        public static IConfiguration CreateConfiguration()
        {
            return new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: false)
#if DEBUG
             .AddJsonFile($"appsettings.Development.json", optional: true)
#else
             .AddJsonFile($"appsettings.Production.json", optional: true)
#endif
             .AddEnvironmentVariables()
             .Build();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseConfiguration(CreateConfiguration())
                              .UseStartup<Startup>();
                });
    }
}
