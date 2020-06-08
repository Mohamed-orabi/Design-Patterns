using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Customer
    {
        IOrder placeorder;

        public Customer(IOrder placeorder)
        {
            this.placeorder = placeorder;
        }

        public void order(string order)
        {
            Console.WriteLine("Client ordered " + order);
            placeorder.PlaceOrder(order);
        }
    }
}
