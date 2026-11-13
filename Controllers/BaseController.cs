using Microsoft.AspNetCore.Mvc;
using WebKalkulator.AppConst;

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
        //Cookies Fanction
        protected void SetCookies(string cookiesName, string cookiesValue)
        {
            Response.Cookies.Append(cookiesName, cookiesValue);
        }
        protected string GetCookies(string cookiesName)
        {
            return Request.Cookies[cookiesName];
        }
    }
}
