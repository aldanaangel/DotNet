using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerFinalNorthWind.dao;

namespace TallerFinalNorthWind.interfaces
{
    public interface InterfazCategorias
    {
        bool insertarRegistroCategorias(CategoriaVO registro);
        CategoriaVO armarRegistroCategorias(string tipo);
        bool modificarRegistroCategorias(CategoriaVO registro);
        CategoriaVO consultarRegistroCategoria(int CategoryID);
        void imprimirDatosEntidadCategoria(CategoriaVO registro);

    }
}
