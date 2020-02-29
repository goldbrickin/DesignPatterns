namespace Shared
{
    public abstract class AbstractCar : AbstractVehicle
    {
        public AbstractCar(IEngine engine) : base(engine)
        {
        }

        public AbstractCar(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}