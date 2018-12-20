using System.Collections.Generic;

namespace CapgeminiShoppingCart
{
    public class ShoppingCartFactory : IShoppingCartFactory
    {
        public ShoppingCart GetShoppingCart(List<string> shoppingList, IProductRespository productRespository)
        {
            return new ShoppingCart(shoppingList, productRespository);
        }
    }
}
