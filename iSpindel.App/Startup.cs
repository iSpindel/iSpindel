using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using iSpindel.App.Data;
using iSpindel.App.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using iSpindel.Database;
using Npgsql;
using Microsoft.EntityFrameworkCore.Migrations;
using iSpindel.App.Settings;
using iSpindel.App.Extensions;
using iSpindel.App.Hubs;

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
        }

        private void MapMQTTSettings()
        {
            MqttConnectionSettings mqttConnectionSettings = new MqttConnectionSettings();
            Configuration.GetSection("Mqtt").Bind(mqttConnectionSettings);
            AppSettingsProvider.MQTTSettings = mqttConnectionSettings;
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

            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentityServer()
                .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

            services.AddAuthentication()
                .AddIdentityServerJwt();
            services.AddControllersWithViews();
            services.AddRazorPages();
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "../iSpindel.ClientApp/dist";
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

            app.UseAuthentication();
            app.UseIdentityServer();
            app.UseAuthorization();
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
