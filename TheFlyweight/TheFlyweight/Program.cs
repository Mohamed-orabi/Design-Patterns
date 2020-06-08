using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFlyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your slider order (use characters B, V, Q with no spaces):");
            var order = Console.ReadLine();
            char[] chars = order.ToCharArray();

            SliderFactory factory = new SliderFactory();

            int num = 0;

            foreach (char item in chars)
            {
                num++;
                Slider character = factory.GetSlider(item);
                character.Display(num);
            }

        }
    }
}
