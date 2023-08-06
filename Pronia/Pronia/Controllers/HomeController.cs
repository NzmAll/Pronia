using Microsoft.AspNetCore.Mvc;
using Pronia.Database.Models;

namespace Pronia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
