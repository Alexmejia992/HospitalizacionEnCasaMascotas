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
    public class EliminarVModel : PageModel
    {
         private readonly iRepositorioVeterinario _RepoVeterinario;

        public Veterinario veterinario {get; set;}

        public EliminarVModel(iRepositorioVeterinario _RepoVeterinario)
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
        public IActionResult OnPost(int Id){
            _RepoVeterinario.DeleteVeterinario(Id);

            return RedirectToPage("/Vet/RegistroVeterinario");
         }
    }
}
