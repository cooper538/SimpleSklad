using Microsoft.AspNetCore.Mvc;

namespace SimpleSklad.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}