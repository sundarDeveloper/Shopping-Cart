using System.Collections.Generic;

namespace CapgeminiShoppingCart
{
    public interface IProductRepository
    {
        List<KeyValuePair<string, decimal>> GetProducts();
        decimal GetProductPrice(string name);
    }
}