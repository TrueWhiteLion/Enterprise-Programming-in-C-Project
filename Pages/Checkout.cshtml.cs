using Enterprise_Programming_in_C_Project.Data;
using Enterprise_Programming_in_C_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Threading.Tasks;

namespace Enterprise_Programming_in_C_Project.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly OrderContext _context;
        private readonly CartService _cartService;

        public CheckoutModel(OrderContext context, CartService cartService)
        {
            _context = context;
            _cartService = cartService;
        }

        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public string City { get; set; }
        [BindProperty]
        public string PostalCode { get; set; }

        public decimal TotalAmount { get; set; }

        public IActionResult OnGet()
        {
            var cartItems = _cartService.GetCartItems();
            if (!cartItems.Any())
            {
                // Redirect to the cart if it's empty
                return RedirectToPage("/Cart");
            }

            TotalAmount = cartItems.Sum(item => item.Quantity * item.Product.Price);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var cartItems = _cartService.GetCartItems();
            if (!cartItems.Any())
            {
                return RedirectToPage("/Cart");
            }

            // Create a new Order
            var order = new Order
            {
                Name = Name,
                Address = Address,
                City = City,
                PostalCode = PostalCode,
                TotalAmount = cartItems.Sum(item => item.Quantity * item.Product.Price)
            };

            // Add cart items as order items
            foreach (var cartItem in cartItems)
            {
                order.OrderItems.Add(new OrderItem
                {
                    ProductId = cartItem.Product.ProductId,
                    ProductName = cartItem.Product.Name,
                    Quantity = cartItem.Quantity,
                    UnitPrice = cartItem.Product.Price
                });
            }

            // Save order to the database
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Clear the cart after order is placed
            _cartService.ClearCart();

            // Redirect to an order confirmation page
            return RedirectToPage("/OrderConfirmation");
        }
    }
}
