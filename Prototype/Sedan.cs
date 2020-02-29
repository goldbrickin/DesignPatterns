using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Sedan : AbstractCar
    {
        public Sedan(IEngine engine) : base(engine)
        {
        }

        public Sedan(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}
