using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pizza_TeamVit.Models;
using Pizza_TeamVit.Models.ViewModels;

namespace Pizza_TeamVit.Controllers
{
    public class HomeController : Controller
    {

        private IStoreRepository repository;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public int PageSize = 6; // số sản phẩm trên 1 trang
        public ViewResult Index(string category, int productPage = 1) //chia sản phẩm theo trang id tính từ 1
            => View(new ProductListViewModel
            {
                Products = repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((productPage -1)*PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPErPage = PageSize,
                    //TotalItems= repository.Products.Count()
                    TotalItems = category == null ?
                    repository.Products.Count() :
                    repository.Products.Where(
                        e => e.Category == category).Count()
                },
                CurrentCategory = category

            });
    }
}
