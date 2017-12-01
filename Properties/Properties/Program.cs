using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1977, 3, 23));
            person.Name = "Jordan";
            person.Username = "Jdawg1337";
            Console.WriteLine("{0}, AKA {1}, was born on {2} and is {3} years old.", person.Name, person.Username, person.Birthdate, person.Age);
        }
    }
}
