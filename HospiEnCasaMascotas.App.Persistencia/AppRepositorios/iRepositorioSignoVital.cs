using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Persistencia
{

   public interface  iRepositorioSignoVital {

    IEnumerable<SignoVital> GetAllSignoVital();

    SignoVital AddSignoVital(SignoVital signovital);

    SignoVital UpdateSignoVital  (SignoVital signovital);

    void DeleteSignoVital(int idSignoVital);

    SignoVital GetSignoVital(int idSignoVital);
    }
}