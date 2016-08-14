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

        [Route]
        public ActionResult Yoga()
        {

            return View("Yoga");
        }
    }
}
