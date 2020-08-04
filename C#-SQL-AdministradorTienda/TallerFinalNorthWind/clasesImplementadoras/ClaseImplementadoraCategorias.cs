using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerFinalNorthWind.dao;

namespace TallerFinalNorthWind.clasesImplementadoras
{
    /// <summary>
    /// En esta clase se almacenan los metodos correspondientes al manejo de la tabla categorias, estos seran accedidos posteriormente por medio de una interfaz.
    /// </summary>
    public class ClaseImplementadoraCategorias : interfaces.InterfazCategorias
    {
 
        //***********************************************
        //***********************************************
        private static DAOOperacionesCategoria fachadaServiciosDAO;
        //***********************************************
        //***********************************************
     
    

        /// <summary>
        /// Clase donde se valida la conexion a la base de datos, estas propiedades vienen del xml del app.config
        /// </summary>
        public ClaseImplementadoraCategorias()
        {
            String cadenaConexion = "";
            cadenaConexion = ConfigurationManager.ConnectionStrings["OrigenDatosSQLServerDemo"].ConnectionString;
            Console.WriteLine("Cadena conexion: " + cadenaConexion);
            fachadaServiciosDAO = new DAOOperacionesCategoria(cadenaConexion);
        }
        //***********************************************
        //***********************************************
        //***********************************************

        /// <summary>
        /// Método para insertar el registro
        /// </summary>
        /// <param name="registro"> Variable del tipo CategoriaVO proveniente del dao</param>
        /// <returns>instancia insertar un nuevo registro en la tabla categoria definido en DAOOperacionesCategoria</returns>
        public bool insertarRegistroCategorias(CategoriaVO registro)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la inserción");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.InsertarRegistroCategoria(registro));

        }

        //***********************************************
        //***********************************************
        //***********************************************

        /// <summary>
        /// Método para modificar el registro
        /// </summary>
        /// <param name="registro">Variable del tipo CategoriaVO proveniente del dao</param>
        /// <returns>instancia para modificar un nuevo registro en la tabla categoria definido en DAOOperacionesCategoria</returns>
        public bool modificarRegistroCategorias(CategoriaVO registro)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la modificación");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.modificarRegistroCategoria(registro));
        }
        //***********************************************
        //***********************************************
        //***********************************************


        /// <summary>
        /// Método para consultar el registro categorias
        /// </summary>
        /// <param name="CategoryID"> Variab le que hace referencia al valor de la llave primaria por el cual se va a realizar la busqueda en la base de datos</param>
        /// <returns>instancia para consultar un nuevo registro en la tabla categoria definido en DAOOperacionesCategoria</returns>
        public CategoriaVO consultarRegistroCategoria(int CategoryID)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Ejecutando método fachada en el controlador para la consulta");
            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            return (fachadaServiciosDAO.consultarRegistroCategoria(CategoryID));

        }

        //***********************************************
        //***********************************************
        //***********************************************

        /// <summary>
        /// Metodo para pedir por consola los valores a insertar o modificar en la tabla Categorias
        /// </summary>
        /// <returns>registro completo de los elementos ingresados por consola</returns>
        public CategoriaVO armarRegistroCategorias(string tipo)
        {
            CategoriaVO registro = new CategoriaVO();

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("INGRESO DE LOS DATOS DEL REGISTRO");

            if (tipo.Equals("modificar"))
            {
                Console.Write("Ingrese el valor del campo CategoryID: ");
                registro.CategoryID = System.Console.ReadLine();

            }
            Console.Write("Ingrese el valor del campo CategoryName: ");
            registro.CategoryName = System.Console.ReadLine();


            Console.Write("Ingrese el valor del campo Description: ");
            registro.Description = System.Console.ReadLine();

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
        
        public void imprimirDatosEntidadCategoria(CategoriaVO registro)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("CategoryID: " + registro.CategoryID);
            Console.WriteLine("************************************************");
            Console.WriteLine("CategoryName: " + registro.CategoryName);
            Console.WriteLine("Description: " + registro.Description);
          
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
        }
        //***********************************************
        //***********************************************
        //***********************************************






    }
}
