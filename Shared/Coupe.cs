using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class Coupe : AbstractCar
    {
        public Coupe(IEngine engine) : base(engine)
        {
        }

        public Coupe(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}
