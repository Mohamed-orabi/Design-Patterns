using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine v = new VendingMachine();

            v.setState(new VendingDepositeState());

            v.BuyProduct(5);
            v.TakeProduct();

            Console.ReadKey();
        }
    }
}
