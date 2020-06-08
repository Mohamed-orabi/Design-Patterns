using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAbstractFactory
{
    abstract class Sandwish { }

    abstract class Dessert { }

    abstract class RecipeFactory
    {
        public abstract Sandwish CreateSanswish();
        public abstract Dessert CreateDessert();
    }

    class BLT : Sandwish { }
    
    class CremeBrulee : Dessert { }

    class AdultCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }

        public override Sandwish CreateSanswish()
        {
            return new BLT();
        }
    }

    class GrilledCheese : Sandwish { }

    class IceCreamSundae : Dessert { }

    class KidCuisineFactory : RecipeFactory
    {
        public override Sandwish CreateSanswish()
        {
            return new GrilledCheese();
        }

        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who are you? (A)dult or (C)hild?");
            char input = Console.ReadKey().KeyChar;
            RecipeFactory factory;

            switch (input)
            {
                case 'A':
                    factory = new AdultCuisineFactory();
                    break;

                case 'C':
                    factory = new KidCuisineFactory();
                    break;
                default:
                    throw new NotImplementedException();
            }

            var sandwish = factory.CreateSanswish();
            var dessert = factory.CreateSanswish();

            Console.WriteLine("\nSandwish: " + sandwish.GetType().Name);
            Console.WriteLine("Dessert: " + dessert.GetType().Name);

            Console.ReadKey();

        }
    }
}
