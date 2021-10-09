using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;
using System.Linq;

namespace HospiEnCasaMascotas.App.Persistencia{


    public class SugerenciaCuidadoRepositorio : iRepositorioSugerenciaCuidado
    {


        private readonly AppContext _appContext = new AppContext();

        // public SugerenciaCuidadoRepositorio(AppContext appContext){
        //     _appContext=appContext;
        // }
        public SugerenciaCuidado AddSugerenciaCuidado(SugerenciaCuidado sugerenciacuidado)
        {
            var SugerenciaCuidadoAdicionada= _appContext.SugerenciasCuidado.Add(sugerenciacuidado);
            _appContext.SaveChanges();
            return SugerenciaCuidadoAdicionada.Entity;
               }

        public void DeleteSugerenciaCuidado(int idSugerenciaCuidado)
        {
            var SugerenciaCuidadoEncontrada=_appContext.SugerenciasCuidado.FirstOrDefault(s =>s.Id==idSugerenciaCuidado);
            if(SugerenciaCuidadoEncontrada==null)
            return;
            _appContext.SugerenciasCuidado.Remove(SugerenciaCuidadoEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<SugerenciaCuidado> GetAllSugerenciaCuidado()
        {
            return _appContext.SugerenciasCuidado;
        }

        public SugerenciaCuidado GetSugerenciaCuidado(int idSugerenciaCuidado)
        {
            return _appContext.SugerenciasCuidado.FirstOrDefault(s =>s.Id==idSugerenciaCuidado);
        }

        public SugerenciaCuidado UpdateSugerenciaCuidado(SugerenciaCuidado sugerenciacuidado)
        {
            var SugerenciaCuidadoEncontrada=_appContext.SugerenciasCuidado.FirstOrDefault(s =>s.Id==sugerenciacuidado.Id);

            if(SugerenciaCuidadoEncontrada!=null)
            {
                SugerenciaCuidadoEncontrada.Id=sugerenciacuidado.Id;
                SugerenciaCuidadoEncontrada.FechaHora=sugerenciacuidado.FechaHora;
                SugerenciaCuidadoEncontrada.Descripcion=sugerenciacuidado.Descripcion;

                


                _appContext.SaveChanges() ;
                

            }
            return SugerenciaCuidadoEncontrada;
        }
    }
}