using Grpc.Reflection;
using iSpindel.Database;
using iSpindel.Database.Job;
using iSpindel.Server.gRPC;
using iSpindel.Server.Options;
using iSpindel.Server.Services;
using iSpindel.Shared.Factories;
using iSpindel.Shared.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql;

namespace iSpindel.Server
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Additional configuration is required to successfully run gRPC on macOS.
            // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

            // Add services to the container.
            builder.Services.AddGrpc();
            builder.Services.AddGrpcReflection();
            builder.Configuration
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", optional: false)
#if DEBUG
                                    .AddJsonFile("appsettings.Development.json", optional: true)
#else
                                    .AddJsonFile("appsettings.Production.json", optional: true)
#endif
                                    .AddEnvironmentVariables();
            builder.Services.Configure<MqttOptions>(builder.Configuration.GetSection(MqttOptions.MqttPosition));
            builder.Services.Configure<SpindelServerOptions>(builder.Configuration.GetSection(SpindelServerOptions.SpindelServerPosition));
            builder.Services.Configure<DbOptions>(builder.Configuration.GetSection(DbOptions.DbPosition));
            builder.Services.Configure<GrpcServerOptions>(builder.Configuration.GetSection(GrpcServerOptions.GrpcServerPosition));
            builder.Services.AddSingleton<IMqttClientFactory, MqttClientFactory>();

            ConfigureDB(builder);

            builder.Services.AddSingleton<ISpindelService, iSpindelServer>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<Services.RecordingService>();

            if (builder.Environment.IsDevelopment())
            {
                app.MapGrpcReflectionService();
            }

            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();

        }

        public static void ConfigureDB(WebApplicationBuilder builder)
        {
            var connectionStringBuilder = new NpgsqlConnectionStringBuilder(builder.Configuration.GetConnectionString("DefaultConnection"))
            {
                ApplicationName = "iSpindel.DataIngestor"
            };
            if (!string.IsNullOrWhiteSpace(builder.Configuration["Database:Username"]) && !string.IsNullOrWhiteSpace(builder.Configuration["Database:Password"]))
            {
                connectionStringBuilder.Username = builder.Configuration["Database:Username"];
                connectionStringBuilder.Password = builder.Configuration["Database:Password"];
                connectionStringBuilder.IntegratedSecurity = false;
            }

            builder.Services.AddDbContext<iSpindelContext>(options =>
                options.UseNpgsql(connectionStringBuilder.ConnectionString)
                .ReplaceService<IHistoryRepository, iSpindelHistoryRepository>(),
                optionsLifetime: ServiceLifetime.Singleton
           );

            builder.Services.AddDbContextFactory<iSpindelContext>(options => { }, ServiceLifetime.Singleton);
        }
    }
}