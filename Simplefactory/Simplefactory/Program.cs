using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplefactory
{

    interface IProducts { }

    class Apple : IProducts { }
    class Orange : IProducts { }

    class ProductsFactory
    {
        public IProducts CreateProduct(string fruit)
        {
            switch (fruit)
            {
                case "orange":
                    return new Orange();
                    break;

                case "apple":
                    return new Apple();
                    break;

                default:
                    throw new ArgumentException();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductsFactory product = new ProductsFactory();

            IProducts orange = product.CreateProduct("orange");
            
         
            Console.ReadKey();
        }
    }
}
