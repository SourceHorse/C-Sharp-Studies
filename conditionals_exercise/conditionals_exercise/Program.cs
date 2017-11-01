using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals_exercise
{
    public class Conditionals
    {
        
        static void Main(string[] args)
        {
            /*Exercise 1: Ask the user to enter a number. The number should be between 1 to 10.If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid".*/
            Console.WriteLine("--EXERCISE 1: Between 1 and 10--");
            Console.WriteLine("Please enter a number between 1 and 10");
            var input = Console.ReadLine();
            var inputNumber = Convert.ToInt32(input);
            if (inputNumber >= 1f && inputNumber <= 10f)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            /*Exercise 2: A program which takes two numbers from the console and displays the maximum of the two.*/
            Console.WriteLine("\n--EXERCISE 2: Max number --");
            Console.WriteLine("Please enter a number");
            var numberA = Console.ReadLine();
            Console.WriteLine("Number A: " + numberA);
            Console.WriteLine("please enter another number");
            var numberB = Console.ReadLine();
            Console.WriteLine("Number A: " + numberA + ", Number B: " + numberB);
            var numberAInt = Convert.ToInt32(numberA);
            var numberBInt = Convert.ToInt32(numberB);
            if (numberAInt > numberBInt)
            {
                Console.WriteLine("Number A: " + numberA + " is higher than Number B: " + numberB + ".");
            }
            else if (numberBInt > numberAInt)
            {
                Console.WriteLine("Number B: " + numberB + " is higher than Number A: " + numberA + ".");
            }
            else if (numberAInt == numberBInt)
            {
                Console.WriteLine("Number A: " + numberA + " and Number B: " + numberB + " are the same.");
            }
            else
            {
                Console.WriteLine("Something went terribly wrong.");
            }
            /*Exercise 3: Ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.*/
            Console.WriteLine("\n--EXERCISE 3: Portrait or Landscape");
            Console.WriteLine("Please enter the height of the image");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the width of the image");
            var width = Convert.ToInt32(Console.ReadLine());
            var imageOrientation = height >= width ? "portrait" : "landscape";
            Console.WriteLine("with a height of " + height + " and a width of " + width + ", the image is a " + imageOrientation + ".");

            /*Exercise 4: write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.*/
            Console.WriteLine("\n--EXERCISE 4: Speed Camera");
            Console.WriteLine("Please enter the speed limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you.\nThe speed limit for this zone is " + speedLimit + " miles per hour.\n\nPlease enter the speed of your car.");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Thank you for driving the speed limit.");
            }
            else
            {
                int licencePointCounter = 5;
                var speedDelta = carSpeed - speedLimit;
                var pointsOnLicence = speedDelta / licencePointCounter;
                var isRevoked = pointsOnLicence >= 12
                    ? "Your license has been suspended."
                    : "Please drive more carefully.";
                Console.WriteLine("You were caught speeding by a speed camera.\nYou have " + pointsOnLicence + " points on your license. " + isRevoked);
            }
        }
    }
}
