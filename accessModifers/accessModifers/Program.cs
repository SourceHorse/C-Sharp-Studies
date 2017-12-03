using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessModifers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1977, 7, 24));
            Console.WriteLine(person.Age);

            //person.SetBirthdate(new DateTime(1984, 7, 23));
            //person.SetName("Cronk McDooferson");

            //Console.WriteLine(person.GetBirthdate());
            //Console.WriteLine(person.GetName());
        }
    }
}
