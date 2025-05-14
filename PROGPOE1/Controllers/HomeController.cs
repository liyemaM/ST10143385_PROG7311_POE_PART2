using Microsoft.AspNetCore.Mvc;

namespace PROGPOE1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }

        public IActionResult AccessDenied()
        {
            return View(); 
        }
    }
}
