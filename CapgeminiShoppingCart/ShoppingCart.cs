using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapgeminiShoppingCart
{
    public class ShoppingCart : IShoppingCart
    {
        /// <summary>
        /// shop cart item list
        /// </summary>
        private readonly List<string> shoppingCart;

        /// <summary>
        /// Shopping cart contructor.
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <param name="productRespository"></param>
        public ShoppingCart(List<string> shoppingCart, IProductRepository productRespository)
        {
            this.shoppingCart = shoppingCart;
            ProductRespository = productRespository;
        }

        /// <summary>
        /// repository object injected by contructor
        /// </summary>
        public IProductRepository ProductRespository { get; }

        /// <summary>
        /// method to checkout the cart and calculate total.
        /// </summary>
        /// <returns></returns>
        public decimal CheckOut()
        {
            var cartitems = shoppingCart.Distinct().ToList();
            if (cartitems.Count() < 1) return 0;
            decimal cartTotal = 0;
            foreach (var cartItem in cartitems)
            {
                cartTotal += shoppingCart.Where(x => x.Equals(cartItem)).Count() * ProductRespository.GetProductPrice(cartItem);
            }
            return cartTotal;
        }
    }
}
