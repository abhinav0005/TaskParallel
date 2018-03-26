using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Drawing;

namespace TaskParalleEx
{
    class ParallelForEachLoop
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Main()
        {
            // A simple source for demonstration purposes. Modify this path as necessary.
            String[] files = System.IO.Directory.GetFiles(@"C:\Users\ABHINAV\Pictures\Screenshots", "Screenshot (10).png");
            String newDir = @"C:\Users\ABHINAV\Pictures\Saved Pictures\Modified";
            System.IO.Directory.CreateDirectory(newDir);

            // Method signature: Parallel.ForEach(IEnumerable<TSource> source, Action<TSource> body)
            // Be sure to add a reference to System.Drawing.dll.
            try
            {
                Parallel.ForEach(files, (currentFile) =>
                {
                    // The more computational work you do here, the greater 
                    // the speedup compared to a sequential foreach loop.
                    String filename = System.IO.Path.GetFileName(currentFile);
                    var bitmap = new Bitmap(currentFile);

                    bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    bitmap.Save(Path.Combine(newDir, filename));

                    // Peek behind the scenes to see how work is parallelized.
                    // But be aware: Thread contention for the Console slows down parallel loops!!!

                    log.Info("Processing {0} on thread {1}" + filename + Thread.CurrentThread.ManagedThreadId);
                    //close lambda expression and method invocation
                });
            }
            catch(Exception e)
            {
                log.Info(e);
            }


            // Keep the console window open in debug mode.
            Console.WriteLine("Processing complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
