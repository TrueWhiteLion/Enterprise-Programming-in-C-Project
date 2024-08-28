using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Enterprise_Programming_in_C_Project;
using Enterprise_Programming_in_C_Project.Services;

namespace Enterprise_Programming_in_C_Project.Pages
{
    public class AdminModel : PageModel
    {
        private readonly ProductService _productService;

        public AdminModel(ProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = _productService.GetProducts();
        }

        public IActionResult OnPostAddProduct(string name, string description, decimal price, string imageUrl)
        {
            if (ModelState.IsValid)
            {
                var product = new Product
                {
                    Id = _productService.GetProducts().Count + 1, // Basic ID assignment
                    Name = name,
                    Description = description,
                    Price = price,
                    ImageUrl = imageUrl
                };

                _productService.AddProduct(product);
                return RedirectToPage();
            }
            return Page();
        }

        public IActionResult OnPostDeleteProduct(int productId)
        {
            _productService.DeleteProduct(productId);
            return RedirectToPage();
        }
    }
}
