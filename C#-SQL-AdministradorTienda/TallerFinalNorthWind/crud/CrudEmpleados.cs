using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerFinalNorthWind.dao;
using TallerFinalNorthWind.clasesImplementadoras;
using TallerFinalNorthWind.interfaces;

namespace TallerFinalNorthWind.crud
{
    public class CrudEmpleados
    {
        public InterfazEmpleados instancia
        {
            get => default(InterfazEmpleados);
            set
            {
            }
        }

        public void ejecutarOpcionEmpleados(int opcion)
        {
            EmpleadoVO registro = null;
            bool resultado = false;
            int EmployeeID = 0;
            string modo = "";

            //***************************************************************************
            InterfazEmpleados interfaceServiciosEmpleados = null;
            ClaseImplementadoraEmpleados objetoInterface1 = new ClaseImplementadoraEmpleados();

            //Hacer un moldeo al tipo de dato de la clase implementadora de la interface

            interfaceServiciosEmpleados = (ClaseImplementadoraEmpleados)objetoInterface1;

         

            switch (opcion)
            {
                case 1:
                    registro = interfaceServiciosEmpleados.armarRegistroEmpleados("crear");
                    resultado = interfaceServiciosEmpleados.insertarRegistroEmpleados(registro);
                    break;
                case 2:
                    registro = interfaceServiciosEmpleados.armarRegistroEmpleados("modificar");
                    resultado = interfaceServiciosEmpleados.modificarRegistroEmpleados(registro);
                    break;

                case 3:
                     Console.Write("Digite el ID del empleado: ");
                     EmployeeID = Int32.Parse(Console.ReadLine());
                     registro = interfaceServiciosEmpleados.consultarRegistroEmpleado(EmployeeID);
                     interfaceServiciosEmpleados.imprimirDatosEntidadEmpleado(registro);

                     break;

            }//Fin del switch
        }





    }
}
