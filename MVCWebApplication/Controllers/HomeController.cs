using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.date = hour < 12 ? "eeee" : "bbcbv";
            return View();
        }

        public ViewResult RspvForm()
        {
            return View();
        }
    }
}