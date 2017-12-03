using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises120317
{
    class StackOverflowPost
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime PostTime { get; private set; }
        public int Votes { get; private set; }


        public StackOverflowPost(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            PostTime = new DateTime();
            Votes = 0;
        }

        public void UpVote()
        {
            this.Votes++;
        }

        public void DownVote()
        {
            this.Votes--;
        }

        public void EditDescription()
        {
            this.Description = Console.ReadLine();
        }
    }
}
