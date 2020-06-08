using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class VendingDepositeState : VendingMachineState
    {
        public override void ChangeVendingState(VendingMachine context)
        {
            context.setState(new VendingStockState());
        }

        public override void GetProduct(int amount, VendingMachine context)
        {
            Console.WriteLine("Thrown into the machine: " + amount);

            if (amount == 5)
            {
                Console.WriteLine("Payment accepted");
                ChangeVendingState(context);
            }
            else if (amount >= 5)
            {
                int sum = amount - 5;
                Console.WriteLine("Payment accepted, pay the rest of money: " + sum);
                ChangeVendingState(context);
            }
            else
            {
                Console.WriteLine("Not enough money\n");
            }
        }
    }
}
