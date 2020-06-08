using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Shop
    {
        private static Shop Instance = new Shop(23);
        public int Numberproducts { get; set; }
        public int NumberClients { get; set; }

        public static Shop GetInstance()
        {
            return Instance;
        }
        private Shop(int numberproducts)
        {
            Numberproducts = numberproducts;
        }

        public void NewClient()
        {
            NumberClients += 1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Shop instance = Shop.GetInstance();
            Console.WriteLine(instance.Numberproducts);

            Console.ReadKey();
        }
    }
}
