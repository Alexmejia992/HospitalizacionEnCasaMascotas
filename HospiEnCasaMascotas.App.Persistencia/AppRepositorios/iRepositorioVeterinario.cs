using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Persistencia
{

   public interface  iRepositorioVeterinario {

    IEnumerable<Veterinario> GetAllVeterinario();

    Veterinario AddVeterinario(Veterinario veterinario);

    Veterinario UpdateVeterinario  (Veterinario veterinario);

    void DeleteVeterinario(int idVeterinario);

    Veterinario GetVeterinario(int idVeterinario);
    }
}