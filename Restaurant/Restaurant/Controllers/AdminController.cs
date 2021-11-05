using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}