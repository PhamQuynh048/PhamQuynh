using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DrinksStore.Models;

namespace DrinksStore.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index() =>  View();
    

    }
}
