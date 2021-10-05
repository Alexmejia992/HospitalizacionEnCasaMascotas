using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Persistencia
{

   public interface iRepositorioMascotaPaciente {

    IEnumerable<MascotaPaciente> GetAllMascotaPaciente();

    MascotaPaciente AddMascotaPaciente(MascotaPaciente mascotapaciente);

    MascotaPaciente UpdateMascotaPaciente  (MascotaPaciente mascotapaciente);

    void DeleteMascotaPaciente(int idMascotaPaciente);

    MascotaPaciente GetMascotaPaciente(int idMascotaPaciente);
    }
}