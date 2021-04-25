using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StudentApi.Data;

namespace StudentApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();



                        //services.AddDbContext<StudentsDbContext>(
            //option => option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            var host = Configuration["DBHOST"] ?? "localhost";
            var port = Configuration["DBPORT"] ?? "1444";
            var password = Configuration["DBPASSWORD"] ?? "SqlExpress!";

            string connStr = $"Server=tcp:{host},{port};Database=funkydb;UID=sa;PWD={password};";

            services.AddDbContext<StudentsDbContext>(options =>
                options.UseSqlServer(connStr));

            services.AddCors(o => o.AddPolicy("Policy", builder => {
                builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
            }));





        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, StudentsDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();
            
            app.UseStaticFiles();
            app.UseCookiePolicy();
            
            app.UseRouting();

            app.UseAuthorization();

            context.Database.Migrate();

            app.UseCors("Policy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
