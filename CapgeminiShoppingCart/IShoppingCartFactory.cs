using System.Collections.Generic;

namespace CapgeminiShoppingCart
{
    public interface IShoppingCartFactory
    {
        IShoppingCart GetShoppingCart(List<string> shoppingList , IProductRepository productRespository);
    }
}
