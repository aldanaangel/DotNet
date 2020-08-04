using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerFinalNorthWind.clasesImplementadoras;
using TallerFinalNorthWind.dao;
using TallerFinalNorthWind.interfaces;

namespace TallerFinalNorthWind.menus
{
    public class CrudProveedores
    {
        public InterfazProveedores instancia
        {
            get => default(InterfazProveedores);
            set
            {
            }
        }

        public void ejecutarOpcionProveedores(int opcion)
        {
            ProveedorVO registro = null;
            bool resultado = false;
            int SupplierID = 0;
            string modo = "";

            //***************************************************************************
            InterfazProveedores interfaceServiciosProveedor = null;
            ClaseImplementadoraProveedores objetoInterface1 = new ClaseImplementadoraProveedores();

            //Hacer un moldeo al tipo de dato de la clase implementadora de la interface

            interfaceServiciosProveedor = (ClaseImplementadoraProveedores)objetoInterface1;

            // ClaseImplementadoraProductos manejadorProducto = new ClaseImplementadoraProductos();

            switch (opcion)
            {
                case 1:
                 
                    registro = interfaceServiciosProveedor.armarRegistroProveedores("crear");
                    resultado = interfaceServiciosProveedor.insertarRegistroProveedor(registro);
                    break;
                case 2:
                    
                    registro = interfaceServiciosProveedor.armarRegistroProveedores("modificar");
                    resultado = interfaceServiciosProveedor.modificarRegistroProveedor(registro);
                    break;

                case 3:
                    Console.Write("Digite el ID del proveedor: ");
                    SupplierID = Int32.Parse(Console.ReadLine());

                  
                    registro = interfaceServiciosProveedor.consultarRegistroProveedor(SupplierID);
                   
                    interfaceServiciosProveedor.imprimirDatosEntidadProveedor(registro);
                    break;
                
            }//Fin del switch
        }


    }
}
