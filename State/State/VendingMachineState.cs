using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    abstract class VendingMachineState
    {
        public abstract void ChangeVendingState(VendingMachine context);
        public abstract void GetProduct(int amount, VendingMachine context);
    }
}
