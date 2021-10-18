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
    public class ActualizarVModel : PageModel
    {
        private readonly iRepositorioVeterinario _RepoVeterinario;

        public Veterinario veterinario {get; set;}

        public ActualizarVModel(iRepositorioVeterinario _RepoVeterinario)
        {
            this._RepoVeterinario=_RepoVeterinario;
        }

        public IActionResult OnGet(int Id)
        {
            veterinario=_RepoVeterinario.GetVeterinario(Id);

            if(veterinario ==null)
            {
                return NotFound();
            }
            else{
                return Page();
            }

        }
        public IActionResult OnPost(Veterinario veterinario){
            _RepoVeterinario.UpdateVeterinario(veterinario);
            return RedirectToPage("/Vet/VistaDoctor");
         }
    }
}
