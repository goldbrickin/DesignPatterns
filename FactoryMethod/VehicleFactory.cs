using System;
using Shared;

namespace FactoryMethod
{
    public abstract class VehicleFactory
    {
        public enum DrivingStyle
        {
            Economical, Midrange, Powerful
        }

        public enum Category
        {
            Car, Van
        }

        public virtual IVehicle Build(DrivingStyle style, VehicleColor color)
        {
            IVehicle vehicle = SelectVehicle(style);
            vehicle.Paint(color);
            return vehicle;
        }

        protected internal abstract IVehicle SelectVehicle(DrivingStyle style);

        public static IVehicle Make(Category cat, DrivingStyle style, VehicleColor color)
        {
            VehicleFactory factory;

            if (cat == Category.Car)
                factory = new CarFactory();
            else
                factory = new VanFactory();

            return factory.Build(style, color);
        }
    }
}
