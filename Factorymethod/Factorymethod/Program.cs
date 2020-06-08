using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorymethod
{
    public interface IPartShop { }

    class Roof : IPartShop { }
    class Floor : IPartShop { }
    class Wall : IPartShop { }

    public abstract class PartShopFactory
    {
        public abstract IPartShop BuildPartShop();
    }

    public class RoofFactory : PartShopFactory
    {
        public override IPartShop BuildPartShop()
        {
            return new Roof();
        }
    }

    public class FloorFactory : PartShopFactory
    {
        public override IPartShop BuildPartShop()
        {
            return new Floor();
        }
    }

    public class WallFactory : PartShopFactory
    {
        public override IPartShop BuildPartShop()
        {
            return new Wall();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            PartShopFactory pathShopFactory = new RoofFactory();
            IPartShop roof = pathShopFactory.BuildPartShop();
        }
    }
}
