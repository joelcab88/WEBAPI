using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRODUCTOS_COTEMAR.Models
{
    /// <summary>
    /// Clase para obtener el listados de todos los productos.
    /// </summary>
    public class ListProduct
    {
        public bool success { get; set; }
        public List<ProductViewModel> data { get; set; }
    }
}
