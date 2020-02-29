using System;
using System.Collections.Generic;
using System.Text;
using Shared;

namespace Builder
{
    public abstract class VehicleDirector
    {
        public abstract IVehicle Build(VehicleBuilder builder);
    }
}
