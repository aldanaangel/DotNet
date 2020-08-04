using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerFinalNorthWind.dao;


namespace TallerFinalNorthWind.interfaces
{
    public interface InterfazProveedores
    {
        //Métodos expuestos por la interface de proveedores
        bool insertarRegistroProveedor(ProveedorVO registro);
        ProveedorVO armarRegistroProveedores(string tipo);
        bool modificarRegistroProveedor(ProveedorVO registro);
        ProveedorVO consultarRegistroProveedor(int SupplierID);
        void imprimirDatosEntidadProveedor(ProveedorVO registro);
        

    }
}
