using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver Mohamed = new HeadChef();
            Approver Ahmed = new PurchasingManager();
            Approver Ramy = new GeneralManager();

            Mohamed.SetSupervisor(Ahmed);
            Ahmed.SetSupervisor(Ramy);

            PurchaseOrder p = new PurchaseOrder(1,"Fishs",30,900);
            Mohamed.ProcessRequest(p);


            p = new PurchaseOrder(2, "Meat", 100,20000);
            Mohamed.ProcessRequest(p);

            Console.ReadKey();
        }
    }
}
