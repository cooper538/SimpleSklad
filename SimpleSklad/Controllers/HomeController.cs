using Microsoft.AspNetCore.Mvc;
using SimpleSklad.Services;

namespace SimpleSklad.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFlasherExtended _f;

        public HomeController(IFlasherExtended f)
        {
            _f = f;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}