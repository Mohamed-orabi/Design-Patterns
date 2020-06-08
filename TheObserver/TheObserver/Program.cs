using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrots carrot = new Carrots(0.84);
            carrot.Attach(new Restaurant("A",0.77));
            carrot.Attach(new Restaurant("B", 0.74));
            carrot.Attach(new Restaurant("C", 0.75));

            carrot.PricePerPound = 0.79;

            Apples apples = new Apples(20.0);
            apples.Attach(new Restaurant("F",18.0));
            apples.Attach(new Restaurant("J", 15.0));
            apples.Attach(new Restaurant("K", 14.0));


            carrot.PricePerPound = 0.79;
            apples.PricePerPound = 13.0;
            apples.PricePerPound = 23.0;

            Console.ReadKey();
        }
    }
}
