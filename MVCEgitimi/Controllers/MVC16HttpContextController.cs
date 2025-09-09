using Microsoft.AspNetCore.Mvc;

namespace MVCEgitimi.Controllers
{
    public class MVC16HttpContextController : Controller
    {
        public IActionResult Index()
        {
            var mesaj = "RouteData controller : " + RouteData.Values["controller"];
            mesaj += "<hr/>Action : " + RouteData.Values["action"];
            mesaj += "<hr/>Id : " + RouteData.Values["id"];
            mesaj += "<hr/>QueryString Kelime : " + HttpContext.Request.Query["kelime"];
            TempData["mesaj"] = mesaj;
            return View();
        }
    }
}