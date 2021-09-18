using System;

namespace HospiEnCasaMascotas.App.Dominio
{
    public class Mascota
    {
        public string IdMascota { get;set; }

        public string NombreMascota { get;set; }
        public string Especie { get;set; }
        public string Raza{ get;set; }
        public string Edad { get;set; }
    }
}