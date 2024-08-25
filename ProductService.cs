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
                ImageUrl = "https://images.pexels.com/photos/90946/pexels-photo-90946.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
            },
            new Product
            {
                Id = 2,
                Name = "Some more stuff that needs to go",
                Description = "Backend to frontend stuff because funny and yes",
                Price = 450.00m,
                ImageUrl = "https://media4.giphy.com/media/v1.Y2lkPTc5MGI3NjExbXh1ZmNvcWQ3dnVhdjMwb25zdXZqdmZ5ZGtwMDA1bWxoNXA3cG53MCZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9Zw/2A75RyXVzzSI2bx4Gj/giphy.webp"
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
