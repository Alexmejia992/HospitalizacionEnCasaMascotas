using System;

namespace HospiEnCasaMascotas.App.Dominio
{
    public class Mascota
    {
        public int Id { get;set; }

        public string NombreMascota { get;set; }

        public string Especie { get;set; }

        public string Raza { get;set; }

        public GeneroMascota generoMascota { get;set; }

        public string Edad { get;set; }
    }
}
