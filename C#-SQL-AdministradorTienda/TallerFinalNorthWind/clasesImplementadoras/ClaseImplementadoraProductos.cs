using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration.Assemblies;
using System.Data.SqlClient;
using TallerFinalNorthWind.dao;



namespace TallerFinalNorthWind.clasesImplementadoras
{
    /// <summary>
    /// En esta clase se almacenan los metodos correspondientes al manejo de la tabla productos, estos seran accedidos posteriormente por medio de una interfaz.
    /// </summary>
    public class ClaseImplementadoraProductos : interfaces.InterfazProductos
    {

        //***********************************************
        //***********************************************
        //***********************************************
        //***********************************************
        private static DAOOperacionesProducto fachadaServiciosDAO;
        //***********************************************
        //***********************************************
        //***********************************************
        //***********************************************
        //***********************************************
        //***********************************************
        public ClaseImplementadoraProductos()
        {
            String cadenaConexion = "";
            cadenaConexion = ConfigurationManager.ConnectionStrings["OrigenDatosSQLServerDemo"].ConnectionString;
            Console.WriteLine("Cadena conexion: " + cadenaConexion);
            fachadaServiciosDAO = new DAOOperacionesProducto(cadenaConexion);
        }
        //***********************************************
        //***********************************************
        //***********************************************
        //Método para insertar el registro
        public bool insertarRegistroProducto(ProductoVO registro)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la inserción");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.insertarRegistroProducto(registro));
        }
        //***********************************************
        //***********************************************
        //***********************************************
        //Método para modificar el registro
        public bool modificarRegistroProducto(ProductoVO registro)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la modificación");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.modificarRegistroProducto(registro));
        }
        //***********************************************
        //***********************************************
        //***********************************************
        //Método para eliminar el registro
        public bool eliminarRegistroProducto(int idProducto)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la eliminación");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.eliminarRegistroProducto(idProducto));
        }
        //***********************************************
        //***********************************************
        //***********************************************
        //Método para consultar el registro
        public ProductoVO consultarRegistroProducto(int idProducto)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la consulta");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.consultarRegistroProducto(idProducto));
        }
        //***********************************************
        //***********************************************
        //***********************************************
        public void generarListadoProductos(string modo)
        {
            List<ProductoVO> registrosProductos = null;
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la consulta de todos los registros");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            registrosProductos = fachadaServiciosDAO.generarListadoProductos(modo);
            imprimirRegistros(registrosProductos);
        }
        //***********************************************
        //***********************************************
        //***********************************************
        public ProductoVO armarRegistroProducto(string tipo)
        {
            ProductoVO registro = new ProductoVO();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("INGRESO DE LOS DATOS DEL REGISTRO");

            if (tipo.Equals("modificar"))
            {
                Console.Write("Ingrese el valor del campo ProductID: ");
                registro.ProductID = System.Console.ReadLine();
            }

            Console.Write("Ingrese el valor del campo ProductName: ");
            registro.ProductName = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo SupplierID: ");
            registro.SupplierID = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo CategoryID: ");
            registro.CategoryID = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo QuantityPerUnit: ");
            registro.QuantityPerUnit = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo UnitPrice: ");
            registro.UnitPrice = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo UnitsInStock: ");
            registro.UnitsInStock = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo UnitsOnOrder: ");
            registro.UnitsOnOrder = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo ReorderLevel: ");
            registro.ReorderLevel = System.Console.ReadLine();

            Console.Write("Ingrese el valor del campo Discontinued: ");
            registro.Discontinued = System.Console.ReadLine();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");

            return (registro);
        }
        //***********************************************
        //***********************************************
        //***********************************************
        public void imprimirDatosEntidad(ProductoVO registro)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("ProductID: " + registro.ProductID);
            Console.WriteLine("************************************************");
            Console.WriteLine("ProductName: " + registro.ProductName);
            Console.WriteLine("SupplierID: " + registro.SupplierID);
            Console.WriteLine("CategoryID: " + registro.CategoryID);
            Console.WriteLine("QuantityPerUnit: " + registro.QuantityPerUnit);
            Console.WriteLine("UnitPrice: " + registro.UnitPrice);
            Console.WriteLine("UnitsInStock: " + registro.UnitsInStock);
            Console.WriteLine("UnitsOnOrder: " + registro.UnitsOnOrder);
            Console.WriteLine("ReorderLevel: " + registro.ReorderLevel);
            Console.WriteLine("Discontinued: " + registro.Discontinued);
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
        }
        //***********************************************
        //***********************************************
        //***********************************************
        public void imprimirRegistros(List<ProductoVO> registros)
        {
            int i = 0;
            string salida = "";
            ProductoVO registro = null;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");

            salida = "ProductID \t" +
                            "ProductName\t" +
                            "SupplierID\t" +
                            "CategoryID\t" +
                            "QuantityPerUnit\t" +
                            "UnitPrice\t" +
                            "UnitsInStock\t" +
                            "UnitsOnOrder\t" +
                            "ReorderLevel\t" +
                            "Discontinued \n";

            for (i = 0; i < registros.Count; i++)
            {
                registro = (ProductoVO)registros.ElementAt(i);
                //*****************************************
                //*****************************************
                salida += registro.ProductID + "\t" +
                                registro.ProductName + "\t" +
                                registro.SupplierID + "\t" +
                                registro.CategoryID + "\t" +
                                registro.QuantityPerUnit + "\t" +
                                registro.UnitPrice + "\t" +
                                registro.UnitsInStock + "\t" +
                                registro.UnitsOnOrder + "\t" +
                                registro.Discontinued + "\t" +
                                registro.ReorderLevel + "\n";
                //*****************************************
                //*****************************************
            }

            Console.Write(salida);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
        }
        //***********************************************
        //***********************************************
        //***********************************************
    }


}

