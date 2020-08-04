using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerFinalNorthWind.dao;

namespace TallerFinalNorthWind.interfaces
{
    public interface InterfazProductos
    {
        //Métodos expuestos por la interface
        bool insertarRegistroProducto(ProductoVO registro);
        bool modificarRegistroProducto(ProductoVO registro);
        bool eliminarRegistroProducto(int idProducto);
        ProductoVO consultarRegistroProducto(int idProducto);
        void generarListadoProductos(string modo);
        ProductoVO armarRegistroProducto(string tipo);
        void imprimirDatosEntidad(ProductoVO registro);
        

    }
}
