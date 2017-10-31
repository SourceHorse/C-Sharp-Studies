using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionals_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isStarbucksMember = false;
            float refillPrice;
            float ncSalesTax = 1.0675f;
            if (isStarbucksMember)
            {
                refillPrice = 0.00f;
            }
            else
            {
                refillPrice = 0.50f;
            }
            //var reRefillPrice = (isStarbucksMember) ? 0.00f : 0.50f;
            float total = (float)System.Math.Round((refillPrice * ncSalesTax), 2, MidpointRounding.ToEven);
            Console.WriteLine("Your total for a refill is " + total);

        }
    }
}
