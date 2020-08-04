using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TallerFinalNorthWind.dao
{
    class DAOOperacionesEmpleados
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
        public DAOOperacionesEmpleados()
        {
        }
        //*************************************************************************
        //*************************************************************************
        //*************************************************************************
        //Constructor sobrecargado del DAO
        public DAOOperacionesEmpleados(string cadenaConexion)
        {
            con = new SqlConnection(cadenaConexion);
            Console.WriteLine("Conexión establecida: " + con);
            generadorQueriesSQL = new GeneradorConsultasCRUD();
        }
        //************************************************************************
        //************************************************************************
        //************************************************************************
        //Método para realizar la inserción del registro del Empleado
        public bool InsertarRegistroEmpleados(EmpleadoVO registroEntidad)
        {
            bool seInserto = false;
            string consulta = "";
            int totalFilas = 0;

            try
            {
                //********************************************************************
                //********************************************************************
                //********************************************************************
                consulta = generadorQueriesSQL.generarConsultaInsertEmpleados();
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

                cmd.Parameters.AddWithValue("@LastNameEm", registroEntidad.LastName);
                cmd.Parameters.AddWithValue("@FirstNameEm", registroEntidad.FirstName);
                cmd.Parameters.AddWithValue("@TitleEm", registroEntidad.Title);
                cmd.Parameters.AddWithValue("@TitleOfCourtesyEm", registroEntidad.TitleOfCourtesy);
                cmd.Parameters.AddWithValue("@BirthDateEm", registroEntidad.BirthDate);
                cmd.Parameters.AddWithValue("@HireDateEm ", registroEntidad.HireDate);
                cmd.Parameters.AddWithValue("@AddressEm", registroEntidad.Address);
                cmd.Parameters.AddWithValue("@CityEm", registroEntidad.City);
                cmd.Parameters.AddWithValue("@RegionEm", registroEntidad.Region);
                cmd.Parameters.AddWithValue("@PostalCodeEm", registroEntidad.PostalCode);
                cmd.Parameters.AddWithValue("@CountryEm", registroEntidad.Country);
                cmd.Parameters.AddWithValue("@HomePhoneEm", registroEntidad.HomePhone);
                cmd.Parameters.AddWithValue("@ExtensionEm", registroEntidad.Extension);
                cmd.Parameters.AddWithValue("@NotesEm", registroEntidad.Notes);
                cmd.Parameters.AddWithValue("@ReportsToEm", registroEntidad.ReportsTo);
                cmd.Parameters.AddWithValue("@PhotoPathEm", registroEntidad.PhotoPath);

                
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
        public bool modificarRegistroEmpleado(EmpleadoVO registroEntidad)
        {
            bool seModifico = false;
            string consulta = "";
            int totalFilas = 0;

            try
            {
                //********************************************************************
                //********************************************************************
                //********************************************************************
                consulta = generadorQueriesSQL.generarConsultaUpdateEmpleados();
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

                cmd.Parameters.AddWithValue("@LastNameEm", registroEntidad.LastName);
                cmd.Parameters.AddWithValue("@FirstNameEm", registroEntidad.FirstName);
                cmd.Parameters.AddWithValue("@TitleEm", registroEntidad.Title);
                cmd.Parameters.AddWithValue("@TitleOfCourtesyEm", registroEntidad.TitleOfCourtesy);
                cmd.Parameters.AddWithValue("@BirthDateEm", registroEntidad.BirthDate);
                cmd.Parameters.AddWithValue("@HireDateEm ", registroEntidad.HireDate);
                cmd.Parameters.AddWithValue("@AddressEm", registroEntidad.Address);
                cmd.Parameters.AddWithValue("@CityEm", registroEntidad.City);
                cmd.Parameters.AddWithValue("@RegionEm", registroEntidad.Region);
                cmd.Parameters.AddWithValue("@PostalCodeEm", registroEntidad.PostalCode);
                cmd.Parameters.AddWithValue("@CountryEm", registroEntidad.Country);
                cmd.Parameters.AddWithValue("@HomePhoneEm", registroEntidad.HomePhone);
                cmd.Parameters.AddWithValue("@ExtensionEm", registroEntidad.Extension);
                cmd.Parameters.AddWithValue("@NotesEm", registroEntidad.Notes);
                cmd.Parameters.AddWithValue("@ReportsToEm", registroEntidad.ReportsTo);
                //cmd.Parameters.AddWithValue("@PhotoPathEm", registroEntidad.PhotoPath);

                //Llave para el update
                cmd.Parameters.AddWithValue("@EmployeeIDEm", registroEntidad.EmployeeID);

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
        //Método para realizar la consulta del registro del empleado

            
        public EmpleadoVO consultarRegistroEmpleado(int EmployeeID)
        {
            EmpleadoVO registroConsultado = new EmpleadoVO();
            string consulta = "";
            SqlCommand command = null;
            SqlDataReader cursor = null;

            try
            {
                consulta = generadorQueriesSQL.generarConsultaSelectEmpleados();
                Console.WriteLine(consulta);

                con.Open();
                command = new SqlCommand(consulta, con);
                Console.WriteLine("ID DE EMPLEADO A CONSULTAR: " + EmployeeID);
                command.Parameters.AddWithValue("@EmployeeIDEm", EmployeeID);

                //Recorremos el cursor de la consulta para obtener
                //los datos usando un sqlDataReader
                cursor = command.ExecuteReader();

                if (cursor != null)
                {
                    while (cursor.Read())
                    {
                        registroConsultado.EmployeeID   = cursor.GetInt32(0).ToString();
                        registroConsultado.LastName     = cursor.GetString(1).ToString();
                        registroConsultado.FirstName     = cursor.GetString(2).ToString();
                        registroConsultado.Title         = cursor.GetString(3).ToString();
                        registroConsultado.TitleOfCourtesy = cursor.GetString(4).ToString();
                        registroConsultado.BirthDate = cursor.GetDateTime(5).ToString();
                        registroConsultado.HireDate = cursor.GetDateTime(6).ToString();
                        registroConsultado.Address = cursor.GetString(7).ToString();
                        registroConsultado.City = cursor.GetString(8).ToString();
                        registroConsultado.Region = cursor.GetString(9).ToString();
                        registroConsultado.PostalCode = cursor.GetString(10).ToString();
                        registroConsultado.Country = cursor.GetString(11).ToString();
                        registroConsultado.HomePhone = cursor.GetString(12).ToString();
                        registroConsultado.Extension = cursor.GetString(13).ToString();
                        //registroConsultado.Photo = cursor.GetString(14).ToString();
                        //registroConsultado.Notes = cursor.GetString(14).ToString();
                        //registroConsultado.ReportsTo = cursor.GetInt32(15).ToString();
                        //registroConsultado.PhotoPath = cursor.GetString(16).ToString();
                    }

                    //Verificamos los datos
                    Console.WriteLine("****************************************************************");
                    Console.WriteLine("****************************************************************");
                    Console.WriteLine("NOMBRE = " + registroConsultado.LastName + registroConsultado.FirstName + " ID EMPLOYEE = " + registroConsultado.EmployeeID);
                    Console.WriteLine("****************************************************************");
                    Console.WriteLine("****************************************************************");

                }
            }

            catch (Exception errorLectura)
            {
                Console.WriteLine("Error de consulta: " + errorLectura.Message);
                EmpleadoVO registroVacio = new EmpleadoVO();
                registroVacio.EmployeeID = "SIN REGISTRO";
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
