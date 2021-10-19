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
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =HospiEnCasaMascotasData");
         }
     }   
    }
}