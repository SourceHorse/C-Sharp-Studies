using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_flow_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1: A program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            Console.WriteLine("--EXERCISE 1: 1 - 100 divisible by 3--");
            var howMany = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + ", ");
                    howMany++;
                }
            }
            Console.WriteLine("\nThere are " + howMany + " numbers divisible by 3 between 1 and 100");

            //Exercixe 2: Continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
            Console.WriteLine("\n--EXERCISE 2: Mo Numbas--");
            Console.WriteLine("Please type a number to be added");
            var input = Console.ReadLine();
            var sum = 0;
            while (input != "ok")
            {
                sum = sum + Convert.ToInt32(input);
                Console.WriteLine("The total is now " + sum + "\nPlease type another number or \"ok\" to exit.");
                input = Console.ReadLine();
            }
            Console.WriteLine("Exiting Loop");

            //Exercise 3: Ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            Console.WriteLine("\n--EXERCISE 3: Factorializenatorer--");
            Console.WriteLine("Please enter a number.");
            var factorializeThis = Convert.ToInt32(Console.ReadLine());
            var factorializeOutput = 1;
            for (var i = 1; i <= factorializeThis; i++)
            {
                factorializeOutput = factorializeOutput * i;
            }
            Console.WriteLine(factorializeThis + "! = " + factorializeOutput);

            //Exercise 4: A program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost".
            Console.WriteLine("\n--EXERCISE 4: Pick a number--");
            Console.WriteLine("Please pick a number between 1 and 10. (you can skip by typing 0)");
            var guess = Convert.ToInt32(Console.ReadLine());
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            while (guess != randomNumber)
            {
                if (guess == 0)
                {
                    break;
                }
                Console.WriteLine("You guessed " + guess + ". The number was " + randomNumber + ". HAHA, You lose! Try again!");
                randomNumber = random.Next(1, 10);
                guess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Congratulations, human! you got it! The number was " + randomNumber + ".\nWe will spare you in the robotic uprising.");

            //Exercise 5: Ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console.
            Console.WriteLine("\n--EXERCISE 5: The Largest of All");
            Console.WriteLine("Please type a list of numbers separated by commas (ex. \"1,6,8,3,2\").");
            var inputList = Console.ReadLine();
            var numberArray = inputList.Split(',');
            var highestNumber = Convert.ToInt32(numberArray[0]);
            foreach (var str in numberArray)
            {
                var number = Convert.ToInt32(str);
                if (number > highestNumber)
                {
                    highestNumber = number;
                }
            }
            Console.WriteLine("The highest number in your list was " + highestNumber);
        }
    }
}
