using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerFinalNorthWind.dao;
using TallerFinalNorthWind.clasesImplementadoras;
using TallerFinalNorthWind.interfaces;

namespace TallerFinalNorthWind.menus
{
    /// <summary>
    /// Clase que almacena el metodo mediante el cual se accenden a las funcionalidades de manejo 
    /// de entidades (tablas) a traves de una interfaz establecida
    /// </summary>
    public class CrudProducto
    {
        public InterfazProductos instancia
        {
            get => default(InterfazProductos);
            set
            {
            }
        }
        /// <summary>
        /// método para la ejecucion de los metodos seleccionados en el menú de selección
        /// </summary>
        /// <param name="opcion"> permite validar en el swtich la opcion escogida por el usuairo</param>
        public void ejecutarOpcionProductos(int opcion)
        {
            ProductoVO registro = null;
            bool resultado = false;
            int idProducto = 0;
            string modo = "";

            //**************************************************************************
            
            InterfazProductos interfaceServiciosProducto = null;
            ClaseImplementadoraProductos objetoInterface1 = new ClaseImplementadoraProductos();

            ///Hacer un moldeo al tipo de dato de la clase implementadora de la interface
            

            interfaceServiciosProducto = (ClaseImplementadoraProductos)objetoInterface1;

            

            switch (opcion)
            {
                case 1:
                    
                    registro = interfaceServiciosProducto.armarRegistroProducto("crear");
                    
                    resultado = interfaceServiciosProducto.insertarRegistroProducto(registro);
                    break;
                case 2:
                    
                    registro = interfaceServiciosProducto.armarRegistroProducto("modificar");
                   
                    resultado = interfaceServiciosProducto.modificarRegistroProducto(registro);
                    break;
                case 3:
                    Console.Write("Digite el ID del producto: ");
                    idProducto = Int32.Parse(Console.ReadLine());
                    
                    registro = interfaceServiciosProducto.consultarRegistroProducto(idProducto);
                    
                    interfaceServiciosProducto.imprimirDatosEntidad(registro);
                    break;
                  
            }//Fin del switch
        }
    }
}
