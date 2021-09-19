using Microsoft.EntityFrameworkCore;

namespace HospiEnCasaMascotas.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Persona {get;set;}
    }
}