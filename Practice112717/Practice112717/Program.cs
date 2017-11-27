using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice112717
{
    class Program
    {
        public static void Main(string[] args)
        {
            var classy = new Classy();
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int swaps = 0;
            /*
            for (var i = 0; i < a.Length; i++) {
                for (var j = i + 1; j < a.Length; j++) {
                    int first = a[i];
                    int second = a[j];
                    if (first > second) {
                        a[i] = second;
                        a[j] = first;
                        swaps++;
                    }
                }
            }
            */
            bool isSorted = false;
            while (isSorted != true)
            {
                isSorted = true;
                for (var i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        classy.Swap(ref a[i], ref a[i + 1]);
                        isSorted = false;
                        swaps++;
                    }
                }
            }

            foreach (var number in a)
            {
                Console.Write(number);
            }
            Console.WriteLine();
            Console.WriteLine("Array is sorted in " + swaps + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[n - 1]);

        }
    }
}
