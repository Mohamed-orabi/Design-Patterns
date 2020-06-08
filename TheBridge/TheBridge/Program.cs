using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch tvButton = new ClickSwitch(new TV());
            tvButton.Off();
            tvButton.On();

            Console.ReadKey();
        }
    }
}
