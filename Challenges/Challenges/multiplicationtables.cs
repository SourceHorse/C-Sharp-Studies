using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    class MultiplicationTables
    {
        public void MakeTable(int start, int end)
        {
            for (var i = start; i <= end; i++)
            {
                for (var j = start; j <= end; j++)
                {
                    Console.Write((i * j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
