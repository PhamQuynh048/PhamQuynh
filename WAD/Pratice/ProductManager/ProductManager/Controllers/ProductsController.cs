using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManager.Manager;
using ProductManager.Models;

namespace ProductManager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductsManager productManager)
        {
            this.ProductManager = productManager;
        }

        public JsonFileProductsManager ProductManager { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductManager.GetProducts();
        }
    }
}
