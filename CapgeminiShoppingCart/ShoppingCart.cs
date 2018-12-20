using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapgeminiShoppingCart
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly List<string> shoppingCart;
        public ShoppingCart(List<string> shoppingCart, IProductRespository productRespository)
        {
            this.shoppingCart = shoppingCart;
            ProductRespository = productRespository;
        }

        public IProductRespository ProductRespository { get; }

        public decimal CheckOut()
        {
            var cartitems = shoppingCart.Distinct().ToList();
            if (cartitems.Count() < 1) return 0;
            decimal cartTotal = 0;
            foreach (var cartItem in cartitems)
            {
                cartTotal += shoppingCart.Where(x => x.Equals(cartItem)).Count() * ProductRespository.GetProductPrice(cartItem);
                //    switch (cartItem)
                //    {
                //        case "apple":
                //            cartTotal += shoppingCart.Where(x => x.Equals(cartItem)).Count() * ProductRespository.GetProductPrice(cartItem);
                //            break;
                //        case "orange":
                //            cartTotal += shoppingCart.Where(x => x.Equals(cartItem)).Count() * ProductRespository.GetProductPrice(cartItem);
                //break;
                //    }
            }
            return cartTotal;
        }
    }
}
