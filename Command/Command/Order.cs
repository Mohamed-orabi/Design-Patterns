using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Order : ICommand
    {
        private ICookAble Icookcble;

        public Order(ICookAble Icookcble)
        {
            this.Icookcble = Icookcble;
        }

        public void Execute(string order)
        {
            Icookcble.CookTheMeal(order);
        }
    }
}
