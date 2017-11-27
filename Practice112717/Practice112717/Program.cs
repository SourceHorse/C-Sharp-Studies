using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Practice112717
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var classy = new Classy();
            
            //--------------DateTime----------------
            var dateTime = new DateTime(2017, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.Hour + ":" + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
            Console.WriteLine(now.ToString("h:mm:ss tt"));

            //-----------------TimeSpan------------
            //Creating
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add

            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString

            Console.WriteLine("ToString: " + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));


            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] a_temp = Console.ReadLine().Split(' ');
            //int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            //int swaps = 0;
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
            ////------------------------------BUBBLE SORT-------------------------------
            //bool isSorted = false;
            //while (isSorted != true)
            //{
            //    isSorted = true;
            //    for (var i = 0; i < a.Length - 1; i++)
            //    {
            //        if (a[i] > a[i + 1])
            //        {
            //            classy.Swap(ref a[i], ref a[i + 1]);  //requires Swap method from class
            //            isSorted = false;
            //            swaps++;
            //        }
            //    }
            //}
            ////------------------------------END BUBBLE SORT----------------------------

            //foreach (var number in a)
            //{
            //    Console.Write(number);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Array is sorted in " + swaps + " swaps.");
            //Console.WriteLine("First Element: " + a[0]);
            //Console.WriteLine("Last Element: " + a[n - 1]);

            ////-----------------------------------List exercise 5 unique numbers----------------------------
            //List<int> fiveNumbers = new List<int>();
            //while (fiveNumbers.Count < 5)
            //{
            //    Console.WriteLine("Please enter a number");
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    if (fiveNumbers.IndexOf(input) < 0)
            //    {
            //        fiveNumbers.Add(input);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a unique number");
            //    }
            //    Console.Write("The list is ");
            //    foreach (var number in fiveNumbers)
            //    {
            //        Console.Write(number + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Thank you!");


            //int[] a = fiveNumbers.ToArray();
            //bool isSorted = false;


            //while (isSorted != true)
            //{
            //    isSorted = true;
            //    for (var i = 0; i < a.Length - 1; i++)
            //    {
            //        if (a[i] > a[i + 1])
            //        {
            //            classy.Swap(ref a[i], ref a[i + 1]);
            //            isSorted = false;
            //        }
            //    }
            //}

            //Console.Write("Your sorted array is " );
            //foreach (var number in a)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine();
            ////-----------------------------------List exercise 5 unique numbers END--------------------------
        }
    }
}
