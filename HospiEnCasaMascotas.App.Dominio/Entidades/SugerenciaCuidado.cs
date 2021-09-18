using System;

namespace HospiEnCasaMascotas.App.Dominio
{
    public class SugerenciaCuidado
    {
        public int Id { get; set; }

        public DateTime FechaHora  { get; set; }

        public string alimentacion_saludable {get;set;}

        public string Limpieza_heridas{get;set;}

        public string Ejercicios{get;set;}
    }
}