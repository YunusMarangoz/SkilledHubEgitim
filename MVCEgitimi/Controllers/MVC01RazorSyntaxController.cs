using Microsoft.AspNetCore.Mvc;

namespace MVCEgitimi.Controllers
{
    public class MVC01RazorSyntaxController : Controller
    {
        public IActionResult Index()//varsayalın indextir
        {
            return View();
        }
    }
}
