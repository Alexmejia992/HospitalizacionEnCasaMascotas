using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasaMascotas.App.Persistencia;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascostas.App.Fontend.Pages
{
    public class RegistroSignosVitalesModel : PageModel
    {
        private readonly iRepositorioSignoVital _RepoSignoVital;
        public SignoVital signovital{get; set;}

        public RegistroSignosVitalesModel(iRepositorioSignoVital _RepoSignoVital)
        {
        this._RepoSignoVital = _RepoSignoVital;
        }
        public void OnGet()
        {
            signovital = new SignoVital();
        }
        
        _RepoSignoVital.AddSignoVital(signovital);
        return Page();
    }
}
