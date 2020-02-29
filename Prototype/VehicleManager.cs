using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class VehicleManager
    {
        private IVehicle sedan, coupe, sport, boxVan, pickup;

        public VehicleManager()
        {
            sedan = new Sedan(new StandardEngine(1300));
            coupe = new Coupe(new StandardEngine(1300));
            sport = new Sport(new StandardEngine(1300));
            boxVan = new BoxVan(new StandardEngine(1300));
            pickup = new Pickup(new StandardEngine(1300));
        }

        public virtual IVehicle CreateSedan()
        {
            return (IVehicle)sedan.Clone();
        }

        public virtual IVehicle CreateCoupe()
        {
            return (IVehicle)coupe.Clone();
        }

        public virtual IVehicle CreateSport()
        {
            return (IVehicle)sport.Clone();
        }

        public virtual IVehicle CreateBoxVan()
        {
            return (IVehicle)boxVan.Clone();
        }
        
        public virtual IVehicle CreatePickup()
        {
            return (IVehicle)pickup.Clone();
        }
    }
}
