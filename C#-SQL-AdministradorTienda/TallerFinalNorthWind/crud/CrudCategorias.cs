using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerFinalNorthWind.clasesImplementadoras;
using TallerFinalNorthWind.dao;
using TallerFinalNorthWind.interfaces;

namespace TallerFinalNorthWind.crud
{
    public class CrudCategorias
    {
        public InterfazCategorias instancia
        {
            get => default(InterfazCategorias);
            set
            {
            }
        }

        public void ejecutarOpcionCategorias(int opcion)
        {
            CategoriaVO registro = null;
            bool resultado = false;
            int CategoryID = 0;
            string modo = "";

            //***************************************************************************
            InterfazCategorias interfaceServiciosCategorias = null;
            ClaseImplementadoraCategorias objetoInterface1 = new ClaseImplementadoraCategorias();

            //Hacer un moldeo al tipo de dato de la clase implementadora de la interface

            interfaceServiciosCategorias = (ClaseImplementadoraCategorias)objetoInterface1;

            // ClaseImplementadoraProductos manejadorProducto = new ClaseImplementadoraProductos();

            switch (opcion)
            {
                case 1:

                    
                    registro = interfaceServiciosCategorias.armarRegistroCategorias("crear");
                    resultado = interfaceServiciosCategorias.insertarRegistroCategorias(registro);
                    
                    break;
                case 2:

                    
                    registro = interfaceServiciosCategorias.armarRegistroCategorias("modificar");
                    resultado = interfaceServiciosCategorias.modificarRegistroCategorias(registro);
                   
                    break;

                case 3:
                    Console.Write("Digite el ID del proveedor: ");
                    CategoryID = Int32.Parse(Console.ReadLine());


                    registro = interfaceServiciosCategorias.consultarRegistroCategoria(CategoryID);
                    interfaceServiciosCategorias.imprimirDatosEntidadCategoria(registro);
                    
                    break;

            }//Fin del switch
        }


    }
}
