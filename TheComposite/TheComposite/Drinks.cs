using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheComposite
{
    /// Component abstract class
    public abstract class SoftDrink
    {
        public int _Calories  { get; set; }
        public List<SoftDrink> Flavors { get; set; }

        public SoftDrink(int Calories)
        {
            _Calories = Calories;
            Flavors = new List<SoftDrink>();
        }

        public void DisplayCalories()
        {
            Console.WriteLine(this.GetType().Name + ": " +this._Calories.ToString() + "Calories.");
            foreach (var drink in this.Flavors)
            {
                drink.DisplayCalories();
            }

        }
    }


    /// Leaf classes
    /// 
    public class VanillaCola : SoftDrink
    {
        public VanillaCola(int calories) : base(calories) { }
    }

    public class CherryCola : SoftDrink
    {
        public CherryCola(int calories) : base(calories) { }
    }

    public class StrawberryRootBeer : SoftDrink
    {
        public StrawberryRootBeer(int calories) : base(calories) { }
    }

    public class VanillaRootBeer : SoftDrink
    {
        public VanillaRootBeer(int calories) : base(calories) { }
    }

    public class LemonLime : SoftDrink
    {
        public LemonLime(int calories) : base(calories) { }
    }


    /// Composite class
    /// 
    public class Cola : SoftDrink
    {
        public Cola(int calories) : base(calories) { }
    }

    public class RootBeer : SoftDrink
    {
        public RootBeer(int calories) : base(calories) { }
    }

    public class SodaWater : SoftDrink
    {
        public SodaWater(int calories) : base(calories) { }
    }
}
