using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntClasses
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void UseConstructor()
        {
            var customer = new Customer("Jim", 123456789);
            customer.Prime = true;
        }

        static void UseOut()
        {
            //var number = int.Parse("abc");
            int otherNumber;
            var trynumber = int.TryParse("abc", out otherNumber);
            if (trynumber)
            {
                Console.WriteLine(otherNumber);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));

        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            }
            catch (Exception)
            {
                Console.WriteLine("An unexpexted error occured.");
                throw;
            }
        }
    }
}
