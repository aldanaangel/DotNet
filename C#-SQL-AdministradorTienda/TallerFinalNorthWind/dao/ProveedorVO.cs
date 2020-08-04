using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerFinalNorthWind.dao
{
    /// <summary>
    /// Definicion del objeto ProveedorVO correspondiente a la abstraccion de la tabla Supplier
    /// </summary>
    public class ProveedorVO
    {
        //*************************************************
        //*************************************************
        //*************************************************
        private string supplierID;
        private string companyName;
        private string contactName;
        private string contactTitle;
        private string address;
        private string city;
        private string region;
        private string postalCode;
        private string country;
        private string phone;
        private string fax;
        private string homePage;


        //*************************************************
        //*************************************************
        //*************************************************
        //*************************************************
        /// <summary>
        /// Encapsulamiento de los atributos del objeto ProveedorVO
        /// </summary>
        public string SupplierID { get => supplierID; set => supplierID = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string ContactTitle { get => contactTitle; set => contactTitle = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Region { get => region; set => region = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string Country { get => country; set => country = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Fax { get => fax; set => fax = value; }
        public string HomePage { get => homePage; set => homePage = value; }
    }
}
