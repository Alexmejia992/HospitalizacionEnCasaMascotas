using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasaMascotas.App.Persistencia;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Frontend.Pages.User
{
    public class EliminarModel : PageModel
    {
        private readonly iRepositorioPropietarioDesignado _RepoPropietario;

        private readonly iRepositorioMascota _RepoMascota;

        public Mascota mascota {get; set;}

        public PropietarioDesignado propietarioDesignado {get; set;}


        public EliminarModel(iRepositorioPropietarioDesignado _RepoPropietario, iRepositorioMascota _RepoMascota)
        {
            this._RepoPropietario=_RepoPropietario;
            this._RepoMascota = _RepoMascota;
        }

        public IActionResult OnGet(int Id)
        {
            propietarioDesignado=_RepoPropietario.GetPropietarioDesignado(Id);
            mascota=_RepoMascota.GetMascota(Id);

            if(propietarioDesignado ==null & mascota==null)
            {
                return NotFound();
            }
            else{
                return Page();
            }

        }
        public IActionResult OnPost(int Id){
            
            _RepoMascota.DeleteMascota(Id);
            _RepoPropietario.DeletePropietarioDesignado(Id);
            return RedirectToPage("/Registro/Registro");

         }
    }
}
