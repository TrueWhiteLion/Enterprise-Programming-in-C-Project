using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Enterprise_Programming_in_C_Project.Services;

namespace Enterprise_Programming_in_C_Project.Pages
{
    public class ProductDetailsModel : PageModel
    {
        private readonly ProductService _productService;
        private readonly CartService _cartService;

        public ProductDetailsModel(ProductService productService, CartService cartService)
        {
            _productService = productService;
            _cartService = cartService;
        }

        public Product Product { get; set; }
        public int CartItemCount => _cartService.GetCartItemCount();

        public void OnGet(int id)
        {
            Product = _productService.GetProductById(id);

            if (Product == null)
            {
                // if the product is not found send the 404 error
                Response.StatusCode = 404;
                return;
            }
        }

        // added some error display
        public IActionResult OnPostAddToCart(int productId, int quantity)
        {
            if (quantity <= 0)
            {
                ModelState.AddModelError(string.Empty, "Quantity must be greater than zero.");
                return Page(); // Stay on the current page and show error
            }

            var product = _productService.GetProductById(productId);
            if (product != null)
            {
                _cartService.AddToCart(product, quantity);
            }
            return RedirectToPage("/Cart"); // Redirect to Cart page after adding
        }
    }
}



