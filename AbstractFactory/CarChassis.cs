using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CarChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get
            {
                return "Chassis for a car.";
            }
        }
    }
}
