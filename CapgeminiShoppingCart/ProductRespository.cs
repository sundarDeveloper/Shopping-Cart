using System.Collections.Generic;
using System.Linq;

namespace CapgeminiShoppingCart
{
    class ProductRepository : IProductRepository
    {

        List<KeyValuePair<string, decimal>> products = new List<KeyValuePair<string, decimal>>
            {
                new KeyValuePair<string, decimal>("apple", 0.60m),
                new KeyValuePair<string, decimal>("orange", 0.25m )
            };

        /// <summary>
        /// get all available products
        /// </summary>
        /// <returns></returns>
        public List<KeyValuePair<string, decimal>> GetProducts()
        {
            return products;
        }

        /// <summary>
        /// get the product price for given product name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public  decimal GetProductPrice(string name)
        {
           return products.FirstOrDefault(x => x.Key == name).Value;
        }
    }
}