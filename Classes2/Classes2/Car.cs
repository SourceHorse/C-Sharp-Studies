using System;

namespace Classes2
{
    public class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public int Speed;

        public void GetDetails()
        {
            Console.WriteLine("This car is a " + Year+ " " + Make + " " + Model + ".");
        }

        public void GetSpeed()
        {
            Console.WriteLine("Your current speed is " + Speed + "mph.");
        }

        public void Accelerate(int increment)
        {
            Speed = Speed + increment;
            Console.WriteLine("You accelerated to " + Speed + "mph.");
        }

        public void Decelerate(int increment)
        {
            Speed = Speed - increment;
            Console.WriteLine("You decelerated to " + Speed + "mph.");
        }


    }
}