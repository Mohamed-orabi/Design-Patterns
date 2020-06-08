using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStrategy
{
    abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }

    class Grilling : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by grilling it.");
        }
    }

    class OvenBaking : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by oven baking it.");
        }
    }

    class DeepFrying : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by deep frying it");
        }
    }

    class CookMethod
    {
        private string food;
        private CookStrategy _cookStrategy;

        public void SetCooKStrategy(CookStrategy cookStrategy)
        {
            this._cookStrategy = cookStrategy;
        }

        public void SetFood(string name)
        {
            food = name;
        }

        public void Cook()
        {
            _cookStrategy.Cook(food);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CookMethod cookmethod = new CookMethod();
            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();
            cookmethod.SetFood(food);

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (input)
            {
                case 1:
                    cookmethod.SetCooKStrategy(new Grilling());
                    cookmethod.Cook();
                    break;

                case 2:
                    cookmethod.SetCooKStrategy(new OvenBaking());
                    cookmethod.Cook();
                    break;

                case 3:
                    cookmethod.SetCooKStrategy(new DeepFrying());
                    cookmethod.Cook();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
