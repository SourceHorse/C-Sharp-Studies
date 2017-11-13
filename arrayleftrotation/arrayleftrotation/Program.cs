using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayleftrotation
{
    class Program
    {
        static void Main(String[] args)
        {


            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            var rotatingList = new List<int>();
            rotatingList.AddRange(a);
            for (var i = 0; i < k; i++)
            {
                var numberToRotate = rotatingList[0];
                rotatingList.Remove(rotatingList[0]);
                rotatingList.Add(numberToRotate);
            }
            foreach (var number in rotatingList)
            {
                Console.Write(number);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
