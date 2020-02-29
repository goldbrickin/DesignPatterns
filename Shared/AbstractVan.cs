namespace Shared
{
    public abstract class AbstractVan : AbstractVehicle
    {
        public AbstractVan(IEngine engine) : base(engine)
        {
        }

        public AbstractVan(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}