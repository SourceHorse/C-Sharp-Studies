using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Fibonacci
    {
        public long fib(int n)
        {
            return n <= 1 ? n : fib(n - 1) + fib(n - 2);
        }

        public void FibIt()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(", " + fib(i));
            }
            Console.WriteLine("\n" + fib(10));
        }
    }
}
