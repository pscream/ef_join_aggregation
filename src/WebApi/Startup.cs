using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

using WebApi.DataContext;
using WebApi.Models.Mapping;
using WebApi.Repositories;

namespace WebApi
{

    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TimesheetContext>(
                builder => 
                {
                    builder.UseSqlServer(Configuration.GetConnectionString("Connection"));
                }
            );

            services.AddScoped<ITimesheetRepository, TimesheetRepository>();

            services.AddAutoMapper(i =>
            {
                i.AddProfile(typeof(UserProfile));
                i.AddProfile(typeof(TimesheetProfile));
            });

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

    }

}