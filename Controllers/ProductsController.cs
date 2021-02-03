using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PRODUCTOS_COTEMAR.Models.Methods;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PRODUCTOS_COTEMAR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        GetProducts getProd;

        /// <summary>
        /// Constructor que inicializa clase de métodos.
        /// </summary>
        public ProductsController()
        {
            this.getProd = new GetProducts();
        }

        // GET: api/<ProuductsController>
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var lstProduct = await getProd.GetAllProducts();
            return View(lstProduct);
        }

        // GET api/<ProuductsController>/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Details(int id)
        {
            var _product = await getProd.GetProductById(id);
            return View(_product);
        }

        // POST api/<ProuductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProuductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProuductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
