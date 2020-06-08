using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{

    abstract class TowerMediator
    {
        public abstract void Register(Machine machine);
        public abstract void SendControlMessage(string typeMachine);
    }

    class ControlTower : TowerMediator
    {
        private Dictionary<string , Machine> _machines = new Dictionary<string , Machine>();
        public override void Register(Machine machine)
        {
            if (!_machines.ContainsValue(machine))
            {
                _machines[machine.TypeMachine] = machine;
            }

            machine.Controltower = this;
        }

        public override void SendControlMessage(string typeMachine)
        {
            Machine machine = _machines[typeMachine];
            Console.WriteLine("Control the flight of a {0}", machine.TypeMachine);
        }
    }

    abstract class Machine
    {
        protected string _typeMachime;

        public string TypeMachine
        {
            get
            {
                return _typeMachime;
            }
        }

        public Machine(string typeMachine)
        {
            _typeMachime = typeMachine;
        }


        protected TowerMediator _controltower;

        public TowerMediator Controltower
        {
            set
            {
                _controltower = value;
            }
            get
            {
                return _controltower;
            }
        }

        public abstract void SendControlMessage(); 
    }

    class SailPlane : Machine
    {
        public SailPlane(string typeMachine) : base(typeMachine)
        {
        }

        public override void SendControlMessage()
        {
            Console.WriteLine("SailPlane Configuration");
            _controltower.SendControlMessage(_typeMachime);
        }
    }

    class Hunter : Machine
    {
        public Hunter(string typeMachine) : base(typeMachine)
        {
        }

        public override void SendControlMessage()
        {
            Console.WriteLine("Hunter Configuration");
            _controltower.SendControlMessage(_typeMachime);
        }
    }

    class Helicopter : Machine
    {
        public Helicopter(string typeMachine) : base(typeMachine)
        {
        }

        public override void SendControlMessage()
        {
            Console.WriteLine("Helicopter Configuration");
            _controltower.SendControlMessage(_typeMachime);
        }
    }


}
