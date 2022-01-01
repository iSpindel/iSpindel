using Grpc.Net.Client;
using iSpindel.App.Data;
using iSpindel.App.Extensions;
using iSpindel.App.Hubs;
using iSpindel.App.Models;
using iSpindel.App.Services;
using iSpindel.App.Settings;
using iSpindel.Database;
using iSpindel.Server.gRPC;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Npgsql;

namespace iSpindel.App
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            MapConfiguration();
        }

        private void MapConfiguration()
        {
            MapMQTTSettings();
            MapGrpcSettings();
        }

        private void MapMQTTSettings()
        {
            MqttConnectionSettings mqttConnectionSettings = new MqttConnectionSettings();
            Configuration.GetSection("Mqtt").Bind(mqttConnectionSettings);
            AppSettingsProvider.MQTTSettings = mqttConnectionSettings;
        }

        private void MapGrpcSettings()
        {
            GrpcOptions grpcOptions = new GrpcOptions();
            Configuration.GetSection("Grpc").Bind(grpcOptions);
            AppSettingsProvider.GrpcSettings = grpcOptions;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var connectionStringBuilder = new NpgsqlConnectionStringBuilder(Configuration.GetConnectionString("DefaultConnection"))
            {
                ApplicationName = "iSpindel.App"
            };
            if (!string.IsNullOrWhiteSpace(Configuration["Database:Username"]) && !string.IsNullOrWhiteSpace(Configuration["Database:Password"]))
            {
                connectionStringBuilder.Username = Configuration["Database:Username"];
                connectionStringBuilder.Password = Configuration["Database:Password"];
                connectionStringBuilder.IntegratedSecurity = false;
            }

            services.Configure<MqttConnectionSettings>(Configuration.GetSection("Mqtt"));
            services.Configure<GrpcOptions>(Configuration.GetSection(GrpcOptions.Position));


            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionStringBuilder.ConnectionString)
                .ReplaceService<IHistoryRepository, ApplicationHistoryRepository>()
            );

            services.AddDbContext<iSpindelContext>(options =>
                options.UseNpgsql(connectionStringBuilder.ConnectionString)
                .ReplaceService<IHistoryRepository, iSpindelHistoryRepository>()
           );

            services.AddSignalR(options =>
             {
#if DEBUG
                 options.EnableDetailedErrors = true;
#endif
             });

            services.AddMqttClientHostedService();
            /*

            services.AddGrpcClient<RecordingService.RecordingServiceClient>(client =>
            {
                client.Address = new Uri("https://localhost:5001");
            });
            */
            services.AddSingleton(serviceProvider =>
            {
                var _grpcOptions = AppSettingsProvider.GrpcSettings;
                return new RecordingService.RecordingServiceClient(
                    GrpcChannel.ForAddress($"{_grpcOptions.Protocol}://{_grpcOptions.Host}:{_grpcOptions.Port}", new GrpcChannelOptions(){ Credentials = Grpc.Core.ChannelCredentials.Insecure })
                        );

            });

            services.AddSingleton<ISpindelClient, SpindelClient>();

            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<ApplicationDbContext>();

            IIdentityServerBuilder identityServerBuilder = services.AddIdentityServer()
                                                                   .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

            services.AddAuthentication()
                .AddIdentityServerJwt();
            services.AddControllersWithViews();
            services.AddRazorPages();
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "./dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            //app.UseAuthentication();
            //app.UseIdentityServer();
            //app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<NotifyHub>("/notify");
                endpoints.MapHub<MqttBridgeHub>("/bridge");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "../iSpindel.ClientApp";

                if (env.IsDevelopment())
                {
                    //spa.UseAngularCliServer(npmScript: "start");
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
                }
            });
        }
    }
}
