/*
 * Material API
 *
 * API to manage material info.
 *
 * The version of the OpenAPI document: 0.1.0
 * Contact: okarians.302.dev@gmail.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using mycocktails.api.materialApi.Logics;
using mycocktails.api.materialApi.Logics.intarfaces;
using mycocktails.api.materialApi.Models;
using mycocktails.library.entity.Models;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace mycocktails.api.materialApi
{
    /// <summary>
    /// Startup
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="env"></param>
        /// <param name="configuration"></param>
        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            // Modelise appsetting.json.
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddJsonFile("secrets/appsettings.secrets.json", optional: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        /// <summary>
        /// The application configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {

            // Add framework services.
            services
                // Don't need the full MVC stack for an API, see https://andrewlock.net/comparing-startup-between-the-asp-net-core-3-templates/
                .AddControllers()
                .AddNewtonsoftJson(opts =>
                {
                    opts.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    opts.SerializerSettings.Converters.Add(new StringEnumConverter
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    });
                });

            //DB connetion
            // directly retrieve setting instead of using strongly-typed options
            string connectionString = this.Configuration["ConnectionStrings:PostgresConnection"];
            services.AddDbContext<MyCocktailsDBContext>(options =>
               options.UseNpgsql(connectionString, o => o.UseNetTopologySuite()));

            // KeyValue set in appsettings.json to entity.
            services.Configure<AppSettingsConfig>(this.Configuration.GetSection("AppSettings"));

            // DI Logics.
            addLogic(services);
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
;
            app.UseRouting();
            app.UseEndpoints(endpoints =>
	            {
	    	        endpoints.MapControllers();
	            });
        }

        /// <summary>
        /// Add DI logics.
        /// </summary>
        /// <param name="services"></param>
        private void addLogic(IServiceCollection services)
        {
            services.AddTransient<IGetLogic, GetLogic>();
        }
    }
}