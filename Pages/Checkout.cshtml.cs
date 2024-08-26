using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Enterprise_Programming_in_C_Project;
using Enterprise_Programming_in_C_Project.Services;
using System.Collections.Generic;
using System.Linq;

namespace Enterprise_Programming_in_C_Project.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly CartService _cartService;

        public CheckoutModel(CartService cartService)
        {
            _cartService = cartService;
        }

        public List<CartItem> CartItems => _cartService.GetCartItems();
        public decimal TotalAmount => CartItems.Sum(item => item.Product.Price * item.Quantity);
        public int CartItemCount => _cartService.GetCartItemCount();

        // Properties to bind form data
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public string City { get; set; }
        [BindProperty]
        public string PostalCode { get; set; }

        public void OnGet()
        {
            // Ensure the cart is not empty
            if (!CartItems.Any())
            {
                Response.Redirect("/Cart");
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Process the order (save to database, send confirmation email, etc.)
            // For now, we will just clear the cart
            _cartService.GetCartItems().Clear();

            // Redirect to a confirmation page or another appropriate page
            return RedirectToPage("/OrderConfirmation"); // Make sure you have this page or adjust as needed
        }
    }
}
