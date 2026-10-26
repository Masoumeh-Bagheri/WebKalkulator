using Microsoft.AspNetCore.Mvc;

namespace WebKalkulator.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
