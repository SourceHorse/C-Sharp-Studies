using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises120317
{
    class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        public Stopwatch()
        {
        }

        public void StartTimer()
        {
            _startTime = DateTime.Now;
        }
        public void StopTimer()
        {
            _endTime = DateTime.Now;
        }

        public TimeSpan GetTime()
        {
            return _startTime - _endTime;
        }

        public void RunStopwatch()
        {
            Console.WriteLine("Press s to start timer, x to stop timer, v to view timespan, or Escape to exit.");
            Beginning:
            ConsoleKeyInfo info = Console.ReadKey();
            while (info.Key != ConsoleKey.Escape)
            {
                if (info.KeyChar == 's')
                {
                    this.StartTimer();
                    Console.WriteLine("Timer has started");
                    goto Beginning;
                }
                if (info.KeyChar == 'x')
                {
                    this.StopTimer();
                    Console.WriteLine("Timer has stopped");
                    goto Beginning;
                }
                if (info.KeyChar == 'v')
                {
                    Console.WriteLine(this.GetTime());
                    goto Beginning;
                }
                else
                {
                    goto Beginning;
                }
            }
        }
    }
}
