using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplicationTables multiplicationTables = new MultiplicationTables();
            multiplicationTables.MakeTable(1,20);
            Console.WriteLine();

            Fibonacci fibonacci = new Fibonacci();
            fibonacci.fib(1);
            fibonacci.FibIt();

            Reverse reverse = new Reverse();
            reverse.reversify("Hello");
        }
    }
}
