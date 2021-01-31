using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PRODUCTOS_COTEMAR.Models.Methods
{
    /// <summary>
    /// Clase para obtener detalle de uno o varios productos.
    /// </summary>
    public class GetProducts
    {
        private String UriApi;
        MediaTypeWithQualityHeaderValue mediaHeader;

        /// <summary>
        /// Constructor
        /// </summary>
        public GetProducts()
        {
            this.UriApi = "http://cotdevsampleapi.azurewebsites.net/v1/"; //API COTEMAR
            this.mediaHeader = new MediaTypeWithQualityHeaderValue("application/json");
        }
    }
}
