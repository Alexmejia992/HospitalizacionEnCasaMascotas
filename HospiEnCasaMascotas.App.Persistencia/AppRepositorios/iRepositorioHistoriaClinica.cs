using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Persistencia
{

   public interface iRepositorioHistoriaClinica {

    IEnumerable<HistoriaClinica> GetAllHistoriaClinica();

    HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaClinica);

    HistoriaClinica UpdateHistoriaClinica  (HistoriaClinica historiaClinica);

    void DeleteHistoriaClinica(int idHistoriaClinica);

    HistoriaClinica GetHistoriaClinica(int idHistoriaClinica);
    }
}