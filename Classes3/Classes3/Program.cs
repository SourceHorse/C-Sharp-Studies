using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    class Program
    {
        static void Main(string[] args)
        {
            var fusion = new Car();
            fusion.Make = "Ford";
            fusion.Model = "Fusion";
            fusion.Year = 2017;
            fusion.MileagePerGallon = 41;
            fusion.Speed = 0;
            Console.WriteLine(fusion.Speed);
            while (Console.ReadLine() != "stop")
            {
                fusion.Accelerate(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(fusion.Speed);
            }
            
            
        }
    }
}
