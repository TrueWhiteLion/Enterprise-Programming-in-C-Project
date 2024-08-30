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
                    Name = "Test Item 1",
                    Description = "This is what an item will look like on the site",
                    Price = 200.00m,
                    ImageUrl = "https://previews.123rf.com/images/fordzolo/fordzolo1506/fordzolo150600296/41026708-example-white-stamp-text-on-red-backgroud.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Handbag",
                    Description = "This is what a handbag would look like on this page",
                    Price = 450.00m,
                    ImageUrl = "https://t4.ftcdn.net/jpg/01/10/04/51/360_F_110045173_QgmA3gg5OwTlLNQBqmPdFnkh6sPvsvt8.jpg"
                },

                  new Product
                {
                    Id = 3,
                    Name = "Example Ball",
                    Description = "This ball is an example of a nother product that can be displayed on the page",
                    Price = 450.00m,
                    ImageUrl = "https://st.depositphotos.com/1016685/1574/i/450/depositphotos_15741123-stock-photo-rugby-ball.jpg"
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

