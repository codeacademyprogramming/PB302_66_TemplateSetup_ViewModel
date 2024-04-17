using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;
using WebApp1.ViewModels;

namespace WebApp1.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> _products = new List<Product>();
        private List<Brand> _brands = new List<Brand>();
        public ProductController()
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

        public ContentResult info()
        {
            return Content("fdf");
        }
        public ActionResult Index()
        {
            if (_products == null || _products.Count == 0)
            {
                TempData["ErrorMessage"] = "Products not found";
                return RedirectToAction("error");
            }

            return View(_products);
        }

        public ActionResult Detail(int id)
        {
            var product = _products.Find(x => x.Id == id);
            if (product == null)
            {
                TempData["ErrorMessage"] = "Product not found by given id";
                return RedirectToAction("error");
            }

            ProductDetailViewModel vm = new ProductDetailViewModel
            {
                Product = product,
                Brands = _brands
            };

            return View(vm);
        }

        public ViewResult Error()
        {

            return View();
        }
    }
}
