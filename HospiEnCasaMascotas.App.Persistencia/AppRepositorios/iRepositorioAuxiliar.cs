using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Persistencia
{

   public interface  iRepositorioAuxiliar {

    IEnumerable<Auxiliar> GetAllAuxiliar();

    Auxiliar AddAuxiliar(Auxiliar auxiliar);

    Auxiliar UpdateAuxiliar  (Auxiliar auxiliar);

    void DeleteAuxiliar(int idAuxiliar);

    Auxiliar GetAuxiliar(int idAuxiliar);
    }
}