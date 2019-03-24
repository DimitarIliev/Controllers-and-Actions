using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class ExampleController: Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Hello";
            ViewBag.Date = DateTime.Now;
            return View();
        }

        public ViewResult Result() => View((object)"Hello World");

        public RedirectToActionResult Redirect() => RedirectToAction("Index");
        //  public RedirectToActionResult Redirect() => RedirectToAction("Index", "Home");
        //public RedirectToRouteResult Redirect() => RedirectToRoute(new { controller = "Example", action = "Index", ID = "MyID" });
        //public RedirectResult Redirect() => RedirectPermanent("Example/Index"); //Redirect("Example/Index");
    }
}
