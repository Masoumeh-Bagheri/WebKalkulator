using Microsoft.AspNetCore.Mvc;
using WebKalkulator.Models;

namespace WebKalkulator.Controllers
{
    public class CalController : Controller
    {
        public IActionResult Index()
        {
            return View(new CalIndexVm());
        }
        public IActionResult Run(CalIndexVm calIndexVm)
        {
            switch (calIndexVm.Operation)
            {
                case '+': 
                    calIndexVm.Result = calIndexVm.Number1 + calIndexVm.Number2;  
                    calIndexVm.Number2 = calIndexVm.Result;
                    calIndexVm.Number1 = 0;
                    break;

                case '-': calIndexVm.Result = calIndexVm.Number1 - calIndexVm.Number2;
                    calIndexVm.Number2 = calIndexVm.Result;
                    calIndexVm.Number1 = 0;
                    break;
                case '*': calIndexVm.Result = calIndexVm.Number1 * calIndexVm.Number2;
                    calIndexVm.Number2 = calIndexVm.Result;
                    calIndexVm.Number1 = 0;
                    break;
                case '/': 
                    if(calIndexVm.Number2!=0)
                    calIndexVm.Result = calIndexVm.Result / calIndexVm.Number2;
                    calIndexVm.Result = calIndexVm.Number1;
                    calIndexVm.Number1 = 0;
                    break;
            }
            
            return View("Index",calIndexVm);
        }
    }
}
