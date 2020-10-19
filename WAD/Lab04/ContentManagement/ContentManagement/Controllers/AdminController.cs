using ContentManagement.CustomFilter;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContentManagement.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [AuthLog(Roles = "Admin")]
        public ActionResult Index()
        {
            return View();
        }
    }
}