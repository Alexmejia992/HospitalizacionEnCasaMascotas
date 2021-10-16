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
    public class VistaUsuarioModel : PageModel
    {
        private readonly iRepositorioPropietarioDesignado _RepoPropietario;
        
        private readonly iRepositorioMascota _RepoMascota;
        public PropietarioDesignado propietarioDesignado {get; set;}
        public Mascota mascota { get; set; }
    
        public IEnumerable<PropietarioDesignado> PropietarioDesignados {get; set;}
        public IEnumerable<Mascota> Mascotas {get; set;}


        public VistaUsuarioModel(iRepositorioPropietarioDesignado _RepoPropietario,iRepositorioMascota _RepoMascota)
        {
            this._RepoPropietario=_RepoPropietario;
            this._RepoMascota = _RepoMascota;
        }

        public void OnGet()
        {
        Mascotas=_RepoMascota.GetAllMascota();
        PropietarioDesignados=_RepoPropietario.GetAllPropietarioDesignado();


            }

    }
}
