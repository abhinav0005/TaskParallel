using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskParalleEx
{
    class Count
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public void Thread1()
        {
            try
            {
                ///<summary>
                ///making this bllock synchronize
                /// </summary>
                lock (this)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        log.Info(i);
                        Thread.Sleep(1000);
                    }
                }
            }
            catch(Exception e)
            {
                log.Info(e);
            }
        }
    }
    class ThreadSyncEx
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            ///<summary>
            ///creating obj for Count class
            /// </summary>
            Count c1 = new Count();
            Thread t1 = new Thread(new ThreadStart(c1.Thread1));
            Thread t2 = new Thread(new ThreadStart(c1.Thread1));
            ///<summary>
            ///starting thread
            /// </summary>
            t1.Start();
            t2.Start();
            Console.Read();
        }
    }
}
