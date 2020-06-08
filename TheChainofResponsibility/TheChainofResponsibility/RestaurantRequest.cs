using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheChainofResponsibility
{
    class PurchaseOrder
    {
        public int RequestNumber { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }

        public PurchaseOrder(int requestNumber , string name, double amount, double price)
        {
            RequestNumber = requestNumber;
            Name = name;
            Amount = amount;
            Price = price;

            Console.WriteLine("Purchase request for " + name + " (" + amount + " for $" + price.ToString() + ") has been submitted.");
        }
    }

    abstract class Approver
    {
        protected Approver _supervisor;

        public void SetSupervisor(Approver supervisor)
        {
            this._supervisor = supervisor;
        }

        public abstract void ProcessRequest(PurchaseOrder purchase);
    }


    class HeadChef : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 1000)
            {
                Console.WriteLine("{0} approved purchase request #{1}", this.GetType().Name, purchase.RequestNumber);
            }
            else if(_supervisor != null)
            {
                _supervisor.ProcessRequest(purchase);
            }
        }
    }

    class PurchasingManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 2500)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, purchase.RequestNumber);
            }
            else if (_supervisor != null)
            {
                _supervisor.ProcessRequest(purchase);
            }
        }
    }

    class GeneralManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 10000)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, purchase.RequestNumber);
            }
            else
            {
                Console.WriteLine(
                    "Purchase request #{0} requires an executive meeting!",
                    purchase.RequestNumber);
            }
        }
    }

}
