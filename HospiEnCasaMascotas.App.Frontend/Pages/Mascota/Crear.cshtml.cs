using System;
using System.Collections.Generic;
using System.Linq;
using HospiEnCasaMascotas.App.Persistencia;
using HospiEnCasaMascotas.App.Dominio;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospiEnCasaMascotas.App.Frontend.Pages
{
    public class IndexModel : PageModel
    {
        private readonly iRepositorioMascota _repoMascota;
        public IEnumerable<Mascota> mascotas {get;set;}
        //public IndexModel(iRepositorioMascota  repoMascota )
        //{
         //   _repoMascota = repoMascota;
       // }

        public void OnGet()
        {
            mascota=_repoMascota.GetAllMascotas();
        }
    }
}
