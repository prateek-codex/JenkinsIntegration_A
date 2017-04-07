using ProjectB_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectA_Dependent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UseExternalLibrary();
            return View();
        }

        private void UseExternalLibrary()
        {
            IVendingMachine vendingMachine = new ChocolateVendingMachine();
            Console.WriteLine(vendingMachine.BuyItem());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}