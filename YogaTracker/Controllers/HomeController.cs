using Keligula.Services.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Keligula.Controllers
{
    [RoutePrefix("Yoga")]
    public class HomeController : Controller
    {
        //[Dependency]
        //public ITestService TestService { get; set; }

        //[Route]
        //public ActionResult Index()
        //{
        //    //int result = TestService.TestMethod();
        //    //result += 1;

        //    return View("Index_ng");
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        [Route]
        public ActionResult Yoga()
        {

            return View("Yoga");
        }
    }
}