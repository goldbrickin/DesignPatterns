using System;
using Shared;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class VanBuilder : VehicleBuilder
    {
        private AbstractVan vanInProgress;

        public VanBuilder(AbstractVan van)
        {
            vanInProgress = van;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building van body.");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("Building van chassis.");
        }

        public override void BuildReinforcedStorageArea()
        {
            Console.WriteLine("Building van reinforced storage area.");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("Build van windows.");
        }

        public override IVehicle Vehicle
        {
            get
            {
                return vanInProgress;
            }
        }
    }
}
