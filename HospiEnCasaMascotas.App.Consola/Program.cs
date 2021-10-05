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

            var Rockysano= new Mascota{
                 Id=1,
                 NombreMascota="Rocky111",
                 Especie="Perro1111",
                 Raza="Criollo1111",
                 Edad="14 años1111"
                };
            //AddMascota();
            //BuscarMascota(1);
            //BorrarMascota(2);
            //ActualizarMascota(Rockysano);

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
        private static void BuscarMascota(int idMascota){
           var Mascota= _repoMascota.GetMascota(idMascota);
           Console.WriteLine("Paciente encontrado"+Mascota.NombreMascota+" "+Mascota.Raza);
        }

        private static void BorrarMascota(int idMascota){
            _repoMascota.DeleteMascota(idMascota);
            Console.WriteLine("La mascota fue borrada");
        }
             
           
        private static void ActualizarMascota(Mascota Rockysano){
             
                var Mascotaactualizada=_repoMascota.UpdateMascota(Rockysano);
                Console.WriteLine("La mascota se actualizo");
            
        }

    }
}
