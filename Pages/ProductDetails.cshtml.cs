using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Enterprise_Programming_in_C_Project.Pages
{
    public class ProductDetailsModel : PageModel
    {
        public Product Product { get; set; }

        public void OnGet(int id)
        {
            // Fetch the product by its Id
            // Replace this with a database lookup in the future
            var products = new List<Product>
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

            // Find the product by Id
            Product = products.FirstOrDefault(p => p.Id == id);
        }
    }
}

