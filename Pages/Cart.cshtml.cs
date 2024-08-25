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
            // No additional logic needed for GET request, cart items are fetched from the service
        }

        public IActionResult OnPostUpdateQuantity(int productId, int quantity)
        {
            _cartService.UpdateCart(productId, quantity);
            return RedirectToPage(); // Redirect to the same page to refresh the cart
        }

        public IActionResult OnPostRemoveItem(int productId)
        {
            _cartService.RemoveFromCart(productId);
            return RedirectToPage(); // Redirect to the same page to refresh the cart
        }
    }
}

