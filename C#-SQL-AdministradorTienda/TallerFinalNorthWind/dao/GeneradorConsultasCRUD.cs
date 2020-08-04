using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerFinalNorthWind.dao
{
    /// <summary>
    /// Clase que genera todas las consultas que se usaran posteriormente para darle manejo a las tablas
    /// </summary>
    public class GeneradorConsultasCRUD
    {
        private string querySQL;
        //******************************************************
        //******************************************************

       
        //******************************************************
        /// <summary>
        /// Consulta insert del producto
        /// </summary>
        /// <returns>Retorna la query que se ha generado en la herramienta management de sqlServer</returns>
        public string generarConsultaInsert()
        {
            this.querySQL =
            "INSERT INTO[dbo].[Products] " +
            " ([ProductName],[SupplierID],[CategoryID],[QuantityPerUnit],[UnitPrice],[UnitsInStock],[UnitsOnOrder],[ReorderLevel],[Discontinued]) " +
            " VALUES (@ProductNameP, @SupplierIDP, @CategoryIDP, @QuantityPerUnitP, @UnitPriceP, @UnitsInStockP, @UnitsOnOrderP, @ReorderLevelP, @DiscontinuedP) ";

            return (this.querySQL);
        }

       
        //******************************************************
        /// <summary>
        /// Consulta del insert proveedor
        /// </summary>
        /// <returns>Retorna la query que se ha generado en la herramienta management de sqlServer</returns>
        public string generarConsultaInsertProveedor()
        {
            this.querySQL =
            "INSERT INTO [dbo].[Suppliers] " +
            " ([CompanyName],[ContactName],[ContactTitle],[Address],[City],[Region],[PostalCode],[Country],[Phone],[Fax],[HomePage]) " +
            " VALUES (@CompanyNamePv, @ContactNamePv, @ContactTitlePv, @AddressPv, @CityPv, @RegionPv, @PostalCodePv, @CountryPv, @PhonePv, @FaxPv, @HomePagePv) ";

            return (this.querySQL);
        }

       
        //******************************************************
        /// <summary>
        /// Consulta del insert empleados
        /// </summary>
        /// <returns>Retorna la query que se ha generado en la herramienta management de sqlServer</returns>

        public string generarConsultaInsertEmpleados()
        {
            this.querySQL =
            "INSERT INTO [dbo].[Employees] " +
            "([LastName],[FirstName],[Title],[TitleOfCourtesy],[BirthDate],[HireDate],[Address],[City],[Region],[PostalCode],[Country],[HomePhone],[Extension],[Notes],[ReportsTo],[PhotoPath]) " +
            " VALUES (@LastNameEm, @FirstNameEm, @TitleEm, @TitleOfCourtesyEm, @BirthDateEm, @HireDateEm, @AddressEm, @CityEm, @RegionEm, @PostalCodeEm, @CountryEm, @HomePhoneEm, @ExtensionEm, @NotesEm, @ReportsToEm, @PhotoPathEm ) ";

            return (this.querySQL);
        }

        
        //******************************************************
        /// <summary>
        /// Consulta del insert categorias
        /// </summary>
        /// <returns>Retorna la query que se ha generado en la herramienta management de sqlServer</returns>
        public string generarConsultaInsertCategorias()
        {
            this.querySQL =
            "INSERT INTO [dbo].[Categories] " +
            "([CategoryName],[Description]) " +
            " VALUES (@CategoryNameCa, @DescriptionCa) ";

            return (this.querySQL);
      
        }



        //******************************************************
        /// <summary>
        /// Modificar registro Producto
        /// </summary>
        /// <returns>Retorna la query que se ha generado en la herramienta management de sqlServer</returns>
        public string generarConsultaUpdate()
        {
            this.querySQL =
            "UPDATE[dbo].[Products] " +
            "    SET[ProductName] = @ProductNameP " +
            "        ,[SupplierID] = @SupplierIDP " +
            "        ,[CategoryID] = @CategoryIDP " +
            "        ,[QuantityPerUnit] = @QuantityPerUnitP " +
            "        ,[UnitPrice] = @UnitPriceP " +
            "        ,[UnitsInStock] = @UnitsInStockP " +
            "        ,[UnitsOnOrder] = @UnitsOnOrderP " +
            "        ,[ReorderLevel] = @ReorderLevelP " +
            "        ,[Discontinued] = @DiscontinuedP " +
            "     WHERE [ProductID] = @ProductIDP ";
            return (this.querySQL);
        }

        
        //******************************************************
        /// <summary>
        /// Modificar registro Proveedor
        /// </summary>
        /// <returns>Retorna la query que se ha generado en la herramienta management de sqlServer</returns>
        public string generarConsultaUpdateProveedor()
        {
            this.querySQL =
            "UPDATE [dbo].[Suppliers]" +
                 " SET[CompanyName] =     @CompanyNamePv        " +
                 "     ,[ContactName] =   @ContactNamePv        " +
                 "     ,[ContactTitle] =  @ContactTitlePv       " +
                 "     ,[Address] =       @AddressPv            " +
                 "     ,[City] =          @CityPv          " +
                 "     ,[Region] =        @RegionPv          " +
                 "     ,[PostalCode] =    @PostalCodePv          " +
                 "     ,[Country] =       @CountryPv           " +
                 "     ,[Phone] =         @PhonePv          " +
                 "     ,[Fax] =           @FaxPv            " +
                 "     ,[HomePage] =      @HomePagePv          " +
                 " WHERE[SupplierID] =   @SupplierIDPv ";
            return (this.querySQL);
        }

        
        //******************************************************
        /// <summary>
        /// Modificar registro Empleados
        /// </summary>
        /// <returns>Retorna la query que se ha generado en la herramienta management de sqlServer</returns>
        public string generarConsultaUpdateEmpleados()
        {
            this.querySQL =
            " UPDATE[dbo].[Employees]" +
                 "   SET[LastName] =             @LastNameEm        " +
                 "     ,[FirstName] =            @FirstNameEm        " +
                 "     ,[Title] =                @TitleEm       " +
                 "     ,[TitleOfCourtesy] =      @TitleOfCourtesyEm            " +
                 "     ,[BirthDate] =            @BirthDateEm          " +
                 "     ,[HireDate] =             @HireDateEm          " +
                 "     ,[Address] =              @AddressEm          " +
                 "     ,[City] =                 @CityEm           " +
                 "     ,[Region] =               @RegionEm            " +
                 "     ,[PostalCode] =           @PostalCodeEm          " +
                 "     ,[Country] =              @CountryEm          " +
                 "     ,[HomePhone] =            @HomePhoneEm          " +
                 "     ,[Extension] =            @ExtensionEm          " +
                 "     ,[Notes] =                @NotesEm          " +
                 "     ,[ReportsTo] =            @ReportsToEm          " +
                

                 " WHERE[EmployeeID] =   @EmployeeIDEm ";
            return (this.querySQL);
          



    }

        
        //******************************************************
        /// <summary>
        /// Modificar registro Categorias
        /// </summary>
        /// <returns>Retorna la query que se ha generado en la herramienta management de sqlServer</returns>
        public string generarConsultaUpdateCategorias()
        {
            this.querySQL =
            "UPDATE [dbo].[Categories]" +
                 " SET[CategoryName] =     @CategoryNameCa        " +
                 "     ,[Description] =   @DescriptionCa        " +
               
                 " WHERE[CategoryID] =   @CategoryIDCa ";
            return (this.querySQL);
          
    }


        //******************************************************
        //******************************************************

        
        //******************************************************
        /// <summary>
        /// Generar consulta select del producto
        /// </summary>
        /// <returns>Retorna la query que se ha generado en la herramienta management de sqlServer</returns>
        public string generarConsultaSelect()
        {
            this.querySQL =
            "SELECT [ProductID] " +
            "      ,[ProductName] " +
            "      ,[SupplierID] " +
            "      ,[CategoryID] " +
            "      ,[QuantityPerUnit] " +
            "      ,[UnitPrice] " +
            "      ,[UnitsInStock] " +
            "      ,[UnitsOnOrder] " +
            "      ,[ReorderLevel] " +
            "      ,[Discontinued] " +
            "        FROM[dbo].[Products] " +
            "  WHERE [ProductID] = @ProductID ";

            return (this.querySQL);
        }

        
        //******************************************************
        /// <summary>
        ///Generar Consulta select para proveedores
        /// </summary>
        /// <returns>Retorna la query que se ha generado en la herramienta management de sqlServer</returns>
        public string generarConsultaSelectProveedores()
        {
            this.querySQL =
            "SELECT [SupplierID] " +
            "      ,[CompanyName] " +
            "      ,[ContactName] " +
            "      ,[ContactTitle] " +
            "      ,[Address] " +
            "      ,[City]" +
            "      ,[Region] " +
            "      ,[PostalCode] " +
            "      ,[Country] " +
            "      ,[Phone] " +
            "      ,[Fax] " +
            "      ,[HomePage]" +
            "        FROM [dbo].[Suppliers]" +
            "  WHERE [SupplierID] = @SupplierIDPv ";

            return (this.querySQL);
        }

        
        //******************************************************
        /// <summary>
        ///Generar Consulta select para empleados
        /// </summary>
        /// <returns>Retorna la query que se ha generado en la herramienta management de sqlServer</returns>
        public string generarConsultaSelectEmpleados()
        {
            this.querySQL =
            "SELECT [EmployeeID] " +
            "      ,[LastName] " +
            "      ,[FirstName] " +
            "      ,[Title] " +
            "      ,[TitleOfCourtesy] " +
            "      ,[BirthDate]" +
            "      ,[HireDate] " +
            "      ,[Address] " +
            "      ,[City] " +
            "      ,[Region] " +
            "      ,[PostalCode] " +
            "      ,[Country]" +
            "      ,[HomePhone]" +
            "      ,[Extension]" +
            "      ,[Photo]" +
            "      ,[Notes]" +
            "      ,[ReportsTo]" +
            "      ,[PhotoPath]" +

            "        FROM [dbo].[Employees]" +
            "  WHERE [EmployeeID] = @EmployeeIDEm ";

            return (this.querySQL);

       
    }

        
        //******************************************************
        /// <summary>
        ///Generar Consulta select para categorias
        /// </summary>
        /// <returns>Retorna la query que se ha generado en la herramienta management de sqlServer</returns>
        public string generarConsultaSelectCategorias()
        {
            this.querySQL =
            "SELECT [CategoryID] " +
            "      ,[CategoryName] " +
            "      ,[Description] " +
            
            "        FROM [dbo].[Categories]" +
            "  WHERE [CategoryID] = @CategoryIDCa ";

            return (this.querySQL);

           
    }

        //******************************************************
        //******************************************************
        //******************************************************
        public string generarConsultaDelete()
        {
            this.querySQL =
            "DELETE FROM[dbo].[Products] " +
            "  WHERE [ProductID] = @ProductID ";
            return (this.querySQL);
        }
        //******************************************************
        //******************************************************
        //******************************************************
        public string generarConsultaTodosRegistros(string modo)
        {
            this.querySQL =
            "SELECT [ProductID] " +
            "      ,[ProductName] " +
            "      ,[SupplierID] " +
            "      ,[CategoryID] " +
            "      ,[QuantityPerUnit] " +
            "      ,[UnitPrice] " +
            "      ,[UnitsInStock] " +
            "      ,[UnitsOnOrder] " +
            "      ,[ReorderLevel] " +
            "      ,[Discontinued] " +
            "        FROM[dbo].[Products] " +
            "  ORDER BY [ProductID] " + modo;

            return (this.querySQL);
        }

        //******************************************************
    }//
}
            
       