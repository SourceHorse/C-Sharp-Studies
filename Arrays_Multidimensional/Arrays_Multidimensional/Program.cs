using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Multidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] {2, 6, 3, 8, 7, 10};
            Console.Write("Array: ");
            foreach (var number in numbers)
            {
                Console.Write(number);
            }

            //Length
            Console.WriteLine("\nLength: " + numbers.Length);

            //IndexOf
            var index = Array.IndexOf(numbers, 7);
            Console.WriteLine("Index of 7: " + index);

            //Clear();
            Array.Clear(numbers, 0, 2);
            Console.Write("Clear index 0 - 1: ");
            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            //Copy();
            var otherArray = new int[3];
            Array.Copy(numbers, otherArray, 3);
            Console.Write("First 3 elements copied to other array. Other Array: ");
            foreach (var number in otherArray)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            //Sort();
            Array.Sort(numbers);
            Console.Write("Sort original array: ");
            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            //Reverse();
            Array.Reverse(numbers);
            Console.Write("Reversed original array: ");
            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();

            //multidimensional arrays

            //matrix
            var myMatrix = new int[3, 5] //2 dimensions, [3, 5, 4] for 3 dimensions
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15}
            };
            var myMatrixElement = myMatrix[1, 3];
            Console.WriteLine(myMatrixElement);

            //jagged

            var jaggedArray = new int[3][];
            jaggedArray[0] = new int[4] {1, 2, 3, 4};
            jaggedArray[1] = new int[5] {5, 6, 7, 8, 9};
            jaggedArray[2] = new int[3] {10, 11, 12};

            Console.WriteLine(jaggedArray[1][2]);
        }
    }
}
