using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;
using System.Linq;

namespace HospiEnCasaMascotas.App.Persistencia{


    public class MascotaPacienteRepositorio : iRepositorioMascotaPaciente
    {


        private readonly AppContext _appContext= new AppContext();

        // public MascotaPacienteRepositorio(AppContext appContext){
        //     _appContext=appContext;
        // }
        public MascotaPaciente AddMascotaPaciente(MascotaPaciente mascotapaciente)
        {
            var MascotaPacienteAdicionada= _appContext.MascotasPacientes.Add(mascotapaciente);
            _appContext.SaveChanges();
            return MascotaPacienteAdicionada.Entity;
               }

        public void DeleteMascotaPaciente(int idMascotaPaciente)
        {
            var MascotaPacienteEncontrada=_appContext.MascotasPacientes.FirstOrDefault(m =>m.Id==idMascotaPaciente);
            if(MascotaPacienteEncontrada==null)
            return;
            _appContext.MascotasPacientes.Remove(MascotaPacienteEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<MascotaPaciente> GetAllMascotaPaciente()
        {
            return _appContext.MascotasPacientes;
        }

        public MascotaPaciente GetMascotaPaciente(int idMascotaPaciente)
        {
            return _appContext.MascotasPacientes.FirstOrDefault(m =>m.Id==idMascotaPaciente);
        }

        public MascotaPaciente UpdateMascotaPaciente(MascotaPaciente mascotapaciente)
        {
            var MascotaPacienteEncontrada=_appContext.MascotasPacientes.FirstOrDefault(m =>m.Id==mascotapaciente.Id);

            if(MascotaPacienteEncontrada!=null)
            {
                MascotaPacienteEncontrada.Id=mascotapaciente.Id;
                MascotaPacienteEncontrada.NombreMascota=mascotapaciente.NombreMascota;
                MascotaPacienteEncontrada.Especie=mascotapaciente.Especie;
                MascotaPacienteEncontrada.Raza=mascotapaciente.Raza;
                MascotaPacienteEncontrada.generoMascota=mascotapaciente.generoMascota;
                MascotaPacienteEncontrada.Edad=mascotapaciente.Edad;
                MascotaPacienteEncontrada.Direccion=mascotapaciente.Direccion;
                MascotaPacienteEncontrada.Latitud=mascotapaciente.Latitud;
                MascotaPacienteEncontrada.Longitud=mascotapaciente.Longitud;
                MascotaPacienteEncontrada.Ciudad=mascotapaciente.Ciudad;
                MascotaPacienteEncontrada.propietario=mascotapaciente.propietario;
                MascotaPacienteEncontrada.veterinario=mascotapaciente.veterinario;
                MascotaPacienteEncontrada.auxiliar=mascotapaciente.auxiliar;
                MascotaPacienteEncontrada.historia=mascotapaciente.historia;
                MascotaPacienteEncontrada.SignosVitales=mascotapaciente.SignosVitales;


                _appContext.SaveChanges() ;
                

            }
            return MascotaPacienteEncontrada;
        }
    }
}