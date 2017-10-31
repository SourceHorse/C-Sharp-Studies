using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals_exercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Exercise 1: Ask the user to enter a number. The number should be between 1 to 10.If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid".*/
            var inputNumber = 10f;
            if (inputNumber >= 1f && inputNumber <= 10f)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            /*Exercise 2: A program which takes two numbers from the console and displays the maximum of the two.*/


        }
    }
}
