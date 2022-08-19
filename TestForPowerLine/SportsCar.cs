using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForPowerLine
{
    internal class SportsCar : Car
    {
        public SportsCar(TypeCar typeCar, double AFC, double FTC, double speed) : base(typeCar, AFC, FTC, speed)
        {

        }

        public override double GetPathDistanceWithLoad()
        {
            throw new NotImplementedException();
        }
    }
}
