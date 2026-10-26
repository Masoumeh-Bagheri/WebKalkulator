using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebKalkulator.Models;

namespace WebKalkulator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(KalModels c)
        {
            switch (c.Opertation)
                {
                case '+': c.Result = c.Number2 + c.Number1;
                    break;
                case '-':
                    c.Result = c.Number2 - c.Number1;
                    break;
                case '*':
                    c.Result = c.Number2 * c.Number1;
                    break;
                case '/':
                    c.Result = c.Number2 / c.Number1;
                    break;
            }
            return View(c);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
