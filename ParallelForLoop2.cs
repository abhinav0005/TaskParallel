using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParalleEx
{
    class ParallelForLoop2
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void thread1()
        {
            Parallel.For(0, 10, i =>
            {
                log.Info(i);
            });
        }
        static void Main(string[] args)
        {
            try
            {
                Thread t1 = new Thread(new ThreadStart(ThreadExample2.thread1));
                Thread t2 = new Thread(new ThreadStart(ThreadExample2.thread1));
                t1.Start();
                t2.Start();
            }
            catch (Exception e)
            {
                log.Info(e);
            }
            Console.Read();
        }
    }
}
