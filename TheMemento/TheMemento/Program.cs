using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMemento
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodSupplier s = new FoodSupplier();
            s.Name = "Mohamed Orabi";
            s.Phone = "01023845610";
            s.Address = "Faqous";

            SupplierMemory m = new SupplierMemory();
            m.Memento = s.SaveMomento();

            s.Address = "Faqous,Egypt";

            s.RestoreMemento(m.Memento);
       

            Console.ReadKey();
        }
    }
}
