using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            int cellnumber = 0;
            SingleCellOrganism s = new SingleCellOrganism(++cellnumber);

            Cell cell1 = s.Split(++cellnumber);
            Cell cell2 = s.Split(++cellnumber);
            Cell cell3 = s.Split(++cellnumber);
            Console.ReadKey();
        }
    }
}
