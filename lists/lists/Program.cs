using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize
            var numbers = new List<int>() {1, 2, 3, 4};
            //add a number (push)
            numbers.Add(5);
            //add (push) an array or other list
            numbers.AddRange(new int[3] {6, 7, 8});

            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            Console.WriteLine("The index of 1 is " + numbers.IndexOf(1));
            numbers.Add(1);
            Console.Write("Added another 1 to the end of the array.\nThe new array is ");
            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            //LastIndexOf
            Console.WriteLine("The index of the last 1 is " + numbers.LastIndexOf(1));

            //Count
            Console.WriteLine("The number of numbers in the list is " + numbers.Count);

            ////Remove()
            //numbers.Remove(1);                                                           
            //Console.Write("The list after removing 1 is ");
            //foreach (var number in numbers)
            //{
            //    Console.Write(number);
            //}
            //Console.WriteLine();

            Console.Write("Remove the 1's: ");
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            ////Clear
            //numbers.Clear();
            //Console.WriteLine("Cleared the list, now there are " + numbers.Count + " numbers.");


            //random practice with lists
            var random = new Random();
            var randomizedNumbers = numbers.OrderBy(x => random.Next()).ToList();
            Console.Write("The list randomized is ");
            var randomListForlater = new List<int>();
            randomListForlater.AddRange(randomizedNumbers);
            numbers = randomizedNumbers;
            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            numbers.RemoveRange(3, 2);

            Console.Write("Removed 2 of the numbers. Now it's ");
            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            Console.Write("Now add the randomized list again: ");
            numbers.AddRange(randomListForlater);
            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            Console.Write("And randomized one more time: ");
            randomizedNumbers = numbers.OrderBy(x => random.Next()).ToList();
            numbers = randomizedNumbers;
            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            Console.Write("Remove the fifth number: ");
            numbers.RemoveRange(4, 1);
            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            Console.Write("And put them in order: ");
            numbers.Sort();
            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();


        }
    }
}
