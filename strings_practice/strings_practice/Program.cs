using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace strings_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var firstName = "Ross";
            var lastName = "Scarborough";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] {"John", "Jack", "Mary"};
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);
            Console.WriteLine(names[0] + " likes " + names[2]);
            Console.WriteLine(myFullName);

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
            var text2 = @"Hi " + names[2] + @"
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text2);
        }
    }
}
