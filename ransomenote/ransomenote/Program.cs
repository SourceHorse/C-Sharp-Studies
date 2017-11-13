using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ransomenote
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');
            var clippings = new List<string>();
            for (var i = 0; i < ransom.Length; i++)
            {
                for (var j = 0; j < magazine.Length; j++)
                {
                    if (ransom[i] == magazine[j])
                    {
                        clippings.Add(magazine[j]);
                        magazine[j] = null;
                        break;
                    }
                }
            }
            if (clippings.Count == ransom.Length)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine(clippings.Count);
                Console.WriteLine(ransom.Length);
                foreach (var word in clippings)
                {
                    Console.Write(word);
                }
                Console.WriteLine();
            }
        }
    }
}
