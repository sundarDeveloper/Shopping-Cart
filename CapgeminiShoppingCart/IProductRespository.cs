using System.Collections.Generic;

namespace CapgeminiShoppingCart
{
    public interface IProductRespository
    {
        List<KeyValuePair<string, decimal>> GetProducts();
        decimal GetProductPrice(string name);
    }
}