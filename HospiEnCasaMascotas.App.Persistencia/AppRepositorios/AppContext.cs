using Microsoft.EntityFrameworkCore;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}      
        public DbSet<PropietarioDesignado> PropietariosDesignados{get;set;}
        public DbSet<HistoriaClinica> HistoriasClinicas {get;set;}
        public DbSet<Auxiliar> Auxiliares {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}
        public DbSet<MascotaPaciente> MascotasPacientes {get;set;}
        public DbSet<SignoVital> SignosVitales {get;set;}
        public DbSet<SugerenciaCuidado> SugerenciasCuidado {get;set;}
        public DbSet<Veterinario> Veterinarios {get;set;}

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
         if (!optionsBuilder.IsConfigured)
         {
            optionsBuilder.UseSqlServer("Server=tcp:hospimascotas.database.windows.net,1433;Initial Catalog=HospiMascotasData;Persist Security Info=False;User ID=dem_yamejia;Password=Azure1071166596//;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
         }
     }   
    }
}