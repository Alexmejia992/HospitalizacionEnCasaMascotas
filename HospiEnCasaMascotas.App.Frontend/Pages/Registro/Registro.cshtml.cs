using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasaMascotas.App.Persistencia;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Frontend.Pages
{
    public class RegistroModel : PageModel
    {
        private readonly iRepositorioPropietarioDesignado _RepoPropietario;
        private readonly iRepositorioMascota _RepoMascota;

        public Mascota mascota { get; set; }
        public PropietarioDesignado propietarioDesignado {get; set;}

        // public RegistroModel(iRepositorioPropietarioDesignado _RepoPropietario,iR)
        // {
        //     this._RepoPropietario=_RepoPropietario;
        // }
        public RegistroModel(iRepositorioMascota _RepoMascota,iRepositorioPropietarioDesignado _RepoPropietario)
        {
            this._RepoMascota = _RepoMascota;
            this._RepoPropietario=_RepoPropietario;
        }

        public void OnGet()
        {
            mascota = new Mascota();
            propietarioDesignado= new PropietarioDesignado();
        }
        public IActionResult OnPost(Mascota mascota, PropietarioDesignado propietarioDesignado)
        {
            _RepoMascota.AddMascota(mascota);
            _RepoPropietario.AddPropietarioDesignado(propietarioDesignado);
            return Page();

        }

        // public IActionResult OnPost(PropietarioDesignado propietarioDesignado)
        // {
        //      _RepoPropietario.AddPropietarioDesignado(propietarioDesignado);
        //      return Page();
           

        //  }

    }
}
