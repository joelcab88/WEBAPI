using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRODUCTOS_COTEMAR.Models
{
    public class ProductViewModel
    {
        public int id { get; set; }
        public double price { get; set; }
        public string name { get; set; }
        public int stock { get; set; }
        public List<object> notifications { get; set; }
    }
}
