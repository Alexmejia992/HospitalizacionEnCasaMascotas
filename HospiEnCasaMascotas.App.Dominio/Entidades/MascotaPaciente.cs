using System;

namespace HospiEnCasaMascotas.App.Dominio
{
     public class MascotaPaciente : Mascota
    {
           
        public string Direccion { get; set; }
        
        
        public float Latitud { get; set; }
        
        public float Longitud { get; set; }
        
        public string Ciudad { get; set; }
        
        public PropietarioDesignado propietario {get; set;}

        public Veterinario veterinario{get; set;}

        public Auxiliar auxiliar{get; set;}

        public HistoriaClinica historia {get; set;}

        public System.Collections.Generic.List<SignoVital> SignosVitales { get; set; }
        
    }
}