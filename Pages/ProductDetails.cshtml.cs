using Enterprise_Programming_in_C_Project.Services;
using Enterprise_Programming_in_C_Project;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
    }

    public IActionResult OnPostAddToCart(int productId, int quantity)
    {
        var product = _productService.GetProductById(productId);
        if (product != null && quantity > 0)
        {
            _cartService.AddToCart(product, quantity);
        }
        return RedirectToPage(); // Refresh the current page
    }
}
