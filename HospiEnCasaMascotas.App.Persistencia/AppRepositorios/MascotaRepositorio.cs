
using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;
using System.Linq;

namespace HospiEnCasaMascotas.App.Persistencia{


    public class MascotaRepositorio : iRepositorioMascota
    {


        private readonly AppContext _appContext;

        public MascotaRepositorio(AppContext appContext){
            _appContext=appContext;
        }
        public Mascota AddMascota(Mascota mascota)
        {
            var MascotaAdicionada= _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return MascotaAdicionada.Entity;
               }

        public void DeleteMascota(int idMascota)
        {
            var MascotaEncontrada=_appContext.Mascotas.FirstOrDefault(m =>m.Id==idMascota);
            if(MascotaEncontrada==null)
            return;
            _appContext.Mascotas.Remove(MascotaEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<Mascota> GetAllMascota()
        {
            return _appContext.Mascotas;
        }

        public Mascota GetMascota(int idMascota)
        {
            return _appContext.Mascotas.FirstOrDefault(m =>m.Id==idMascota);
        }

        public Mascota UpdateMascota(Mascota mascota)
        {
            var MascotaEncontrada=_appContext.Mascotas.FirstOrDefault(m =>m.Id==mascota.Id);

            if(MascotaEncontrada!=null)
            {
                MascotaEncontrada.NombreMascota=mascota.NombreMascota;
                MascotaEncontrada.Especie=mascota.Especie;
                MascotaEncontrada.Raza=mascota.Raza;
                MascotaEncontrada.generoMascota=mascota.generoMascota;
                MascotaEncontrada.Edad=mascota.Edad;

                _appContext.SaveChanges();
                

            }
            return MascotaEncontrada;
        }
    }
}