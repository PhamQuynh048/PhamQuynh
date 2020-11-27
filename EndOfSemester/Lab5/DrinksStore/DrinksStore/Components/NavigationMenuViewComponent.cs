using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DrinksStore.Models;

namespace DrinksStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        //public string Invoke()
        //{
        //    return "Hello from the Mav Viwe Component";
        //}
        private IStoreRepository repository;

        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
