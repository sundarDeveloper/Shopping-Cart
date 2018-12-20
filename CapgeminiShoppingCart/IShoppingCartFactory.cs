using System.Collections.Generic;

namespace CapgeminiShoppingCart
{
    public interface IShoppingCartFactory
    {
        ShoppingCart GetShoppingCart(List<string> shoppingList , IProductRespository productRespository);
    }
}
