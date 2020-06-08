using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlTower tower = new ControlTower();

            Machine helicopter = new Helicopter("Helicopter");
            Machine sailPlane = new SailPlane("SailPlane");
            Machine hunter = new Hunter("Hunter");

            tower.Register(helicopter);
            tower.Register(sailPlane);
            tower.Register(hunter);

            helicopter.SendControlMessage();
            sailPlane.SendControlMessage();
            hunter.SendControlMessage();

            Console.ReadKey();
        }
    }
}
