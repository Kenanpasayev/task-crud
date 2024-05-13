using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MVC_pronia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
