using Microsoft.AspNetCore.Mvc.RazorPages;
using Enterprise_Programming_in_C_Project.Services;

namespace Enterprise_Programming_in_C_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProductService _productService;

        public IndexModel(ProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = _productService.GetProducts();
        }
    }
}

