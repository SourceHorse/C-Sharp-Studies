﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindARepeat
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the desired length of the substring");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a string to search");
            string s = Console.ReadLine();
            
            Console.WriteLine(RepeatSearch(n, s));
        }

        public static string RepeatSearch(int stringLength, string searchString)
        {
            var lowestRepeatedSubstring = "No repeated substring found";
            var lowIndex = searchString.Length;
            for (var i = 0; i < searchString.Length - stringLength; i++)
            {
                var target = searchString.Substring(i, stringLength);
                var second = searchString.IndexOf(target, i + 1);
                if (second > 0 && second < lowIndex)
                {
                    lowestRepeatedSubstring = target + " is the first repeated substring";
                    lowIndex = second;
                }
            }
            return lowestRepeatedSubstring;
        }
    }
}
