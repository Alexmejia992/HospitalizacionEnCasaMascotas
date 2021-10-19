using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HospiEnCasaMascotas.App.Persistencia;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Frontend
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
            services.AddRazorPages();
            services.AddControllersWithViews();
            // .AddRazorPagesOptions(options => {
            //     options.RootDirectory = "/Pages";
            // });

            services.AddSingleton<iRepositorioMascota,MascotaRepositorio>();
            services.AddSingleton<iRepositorioMascotaPaciente,MascotaPacienteRepositorio>();
            services.AddSingleton<iRepositorioAuxiliar,AuxiliarRepositorio>();
            services.AddSingleton<iRepositorioHistoriaClinica,HistoriaClinicaRepositorio>();
            services.AddSingleton<iRepositorioPersona,PersonaRepositorio>();
            services.AddSingleton<iRepositorioPropietarioDesignado,PropietarioDesignadoRepositorio>();
            services.AddSingleton<iRepositorioSignoVital,SignoVitalRepositorio>();
            services.AddSingleton<iRepositorioSugerenciaCuidado,SugerenciaCuidadoRepositorio>();
            services.AddSingleton<iRepositorioVeterinario,VeterinarioRepositorio>();



            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
