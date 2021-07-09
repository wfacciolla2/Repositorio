using CatalogoJogos.Controllers.v1;
using CatalogoJogos.Middleware;
using CatalogoJogos.Repositories;
using CatalogoJogos.Services;
using ExemploApiCatalogoJogos.Repositories;
using ExemploApiCatalogoJogos.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace CatalogoJogos
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
            services.AddSingleton<IExemploSingleton, ExemploCicloDeVida>();
            services.AddScoped<IExemploScoped, ExemploCicloDeVida>();
            services.AddTransient<IExemploTransient, ExemploCicloDeVida>();
            services.AddScoped<IJogoService, JogoService>();
            services.AddScoped<IJogoRepository, JogoSqlServerRepository>();
            //Configuração dos serviços utilizados
            services.AddControllers();
            //services.AddControllersWithViews(); //Caso fosse uma API MVC
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CatalogoJogos", Version = "v1" });

                var basePath = AppDomain.CurrentDomain.BaseDirectory;
                var fileName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
                c.IncludeXmlComments(Path.Combine(basePath, fileName));
            });
        }

        // Configura os serviços. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Configura o ambiente de desenvolvimento
            if (env.IsDevelopment()) //O que esta aqui dentro fica disponivel
            {
                app.UseDeveloperExceptionPage(); //Mostra o erro dentro da aplicação
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CatalogoJogos v1"));
            }
            app.UseMiddleware<ExceptionMiddleware>();

            app.UseHttpsRedirection();
            //Usa roteamento
            app.UseRouting();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
