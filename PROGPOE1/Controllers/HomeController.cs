using Microsoft.AspNetCore.Mvc;

namespace PROGPOE1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // This will be your public landing page
        }

        public IActionResult AccessDenied()
        {
            return View(); // Optional: show if user is denied access to a page
        }
    }
}
