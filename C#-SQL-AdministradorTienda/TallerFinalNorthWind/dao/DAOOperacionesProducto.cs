using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TallerFinalNorthWind.dao
{
    
        public class DAOOperacionesProducto
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

            //*************************************************************************
            //*************************************************************************
            //*************************************************************************
            public DAOOperacionesProducto()
            {
            }
            //*************************************************************************
            //*************************************************************************
            //*************************************************************************
            //Constructor sobrecargado del DAO
            public DAOOperacionesProducto(string cadenaConexion)
            {
                con = new SqlConnection(cadenaConexion);
                Console.WriteLine("Conexión establecida: " + con);
                generadorQueriesSQL = new GeneradorConsultasCRUD();
            }
            //************************************************************************
            //************************************************************************
            //************************************************************************
            //Método para realizar la inserción del registro
            public bool insertarRegistroProducto(ProductoVO registroEntidad)
            {
                bool seInserto = false;
                string consulta = "";
                int totalFilas = 0;

                try
                {
                    //********************************************************************
                    //********************************************************************
                    //********************************************************************
                    consulta = generadorQueriesSQL.generarConsultaInsert();
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
                    //cmd.Parameters.AddWithValue("@ProductIDP",	registroEntidad.ProductID);
                    cmd.Parameters.AddWithValue("@ProductNameP", registroEntidad.ProductName);
                    cmd.Parameters.AddWithValue("@SupplierIDP", registroEntidad.SupplierID);
                    cmd.Parameters.AddWithValue("@CategoryIDP", registroEntidad.CategoryID);
                    cmd.Parameters.AddWithValue("@QuantityPerUnitP", registroEntidad.QuantityPerUnit);
                    cmd.Parameters.AddWithValue("@UnitPriceP", registroEntidad.UnitPrice);
                    cmd.Parameters.AddWithValue("@UnitsInStockP", registroEntidad.UnitsInStock);
                    cmd.Parameters.AddWithValue("@UnitsOnOrderP", registroEntidad.UnitsOnOrder);
                    cmd.Parameters.AddWithValue("@ReorderLevelP", registroEntidad.ReorderLevel);
                    cmd.Parameters.AddWithValue("@DiscontinuedP", registroEntidad.Discontinued);
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
            //Método para realizar la modificación del registro
            public bool modificarRegistroProducto(ProductoVO registroEntidad)
            {
                bool seModifico = false;
                string consulta = "";
                int totalFilas = 0;

                try
                {
                    //********************************************************************
                    //********************************************************************
                    //********************************************************************
                    consulta = generadorQueriesSQL.generarConsultaUpdate();
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
                    cmd.Parameters.AddWithValue("@ProductNameP", registroEntidad.ProductName);
                    cmd.Parameters.AddWithValue("@SupplierIDP", registroEntidad.SupplierID);
                    cmd.Parameters.AddWithValue("@CategoryIDP", registroEntidad.CategoryID);
                    cmd.Parameters.AddWithValue("@QuantityPerUnitP", registroEntidad.QuantityPerUnit);
                    cmd.Parameters.AddWithValue("@UnitPriceP", registroEntidad.UnitPrice);
                    cmd.Parameters.AddWithValue("@UnitsInStockP", registroEntidad.UnitsInStock);
                    cmd.Parameters.AddWithValue("@UnitsOnOrderP", registroEntidad.UnitsOnOrder);
                    cmd.Parameters.AddWithValue("@ReorderLevelP", registroEntidad.ReorderLevel);
                    cmd.Parameters.AddWithValue("@DiscontinuedP", registroEntidad.Discontinued);

                    //Llave para el update
                    cmd.Parameters.AddWithValue("@ProductIDP", registroEntidad.ProductID);

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
            public bool eliminarRegistroProducto(int idProducto)
            {
                bool seElimino = false;
                string consulta = "";

                try
                {
                    consulta = generadorQueriesSQL.generarConsultaDelete();
                    cmd = new SqlCommand(consulta, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@ProductID", idProducto);
                    cmd.ExecuteNonQuery();
                    seElimino = true;
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("El registro con ID " + idProducto + " se borró: " + seElimino);
                    Console.WriteLine("-------------------------------------------------------------------");
                }

                catch (Exception errorInsertar)
                {
                    Console.WriteLine("Error de eliminación: " + errorInsertar.Message);
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

                return (seElimino);
            }
            //************************************************************************
            //************************************************************************
            //************************************************************************
            public ProductoVO consultarRegistroProducto(int idProducto)
            {
                ProductoVO registroConsultado = new ProductoVO();
                string consulta = "";
                SqlCommand command = null;
                SqlDataReader cursor = null;

                try
                {
                    consulta = generadorQueriesSQL.generarConsultaSelect();
                    Console.WriteLine(consulta);

                    con.Open();
                    command = new SqlCommand(consulta, con);
                    Console.WriteLine("ID DE PRODUCTO A CONSULTAR: " + idProducto);
                    command.Parameters.AddWithValue("@ProductID", idProducto);

                    //Recorremos el cursor de la consulta para obtener
                    //los datos usando un sqlDataReader
                    cursor = command.ExecuteReader();

                    if (cursor != null)
                    {
                        while (cursor.Read())
                        {
                            registroConsultado.ProductID = cursor.GetInt32(0).ToString();
                            registroConsultado.ProductName = cursor.GetString(1).ToString();
                            registroConsultado.SupplierID = cursor.GetInt32(2).ToString();
                            registroConsultado.CategoryID = cursor.GetInt32(3).ToString();
                            registroConsultado.QuantityPerUnit = cursor.GetString(4);
                            registroConsultado.UnitPrice = cursor.GetDecimal(5).ToString();
                            registroConsultado.UnitsInStock = cursor.GetInt16(6).ToString();
                            registroConsultado.UnitsOnOrder = cursor.GetInt16(7).ToString();
                            registroConsultado.ReorderLevel = cursor.GetInt16(8).ToString();
                            registroConsultado.Discontinued = cursor.GetBoolean(9).ToString();
                        }

                        //Verificamos los datos
                        Console.WriteLine("****************************************************************");
                        Console.WriteLine("****************************************************************");
                        Console.WriteLine("NOMBRE = " + registroConsultado.ProductName + " ID PRODUCTO = " + registroConsultado.ProductID);
                        Console.WriteLine("****************************************************************");
                        Console.WriteLine("****************************************************************");

                    }
                }

                catch (Exception errorLectura)
                {
                    Console.WriteLine("Error de consulta: " + errorLectura.Message);
                    ProductoVO registroVacio = new ProductoVO();
                    registroVacio.ProductName = "SIN REGISTRO";
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
            public List<ProductoVO> generarListadoProductos(string modo)
            {
                List<ProductoVO> registros = new List<ProductoVO>();
                ProductoVO registroConsultado = null;
                string consulta = "";
                SqlCommand command = null;
                SqlDataReader cursor = null;
                int i = 0;

                try
                {
                    consulta = generadorQueriesSQL.generarConsultaTodosRegistros(modo);
                    Console.WriteLine(consulta);

                    con.Open();
                    command = new SqlCommand(consulta, con);

                    //Recorremos el cursor de la consulta para obtener
                    //los datos usando un sqlDataReader
                    cursor = command.ExecuteReader();

                    if (cursor != null)
                    {
                        while (cursor.Read())
                        {
                            registroConsultado = new ProductoVO();
                            registroConsultado.ProductID = cursor.GetInt32(0).ToString();
                            registroConsultado.ProductName = cursor.GetString(1).ToString();
                            registroConsultado.SupplierID = cursor.GetInt32(2).ToString();
                            registroConsultado.CategoryID = cursor.GetInt32(3).ToString();
                            registroConsultado.QuantityPerUnit = cursor.GetString(4);
                            registroConsultado.UnitPrice = cursor.GetDecimal(5).ToString();
                            registroConsultado.UnitsInStock = cursor.GetInt16(6).ToString();
                            registroConsultado.UnitsOnOrder = cursor.GetInt16(7).ToString();
                            registroConsultado.ReorderLevel = cursor.GetInt16(8).ToString();
                            registroConsultado.Discontinued = cursor.GetBoolean(9).ToString();

                            registros.Add(registroConsultado);
                        }

                        //Verificamos los datos
                        Console.WriteLine("****************************************************************");
                        Console.WriteLine("****************************************************************");
                        Console.WriteLine("NOMBRE = " + registroConsultado.ProductName + " ID PRODUCTO = " + registroConsultado.ProductID);
                        Console.WriteLine("****************************************************************");
                        Console.WriteLine("****************************************************************");

                    }
                }

                catch (Exception errorLectura)
                {
                    Console.WriteLine("Error de consulta: " + errorLectura.Message);
                    List<ProductoVO> vacios = new List<ProductoVO>();
                    return (vacios);
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

                return (registros);
            }
            //************************************************************************
            //************************************************************************
            //************************************************************************
            //************************************************************************
            //************************************************************************
        }//Fin de la clase

    }

