using System;

namespace HospiEnCasaMascotas.App.Dominio
{
    public class HistoriaClinica
    {
        public int Id { get; set; }

         public string Diagnostico  { get; set; }

         public List<SugerenciaCuidado> Sugerencias { get; set; }
    }
}