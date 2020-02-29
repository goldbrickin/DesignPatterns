using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class CarFactory : VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            if (style == DrivingStyle.Economical)
                return new Sedan(new StandardEngine(1300));
            else if (style == DrivingStyle.Midrange)
                return new Coupe(new StandardEngine(2200));
            else
                return new Sport(new TurboEngine(2500));
        }
    }
}
