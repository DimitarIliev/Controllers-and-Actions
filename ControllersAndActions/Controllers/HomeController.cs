using ControllersAndActions.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllersAndActions.Controllers
{
    public class HomeController: Controller
    {
        //public JsonResult Index() => Json(new[] { "Alice", "Bob", "Joe" });

        //public ObjectResult Index() => Ok(new string[] { "Alice", "Bob", "Joe" });

        //public VirtualFileResult Index() => File("lib/bootstrap/dis/css/bootstrap.css", "text/css");

        //public StatusCodeResult Index() => StatusCode(StatusCodes.Status404NotFound);

        public StatusCodeResult Index() => NotFound();

        //public IActionResult RecieveForm(string name, string city) => new CustomHtmlResult
        //{
        //    Content = $"{name} lives in {city}"
        //};

        //render a specific view 
        //return View("/Views/Admin/Index");
        [HttpPost]
        public RedirectToActionResult RecieveForm(string name, string city)
        {
            TempData["name"] = name;
            TempData["city"] = city;
            return RedirectToAction(nameof(Data));
        }

        public ViewResult Data()
        {
            string name = TempData["name"] as string;
            string city = TempData["city"] as string;
            return View("Result", $"{name} lives in {city}");
        }
    }
}
