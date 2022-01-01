using Grpc.Reflection;
using iSpindel.Database;
using iSpindel.Database.Job;
using iSpindel.Server.gRPC;
using iSpindel.Server.Options;
using iSpindel.Server.Services;
using iSpindel.Shared.Factories;
using iSpindel.Shared.Options;
using Microsoft.EntityFrameworkCore;

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
            builder.Services.Configure<MqttOptions>(builder.Configuration.GetSection(MqttOptions.MqttPosition));
            builder.Services.Configure<SpindelServerOptions>(builder.Configuration.GetSection(SpindelServerOptions.SpindelServerPosition));
            builder.Services.Configure<DbOptions>(builder.Configuration.GetSection(DbOptions.DbPosition));
            builder.Services.Configure<GrpcServerOptions>(builder.Configuration.GetSection(GrpcServerOptions.GrpcServerPosition));
            builder.Services.AddSingleton<IMqttClientFactory, MqttClientFactory>();
            builder.Services.AddDbContextFactory<iSpindelContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            
            //builder.Services.AddSingleton<IDbContextFactory, DbContextFactory>();
            builder.Services.AddSingleton<ISpindelService, iSpindelServer>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<Services.RecordingService>();

            if(builder.Environment.IsDevelopment())
            {
                app.MapGrpcReflectionService();
            }

            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();

        }
    }
}