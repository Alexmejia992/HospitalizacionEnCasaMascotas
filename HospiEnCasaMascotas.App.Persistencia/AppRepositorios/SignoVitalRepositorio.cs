using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;
using System.Linq;

namespace HospiEnCasaMascotas.App.Persistencia{


    public class SignoVitalRepositorio : iRepositorioSignoVital
    {


        private readonly AppContext _appContext;

        public SignoVitalRepositorio(AppContext appContext){
            _appContext=appContext;
        }
        public SignoVital AddSignoVital(SignoVital signovital)
        {
            var SignoVitalAdicionada= _appContext.SignosVitales.Add(signovital);
            _appContext.SaveChanges();
            return SignoVitalAdicionada.Entity;
               }

        public void DeleteSignoVital(int idSignoVital)
        {
            var SignoVitalEncontrada=_appContext.SignosVitales.FirstOrDefault(s =>s.Id==idSignoVital);
            if(SignoVitalEncontrada==null)
            return;
            _appContext.SignosVitales.Remove(SignoVitalEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<SignoVital> GetAllSignoVital()
        {
            return _appContext.SignosVitales;
        }

        public SignoVital GetSignoVital(int idSignoVital)
        {
            return _appContext.SignosVitales.FirstOrDefault(s =>s.Id==idSignoVital);
        }

        public SignoVital UpdateSignoVital(SignoVital signovital)
        {
            var SignoVitalEncontrada=_appContext.SignosVitales.FirstOrDefault(s =>s.Id==signovital.Id);

            if(SignoVitalEncontrada!=null)
            {
                SignoVitalEncontrada.Id=signovital.Id;
                SignoVitalEncontrada.FechaHora=signovital.FechaHora;
                SignoVitalEncontrada.Valor=signovital.Valor;
                SignoVitalEncontrada.Signo=signovital.Signo;


                _appContext.SaveChanges() ;
                

            }
            return SignoVitalEncontrada;
        }
    }
}