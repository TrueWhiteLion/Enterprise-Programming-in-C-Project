using Microsoft.AspNetCore.Mvc.RazorPages;
using Enterprise_Programming_in_C_Project.Services;
using System.Collections.Generic;

namespace Enterprise_Programming_in_C_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProductService _productService;
        private readonly CartService _cartService;

        public IndexModel(ProductService productService, CartService cartService)
        {
            _productService = productService;
            _cartService = cartService;
        }

        public List<Product> Products { get; set; }
        public int CartItemCount => _cartService.GetCartItemCount();

        public void OnGet()
        {
            Products = _productService.GetProducts(); // Use GetProducts method
        }
    }
}

