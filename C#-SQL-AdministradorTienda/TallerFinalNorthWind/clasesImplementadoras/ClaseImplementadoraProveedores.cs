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
    public class ClaseImplementadoraProveedores : interfaces.InterfazProveedores
    {
        //***********************************************
        //***********************************************
        //***********************************************
        //***********************************************
        private static DAOOperacionesProveedor fachadaServiciosDAO;
        //***********************************************
        //***********************************************
        //***********************************************
        //***********************************************
        //***********************************************
        //***********************************************
        public ClaseImplementadoraProveedores()
        {
            String cadenaConexion = "";
            cadenaConexion = ConfigurationManager.ConnectionStrings["OrigenDatosSQLServerDemo"].ConnectionString;
            Console.WriteLine("Cadena conexion: " + cadenaConexion);
            fachadaServiciosDAO = new DAOOperacionesProveedor(cadenaConexion);
        }
        //***********************************************
        //***********************************************
        //***********************************************
        //Método para insertar el registro
        public bool insertarRegistroProveedor(ProveedorVO registro)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la inserción");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.InsertarRegistroProveedor(registro));
            
        }
        
        //***********************************************
        //***********************************************
        //***********************************************
        //Método para modificar el registro
        public bool modificarRegistroProveedor(ProveedorVO registro)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la modificación");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.modificarRegistroProveedor(registro));
        }
        //***********************************************
        //***********************************************
        //***********************************************

        //Método para consultar el registro proveedores
        public ProveedorVO consultarRegistroProveedor(int SupplierID)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la consulta");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.consultarRegistroProveedor(SupplierID));
           
        }
       
        //***********************************************
        //***********************************************
        //***********************************************
        public ProveedorVO armarRegistroProveedores(string tipo)
        {
            ProveedorVO registro = new ProveedorVO();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("INGRESO DE LOS DATOS DEL REGISTRO");

            if (tipo.Equals("modificar"))
            {
                Console.Write("Ingrese el valor del campo SupplierID: ");
                registro.SupplierID = System.Console.ReadLine();

            }
            Console.Write("Ingrese el valor del campo CompanyName: ");
            registro.CompanyName = System.Console.ReadLine();


            Console.Write("Ingrese el valor del campo ContactName: ");
            registro.ContactName = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo ContactTitle: ");
            registro.ContactTitle = System.Console.ReadLine();

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

            Console.Write("Ingrese el valor del campo Phone: ");
            registro.Phone = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo Fax: ");
            registro.Fax = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo HomePage: ");
            registro.HomePage = System.Console.ReadLine();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");

            return (registro);
        }
        //***********************************************
        //***********************************************
        //***********************************************
        public void imprimirDatosEntidadProveedor(ProveedorVO registro)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("SupplierID: " + registro.SupplierID);
            Console.WriteLine("************************************************");
            Console.WriteLine("CompanyName: " + registro.CompanyName);
            Console.WriteLine("ContactName: " + registro.ContactName);
            Console.WriteLine("ContactTitle: " + registro.ContactTitle);
            Console.WriteLine("Address: " + registro.Address);
            Console.WriteLine("City: " + registro.City);
            Console.WriteLine("Region: " + registro.Region);
            Console.WriteLine("PostalCode: " + registro.PostalCode);
            Console.WriteLine("Country: " + registro.Country);
            Console.WriteLine("Phone: " + registro.Phone);
            Console.WriteLine("Fax: " + registro.Fax);
            Console.WriteLine("HomePage: " + registro.HomePage);
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
        }
        //***********************************************
        //***********************************************
        //***********************************************
      
        

    }
}
