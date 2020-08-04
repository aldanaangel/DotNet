using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TallerFinalNorthWind.dao;
using System.Configuration;


namespace TallerFinalNorthWind.clasesImplementadoras
{
 
    public class ClaseImplementadoraEmpleados : interfaces.InterfazEmpleados
    {
      
        //***********************************************
        //***********************************************
        private static DAOOperacionesEmpleados fachadaServiciosDAO;
        //***********************************************
        //***********************************************
      
  

        /// <summary>
        /// Clase donde se valida la conexion a la base de datos, estas propiedades vienen del xml del app.config
        /// </summary>
        public ClaseImplementadoraEmpleados()
        {
            String cadenaConexion = "";
            cadenaConexion = ConfigurationManager.ConnectionStrings["OrigenDatosSQLServerDemo"].ConnectionString;
            Console.WriteLine("Cadena conexion: " + cadenaConexion);
            fachadaServiciosDAO = new DAOOperacionesEmpleados(cadenaConexion);
        }
        //***********************************************
        //***********************************************
        //***********************************************

        /// <summary>
        /// Método para insertar el registro
        /// </summary>
        /// <param name="registro"> Variable del tipo EmpleadoVO proveniente del dao</param>
        /// <returns>instancia insertar un nuevo registro en la tabla Empleados definido en DAOOperacionesEmpleados</returns>
        public bool insertarRegistroEmpleados(EmpleadoVO registro)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la inserción");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.InsertarRegistroEmpleados(registro));

        }

        //***********************************************
        //***********************************************
        //***********************************************

        /// <summary>
        /// Método para modificar el registro
        /// </summary>
        /// <param name="registro"> Variable del tipo EmpleadoVO proveniente del dao</param>
        /// <returns>instancia modificar un registro en la tabla Empleados definido en DAOOperacionesEmpleados</returns>
        public bool modificarRegistroEmpleados(EmpleadoVO registro)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la modificación");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.modificarRegistroEmpleado(registro));
        }


        //***********************************************
        //***********************************************
        //***********************************************

        /// <summary>
        /// Método para consultar el registro
        /// </summary>
        /// <param name="EmployeeID"> Variable que hace referencia a la llave primaria por la cual se va a realizar la consulta</param>
        /// <returns>instancia consultar un registro en la tabla Empleados definido en DAOOperacionesEmpleados</returns>
        public EmpleadoVO consultarRegistroEmpleado(int EmployeeID)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la consulta");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.consultarRegistroEmpleado(EmployeeID));

        }

        //***********************************************
        //***********************************************
        //***********************************************

        /// <summary>
        /// Metodo para pedir por consola los valores a insertar o modificar en la tabla Empleados
        /// </summary>
        /// <returns>registro completo de los elementos ingresados por consola</returns>
        public EmpleadoVO armarRegistroEmpleados(string tipo)
        {
            EmpleadoVO registro = new EmpleadoVO();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("INGRESO DE LOS DATOS DEL REGISTRO");

            if (tipo.Equals("modificar"))
            {
                Console.Write("Ingrese el valor del campo EmployeeID: ");
                registro.EmployeeID = System.Console.ReadLine();

            }
            Console.Write("Ingrese el valor del campo LastName: ");
            registro.LastName = System.Console.ReadLine();


            Console.Write("Ingrese el valor del campo FirstName: ");
            registro.FirstName = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo Title: ");
            registro.Title = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo TitleOfCourtesy: ");
            registro.TitleOfCourtesy = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo BirthDate: ");
            registro.BirthDate = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo HireDate: ");
            registro.HireDate = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo Address: ");
            registro.Address = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo City: ");
            registro.City = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo Region: ");
            registro.Region = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo PostalCode: ");
            registro.PostalCode = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo Country: ");
            registro.Country = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo HomePhone: ");
            registro.HomePhone = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo Extension: ");
            registro.Extension = System.Console.ReadLine();


            Console.Write("Ingrese el valor del campo Notes: ");
            registro.Notes = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo ReportsTo: ");
            registro.ReportsTo = System.Console.ReadLine();


            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");

            return (registro);
        }


        //***********************************************
        //***********************************************
        //***********************************************

        /// <summary>
        /// Metodo que permite imprimir en pantalla los datos correspondientes a la consulta realizada
        /// </summary>
        public void imprimirDatosEntidadEmpleado(EmpleadoVO registro)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("EmployeeID: " + registro.EmployeeID);
            Console.WriteLine("************************************************");
            Console.WriteLine("LastName: " + registro.LastName);
            Console.WriteLine("FirstName: " + registro.FirstName);
            Console.WriteLine("Title: " + registro.Title);
            Console.WriteLine("TitleOfCourtesy: " + registro.TitleOfCourtesy);
            Console.WriteLine("BirthDate: " + registro.BirthDate);
            Console.WriteLine("HireDate: " + registro.HireDate);
            Console.WriteLine("Address: " + registro.Address);
            Console.WriteLine("City: " + registro.City);
            Console.WriteLine("Region: " + registro.Region);
            Console.WriteLine("PostalCode: " + registro.PostalCode);
            Console.WriteLine("Country: " + registro.Country);
            Console.WriteLine("HomePhone: " + registro.HomePhone);
            Console.WriteLine("Extension: " + registro.Extension);
           

            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
        }
        
        //***********************************************
        //***********************************************
        //***********************************************



    }
}
