using System;
using Shared;

namespace Builder
{
    public class CarBuilder : VehicleBuilder
    {
        private AbstractCar carInProgress;

        public CarBuilder(AbstractCar car)
        {
            carInProgress = car;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building car body.");
        }

        public override void BuildTrunk()
        {
            Console.WriteLine("Building car trunk.");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("Building car chassis.");
        }

        public override void BuildPassengerArea()
        {
            Console.WriteLine("Building car passenger area.");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("Building car windows.");
        }

        public override IVehicle Vehicle
        {
            get
            {
                return carInProgress;
            }
        }
    }
}
