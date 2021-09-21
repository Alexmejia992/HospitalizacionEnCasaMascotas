using Microsoft.EntityFrameworkCore;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}      
        public DbSet<PropietarioDesignado> PropietariosDesignados{get;set;}
        public DbSet<HistoriaClinica> HistoriasClinicas {get;set;}

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
         if (!optionsBuilder.IsConfigured)
         {
             optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =HospiEnCasaMascotasData");
         }
     }   
    }
}