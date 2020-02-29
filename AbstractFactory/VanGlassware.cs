using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class VanGlassware : IGlassware
    {
        public virtual string GlasswareParts
        {
            get
            {
                return "Glassware for a Van.";
            }
        }
    }
}
