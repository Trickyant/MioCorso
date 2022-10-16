using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MioCorso
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

/*  Fatto all'inizio per far scrivere il nome in maiuscolo        
            app.Run(async (context) =>
            {
                string nome = context.Request.Query["nome"];
                await context.Response.WriteAsync($"Ciao {nome.ToUpper()}");
            });       
*/
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routeBuilder =>
            {
/*  Funziona, ma se non si inseriscono i dati mi da errore 404. Quindi dobbiamo mettere
    dei valori di default, come sulla riga successiva.              
                routeBuilder.MapRoute("default", "{controller}/{action}/{id}");
*/
                routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
