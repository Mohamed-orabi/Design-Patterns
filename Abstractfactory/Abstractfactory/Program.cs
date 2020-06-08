using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractfactory
{
    public interface IPartShop { }

    class Roof : IPartShop { }
    class Floor : IPartShop { }
    class Wall : IPartShop { }

    public interface IWorker { }

    class WorkersRoof : IWorker { }
    class WorkersFloor : IWorker { }
    class WorkersWall : IWorker { }

    public abstract class SpaceConstructionFactory
    {
        public abstract IPartShop BuildPartShop();
        public abstract IWorker AssignWorkers();
    }

    public class SpaceContructionRoofFactory : SpaceConstructionFactory
    {
        public override IPartShop BuildPartShop()
        {
            return new Roof();
        }
        public override IWorker AssignWorkers()
        {
            return new WorkersRoof();
        }
    }

    public class SpaceContructionFloorFactory : SpaceConstructionFactory
    {
        public override IPartShop BuildPartShop()
        {
            return new Floor();
        }
        public override IWorker AssignWorkers()
        {
            return new WorkersFloor();
        }
    }

    public class SpaceContructionWallFactory : SpaceConstructionFactory
    {
        public override IPartShop BuildPartShop()
        {
            return new Wall();
        }
        public override IWorker AssignWorkers()
        {
            return new WorkersWall();
        }
    }


    class SpaceConstruction
    {
        private SpaceConstructionFactory _spaceconstruction;

        public SpaceConstruction(SpaceConstructionFactory spaceconstruction)
        {
            this._spaceconstruction = spaceconstruction;
        }

        public void MakeSpaceContruction()
        {
            var partshop = this._spaceconstruction.BuildPartShop();
            var workers = this._spaceconstruction.AssignWorkers();
            System.Console.WriteLine("Workers are assigned to build individual parts of the store");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            SpaceConstruction spaceConstruction = new SpaceConstruction(new SpaceContructionRoofFactory());
            spaceConstruction.MakeSpaceContruction();

            Console.ReadKey();
        }
    }
}
