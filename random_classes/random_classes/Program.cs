using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int arrayLength = 8;
            var bufferArray = new char[arrayLength];
            for (var i = 0; i < arrayLength; i++)
            {
                //Console.WriteLine(random.Next(1, 10)); //random number
                //Console.Write((char)random.Next(97, 122)); //random string
                //Console.Write((char)('a' + random.Next(0, 26))); //more readable random string
                bufferArray[i] = (char)('a' + random.Next(0, 26)); //more readable random string in an array
            }
            var randomString = new string(bufferArray); //assign array to a string variable
            
            Console.WriteLine(randomString);
            
        }
    }
}
