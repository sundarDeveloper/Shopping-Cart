using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapgeminiShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppinglist = new List<string>() { "apple", "apple", "orange", "apple" };
            ProductRepository productRespository = new ProductRepository();
            ShoppingCartFactory of = new ShoppingCartFactory();

            var shoppingCart = of.GetShoppingCart(shoppinglist, productRespository);

            Console.WriteLine(shoppingCart.CheckOut());
            Console.ReadKey();
        }
    }
}
