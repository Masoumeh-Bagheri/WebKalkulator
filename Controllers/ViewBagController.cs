using Microsoft.AspNetCore.Mvc;
using WebKalkulator.Models;

namespace WebKalkulator.Controllers
{
    public class ViewBagController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Username = "Martin Bagheri";
            ViewBag.personVm = CreatePersonVm();
            return View();
        }
       
        private static PersonVm CreatePersonVm()
        {
            return new PersonVm { Id = 1, FirstName = "Rosa", Lastname = "Bagheri" };
        }
    }
}
