using Microsoft.AspNetCore.Mvc;
using StartBootstrap1.Data;
using StartBootstrap1.Models;
using System.Diagnostics;

namespace StartBootstrap1.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _cotext;
        public HomeController()
        {
            _cotext = new DataContext();
        }
        public IActionResult Index()
        {
            return View(_cotext.Products);
        }

        public IActionResult Detail(int id)
        {
            Product product = _cotext.Products.Find(x => x.Id == id);

            if (product == null)
            {
                TempData["error"] = "Prduct not found by given id";
                return RedirectToAction("error");
            }

            return View(product);
        }

        public IActionResult Error()
        {
            return View();
        }
       
    }
}
