using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Enterprise_Programming_in_C_Project;
using Enterprise_Programming_in_C_Project.Services;
using System.Collections.Generic;
using System.Linq;

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
        public decimal TotalAmount => CartItems.Sum(item => item.Product.Price * item.Quantity);
        public int CartItemCount => _cartService.GetCartItemCount();

        public IActionResult OnPostRemove(int productId)
        {
            _cartService.RemoveFromCart(productId);
            return RedirectToPage(); // Refresh the page after removing an item
        }
    }
}

