using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoOficinas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Configuração dos serviços que são utilizados no projeto.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            //Implementação do Swagger e controle de versão.
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiCatalogoOficinas", Version = "V1" });
            });
        }

        // Verifica se o ambiente é de desenvolvimento, launchSetthings contém as descriminações 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Manter dentro do if sempre.
                //Para sair do ambiente de desenvolvimento e liberar acesso externo, coloque essas 2 linhas após o }
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiCatalogoOficinas v1"));
            }
            //Para liberar acesso externo.
            //app.UseSwagger();
            //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiCatalogoOficinas v1"));

            //Redireciona a requisição para  Https.
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //Mapeamento dos end points da aplicação
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
