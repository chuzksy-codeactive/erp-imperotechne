using Cache.API.Data;
using Cache.API.Data.Interface;
using Cache.API.Middlewares;
using Cache.API.Model;
using Cache.API.Repositories;
using Cache.API.Repositories.Interface;
using Cache.API.Validations;
using ERP.EventBus;
using ERP.EventBus.Producer;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RabbitMQ.Client;
using StackExchange.Redis;

namespace Cache.API
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

            #region Redis Dependencies
            services.AddSingleton<ConnectionMultiplexer>(sp =>
            {
                var configuration = ConfigurationOptions.Parse(Configuration.GetConnectionString("Redis"), true);
                return ConnectionMultiplexer.Connect(configuration);
            }); 
            #endregion

            #region Project Dependencies
            services.AddTransient<ICacheContext, CacheContext>();
            services.AddTransient<IMtoRepository, MtoRepository>();
            services.AddAutoMapper(typeof(Startup));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest)
                .ConfigureApiBehaviorOptions(o =>
                {
                    o.InvalidModelStateResponseFactory = context => new ValidationFailedResult(context.ModelState);
                }).AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<MaterialTakeOffDtoValidator>());
            services.AddTransient<IValidator<MaterialTakeOffDto>, MaterialTakeOffDtoValidator>();
            services.AddTransient<IValidator<MtoCivilDetailsDto>, MtoCivilDetailsDtoValidator>();
            services.AddTransient<IValidator<MtoElectricalDetailsDto>, MtoElectricalDetailsDtoValidator>();
            services.AddTransient<IValidator<MtoPipingDetailsDto>, MtoPipingDetailsDtoValidator>();
            services.AddTransient<IValidator<MtoInstrumentDetailsDto>, MtoInstrumentDetailsDtoValidator>();
            services.AddTransient<IValidator<MtoDisciplineDetailDto>, MtoDisciplineDetailDtoValidator>();
            services.AddTransient<IValidator<MtoDisciplineDetailsDto>, MtoDisciplineDetailsDtoValidaor>();
            #endregion

            #region RabbitMQ Dependencies
            services.AddSingleton<IRabbitMQConnection>(sp =>
                {
                    var factory = new ConnectionFactory()
                    {
                        HostName = Configuration["EventBus:HostName"]
                    };

                    if (!string.IsNullOrEmpty(Configuration["EventBus:UserName"]))
                    {
                        factory.UserName = Configuration["EventBus:UserName"];
                    }

                    if (!string.IsNullOrEmpty(Configuration["EventBus:Password"]))
                    {
                        factory.Password = Configuration["EventBus:Password"];
                    }

                    return new RabbitMQConnection(factory);
                });

            services.AddSingleton<MTOEventProducer>(); 
            #endregion

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cache.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cache.API v1");
                    c.RoutePrefix = string.Empty;
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseMiddleware<ErrorHandlingMiddleware>();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
