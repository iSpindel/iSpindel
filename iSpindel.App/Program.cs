using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace iSpindel.App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = CreateHostBuilder(args);
            builder.Build().Run();
        }

        public static IConfiguration CreateConfiguration()
        {
            return new ConfigurationBuilder()
             .SetBasePath("/etc/ispindel/webapp")
             .AddJsonFile("appsettings.json", optional: false)
             .AddJsonFile($"appsettings.Production.json", optional: false)
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
