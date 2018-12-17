using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OQS.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Registration() {

            ViewBag.CityList = new List<String>
            {
                "Nanded",
                "Mumnai",
                "Pune",
                "Delhi"
            };
            return View();
        }
    }
}
