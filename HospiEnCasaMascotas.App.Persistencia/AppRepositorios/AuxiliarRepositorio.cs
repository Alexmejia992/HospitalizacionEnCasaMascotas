using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;
using System.Linq;

namespace HospiEnCasaMascotas.App.Persistencia{


    public class AuxiliarRepositorio : iRepositorioAuxiliar
    {

        private readonly AppContext _appContext= new AppContext();

        // public AuxiliarRepositorio(AppContext appContext){
        //     _appContext=appContext;
        // }
        public Auxiliar AddAuxiliar(Auxiliar auxiliar)
        {
            var AuxiliarAdicionada= _appContext.Auxiliares.Add(auxiliar);
            _appContext.SaveChanges();
            return AuxiliarAdicionada.Entity;
               }

        public void DeleteAuxiliar(int idAuxiliar)
        {
            var AuxiliarEncontrada=_appContext.Auxiliares.FirstOrDefault(a =>a.Id==idAuxiliar);
            if(AuxiliarEncontrada==null)
            return;
            _appContext.Auxiliares.Remove(AuxiliarEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<Auxiliar> GetAllAuxiliar()
        {
            return _appContext.Auxiliares;
        }

        public Auxiliar GetAuxiliar(int idAuxiliar)
        {
            return _appContext.Auxiliares.FirstOrDefault(a =>a.Id==idAuxiliar);
        }

        public Auxiliar UpdateAuxiliar(Auxiliar auxiliar)
        {
            var AuxiliarEncontrada=_appContext.Auxiliares.FirstOrDefault(a =>a.Id==auxiliar.Id);

            if(AuxiliarEncontrada!=null)
            {
                AuxiliarEncontrada.Nombre=auxiliar.Nombre;
                AuxiliarEncontrada.Apellidos=auxiliar.Apellidos;
                AuxiliarEncontrada.NumeroTelefono=auxiliar.NumeroTelefono;
                AuxiliarEncontrada.Genero=auxiliar.Genero;
                AuxiliarEncontrada.NumPermiso=auxiliar.NumPermiso;
                AuxiliarEncontrada.horas_laborales=auxiliar.horas_laborales;

                _appContext.SaveChanges() ;
                

            }
            return AuxiliarEncontrada;
        }
    }
}