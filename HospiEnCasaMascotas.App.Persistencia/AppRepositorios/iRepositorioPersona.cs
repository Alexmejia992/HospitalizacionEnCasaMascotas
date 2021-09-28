using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Persistencia
{

   public interface iRepositorioPersona {

    IEnumerable<Persona> GetAllPersona();

    Persona AddPersona(Persona persona);

    Persona UpdatePersona  (Persona persona);

    void DeletePersona(int idPersona);

    Persona GetPersona(int idPersona);
    }
}