using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index() => View("SimpleForm");

        public ViewResult RecieveForm(string name, string city)
        {
            //var name = Request.Form["name"];
            //var city = Request.Form["city"];
            return View("Result", $"{name} lives in {city}");
        }
    }
}
