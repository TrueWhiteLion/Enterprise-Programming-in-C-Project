using Microsoft.AspNetCore.Mvc.RazorPages;
using Enterprise_Programming_in_C_Project.Services;

namespace Enterprise_Programming_in_C_Project.Pages
{
    public class OrderConfirmationModel : PageModel
    {
        private readonly CartService _cartService;

        public OrderConfirmationModel(CartService cartService)
        {
            _cartService = cartService;
        }

        public int CartItemCount => _cartService.GetCartItemCount();

        public void OnGet()
        {
            // Additional logic for the order confirmation page, if needed
        }
    }
}
