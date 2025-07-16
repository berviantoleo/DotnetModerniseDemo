using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotnetModerniseDemo.Library;

namespace DotnetModerniseDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var random = new Random();
            var magicNumber1 = random.Next(1, 1000);
            var magicNumber2 = random.Next(1, 1000);
            var sum = SimpleCalculator.Add(magicNumber1, magicNumber2);
            ViewBag.Message = $"Your application description page. Your magic number a: {magicNumber1} b: {magicNumber2} sum: {sum}";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}