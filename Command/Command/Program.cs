using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook cook = new Cook();

            Order order = new Order(cook);
            Waiter waiter = new Waiter(order);

            Customer c1 = new Customer(waiter);
            Customer c2 = new Customer(waiter);
            Customer c3 = new Customer(waiter);

            c1.order("Meal,Meal,Meal,Meal");
            Console.WriteLine();

            c2.order("Meal,Meal");
            Console.WriteLine();

            c3.order("Meal");
            Console.WriteLine();

            cook.DisplayOrders();

            Console.ReadKey();

        }
    }
}
