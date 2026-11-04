using Microsoft.AspNetCore.Mvc;
using WebKalkulator.Models;

namespace WebKalkulator.Controllers
{
    public class ZweiModelController : Controller
    {
        public IActionResult Index()
        {
            var ZweiModelshowVm = CreateZweiModelIndexVm();
            return View(ZweiModelshowVm);
        }
        private ZweiModelIndexVm CreateZweiModelIndexVm()
        {
            return new ZweiModelIndexVm
            {
                StudentVm = CreateStundentVm(),
                PersonVm = CreatePersonVm(),
            };
        }
        private StudentVm CreateStundentVm()
        {
            return new StudentVm
            {
                IdPerson = 254,
                IdStudent = 1,
                Fach = "Wirtschaftinformatik"
            };
         }
        private PersonVm CreatePersonVm()
        {
            return new PersonVm
            {
                Id = 254,
                FirstName = "Lora",
                Lastname = "Stein"
            };
        }
    }
}
