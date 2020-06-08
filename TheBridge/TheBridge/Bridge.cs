using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBridge
{

    abstract class Switch
    {
        protected IDevice _device;

        public Switch(IDevice device)
        {
            this._device = device;
        }

        public abstract void On();
        public abstract void Off(); 
    }

    class ClickSwitch : Switch
    {
        public ClickSwitch(IDevice device) : base(device)
        {
        }

        public override void Off()
        {
            _device.On();
        }

        public override void On()
        {
            _device.Off();
        }
    }


    interface IDevice
    {
        void On();
        void Off();
    }

    class TV : IDevice
    {
        public void Off()
        {
            Console.WriteLine("the TV was turned off");
        }

        public void On()
        {
            Console.WriteLine("the TV was turned on");
        }
    }

    class Radio : IDevice
    {
        public void Off()
        {
            Console.WriteLine("the radio was turned off");
        }

        public void On()
        {
            Console.WriteLine("the radio was turned on");
        }
    }

    class Lamp : IDevice
    {
        public void Off()
        {
            Console.WriteLine("the lamp was turned off");
        }

        public void On()
        {
            Console.WriteLine("the lamp was turned on");
        }
    }
 }
