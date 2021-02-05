using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TrakingLibrary.API
{
    public class Startup
    {

        private const string AllCors = "All";
        
        public void ConfigureServices(IServiceCollection services)
        {
            // Documentation
            services.AddControllers();
            // Documentation
            services.AddCors(
                options => options.AddPolicy(
                    AllCors,
                    build =>
                        build.AllowAnyHeader()
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                    )
                );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Documentation
            app.UseRouting();
            // Documentation
            app.UseCors(AllCors);
            // Documentation
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}