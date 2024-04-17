using WebApp1.Models;

namespace WebApp1.ViewModels
{
    public class ProductDetailViewModel
    {
        public Product Product { get; set; }
        public List<Brand> Brands { get; set; }
    }
}
