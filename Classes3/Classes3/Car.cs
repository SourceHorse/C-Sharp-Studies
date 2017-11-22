using System;

namespace Classes3
{
    public class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public int MileagePerGallon;
        public int Speed = 0;

        public void Accelerate(int increment)
        {
            Speed = Speed + increment;
        }
    }
}