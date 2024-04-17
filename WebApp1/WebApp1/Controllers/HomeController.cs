using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;
using WebApp1.ViewModels;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        private List<Product> _products = new List<Product>();
        private List<Brand> _brands = new List<Brand>();
        public HomeController()
        {
            _products = new List<Product>
             {
                 new Product
            {
                Id = 1,
                Name = "Pr 1",
                Price = 250
            },
                 new Product
            {
                Id = 2,
                Name = "Pr 2",
                Price = 450
            },
                 new Product
            {
                Id = 3,
                Name = "Pr 3",
                Price = 550
            }
        };
            _brands = new List<Brand>
            {
                new Brand
                {
                    Id=1,
                    Name = "Brand 1"
                },
                 new Brand
                {
                    Id=2,
                    Name = "Brand 2"
                },
            };
        }
        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                Products = _products,
                Brands = _brands
            };
            return View(vm);
        }
    }
}
