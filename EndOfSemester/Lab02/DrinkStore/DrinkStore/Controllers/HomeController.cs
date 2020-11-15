using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DrinkStore.Models;
using DrinkStore.Models.ViewModels;

namespace DrinkStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        

        public ViewResult Index(int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPErPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
    }
}
