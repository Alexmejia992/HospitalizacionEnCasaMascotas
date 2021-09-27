using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Persistencia
{

   public interface iRepositorioMascota {

    IEnumerable<Mascota> GetAllMascota();

    Mascota AddMascota(Mascota mascota);

    Mascota UpdateMascota  (Mascota mascota);

    void DeleteMascota(int idMascota);

    Mascota GetMascota(int idMascota);
    }
}