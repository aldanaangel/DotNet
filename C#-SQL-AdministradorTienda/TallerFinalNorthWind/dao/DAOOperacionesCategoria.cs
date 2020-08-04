using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerFinalNorthWind.dao
{
    public class DAOOperacionesCategoria
    {
        //*************************************************************************
        //*************************************************************************
        //*************************************************************************
        //*************************************************************************
        //*************************************************************************
        private static GeneradorConsultasCRUD generadorQueriesSQL;
        private static SqlConnection con;
        private static SqlCommand cmd;
        //*************************************************************************
        //*************************************************************************
        //*************************************************************************
        //*************************************************************************
        //*************************************************************************
        public DAOOperacionesCategoria()
        {
        }
        //*************************************************************************
        //*************************************************************************
        //*************************************************************************
        //Constructor sobrecargado del DAO
        public DAOOperacionesCategoria(string cadenaConexion)
        {
            con = new SqlConnection(cadenaConexion);
            Console.WriteLine("Conexión establecida: " + con);
            generadorQueriesSQL = new GeneradorConsultasCRUD();
        }
        //************************************************************************
        //************************************************************************
        //************************************************************************
        //Método para realizar la inserción del registro del Categoria
        public bool InsertarRegistroCategoria(CategoriaVO registroEntidad)
        {
            bool seInserto = false;
            string consulta = "";
            int totalFilas = 0;

            try
            {
                //********************************************************************
                //********************************************************************
                //********************************************************************
                consulta = generadorQueriesSQL.generarConsultaInsertCategorias();
                Console.WriteLine("*********************************************");
                Console.WriteLine("*********************************************");
                Console.WriteLine("CONSULTA INSERT: " + consulta);
                Console.WriteLine("*********************************************");
                //********************************************************************
                //********************************************************************
                //Generamos el comando
                cmd = new SqlCommand(consulta, con);
                //Abrimos la conexión
                con.Open();
                //********************************************************************
                //********************************************************************
                //Seteamos los parámetros

                
                cmd.Parameters.AddWithValue("CategoryNameCa", registroEntidad.CategoryName);
                cmd.Parameters.AddWithValue("DescriptionCa", registroEntidad.Description);
                
                
               
                //********************************************************************
                //********************************************************************
                //Ejecutamos la query de actualización
                totalFilas = cmd.ExecuteNonQuery();
                seInserto = true;
                //********************************************************************
                //********************************************************************
                Console.WriteLine("Resultado de la inserción: " + seInserto + " - Se insertaron " + totalFilas + " filas en la tabla");
                Console.WriteLine("*********************************************");
                Console.WriteLine("*********************************************");
                //********************************************************************
                //********************************************************************
                //********************************************************************
            }

            catch (Exception errorInsertar)
            {
                Console.WriteLine("Error de inserción: " + errorInsertar.Message);
                Console.WriteLine("Error detallado: " + errorInsertar.ToString());
                return (false);
            }

            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (con != null)
                {
                    con.Close();
                }
            }

            return (seInserto);
        }
        //************************************************************************
        //************************************************************************
        //************************************************************************
        //Método para realizar la modificación del registro del proveedor
        public bool modificarRegistroCategoria(CategoriaVO registroEntidad)
        {
            bool seModifico = false;
            string consulta = "";
            int totalFilas = 0;

            try
            {
                //********************************************************************
                //********************************************************************
                //********************************************************************
                consulta = generadorQueriesSQL.generarConsultaUpdateCategorias();
                Console.WriteLine("*********************************************");
                Console.WriteLine("*********************************************");
                Console.WriteLine("CONSULTA UPDATE: " + consulta);
                Console.WriteLine("*********************************************");
                //********************************************************************
                //********************************************************************
                //Generamos el comando
                cmd = new SqlCommand(consulta, con);
                //Abrimos la conexión
                con.Open();
                //********************************************************************
                //********************************************************************
                //Seteamos los parámetros
                cmd.Parameters.AddWithValue("CategoryNameCa", registroEntidad.CategoryName);
                cmd.Parameters.AddWithValue("DescriptionCa", registroEntidad.Description);
                
                //Llave para el update
                cmd.Parameters.AddWithValue("@CategoryIDCa", registroEntidad.CategoryID);

                //********************************************************************
                //********************************************************************
                //Ejecutamos la query de actualización
                totalFilas = cmd.ExecuteNonQuery();
                seModifico = true;
                //********************************************************************
                //********************************************************************
                Console.WriteLine("Resultado de la modificación: " + seModifico + " - Se modificaron " + totalFilas + " filas en la tabla");
                Console.WriteLine("*********************************************");
                Console.WriteLine("*********************************************");
                //********************************************************************
                //********************************************************************
                //********************************************************************
            }

            catch (Exception errorInsertar)
            {
                Console.WriteLine("Error de modificación: " + errorInsertar.Message);
                Console.WriteLine("Error detallado: " + errorInsertar.ToString());
                return (false);
            }

            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (con != null)
                {
                    con.Close();
                }
            }

            return (seModifico);
        }
        //************************************************************************
        //************************************************************************
        //************************************************************************
        //Método para realizar la consulta del registro del proveedor
        public CategoriaVO consultarRegistroCategoria(int CategoryID)
        {
            CategoriaVO registroConsultado = new CategoriaVO();
            string consulta = "";
            SqlCommand command = null;
            SqlDataReader cursor = null;

            try
            {
                consulta = generadorQueriesSQL.generarConsultaSelectCategorias();
                Console.WriteLine(consulta);

                con.Open();
                command = new SqlCommand(consulta, con);
                Console.WriteLine("ID DE LA CATEGORIA A CONSULTAR: " + CategoryID);
                command.Parameters.AddWithValue("@CategoryIDCa", CategoryID);

                //Recorremos el cursor de la consulta para obtener
                //los datos usando un sqlDataReader
                cursor = command.ExecuteReader();

                if (cursor != null)
                {
                    while (cursor.Read())
                    {
                        registroConsultado.CategoryID = cursor.GetInt32(0).ToString();
                        registroConsultado.CategoryName = cursor.GetString(1).ToString();
                        registroConsultado.Description = cursor.GetString(2).ToString();
                       
                    }

                    //Verificamos los datos
                    Console.WriteLine("****************************************************************");
                    Console.WriteLine("****************************************************************");
                    Console.WriteLine("NOMBRE = " + registroConsultado.CategoryName + " ID CATEGORY = " + registroConsultado.CategoryID);
                    Console.WriteLine("****************************************************************");
                    Console.WriteLine("****************************************************************");

                }
            }

            catch (Exception errorLectura)
            {
                Console.WriteLine("Error de consulta: " + errorLectura.Message);
                CategoriaVO registroVacio = new CategoriaVO();
                registroVacio.CategoryID = "SIN REGISTRO";
                //registroVacio.ProductID = 0;
                return (registroVacio);
            }

            finally
            {
                //Libera los recursos de la transacción DML de consulta
                if (command != null)
                {
                    command.Dispose();
                }

                if (con != null)
                {
                    con.Close();
                }
            }

            return (registroConsultado);
        }
        //************************************************************************
        //************************************************************************
        //************************************************************************

        //Fin de la clase



    }
}
