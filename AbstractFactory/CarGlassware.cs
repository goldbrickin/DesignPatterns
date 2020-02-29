using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CarGlassware : IGlassware
    {
        public virtual string GlasswareParts
        {
            get
            {
                return "Glass for a car.";
            }
        }
    }
}
