using StartBootstrap1.Models;

namespace StartBootstrap1.Data
{
    public class DataContext
    {
        public List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Product 1",
                Price  = 101
            },
             new Product
            {
                Id = 2,
                Name = "Product 2",
                Price  = 401
            },
              new Product
            {
                Id = 3,
                Name = "Product 3",
                Price  = 501
            },
               new Product
            {
                Id = 11,
                Name = "Product 11",
                Price  = 1101
            },
             new Product
            {
                Id = 22,
                Name = "Product 22",
                Price  = 1401
            },
              new Product
            {
                Id = 33,
                Name = "Product 33",
                Price  = 1501
            }
        };
    }
}
