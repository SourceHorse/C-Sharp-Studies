using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers");
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\nCharacters in name: John Smith");
            var name = "John Smith";
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("\nCharacters in name: John Smith (using foreach)");
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            Console.WriteLine("\nFinding total with foreach");
            var numbers = new int[] {1, 2, 3, 4, 5, 6, 7};
            var total = 0;
            foreach (var number in numbers)
            {
                Console.WriteLine(total + " + " + number + " = " + (total + number));
                total = total + number;
            }

            Console.WriteLine("\nOdd numbers with while loop.");

            var j = 0;
            while (j <= 10)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            Console.WriteLine("\n");
            while (true)
            {
                Console.Write("Type your name.");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue; //return to top of loop
                }

                break; //end loop
            }

        }
    }
}
