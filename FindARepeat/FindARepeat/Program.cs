using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindARepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the desired length of the substring");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a string to search");
            string s = Console.ReadLine();
            var lowestRepeatedSubstring = "No repeated substring found";
            var lowIndex = s.Length;
            for (var i = 0; i < s.Length - n; i++)
            {
                var target = s.Substring(i, n);
                var second = s.IndexOf(target, i + 1);
                if (second > 0 && second < lowIndex)
                {
                    lowestRepeatedSubstring = target + " is the first repeated substring";
                    lowIndex = second;
                }
            }
            Console.WriteLine(lowestRepeatedSubstring);
        }
    }
}
