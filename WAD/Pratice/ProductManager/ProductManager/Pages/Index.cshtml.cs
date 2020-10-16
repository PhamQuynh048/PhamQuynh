using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProductManager.Manager;
using ProductManager.Models;

namespace ProductManager.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileProductsManager ProductManager;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
        JsonFileProductsManager productManager)
        {
            _logger = logger;
            ProductManager = productManager;
        }

        public void OnGet()
        {
            Products = ProductManager.GetProducts();
        }
    }
}
