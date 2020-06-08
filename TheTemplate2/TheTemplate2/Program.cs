using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTemplate2
{
    class Program
    {
        static void Main(string[] args)
        {
            HTMLDocGenerator html = new HTMLDocGenerator();
            html.generateDocument();

            XMLDocGenerator xml = new XMLDocGenerator();
            xml.generateDocument();

            Console.ReadKey();
        }
    }
}
