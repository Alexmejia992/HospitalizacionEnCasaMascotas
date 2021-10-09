using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;
using System.Linq;

namespace HospiEnCasaMascotas.App.Persistencia{


    public class PropietarioDesignadoRepositorio : iRepositorioPropietarioDesignado
    {


        private readonly AppContext _appContext= new AppContext();

        // public PropietarioDesignadoRepositorio(AppContext appContext){
        //     _appContext=appContext;
        // }
        public PropietarioDesignado AddPropietarioDesignado(PropietarioDesignado propietariodesignado)
        {
            var PropietarioDesignadoAdicionada= _appContext.PropietariosDesignados.Add(propietariodesignado);
            _appContext.SaveChanges();
            return PropietarioDesignadoAdicionada.Entity;
               }

        public void DeletePropietarioDesignado(int idPropietarioDesignado)
        {
            var PropietarioDesignadoEncontrada=_appContext.PropietariosDesignados.FirstOrDefault(p =>p.Id==idPropietarioDesignado);
            if(PropietarioDesignadoEncontrada==null)
            return;
            _appContext.PropietariosDesignados.Remove(PropietarioDesignadoEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<PropietarioDesignado> GetAllPropietarioDesignado()
        {
            return _appContext.PropietariosDesignados;
        }

        public PropietarioDesignado GetPropietarioDesignado(int idPropietarioDesignado)
        {
            return _appContext.PropietariosDesignados.FirstOrDefault(p =>p.Id==idPropietarioDesignado);
        }

        public PropietarioDesignado UpdatePropietarioDesignado(PropietarioDesignado propietariodesignado)
        {
            var PropietarioDesignadoEncontrada=_appContext.PropietariosDesignados.FirstOrDefault(p =>p.Id==propietariodesignado.Id);

            if(PropietarioDesignadoEncontrada!=null)
            {
                PropietarioDesignadoEncontrada.Nombre=propietariodesignado.Nombre;
                PropietarioDesignadoEncontrada.Apellidos=propietariodesignado.Apellidos;
                PropietarioDesignadoEncontrada.NumeroTelefono=propietariodesignado.NumeroTelefono;
                PropietarioDesignadoEncontrada.Genero=propietariodesignado.Genero;
                PropietarioDesignadoEncontrada.correo=propietariodesignado.correo;


                _appContext.SaveChanges() ;
                

            }
            return PropietarioDesignadoEncontrada;
        }
    }
}