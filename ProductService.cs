using System;
using System.Collections.Generic;
using System.Linq;
using Enterprise_Programming_in_C_Project.Models; // Adjust according to your namespace

namespace Enterprise_Programming_in_C_Project.Services
{
    public class ProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            // Initialize with some products or load from a data source
            _products = new List<Product>();
        }

        public Product GetProduct(int id)
        {
            var product = _products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new ArgumentException("Product not found", nameof(id));
            }
            return product;
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null");
            }

            _products.Add(product);
        }

        public void RemoveProduct(int id)
        {
            var product = _products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new ArgumentException("Product not found", nameof(id));
            }

            _products.Remove(product);
        }
    }
}

