using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerFinalNorthWind.dao
{
    /// <summary>
    /// Definicion del objeto ProductoVO correspondiente a la abstraccion de la tabla Products
    /// </summary>
    public class ProductoVO
    {
        //*************************************************
        //*************************************************
        //*************************************************

        private string productID;
        private string productName;
        private string supplierID;
        private string categoryID;
        private string quantityPerUnit;
        private string unitPrice;
        private string unitsInStock;
        private string unitsOnOrder;
        private string reorderLevel;
        private string discontinued;
        //*************************************************
        //*************************************************
        //*************************************************
        //*************************************************
        /// <summary>
        /// Encapsulamiento de los atributos del objeto ProductoVo
        /// </summary>
        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string SupplierID { get => supplierID; set => supplierID = value; }
        public string CategoryID { get => categoryID; set => categoryID = value; }
        public string QuantityPerUnit { get => quantityPerUnit; set => quantityPerUnit = value; }
        public string UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string UnitsInStock { get => unitsInStock; set => unitsInStock = value; }
        public string UnitsOnOrder { get => unitsOnOrder; set => unitsOnOrder = value; }
        public string ReorderLevel { get => reorderLevel; set => reorderLevel = value; }
        public string Discontinued { get => discontinued; set => discontinued = value; }
        //*************************************************
        //*************************************************
        //*************************************************
    }
}
