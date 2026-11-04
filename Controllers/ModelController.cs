using Microsoft.AspNetCore.Mvc;
using WebKalkulator.Models;

namespace WebKalkulator.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Index()
        {
            return View( new PersonVm());
        }
        public IActionResult ShowModel(PersonVm personVm)
        {
            personVm.Id = 1150;
            personVm.FirstName = "Lorak";
            personVm.Lastname = "Ben";

            var studentVm =new StudentVm();
            studentVm.IdPerson = 14785;
            studentVm.IdStudent = 124785;
            studentVm.Fach = "Wirtschaftinformatik";
            return View(studentVm);
        }
    }
}
