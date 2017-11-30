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
            var customer = new Customer("Jim", 123456789);
            customer.Prime = true;

            var customer1 = new Customer("Andy", 888888888);
            var shipping = new Shipping();

            var customer2 = new Customer
            {
                ID = 565656565,
                Name = "Amanda"
            };
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.ID);
            Console.WriteLine(customer.Prime);

            Console.WriteLine(customer1.Name);
            Console.WriteLine(customer1.ID);
            Console.WriteLine(customer1.Prime);

            Console.WriteLine(customer2.Name);
            Console.WriteLine(customer2.ID);
            Console.WriteLine(customer2.Prime);

            Console.WriteLine(shipping.FreeShipping(customer1.Prime));

        }
    }
}
