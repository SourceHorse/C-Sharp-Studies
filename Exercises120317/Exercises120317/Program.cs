using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises120317
{
    class Program
    {
        static void Main(string[] args)
        {
            //var stopwatch = new Stopwatch();
            //stopwatch.RunStopwatch();

            var post = new StackOverflowPost(Console.ReadLine(), Console.ReadLine());
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();


            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.PostTime);
            Console.WriteLine(post.Votes);

        }
    }
}
