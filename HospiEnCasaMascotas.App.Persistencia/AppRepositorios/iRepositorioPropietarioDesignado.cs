using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Persistencia
{

   public interface iRepositorioPropietarioDesignado {

    IEnumerable<PropietarioDesignado> GetAllPropietarioDesignado();

    PropietarioDesignado AddPropietarioDesignado(PropietarioDesignado propietariodesignado);

    PropietarioDesignado UpdatePropietarioDesignado  (PropietarioDesignado propietariodesignado);

    void DeletePropietarioDesignado(int idPropietarioDesignado);

    PropietarioDesignado GetPropietarioDesignado(int idPropietarioDesignado);
    }
}