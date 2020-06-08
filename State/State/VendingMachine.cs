using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class VendingMachine
    {
        private VendingMachineState current;
        private int CostOfproduct;

        public void setState(VendingMachineState state)
        {
            current = state;
        }

        public void BuyProduct(int amount)
        {
            CostOfproduct = amount;
            current.GetProduct(amount,this);
        }

        public void TakeProduct()
        {
            current.GetProduct(CostOfproduct,this);
        }
    }
}
