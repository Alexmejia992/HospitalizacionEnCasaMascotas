using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasaMascotas.App.Persistencia;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Frontend.Pages.Vet
{
    public class VistaDoctorModel : PageModel
    {
        private readonly iRepositorioVeterinario _RepoVeterinario;

        public IEnumerable<Veterinario> Veterinarios { get; set; }


        public VistaDoctorModel(iRepositorioVeterinario _RepoVeterinario)
        {
            this._RepoVeterinario=_RepoVeterinario;
        }

        public void OnGet()
        {
            Veterinarios = _RepoVeterinario.GetAllVeterinario();


        }

    }
}
