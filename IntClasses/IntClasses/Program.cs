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
            var customer = new Customer(true, 123456789, "Jim");
            var customer1 = new Customer(false, 888888888, "Andy");
            var shipping = new Shipping();

            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.ID);
            Console.WriteLine(customer.Prime);

            Console.WriteLine(customer1.Name);
            Console.WriteLine(customer1.ID);
            Console.WriteLine(customer1.Prime);

            Console.WriteLine(shipping.FreeShipping(customer1.Prime));

        }
    }
}
