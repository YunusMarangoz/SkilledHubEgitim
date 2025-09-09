using Microsoft.AspNetCore.Mvc;

namespace MVCEgitimi.Areas.Admin.Controllers
{
    [Area("Admin")]// bu controllerin Admin areası altında çalışacağını belirtiyoruz.
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
