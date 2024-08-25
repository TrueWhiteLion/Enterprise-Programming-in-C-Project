using System.Collections.Generic;
using System.Linq;

namespace Enterprise_Programming_in_C_Project.Services
{
    public class CartService
    {
        private readonly List<CartItem> _cartItems = new List<CartItem>();

        public int GetCartItemCount()
        {
            return _cartItems.Sum(c => c.Quantity); // Total quantity of items in the cart
        }

        public void AddToCart(Product product, int quantity)
        {
            var existingItem = _cartItems.FirstOrDefault(c => c.Product.Id == product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _cartItems.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }

        public void RemoveFromCart(int productId)
        {
            var itemToRemove = _cartItems.FirstOrDefault(c => c.Product.Id == productId);
            if (itemToRemove != null)
            {
                _cartItems.Remove(itemToRemove);
            }
        }

        public void UpdateCart(int productId, int newQuantity)
        {
            var item = _cartItems.FirstOrDefault(c => c.Product.Id == productId);
            if (item != null)
            {
                if (newQuantity <= 0)
                {
                    _cartItems.Remove(item);
                }
                else
                {
                    item.Quantity = newQuantity;
                }
            }
        }

        public List<CartItem> GetCartItems()
        {
            return _cartItems;
        }
    }
}


