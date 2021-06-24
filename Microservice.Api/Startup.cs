using AutoMapper;
using Microservice.Api.Database;
using Microservice.Api.Models;
using Microservice.API.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Microservice
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

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddOptions();
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = context =>
                {
                    var problemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Type = "One or more body to model validation errors occured",
                        Status = StatusCodes.Status422UnprocessableEntity,
                        Detail = "See the errors property for more details",
                        Instance = context.HttpContext.Request.Path
                    };

                    return new UnprocessableEntityObjectResult(problemDetails)
                    {
                        ContentTypes = { "application/problem+json" }
                    };
                };
            });

            // inject configuration settings
            services.AddDbContext<DatabaseContext>(opt => opt.UseSqlServer(Configuration["ConnectionStrings:phototravel"]));

            // inject configuration settings to other projects
            //services.Configure<ResultsService.Application.ConfigurationOptions>("Application", Configuration.GetSection("Application"));
            
            services.AddSingleton<IHostedService, HostedService>();
            services.AddScoped<IPhotoTravelRepository, PhotoTravelRepository>();


            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new PhoTravelMappings());
            });

            services.AddSingleton<IMapper>(config.CreateMapper());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
