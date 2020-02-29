using System;
using System.Collections.Generic;
using System.Text;
using Shared;

namespace Builder
{
    public class CarDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildBody();
            builder.BuildChassis();
            builder.BuildPassengerArea();
            builder.BuildTrunk();
            builder.BuildWindows();

            return builder.Vehicle;
        }
    }
}
