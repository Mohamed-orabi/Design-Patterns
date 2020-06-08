using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTemplateMethod
{
    abstract class Bread
    {
        public abstract void MixIngredients();
        public abstract void Bake();
        public void Slice()
        {
            Console.WriteLine("Slicing the " + GetType().Name + " bread!");
        }

        //This is The Template Method

        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }
    }

    class TwelveGrain : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Gathering Ingredients for 12-Grain Bread.");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Baking the 12-Grain Bread. (25 minutes)");
        }
    }

    class Sourdough : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for Sourdough Bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Sourdough Bread. (20 minutes)");
        }
    }

    class WholeWheat : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering Ingredients for Whole Wheat Bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Whole Wheat Bread. (15 minutes)");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            WholeWheat w = new WholeWheat();
            w.Make();

            Sourdough sourdough = new Sourdough();
            sourdough.Make();

            Console.ReadKey();
        }
    }
}
