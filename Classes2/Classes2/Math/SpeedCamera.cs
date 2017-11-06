using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2.Math
{
    class SpeedCamera
    {
        public string CarMakeModel;
        public int SpeedLimit;
        public int CarSpeed;

        public void CameraMethod()
        {
            if (CarSpeed <= SpeedLimit)
            {
                Console.WriteLine("The " + CarMakeModel + " is going the speed limit.");
            }
            else
            {
                Console.WriteLine("The " + CarMakeModel + " was pulled over for speeding.");
            }
        }
    }
}
