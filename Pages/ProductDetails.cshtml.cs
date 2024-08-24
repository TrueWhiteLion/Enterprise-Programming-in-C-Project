using Microsoft.AspNetCore.Mvc.RazorPages;
using Enterprise_Programming_in_C_Project.Services;

namespace Enterprise_Programming_in_C_Project.Pages
{
    public class ProductDetailsModel : PageModel
    {
        private readonly ProductService _productService;

        public ProductDetailsModel(ProductService productService)
        {
            _productService = productService;
        }

        public Product Product { get; set; }

        public void OnGet(int id)
        {
            Product = _productService.GetProductById(id);
        }
    }
}

