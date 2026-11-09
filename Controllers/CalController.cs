using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebKalkulator.Models;

namespace WebKalkulator.Controllers
{
    public class CalController : Controller
    {
        private CalIndexVm _calIndexVm;
        public IActionResult Index()
        {
            return View(new CalIndexVm());
        }
        public IActionResult Run(CalIndexVm calIndexVm)
        {
            _calIndexVm = calIndexVm;

            DoCalc();
            return View("Index", _calIndexVm);
        }
        private void DoCalc() {
            _calIndexVm.Result = ResultCalc();
            _calIndexVm.Number2 = _calIndexVm.Result;
            _calIndexVm.Number1 = 0;
        }
        private int ResultCalc()
        {
            int result = 0;
            switch (_calIndexVm.Operation)
            {
                case ECalOperation.Sum: result=_calIndexVm.Number2 + _calIndexVm.Number1; break;
                case ECalOperation.Min: result=_calIndexVm.Number2 - _calIndexVm.Number1; break;
                case ECalOperation.Mul: result=_calIndexVm.Number2 * _calIndexVm.Number1; break;
                case ECalOperation.Div: result=_calIndexVm.Number2 / _calIndexVm.Number1; break;
            }
            return result;
        }

    }
}
