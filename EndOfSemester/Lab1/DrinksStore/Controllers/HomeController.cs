using Microsoft.AspNetCore.Mvc;
using DrinksStore.Models;

namespace DrinksStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
