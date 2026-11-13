using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebKalkulator.AppConst;
using WebKalkulator.Models;

namespace WebKalkulator.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {

            //SetSession(SessionNamesConst.UserName, "MB Mit Session");
            //ViewBag.UserName = GetSession(SessionNamesConst.UserName);
            ViewBag.UserName=GetCookies(CookiesNamesConst.UserName);
            return View();
        }

        public IActionResult Privacy()
        {
            SetCookies(CookiesNamesConst.UserName, "MB mit Cookies");
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
