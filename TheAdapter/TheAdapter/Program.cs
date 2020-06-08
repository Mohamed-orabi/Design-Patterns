using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Meat unknown = new Meat("Beef");
            unknown.LoadData();

            MeatDetails beef = new MeatDetails("Beef");
            beef.LoadData();

            Console.ReadKey();
        }
    }
}
