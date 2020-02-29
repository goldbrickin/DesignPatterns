using System;
using System.Collections.Generic;
using System.Text;
using Shared;

namespace Builder
{
    class VanDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildBody();
            builder.BuildChassis();
            builder.BuildReinforcedStorageArea();
            builder.BuildWindows();

            return builder.Vehicle;
        }
    }
}
