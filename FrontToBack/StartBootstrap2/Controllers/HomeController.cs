using Microsoft.AspNetCore.Mvc;

namespace StartBootstrap2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
