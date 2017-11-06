using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Reverse
    {
        public void reversify(string target)
        {
            var output = "";
            for (var i = target.Length - 1; i >= 0; i--)
            {
                output += target[i];
            }
            Console.WriteLine(output);
        }
    }
}
