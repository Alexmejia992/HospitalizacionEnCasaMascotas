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
    public class ActualizarModel : PageModel
    {
        private readonly iRepositorioPropietarioDesignado _RepoPropietario;

        private readonly iRepositorioMascota _RepoMascota;

        public Mascota mascota {get; set;}

        public PropietarioDesignado propietarioDesignado {get; set;}


        public ActualizarModel(iRepositorioPropietarioDesignado _RepoPropietario, iRepositorioMascota _RepoMascota)
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
        public IActionResult OnPost(Mascota mascota, PropietarioDesignado propietarioDesignado){

            _RepoMascota.UpdateMascota(mascota);
            _RepoPropietario.UpdatePropietarioDesignado(propietarioDesignado);
            return RedirectToPage("/User/VistaUsuario");

         }
    }
}
