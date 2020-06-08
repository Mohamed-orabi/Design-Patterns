using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class VendingStockState : VendingMachineState
    {
        public override void ChangeVendingState(VendingMachine context)
        {
            context.setState(new VendingDepositeState());
        }

        public override void GetProduct(int amount, VendingMachine context)
        {
            Console.WriteLine("Money deliverd, amount: " + amount + " give product which costing: 5\n");
            ChangeVendingState(context);
        }
    }
}
