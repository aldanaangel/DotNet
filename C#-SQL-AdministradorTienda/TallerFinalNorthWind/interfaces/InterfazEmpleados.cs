using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerFinalNorthWind.dao;

namespace TallerFinalNorthWind.interfaces
{
    public interface InterfazEmpleados
    {
        bool insertarRegistroEmpleados(EmpleadoVO registro);
        EmpleadoVO armarRegistroEmpleados(string tipo);
        bool modificarRegistroEmpleados(EmpleadoVO registro);
        EmpleadoVO consultarRegistroEmpleado(int EmployeeID);
        void imprimirDatosEntidadEmpleado(EmpleadoVO registro);


    }
}
