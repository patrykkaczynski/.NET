using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PatrykKaczynskiLab6ZadDom.Core.Repositories;
using PatrykKaczynskiLab6ZadDom.Infrastructure.Mappers;
using PatrykKaczynskiLab6ZadDom.Infrastructure.Repositories;
using PatrykKaczynskiLab6ZadDom.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab6ZadDom.Api
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
            //metoda AddScoped zapewnia, ¿e implementacja interfejsu bêdzie pojedyncza przez ca³e ¿¹danie HTTP,
            //dziêki temu ASP.NET Core bêdzie wiedzia³, ¿e je¿eli gdziekolwiek na wejœciu dostaje interfejs BeerRepository jak na przyk³ad w klasie BeerService to automatycznie przypisze sobie implementacjê BeerRepository
            services.AddScoped<IBeerRepository, BeerRepository>();
            services.AddScoped<IBeerService, BeerService>();

            services.AddScoped<IWineRepository, WineRepository>();
            services.AddScoped<IWineService, WineService>();
            //metoda AddSingleton zapewnia, ¿e implementacja interfejsu bêdzie tworzona tylko raz (jako argument przekazywana jest instancja konfiguracji AutoMappera)
            //dziêki temu ASP.NET core bêdzie wiedzia³ ¿e je¿eli gdziekolwiek na wejœciu dostanie interfejs IMapper to wstrzyknie implementacjê pochodz¹c¹ z klasy AutoMapperConfig
            services.AddSingleton(AutoMapperConfig.Initialize());

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PatrykKaczynskiLab6ZadDom.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PatrykKaczynskiLab6ZadDom.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
