using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class BoxVan : AbstractVan
    {
        public BoxVan(IEngine engine) : base(engine)
        {
        }

        public BoxVan(IEngine engine, VehicleColor color) : base(engine, color)
        {
        }
    }
}
