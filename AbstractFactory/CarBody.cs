using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CarBody : IBody
    {
        public virtual string BodyParts
        {
            get
            {
                return "Body shell parts for a car.";
            }
        }
    }
}
