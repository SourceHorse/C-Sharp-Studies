using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagram_deletions
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();//cdefjkl
            string b = Console.ReadLine();//abcfh
            var aArray = new string[] {a};

            int numberOfDeletions = 0;
            var commonLetters = new List<char>();

            for (var i = 0; i < a.Length; i++)
            {
                for (var j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        b[j] = 0;
                        commonLetters.Add(a[i]);
                        break;
                    }
                }
            }

            foreach (var letter in aArray)
            {
                Console.Write(letter);
            }
        }
    }
}
