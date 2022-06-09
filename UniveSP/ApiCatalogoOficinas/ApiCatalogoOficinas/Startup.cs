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

        // Configura��o dos servi�os que s�o utilizados no projeto.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            //Implementa��o do Swagger e controle de vers�o.
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiCatalogoOficinas", Version = "V1" });
            });
        }

        // Verifica se o ambiente � de desenvolvimento, launchSetthings cont�m as descrimina��es 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Manter dentro do if sempre.
                //Para sair do ambiente de desenvolvimento e liberar acesso externo, coloque essas 2 linhas ap�s o }
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiCatalogoOficinas v1"));
            }
            //Para liberar acesso externo.
            //app.UseSwagger();
            //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiCatalogoOficinas v1"));

            //Redireciona a requisi��o para  Https.
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //Mapeamento dos end points da aplica��o
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
