using Microsoft.AspNetCore.Mvc;

namespace WebKalkulator.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult Index()
        {
            TempData["Username"] = "M Bagheri";
            return View();
        }
    }
}
