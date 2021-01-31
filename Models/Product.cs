using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRODUCTOS_COTEMAR.Models
{
    /// <summary>
    /// Clase para obtener detalles de un producto.
    /// </summary>
    public class Product
    {
        public bool success { get; set; }
        public ProductViewModel data { get; set; }
    }
}
