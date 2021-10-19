using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;
using System.Linq;

namespace HospiEnCasaMascotas.App.Persistencia{


    public class VeterinarioRepositorio : iRepositorioVeterinario
    {


        private readonly AppContext _appContext = new AppContext();

        // public VeterinarioRepositorio(AppContext appContext){
        //     _appContext=appContext;
        // }
        public Veterinario AddVeterinario(Veterinario veterinario)
        {
            var VeterinarioAdicionada= _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return VeterinarioAdicionada.Entity;
               }

        public void DeleteVeterinario(int idVeterinario)
        {
            var VeterinarioEncontrada=_appContext.Veterinarios.FirstOrDefault(v =>v.Id==idVeterinario);
            if(VeterinarioEncontrada==null)
            return;
            _appContext.Veterinarios.Remove(VeterinarioEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<Veterinario> GetAllVeterinario()
        {
            return _appContext.Veterinarios;
        }

        public Veterinario GetVeterinario(int idVeterinario)
        {
            return _appContext.Veterinarios.FirstOrDefault(v =>v.Id==idVeterinario);
        }

        public Veterinario UpdateVeterinario(Veterinario veterinario)
        {
            var VeterinarioEncontrada=_appContext.Veterinarios.FirstOrDefault(v =>v.Id==veterinario.Id);

            if(VeterinarioEncontrada!=null)
            {
                VeterinarioEncontrada.Nombre=veterinario.Nombre;
                VeterinarioEncontrada.Apellidos=veterinario.Apellidos;
                VeterinarioEncontrada.NumeroTelefono=veterinario.NumeroTelefono;
                VeterinarioEncontrada.Genero=veterinario.Genero;
                VeterinarioEncontrada.NumPermiso=veterinario.NumPermiso;
                VeterinarioEncontrada.especialidad=veterinario.especialidad;
                // VeterinarioEncontrada.correo=veterinario.correo;
                // VeterinarioEncontrada.contraseña=veterinario.contraseña;
                

                _appContext.SaveChanges() ;
                

            }
            return VeterinarioEncontrada;
        }
    }
}