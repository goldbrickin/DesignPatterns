using Shared;
using System;

namespace Prototype
{
    public class Sport : AbstractCar
    {
        public Sport(IEngine engine) : base(engine)
        {
        }

        public Sport(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}
