using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathA = @"c:\filePracticeAlpha\";
            var pathB = @"c:\filePracticeBeta\";
          
            if (File.Exists(pathA + "textFile.txt"))
            {
                Console.WriteLine("Starting file copy " + DateTime.Now.Millisecond);
                Directory.CreateDirectory(@"c:\filePracticeGamma");
                File.Copy(@"c:\filePracticeAlpha\textFile.txt", @"c:\filePracticeGamma\textFile.txt", true);
                Console.WriteLine("Finished file copy " + DateTime.Now.Millisecond);
                Console.WriteLine(File.ReadAllText(pathA + "textFile.txt"));
            }
            else
            {
                Console.WriteLine("File not found");
            }
            var fileInfo = new FileInfo(pathA + "favicon.ico");
            fileInfo.CopyTo(pathB + "faviconCopy.ico", true);


            var directories = Directory.GetDirectories(@"c:\Users\Sangmin.DESKTOP-121G7I7\Documents\code\projects");
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
            var files = Directory.GetFiles(@"c:\Users\Sangmin.DESKTOP-121G7I7\Documents\code\projects");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
