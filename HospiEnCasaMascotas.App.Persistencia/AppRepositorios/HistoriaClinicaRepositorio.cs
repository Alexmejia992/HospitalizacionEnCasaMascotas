using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;
using System.Linq;

namespace HospiEnCasaMascotas.App.Persistencia{


    public class HistoriaClinicaRepositorio : iRepositorioHistoriaClinica
    {


        private readonly AppContext _appContext= new AppContext();

        // public HistoriaClinicaRepositorio(AppContext appContext){
        //     _appContext=appContext;
        // }
        public HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaClinica)
        {
            var HistoriaClinicaAdicionada= _appContext.HistoriasClinicas.Add(historiaClinica);
            _appContext.SaveChanges();
            return HistoriaClinicaAdicionada.Entity;
               }

        public void DeleteHistoriaClinica(int idHistoriaClinica)
        {
            var HistoriaClinicaEncontrada=_appContext.HistoriasClinicas.FirstOrDefault(h =>h.Id==idHistoriaClinica);
            if(HistoriaClinicaEncontrada==null)
            return;
            _appContext.HistoriasClinicas.Remove(HistoriaClinicaEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<HistoriaClinica> GetAllHistoriaClinica()
        {
            return _appContext.HistoriasClinicas;
        }

        public HistoriaClinica GetHistoriaClinica(int idHistoriaClinica)
        {
            return _appContext.HistoriasClinicas.FirstOrDefault(h =>h.Id==idHistoriaClinica);
        }

        public HistoriaClinica UpdateHistoriaClinica(HistoriaClinica historiaClinica)
        {
            var HistoriaClinicaEncontrada=_appContext.HistoriasClinicas.FirstOrDefault(h =>h.Id==historiaClinica.Id);

            if(HistoriaClinicaEncontrada!=null)
            {
                HistoriaClinicaEncontrada.Id=historiaClinica.Id;
                HistoriaClinicaEncontrada.Diagnostico=historiaClinica.Diagnostico;
                HistoriaClinicaEncontrada.Sugerencias=historiaClinica.Sugerencias;

                _appContext.SaveChanges() ;
                

            }
            return HistoriaClinicaEncontrada;
        }
    }
}