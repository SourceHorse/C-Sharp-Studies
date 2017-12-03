using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Copy();
            text.Width = 720;
            text.Height = 480;
            text.AddHyperlink("www.rossscarborough.com");
            Console.WriteLine(text.Width + " x " + text.Height);
        }
    }
}
