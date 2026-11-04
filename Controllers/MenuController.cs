using Microsoft.AspNetCore.Mvc;

namespace WebKalkulator.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MenuIndex()
        {

            return View();
        }
    }
}
