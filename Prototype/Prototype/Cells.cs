using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
   public abstract class Cell
    {
        public abstract Cell Split(int cellnumber);
    }

    class SingleCellOrganism : Cell
    {
        int _cellnumber;

        public SingleCellOrganism(int cellnumber)
        {
            _cellnumber = cellnumber;
            Count();
        }
        public override Cell Split(int cellnumber)
        {
            return new SingleCellOrganism(cellnumber);
        }

        public void Count()
        {
            Console.WriteLine("Cell number: " + _cellnumber);
        }
    }
}
