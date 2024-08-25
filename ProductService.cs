using System.Collections.Generic;
using System.Linq;

namespace Enterprise_Programming_in_C_Project.Services
{
    public class ProductService
    {
        private List<Product> _products;

        // Constructor to initialize the product list
        public ProductService()
        {
            InitializeProducts();
        }

        // Method to initialize product data
        private void InitializeProducts()
        {
            _products = new List<Product>
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
        }

        // Returns the full list of products
        public List<Product> GetProducts()
        {
            return _products;
        }

        // Returns a product by its ID
        public Product GetProductById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            // error handeling
            if (product == null)
            {
                 throw new ArgumentException("Product not found");
            }
            return product;
        }

        // Adds a new product to the list - Preps for future
        public void AddProduct(Product product)
        {
            if (product != null && !_products.Any(p => p.Id == product.Id))
            {
                _products.Add(product);
            }
        }

        // Updates an existing product - Preps for future
        public void UpdateProduct(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.ImageUrl = product.ImageUrl;
            }
        }

        // Deletes a product by its ID - Prep for future with db
        public void DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}

