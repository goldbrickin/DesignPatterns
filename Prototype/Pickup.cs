using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Pickup : AbstractVan
    {
        public Pickup(IEngine engine) : base(engine)
        {
        }

        public Pickup(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}
