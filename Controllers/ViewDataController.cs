using Microsoft.AspNetCore.Mvc;

namespace WebKalkulator.Controllers
{
    public class ViewDataController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Username"] = "M Bagheri";
            return View();
        }
    }
}
