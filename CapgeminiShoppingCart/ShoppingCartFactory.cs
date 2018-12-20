using System.Collections.Generic;

namespace CapgeminiShoppingCart
{
    public class ShoppingCartFactory : IShoppingCartFactory
    {
        public IShoppingCart GetShoppingCart(List<string> shoppingList, IProductRepository productRespository)
        {
            // return new ShoppingCart(shoppingList, productRespository);
            return new ShoppingCartOffer(shoppingList, productRespository);
        }
    }
}
