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
            //if, else if, else same as js-----------
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

            //Switch Case-----------------------

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Pumpkin Spice Lattes are back.");
                    break;

                case Season.Winter:
                    Console.WriteLine("Controversial holiday cups are back.");
                    break;

                default:
                    Console.WriteLine("welcome to the MacBook club");
                    break;


            }
        }
    }
}
