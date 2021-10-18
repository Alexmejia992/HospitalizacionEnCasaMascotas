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
    public class RegistroVeterinarioModel : PageModel
    {
        private readonly iRepositorioVeterinario _RepoVeterinario;

        public Veterinario veterinario { get; set; }

        public RegistroVeterinarioModel(iRepositorioVeterinario _RepoVeterinario)
        {
            this._RepoVeterinario=_RepoVeterinario;
        }

        public void OnGet()
        {
            veterinario= new Veterinario();
        }
        public IActionResult OnPost(Veterinario veterinario)
        {
           _RepoVeterinario.AddVeterinario(veterinario);
            return RedirectToPage("/Vet/VistaDoctor");

        }
    }
}