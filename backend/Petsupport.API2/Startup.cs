using System.IO;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;
using Petsupport.API2.GraphServiceFactory;
using PetSupport.API2.AuthorizationPolicies;
using PetSupport.Core.Interfaces;
using PetSupport.Core.Services;
using PetSupport.Infrastructure.Data.Data;
using PetSupport.Infrastructure.Data.Repositories;
using System.Reflection;
using System.Text.Json;
using NLog;

namespace Petsupport.API2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), 
                "/nlog.config"));
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ILoggerService, LoggerService>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "Petsupport.API2", Version = "v1"});
            });
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                        options => options.MigrationsAssembly("Petsupport.API2"))
                    .EnableSensitiveDataLogging()
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi(
                    options =>
                    {
                        Configuration.Bind("AzureAdB2C", options);

                        options.TokenValidationParameters.NameClaimType = "name";
                    },
                    options => { Configuration.Bind("AzureAdB2C", options); });

            services.AddAuthorization(options =>
            {
                options.AddPolicy(
                    "CustomerScope",
                    policy => policy.Requirements.Add(new ScopesRequirement("Customer")));
                options.AddPolicy(
                    "SitterScope",
                    policy => policy.Requirements.Add(new ScopesRequirement("Sitter")));
            });
            
            services.AddCors(
                options =>
                {
                    options.AddPolicy(
                        "CorsDevelopmentPolicy",
                        builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
                });
            services.Configure<IISOptions>(options =>{});
            services.AddTransient<IPetsitterRepository, PetsitterRepository>();
            services.AddTransient<IBookingMessageRepository, BookingMessageRepository>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddSingleton<IGraphService, GraphService>();
            
        }
        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Petsupport.API2 v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors(env.IsDevelopment() ? "CorsDevelopmentPolicy" : "CorsReleasePolicy");
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}