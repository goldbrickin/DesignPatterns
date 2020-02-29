using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class VanFactory : VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            if (style == DrivingStyle.Economical || style == DrivingStyle.Midrange)
                return new Pickup(new StandardEngine(2500));
            else
                return new BoxVan(new TurboEngine(3000));
        }
    }
}
