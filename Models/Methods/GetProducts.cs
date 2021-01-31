using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        /// <summary>
        /// Obtiene una lista de todos los productos.
        /// </summary>
        /// <returns>Lista de productos</returns>
        public async Task<List<ProductViewModel>> GetAllProducts()
        {
            using (HttpClient client = new HttpClient())
            {
                String petition = "products/forsale";
                client.BaseAddress = new Uri(this.UriApi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(mediaHeader);
                HttpResponseMessage respuesta = await client.GetAsync(petition);
                if (respuesta.IsSuccessStatusCode)
                {
                    var jsonResult = await respuesta.Content.ReadAsStringAsync();
                    var lstResponse = JsonConvert.DeserializeObject<ListProduct>(jsonResult).data;
                    return lstResponse;
                }
                else { return null; }
            }
        }
    }
}
