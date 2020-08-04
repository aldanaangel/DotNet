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
    public class MenuPrincipal
    {
        

        //**************************************************
        //**************************************************

        public void menuIncial()
        {
            string menu = "";
            int opcion = 0;

            menu = "APLICACIÓN DE ADMINISTRACIÓN DE LA TIENDA DE PRODUCTOS NORTHWIND \n\n" +
                         "MENÚ PRINCIAL \n\n" +
                         "1.  Administrar Nuevos Productos. \n" +
                         "2.  Administrar Proveedores \n" +
                         "3.  Administrar Empleados \n" +
                         "4.  Administrar Categorías \n" +
                         "5.  Facturar Pedidos \n" +
                         "6.  Generar Reporte de Ventas \n" +
                         "7.  Salir de la Aplicación \n\n" +
                         "Ingrese una opción: ";



            do
            {
                Console.WriteLine(menu);
                opcion = Int32.Parse(System.Console.ReadLine());

                //Menú de selección

                switch (opcion)
                {
                    //caso en el cual el usuario selecciona Administrar Nuevos Productos
                    case 1:

                        //**********************************************************************************************************
                        MenuProductos menuProductos = new MenuProductos();
                        menuProductos.mostrarMenuProductos();
                        //**********************************************************************************************************
                        break;
                    //caso en el cual el usuario selecciona Administrar Proveedores
                    case 2:

                        //**********************************************************************************************************
                        MenuProveedores menuProveedores = new MenuProveedores();
                        menuProveedores.mostrarMenuProveedores();
                        //**********************************************************************************************************

                        break;
                    //caso en el cual el usuario selecciona Administrar Empleados
                    case 3:

                        //***********************************************************************************************************
                        MenuEmpleados menuEmpleados = new MenuEmpleados();
                        menuEmpleados.mostrarMenuEmpleados();
                        //***********************************************************************************************************

                        break;
                    //caso en el cual el usuario selecciona Administrar Categorías
                    case 4:

                        //***********************************************************************************************************
                        MenuCategorias menuCategorias = new MenuCategorias();
                        menuCategorias.mostrarMenuCategorias();
                        //***********************************************************************************************************

                        break;
                    //caso en el cual el usuario selecciona Facturar Pedidos
                    case 5:

                        //***********************************************************************************************************

                        //***********************************************************************************************************

                        break;
                    //caso en el cual el usuario selecciona Generar Reporte de Ventas
                    case 6:

                        //***********************************************************************************************************

                        //***********************************************************************************************************

                        break;

                }




            } while (opcion != 7);

            Console.WriteLine("El programa ha terminado");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*******************************************");

        }

        //**************************************************
        //**************************************************

        
    }
}
