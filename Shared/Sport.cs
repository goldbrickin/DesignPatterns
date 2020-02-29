using System;

namespace Shared
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
