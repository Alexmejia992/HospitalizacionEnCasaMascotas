using System;
using HospiEnCasaMascotas.App.Dominio;
using HospiEnCasaMascotas.App.Persistencia;

namespace HospiEnCasaMascotas.App.Consola
{
    class Program
    {

         private static iRepositorioMascota _repoMascota = new MascotaRepositorio(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddMascota();
        }
        private static void AddMascota()
        {
             var mascota=new Mascota {

                 NombreMascota="Firulais",
                 Especie="Perro",
                 Raza="Criollo",
                 Edad="14 años"

             };
             _repoMascota.AddMascota(mascota);
        }

    }
}
