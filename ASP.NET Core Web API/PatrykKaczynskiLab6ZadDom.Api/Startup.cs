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
            //metoda AddScoped zapewnia, �e implementacja interfejsu b�dzie pojedyncza przez ca�e ��danie HTTP,
            //dzi�ki temu ASP.NET Core b�dzie wiedzia�, �e je�eli gdziekolwiek na wej�ciu dostaje interfejs BeerRepository jak na przyk�ad w klasie BeerService to automatycznie przypisze sobie implementacj� BeerRepository
            services.AddScoped<IBeerRepository, BeerRepository>();
            services.AddScoped<IBeerService, BeerService>();

            services.AddScoped<IWineRepository, WineRepository>();
            services.AddScoped<IWineService, WineService>();
            //metoda AddSingleton zapewnia, �e implementacja interfejsu b�dzie tworzona tylko raz (jako argument przekazywana jest instancja konfiguracji AutoMappera)
            //dzi�ki temu ASP.NET core b�dzie wiedzia� �e je�eli gdziekolwiek na wej�ciu dostanie interfejs IMapper to wstrzyknie implementacj� pochodz�c� z klasy AutoMapperConfig
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
