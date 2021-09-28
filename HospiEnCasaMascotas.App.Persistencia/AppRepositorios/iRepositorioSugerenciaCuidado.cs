using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Persistencia
{

   public interface  iRepositorioSugerenciaCuidado {

    IEnumerable<SugerenciaCuidado> GetAllSugerenciaCuidado();

    SugerenciaCuidado AddSugerenciaCuidado(SugerenciaCuidado sugerenciacuidado);

    SugerenciaCuidado UpdateSugerenciaCuidado  (SugerenciaCuidado sugerenciacuidado);

    void DeleteSugerenciaCuidado(int idSugerenciaCuidado);

    SugerenciaCuidado GetSugerenciaCuidado(int idSugerenciaCuidado);
    }
}