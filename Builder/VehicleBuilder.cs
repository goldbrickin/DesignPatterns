using System;
using Shared;

namespace Builder
{
    public abstract class VehicleBuilder
    {
        public virtual void BuildBody() { }
        public virtual void BuildTrunk() { }
        public virtual void BuildChassis() { }
        public virtual void BuildPassengerArea() { }
        public virtual void BuildReinforcedStorageArea() { }
        public virtual void BuildWindows() { }

        public abstract IVehicle Vehicle { get; }
    }
}
