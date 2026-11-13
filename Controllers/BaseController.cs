using Microsoft.AspNetCore.Mvc;

namespace WebKalkulator.Controllers
{
    public class BaseController : Controller
    {
        protected void SetSession(string sessionName,string sessionValue)
        {
            HttpContext.Session.SetString(sessionName, sessionValue);
        }
        protected string GetSession(string sessionName)
        {
            return HttpContext.Session.GetString(sessionName);
        }
    }
}
