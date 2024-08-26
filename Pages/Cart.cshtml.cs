using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Enterprise_Programming_in_C_Project.Services;

namespace Enterprise_Programming_in_C_Project.Pages
{
    public class CartModel : PageModel
    {
        private readonly CartService _cartService;

        public CartModel(CartService cartService)
        {
            _cartService = cartService;
        }

        public List<CartItem> CartItems => _cartService.GetCartItems();

        public void OnGet()
        {
            // No additional logic needed for GET request
        }

        public IActionResult OnPostUpdateQuantity(int productId, int quantity)
        {
            _cartService.UpdateCart(productId, quantity);
            return RedirectToPage(); // Refresh the cart page
        }

        public IActionResult OnPostRemoveItem(int productId)
        {
            _cartService.RemoveFromCart(productId);
            return RedirectToPage(); // Refresh the cart page
        }
    }
}


