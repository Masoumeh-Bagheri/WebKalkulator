using Microsoft.AspNetCore.Mvc;
using WebKalkulator.Models;

namespace WebKalkulator.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View( new PersonVm());
        }
        
        [HttpPost]
        public IActionResult ShowPerson(PersonVm personVm)
        {
            //to do
            return View(personVm);
        }
    }
}
