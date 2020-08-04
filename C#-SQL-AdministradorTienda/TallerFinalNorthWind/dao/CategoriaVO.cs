using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerFinalNorthWind.dao
{

    /// <summary>
    /// Definicion del objeto CategoriaVO correspondiente a la abstraccion de la tabla Categories
    /// </summary>
    public class CategoriaVO
    {

        private string categoryID;
        private string categoryName;
        private string description;
        private string picture;

        /// <summary>
        /// Encapsulamiento de los atributos del objeto CategoriaVO
        /// </summary>
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string Description { get => description; set => description = value; }
        public string Picture { get => picture; set => picture = value; }
        public string CategoryID { get => categoryID; set => categoryID = value; }
    }
}
