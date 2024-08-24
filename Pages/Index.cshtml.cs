using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Enterprise_Programming_in_C_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public List<Product> Products { get; set; }

        public void OnGet()
        {
            // For Now I am listing these here for testing and formatting. Will add database Integration once I'm happy with format
            // Hardcoded data to follow:

            Products = new List<Product>
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
                Description = "Backend to frontend stuff beccause funny and yes",
                Price = 450.00m,
                ImageUrl = "/images/product2.jpg"
            },

            


            };
        }
    }
}
