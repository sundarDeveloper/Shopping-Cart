using System;
using System.Collections.Generic;
using System.Linq;

namespace CapgeminiShoppingCart
{
    public class ShoppingCartOffer : IShoppingCart
    {


        /// <summary>
        /// shop cart item list
        /// </summary>
        private readonly List<string> shoppingCart;

        /// <summary>
        /// Shopping cart contructor.
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <param name="productRepository"></param>
        public ShoppingCartOffer(List<string> shoppingCart, IProductRepository productRepository)
        {
            this.shoppingCart = shoppingCart;
            ProductRepository = productRepository;
        }

        /// <summary>
        /// repository object injected by contructor
        /// </summary>
        public IProductRepository ProductRepository { get; }
        public decimal CheckOut()
        {
            var cartitems = shoppingCart.Distinct().ToList();
            if (cartitems.Count() < 1) return 0;
            decimal cartTotal =0, partialApplePrice =0 , totalApplePrice=0,
                partialOrangePrice = 0, totalOrangePrice = 0; ;
            var apple = "apple";
            var orange = "orange";
            var appleCount = 0;
            var orangeCount = 0;

            appleCount += shoppingCart.Where(x => x.Equals("apple")).Count();
            if (appleCount % 2 > 0)
            {
                partialApplePrice += appleCount % 2 * ProductRepository.GetProductPrice(apple);
            }

            totalApplePrice = partialApplePrice + Math.Floor((decimal)appleCount / 2) * ProductRepository.GetProductPrice(apple);

            orangeCount += shoppingCart.Where(x => x.Equals(orange)).Count();
            if (orangeCount % 3 > 0)
            {
                partialOrangePrice += orangeCount % 3 * ProductRepository.GetProductPrice(orange);
            }

            totalOrangePrice = partialOrangePrice + Math.Floor((decimal)orangeCount / 3) * ProductRepository.GetProductPrice(orange);

            return cartTotal = totalApplePrice + totalOrangePrice;
        }
    }
}
