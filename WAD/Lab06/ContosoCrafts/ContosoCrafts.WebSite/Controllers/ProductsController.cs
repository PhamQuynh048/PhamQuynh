using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductsServices productService)
        {

        }

        public JsonFileProductsServices ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
                    return ProductService.GetProducts();
        }

        //[HttpPatch]
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string productId,
            [FromQuery] int Rating)
        {
            ProductService.AddRating(productId, Rating);
            return Ok();
        }
    }
}
