using System.Collections.Generic;
using System.Linq;

namespace Enterprise_Programming_in_C_Project.Services
{
    public class ProductService
    {
        //My current product list. Still hard coded for the time being
        private readonly List<Product> _products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Yeet Yeet Yite Test",
                Description = "This has some stuff in that I want to see how it looks.",
                Price = 200.00m,
                ImageUrl = "/images/product1.jpg"
            },
            new Product
            {
                Id = 2,
                Name = "Some more stuff that needs to go",
                Description = "Backend to frontend stuff because funny and yes",
                Price = 450.00m,
                ImageUrl = "/images/product2.jpg"
            }
        };

        public List<Product> GetProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
