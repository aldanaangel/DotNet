using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerFinalNorthWind.dao
{
    public class DAOOperacionesProveedor
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
            public DAOOperacionesProveedor()
            {
            }
            //*************************************************************************
            //*************************************************************************
            //*************************************************************************
            //Constructor sobrecargado del DAO
            public DAOOperacionesProveedor(string cadenaConexion)
            {
                con = new SqlConnection(cadenaConexion);
                Console.WriteLine("Conexión establecida: " + con);
                generadorQueriesSQL = new GeneradorConsultasCRUD();
            }
            //************************************************************************
            //************************************************************************
            //************************************************************************
            //Método para realizar la inserción del registro del proveedor
            public bool InsertarRegistroProveedor(ProveedorVO registroEntidad)
            {
                bool seInserto = false;
                string consulta = "";
                int totalFilas = 0;

                try
                {
                    //********************************************************************
                    //********************************************************************
                    //********************************************************************
                    consulta = generadorQueriesSQL.generarConsultaInsertProveedor();
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
                
                   // cmd.Parameters.AddWithValue("SupplierIDPv",   registroEntidad.SupplierID);
                    cmd.Parameters.AddWithValue("CompanyNamePv",  registroEntidad.CompanyName);
                    cmd.Parameters.AddWithValue("ContactNamePv",  registroEntidad.ContactName);
                    cmd.Parameters.AddWithValue("ContactTitlePv", registroEntidad.ContactTitle);
                    cmd.Parameters.AddWithValue("AddressPv",      registroEntidad.Address);
                    cmd.Parameters.AddWithValue("CityPv",         registroEntidad.City);
                    cmd.Parameters.AddWithValue("RegionPv",       registroEntidad.Region);
                    cmd.Parameters.AddWithValue("PostalCodePv",   registroEntidad.PostalCode);
                    cmd.Parameters.AddWithValue("CountryPv",      registroEntidad.Country);
                    cmd.Parameters.AddWithValue("PhonePv",        registroEntidad.Phone);
                    cmd.Parameters.AddWithValue("FaxPv",          registroEntidad.Fax);
                    cmd.Parameters.AddWithValue("HomePagePv",     registroEntidad.HomePage);
                // cmd.Parameters.AddWithValue("@DiscontinuedP", registroEntidad.Discontinued);
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
            public bool modificarRegistroProveedor(ProveedorVO registroEntidad)
            {
                bool seModifico = false;
                string consulta = "";
                int totalFilas = 0;

                try
                {
                    //********************************************************************
                    //********************************************************************
                    //********************************************************************
                    consulta = generadorQueriesSQL.generarConsultaUpdateProveedor();
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
                cmd.Parameters.AddWithValue("CompanyNamePv", registroEntidad.CompanyName);
                cmd.Parameters.AddWithValue("ContactNamePv", registroEntidad.ContactName);
                cmd.Parameters.AddWithValue("ContactTitlePv", registroEntidad.ContactTitle);
                cmd.Parameters.AddWithValue("AddressPv", registroEntidad.Address);
                cmd.Parameters.AddWithValue("CityPv", registroEntidad.City);
                cmd.Parameters.AddWithValue("RegionPv", registroEntidad.Region);
                cmd.Parameters.AddWithValue("PostalCodePv", registroEntidad.PostalCode);
                cmd.Parameters.AddWithValue("CountryPv", registroEntidad.Country);
                cmd.Parameters.AddWithValue("PhonePv", registroEntidad.Phone);
                cmd.Parameters.AddWithValue("FaxPv", registroEntidad.Fax);
                cmd.Parameters.AddWithValue("HomePagePv", registroEntidad.HomePage);

                //Llave para el update
                cmd.Parameters.AddWithValue("@SupplierIDPv", registroEntidad.SupplierID);

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
            public ProveedorVO consultarRegistroProveedor(int SupplierID)
            {
                ProveedorVO registroConsultado = new ProveedorVO();
                string consulta = "";
                SqlCommand command = null;
                SqlDataReader cursor = null;

                try
                {
                    consulta = generadorQueriesSQL.generarConsultaSelectProveedores();
                    Console.WriteLine(consulta);

                    con.Open();
                    command = new SqlCommand(consulta, con);
                    Console.WriteLine("ID DE PROVEEDOR A CONSULTAR: " + SupplierID);
                    command.Parameters.AddWithValue("@SupplierIDPv", SupplierID);

                    //Recorremos el cursor de la consulta para obtener
                    //los datos usando un sqlDataReader
                    cursor = command.ExecuteReader();

                    if (cursor != null)
                    {
                        while (cursor.Read())
                        {
                            registroConsultado.SupplierID = cursor.GetInt32(0).ToString();
                            registroConsultado.CompanyName = cursor.GetString(1).ToString();
                            registroConsultado.ContactName = cursor.GetString(2).ToString();
                            registroConsultado.ContactTitle = cursor.GetString(3).ToString();
                            registroConsultado.Address = cursor.GetString(4).ToString();
                            registroConsultado.City = cursor.GetString(5).ToString();
                            registroConsultado.Region = cursor.GetString(6).ToString();
                            registroConsultado.PostalCode = cursor.GetString(7).ToString();
                            registroConsultado.Country = cursor.GetString(8).ToString();
                            registroConsultado.Phone = cursor.GetString(9).ToString();
                            registroConsultado.Fax = cursor.GetString(10).ToString();
                            registroConsultado.HomePage = cursor.GetString(11).ToString();
                    }

                        //Verificamos los datos
                        Console.WriteLine("****************************************************************");
                        Console.WriteLine("****************************************************************");
                        Console.WriteLine("NOMBRE = " + registroConsultado.CompanyName + " ID SUPPLIER = " + registroConsultado.SupplierID);
                        Console.WriteLine("****************************************************************");
                        Console.WriteLine("****************************************************************");

                    }
                }

                catch (Exception errorLectura)
                {
                    Console.WriteLine("Error de consulta: " + errorLectura.Message);
                    ProveedorVO registroVacio = new ProveedorVO();
                    registroVacio.SupplierID = "SIN REGISTRO";
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
