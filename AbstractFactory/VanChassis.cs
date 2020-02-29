using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class VanChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get
            {
                return "Chassis for a van.";
            }
        } 
    }
}
