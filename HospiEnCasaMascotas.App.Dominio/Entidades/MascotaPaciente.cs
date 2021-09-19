using System;

namespace HospiEnCasaMascotas.App.Dominio
{
     public class MascotaPaciente : Mascota
    {
        

        
        public string Direccion { get; set; }
        
        public float Latitud { get; set; }
        
        public float Longitud { get; set; }
        
        public string Ciudad { get; set; }
        
        public PorpietarioDesignado propietario {get; set;}

        public Veterinario Veterinario{get; set;}

        public Auxiliar Auxiliar{get; set;}

        public HistoriaClinica historia {get; set;}

        public System.Collections.Generic.List<SignoVital> SignosVitales { get; set; }
        
    }
}