using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Car
    {
        public abstract double CostCar();
        public abstract string TypeEngine();
        public abstract string ColorCar();


    }


    class Fiat : Car
    {
        public override string ColorCar()
        {
            return "White";
        }

        public override double CostCar()
        {
            return 10000.32;
        }

        public override string TypeEngine()
        {
            return "engine-v3";
        }
    }

    class Golf : Car
    {
        public override string ColorCar()
        {
            return "Black";
        }

        public override double CostCar()
        {
            return 23450.32;
        }

        public override string TypeEngine()
        {
            return "engine-v7";
        }
    }

    class Mercedes : Car
    {
        public override string ColorCar()
        {
            return "Green";
        }

        public override double CostCar()
        {
            return 36750.52;
        }

        public override string TypeEngine()
        {
            return "engine-v3e5";
        }
    }

    class MercedesWithRadioAndAC : Car
    {
        public override string ColorCar()
        {
            return "gray";
        }

        public override double CostCar()
        {
            return 45350.65;
        }

        public override string TypeEngine()
        {
            return "engine-v3e5sd";
        }
    }

    class MercedesWithRadio : Car
    {
        public override string ColorCar()
        {
            return "white";
        }

        public override double CostCar()
        {
            return 41350.65;
        }

        public override string TypeEngine()
        {
            return "engine-v3e5s";
        }
    }


    public abstract class CarDecorator : Car
    {
        protected Car _car;

        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override string ColorCar()
        {
            return _car.ColorCar();
        }

        public override double CostCar()
        {
            return _car.CostCar();
        }

        public override string TypeEngine()
        {
            return _car.TypeEngine();
        }
    }


    public class RadioDecorator : CarDecorator
    {
        public RadioDecorator(Car car) : base(car)
        {
        }

        public override string ColorCar()
        {
            return base.ColorCar();
        }

        public override double CostCar()
        {
            return base.CostCar() + 1232.32 ;
        }

        public override string TypeEngine()
        {
            return base.TypeEngine();
        }
    }

    public class ACAndNewestEngineModelDecorator : CarDecorator
    {
        public ACAndNewestEngineModelDecorator(Car car) : base(car)
        {
        }

        public override string ColorCar()
        {
            return base.ColorCar();
        }

        public override double CostCar()
        {
            return base.CostCar() + 12332.32;
        }

        public override string TypeEngine()
        {
            return base.TypeEngine() + "a7c";
        }
    }


}
